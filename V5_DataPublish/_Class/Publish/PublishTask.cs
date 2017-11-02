using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DAL;
using System.Data;
using System.Threading;
using System.IO;
using V5_Utility;
using V5_DataPlugins;
using V5_Utility.Core;
using V5_DataPublish._Class.BaiduHelper;
using System.Windows.Forms;
using V5_DataPlugins.Model;
using V5_DataPublish._Class;
using V5_Utility.Utility;
using V5_WinLibs.Core;
using V5_WinLibs.DBUtility;

namespace V5_DataPublish._Class.Publish {
    public class PublishTask {
        #region 公共
        public MainEventHandler.PublishOutPutWindowHandler PublishOP;
        MainEvents.OutPutWindowEventArgs MeOutPut = new MainEvents.OutPutWindowEventArgs();
        public delegate void OverOpHandler(WebSiteHelper model);
        public OverOpHandler OverOP;
        #endregion

        #region 私有
        private WebSiteHelper ModelWebSite = new WebSiteHelper();
        private string ClassID = string.Empty, ClassName = string.Empty, Keywords = string.Empty;
        private IPublish iPublish;
        private ModelGatherItem mGatherItem;
        private ModelClassItem mClassList;
        private string Title = string.Empty, Content = string.Empty;
        public string modulePath = AppDomain.CurrentDomain.BaseDirectory + "/Modules/";
        #endregion

        public PublishTask() {
        }

        #region   发布文章入口
        /// <summary>
        /// 发布文章
        /// </summary>
        /// <param name="model"></param>
        public void ThreadSendContent(WebSiteHelper model) {
            ModelWebSite = model;
            int DataSourceType = ModelWebSite.DataSourceType.Value;
            if (DataSourceType == 2) {
                MeOutPut.Message = string.Format("网站名称:{0} 网站地址:{1} 信息:{2} 发布失败!",
                            ModelWebSite.WebSiteName, ModelWebSite.WebSiteUrl, "索引获取数据接口正在开发中..,");
                PublishOP(this, MeOutPut);
                return;
            }
            SendArticleContentClassList(DataSourceType);
        }
        /// <summary>
        /// 发布文章外部入口
        /// </summary>
        /// <param name="model"></param>
        /// <param name="Title"></param>
        /// <param name="Content"></param>
        /// <param name="ClassName"></param>
        /// <param name="ClassID"></param>
        public void CommonSendContent(WebSiteHelper model,
            string Title, string Content, string ClassName, string ClassID) {
            this.SendArticleContent(model, Title, Content, ClassName, ClassID);
        }
        #endregion
        /// <summary>
        /// 分类发布数据
        /// </summary>
        private void SendArticleContentClassList(int DataSourceType) {
            DataSet dsClassList = new DALWebSiteClassList().GetClassList(ModelWebSite.ID.ToString());
            if (dsClassList != null && dsClassList.Tables[0].Rows.Count > 0) {
                if (DataSourceType == 4) {
                    this.SendArticleContentByNetWork(dsClassList.Tables[0]);
                    return;
                }
                if (DataSourceType == 3) {
                    this.SendArticleContentByFileDir();
                }
            }

            foreach (DataRow drClass in dsClassList.Tables[0].Rows) {
                ClassID = drClass["ClassID"].ToString();
                ClassName = drClass["ClassName"].ToString();
                Keywords = drClass["KeywordList"].ToString();
                switch (DataSourceType) {
                    case 1:
                        this.SendArticleContentByDataBase();
                        break;
                    case 2:
                        break;
                    case 3:
                        this.SendArticleContentByFileDir();
                        break;
                    case 4:
                        break;
                }
            }
        }



        private void SendArticleContent(WebSiteHelper model, string Title, string Content, string ClassName, string ClassID) {
            ModelWebSite = model;
            try {
                LoadPublishModule(ModelWebSite.PublishName);
                if (iPublish != null) {
                    Title = Title.Replace("'", "''");
                    Content = Content.Replace("'", "''");

                    mGatherItem = new ModelGatherItem();
                    mGatherItem.Title = Title;
                    mGatherItem.Content = Content;

                    mClassList = new ModelClassItem();
                    mClassList.ClassID = ClassID;
                    mClassList.ClassName = ClassName;

                    iPublish.Publish_OutResult = OPR_SendData;
                    iPublish.Publish_Init(ModelWebSite.WebSiteUrl,
                        ModelWebSite.WebSiteLoginUrl,
                        ModelWebSite.LoginUserName,
                        ModelWebSite.LoginUserPwd,
                        0,
                        string.Empty);
                    iPublish.Publish_Type = PublishType.PostData;
                    iPublish.Publish_PostData(mGatherItem, mClassList);

                }
                else {
                    MeOutPut.Message = string.Format("插件不存在!或者插件有误!");
                    if (PublishOP != null) {
                        PublishOP(this, MeOutPut);
                    }
                }
            }
            catch (Exception ex) {
                MeOutPut.Message = string.Format("网站名称:{0} 网站地址:{1} 信息:{2} 发布失败!",
                               ModelWebSite.WebSiteName, ModelWebSite.WebSiteUrl, ex.Message);
                if (PublishOP != null) {
                    PublishOP(this, MeOutPut);
                }
            }
        }

        private void OPR_SendData(object sender, PublishType pt, bool isLogin, string Msg, object oResult) {
            if (pt == PublishType.Login) {
                MessageBox.Show(Msg.ToString());
            }
            else if (pt == PublishType.LoginOver) {
                MessageBox.Show(Msg.ToString());
            }
            else if (pt == PublishType.PostData) {
                iPublish.Publish_PostData(mGatherItem, mClassList);
            }
            else if (pt == PublishType.PostDataOver) {
                this.BakDataBase(Title, Content);
            }
        }


        #region 数据源来自数据库
        private void SendArticleContentByDataBase() {
            try {
                if (ModelWebSite.DataSourceType == 1) {
                    string strWhere = string.Empty;
                    if (!string.IsNullOrEmpty(Keywords)) {
                        string[] KeywordsArr = Keywords.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string key in KeywordsArr) {
                            strWhere += " And (Title like '%" + key + "%' And Content like '%" + key + "%') ";
                        }
                    }
                    DbHelperSQL.connectionString = ModelWebSite.DataLinkUrl;
                    DataTable dt = DbHelperSQL.Query(ModelWebSite.DataQuerySQL.Replace("[参数]", strWhere)).Tables[0];
                    foreach (DataRow dr in dt.Rows) {
                        Title = dr["Title"].ToString();
                        Content = dr["Content"].ToString();
                        if (!CheckArticleContentIsSend(Title, Content)) {
                            this.SendArticleContent(ModelWebSite, Title, Content, ClassName, ClassID);
                        }
                        Thread.Sleep(0);
                    }
                }
            }
            catch (Exception ex) {
                MeOutPut.Message = string.Format("网站名称:{0} 网站地址:{1} 信息:{2} 发布失败!",
                                ModelWebSite.WebSiteName, ModelWebSite.WebSiteUrl, ex.Message);
                PublishOP(this, MeOutPut);
            }

        }
        #endregion

        #region 数据源来自索引库

        #endregion

        #region 数据源来自文件夹
        private void SendArticleContentByFileDir() {

            string Title = string.Empty, Content = string.Empty;
            if (ModelWebSite.DataSourceType == 3) {
                string[] files = Directory.GetFiles(ModelWebSite.FileSourcePath, "*.html");
                int lLen = files.Length;
                for (int i = 0; i < lLen; i++) {
                    try {
                        string file = files[i];
                        FileInfo fiFile = new FileInfo(file);
                        Title = fiFile.Name.Replace(fiFile.Extension, "");
                        int l = fiFile.Name.LastIndexOf("_");
                        if (l > -1) {
                            Title = Title.Substring(0, l);
                        }
                        StreamReader sr = new StreamReader(file, Encoding.Default);
                        Content = sr.ReadToEnd();
                        sr.Close();
                        if (!CheckArticleContentIsSend(Title, Content)) {
                            this.SendArticleContent(ModelWebSite, Title, Content, ClassName, "1");
                        }
                        else {
                            MeOutPut.Message = string.Format("地址:{0} 分类:{1} 标题:{2} 文章存在!",
                             ModelWebSite.WebSiteUrl, ClassName, Title);
                            if (PublishOP != null) {
                                PublishOP(this, MeOutPut);
                            }
                        }
                        File.Delete(file);
                        Thread.Sleep(0);
                    }
                    catch (Exception ex) {
                        MeOutPut.Message = string.Format("网站名称:{0} 网站地址:{1} 信息:{2} 发布失败!",
                                       ModelWebSite.WebSiteName, ModelWebSite.WebSiteUrl, ex.Message);
                        if (PublishOP != null) {
                            PublishOP(this, MeOutPut);
                        }
                    }
                }
                if (OverOP != null) {
                    OverOP(ModelWebSite);
                }
            }
        }
        #endregion

        #region 数据源来自网络
        private void SendArticleContentByNetWork(DataTable dtClassList) {
            try {
                string Title = string.Empty, Content = string.Empty;
                if (ModelWebSite.DataSourceType == 4) {

                    while (true) {
                        foreach (DataRow dr in dtClassList.Rows) {
                            ClassID = dr["ClassID"].ToString();
                            ClassName = dr["ClassName"].ToString();
                            string dataDir = ModelWebSite.ID + "-" + ClassID;
                            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Data\\NetWork\\" + dataDir + "\\", "*.html");
                            int lLen = files.Length;
                            for (int i = 0; i < lLen; i++) {
                                try {
                                    string file = files[i];
                                    FileInfo fiFile = new FileInfo(file);
                                    Title = fiFile.Name.Replace(fiFile.Extension, "");
                                    int l = fiFile.Name.LastIndexOf("_");
                                    if (l > -1) {
                                        Title = Title.Substring(0, l);
                                    }
                                    StreamReader sr = new StreamReader(file, Encoding.Default);
                                    Content = sr.ReadToEnd();
                                    sr.Close();
                                    if (!CheckArticleContentIsSend(Title, Content)) {
                                        this.SendArticleContent(ModelWebSite, Title, Content, ClassName, ClassID);
                                    }
                                    else {
                                        MeOutPut.Message = string.Format("地址:{0} 分类:{1} 标题:{2} 文章存在!",
                                         ModelWebSite.WebSiteUrl, ClassName, Title);
                                        if (PublishOP != null) {
                                            PublishOP(this, MeOutPut);
                                        }
                                    }
                                    File.Delete(file);
                                    Thread.Sleep(1);
                                }
                                catch (Exception ex) {
                                    MeOutPut.Message = string.Format("网站名称:{0} 网站地址:{1} 信息:{2} 发布失败!",
                                                   ModelWebSite.WebSiteName, ModelWebSite.WebSiteUrl, ex.Message);
                                    if (PublishOP != null) {
                                        PublishOP(this, MeOutPut);
                                    }
                                }
                            }
                            if (OverOP != null) {
                                OverOP(ModelWebSite);
                            }
                            Thread.Sleep(6000);
                        }
                    }
                }
            }
            catch (Exception ex) {
                Log4Helper.Write(LogLevel.Error, ex);
            }
        }
        #endregion

        #region 伪原创  pdf pic word
        /// <summary>
        /// 伪原创  pdf pic word
        /// </summary>
        private void OutFalseOriginal(ref string Title, ref string Content) {
            #region 文章标题伪原创
            Dictionary<string, string> retDict = null;
            //标题自动伪原创
            if (ModelWebSite.IsTitleFalse.Value == 1) {
                if (retDict == null)
                    retDict = (Dictionary<string, string>)cFalseOriginalHelper.FalseOriginalWords();
                foreach (var item in retDict) {
                    Title = cFalseOriginalHelper.FalseOriginalData(Title, item.Key, item.Value, 4);
                }
            }
            //内容自动伪原创
            if (ModelWebSite.IsContentFalse.Value == 1) {
                if (retDict == null)
                    retDict = (Dictionary<string, string>)cFalseOriginalHelper.FalseOriginalWords();
                foreach (var item in retDict) {
                    Content = cFalseOriginalHelper.FalseOriginalData(Content, item.Key, item.Value, 4);
                }
            }
            retDict = null;
            #endregion
            #region 如果内容有图片 保存图片列表 图片大小为200X300 异步下载

            #endregion
            #region 自动生成  pdf word <200 个字符  提高Pr值 异步生成

            #endregion
        }
        #endregion

        #region SQLite操作
        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="sWebSiteID"></param>
        public void CreateDataFile(string sWebSiteID) {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Spider\\";
            string SQLiteName = baseDir + sWebSiteID + "\\SpiderResult.db";
            string LocalSQLiteName = "Data\\Spider\\" + sWebSiteID + "\\SpiderResult.db";

            string SQL = string.Empty;
            if (!Directory.Exists(baseDir + sWebSiteID + "\\")) {
                Directory.CreateDirectory(baseDir + sWebSiteID + "\\");
            }

            string PdfDir = baseDir + sWebSiteID + "\\Pdf\\";
            string ImagesDir = baseDir + sWebSiteID + "\\Images\\";
            string WordDir = baseDir + sWebSiteID + "\\Word\\";
            string VideoDir = baseDir + sWebSiteID + "\\Video\\";
            if (!Directory.Exists(PdfDir)) {
                Directory.CreateDirectory(PdfDir);
            }
            if (!Directory.Exists(ImagesDir)) {
                Directory.CreateDirectory(ImagesDir);
            }
            if (!Directory.Exists(WordDir)) {
                Directory.CreateDirectory(WordDir);
            }
            if (!Directory.Exists(VideoDir)) {
                Directory.CreateDirectory(VideoDir);
            }
            if (!File.Exists(SQLiteName)) {
                DbHelper.CreateDataBase(SQLiteName);
                string createSQL = string.Empty;
                SQL = @"
                create table Content(
                    ID integer primary key autoincrement,
                    Title varchar,
                    Content varchar,
                    AddDateTime varchar
                );
            ";
                DbHelper.Execute(LocalSQLiteName, SQL);
            }
        }
        /// <summary>
        /// 检查文章是否发布过了
        /// </summary>
        private bool CheckArticleContentIsSend(string Title, string Content) {
            int sWebSiteID = ModelWebSite.ID;
            string baseDir = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Spider\\";
            string SQLiteName = baseDir + sWebSiteID + "\\SpiderResult.db";
            string LocalSQLiteName = "Data\\Spider\\" + sWebSiteID + "\\SpiderResult.db";
            if (File.Exists(SQLiteName)) {
                string SQL = string.Empty;
                SQL = string.Format(@"Select Count(1) From Content Where Title='{0}' ", Title, Content.Replace("'", "''"), DateTime.Now.ToString());
                int result = StringHelper.Instance.SetNumber(DbHelper.Execute(LocalSQLiteName, SQL));
                if (result > 0) {
                    return true;
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// 备份文章
        /// </summary>
        private void BakDataBase(string Title, string Content) {
            int sWebSiteID = ModelWebSite.ID;
            string baseDir = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Spider\\";
            string SQLiteName = baseDir + sWebSiteID + "\\SpiderResult.db";
            string LocalSQLiteName = "Data\\Spider\\" + sWebSiteID + "\\SpiderResult.db";
            if (!File.Exists(SQLiteName)) {
                CreateDataFile(sWebSiteID.ToString());
            }
            else {
                string SQL = string.Empty;
                SQL = string.Format(@"Insert Into  Content(Title,Content,AddDateTime)values
                        ('{0}','{1}','{2}')
                        ", Title, Content, DateTime.Now.ToString());
                DbHelper.Execute(LocalSQLiteName, SQL);
            }
        }
        #endregion

        #region
        /// <summary>
        /// 加载发布模块
        /// </summary>
        /// <param name="publishName"></param>
        public void LoadPublishModule(string publishName) {
            if (publishName.IndexOf(".pmod") > -1) {
                iPublish = new PublishCommon();
                iPublish.Publish_OutResult = OPR_SendData;
                iPublish.Publish_Name = publishName;
                iPublish.Publish_Model = Load_PublishItem(publishName);
            }
            else {
                iPublish = Utility.ListIPublish.Where(p => p.Publish_Name == ModelWebSite.PublishName).FirstOrDefault();
                iPublish.Publish_OutResult = OPR_SendData;
                iPublish.Publish_Name = ModelWebSite.PublishName;
            }
        }
        /// <summary>
        /// 加载单个模块数据
        /// </summary>
        /// <param name="pathName"></param>
        private ModelPublishModuleItem Load_PublishItem(string pathName) {
            ModelPublishModuleItem model = new ModelPublishModuleItem();
            try {
                string fileName = modulePath + pathName;
                model = (ModelPublishModuleItem)ObjFileStoreHelper.Deserialize(fileName);
            }
            catch {
                model = null;
            }
            return model;
        }
        #endregion

    }
}
