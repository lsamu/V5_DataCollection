using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using V5_DataCollection._Class.DAL;
using V5_DataCollection._Class.Gather;
using V5_DataCollection.Forms.Publish;
using V5_Model;
using V5_Utility.Utility;
using V5_WinLibs.Core;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection._Class.Publish {

    public class PublishContentHelper {

        string modulePath = AppDomain.CurrentDomain.BaseDirectory + "/Modules/";

        public ModelTask Model;

        private GatherEvents.GatherLinkEvents gatherEv = new GatherEvents.GatherLinkEvents();
        public GatherEventHandler.GatherWorkHandler PublishCompalteDelegate;

        public void Start() {
            if (Model.IsWebOnlinePublish1.Value == 1) {
                gatherEv.Message = "开始发布Web数据!";
                PublishCompalteDelegate?.Invoke(this, gatherEv);
                StartWeb();
            }

            if (Model.IsSaveLocal2.Value == 1) {
                gatherEv.Message = "开始发布本地数据!";
                PublishCompalteDelegate?.Invoke(this, gatherEv);
                StartLocal();
            }

            if (Model.IsSaveDataBase3.Value == 1) {
                gatherEv.Message = "开始保存到数据库!";
                PublishCompalteDelegate?.Invoke(this, gatherEv);
                StartDataBase();
            }

            if (Model.IsSaveSQL4.Value == 1) {
                gatherEv.Message = "开始发布自定义网站!";
                PublishCompalteDelegate?.Invoke(this, gatherEv);
                StartDiyWeb();
            }

            gatherEv.Message = "数据发布成功!";
            PublishCompalteDelegate?.Invoke(this, gatherEv);

        }

        public void MessageOut(string msg) {
            gatherEv.Message = msg;
            PublishCompalteDelegate?.Invoke(this, gatherEv);
        }

        #region 发布Web数据
        private void StartWeb() {
            foreach (ModelWebPublishModule m in Model.ListModelWebPublishModule) {
                var mPublishModuleItem = GetModelXml(m.ModuleNameFile);
                if (m.IsCookiesLogin == 1) {
                    var LoginedCookies = m.CookiesValue;
                    var LoginPostData = mPublishModuleItem.ViewPostData;
                    string result = SimulationHelper.PostPage(m.SiteUrl + mPublishModuleItem.ViewUrl,
                        "",
                        m.SiteUrl + mPublishModuleItem.ViewRefUrl,
                        mPublishModuleItem.PageEncode,
                        ref LoginedCookies);
                }
            }
        }

        private cPublishModuleItem GetModelXml(string pathName) {
            cPublishModuleItem model = new cPublishModuleItem();
            XmlSerializer serializer = new XmlSerializer(typeof(cPublishModuleItem));
            try {
                string fileName = modulePath + pathName;
                using (FileStream fs = new FileStream(fileName, FileMode.Open)) {
                    model = (cPublishModuleItem)serializer.Deserialize(fs);
                    fs.Close();
                }
            }
            catch {

            }
            return model;
        }
        #endregion

        #region 发布本地数据
        private void StartLocal() {
            try {
                string str = string.Empty;
                string LocalSQLiteName = "Data\\Collection\\" + Model.TaskName + "\\SpiderResult.db";
                DataTable dtData = DbHelper.Query(LocalSQLiteName, "Select * From Content").Tables[0];
                if (!Directory.Exists(Model.SaveDirectory2))
                    Directory.CreateDirectory(Model.SaveDirectory2);
                if (Model.SaveFileFormat2.ToLower() == ".html") {
                    foreach (DataRow dr in dtData.Rows) {
                        string fileName = dr["标题"].ToString();
                        str = dr["内容"].ToString();
                        try {
                            fileName = fileName.Replace(".", "");
                            fileName = fileName.Replace(",", "");
                            fileName = fileName.Replace("、", "");
                            fileName = fileName.Replace(" ", "");
                            fileName = fileName.Replace("*", "_");
                            fileName = fileName.Replace("?", "_");
                            fileName = fileName.Replace("/", "_");
                            fileName = fileName.Replace("\\", "_");
                            fileName = fileName.Replace(":", "_");
                            fileName = fileName.Replace("|", "_");
                            fileName += ".html";
                            using (StreamWriter sw = new StreamWriter(Model.SaveDirectory2 + "\\" + fileName, false, Encoding.UTF8)) {
                                sw.Write(str);
                                sw.Flush();
                                sw.Close();
                            }
                        }
                        catch {
                            continue;
                        }
                    }
                }
                else if (Model.SaveFileFormat2.ToLower() == ".txt") {
                    foreach (DataRow dr in dtData.Rows) {
                        foreach (ModelTaskLabel mTaskLabel in Model.ListTaskLabel) {
                            str += mTaskLabel.LabelName + ":" + dr[mTaskLabel.LabelName] + "\r\n";
                        }
                        str += "\r\n\r\n";
                    }
                    using (StreamWriter sw = new StreamWriter(Model.SaveDirectory2 + "\\采集结果文本保存.txt", false, Encoding.UTF8)) {
                        sw.Write(str);
                        sw.Flush();
                        sw.Close();
                    }
                }
                else if (Model.SaveFileFormat2.ToLower() == ".sql") {
                    try {
                        string strTemplateContent = File.ReadAllText(Model.SaveHtmlTemplate2, Encoding.UTF8);
                        StringBuilder sbContent = new StringBuilder();
                        foreach (DataRow dr in dtData.Rows) {
                            string sql = strTemplateContent;
                            foreach (ModelTaskLabel mTaskLabel in Model.ListTaskLabel) {
                                string content = dr[mTaskLabel.LabelName].ToString().Replace("'", "''");
                                sql = sql.Replace("[" + mTaskLabel.LabelName + "]", content);
                            }
                            sbContent.AppendLine(sql);
                        }
                        using (StreamWriter sw = new StreamWriter(Model.SaveDirectory2 + "\\sql.sql", false, Encoding.UTF8)) {
                            sw.Write(sbContent.ToString());
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    catch (Exception ex) {
                        gatherEv.Message = "错误!" + ex.Message;
                        PublishCompalteDelegate?.Invoke(this, gatherEv);
                    }
                }
            }
            catch (Exception ex) {
                Log4Helper.Write(LogLevel.Error, ex);
            }
        }
        #endregion

        #region 保存到数据库
        private void StartDataBase() {
            string LocalSQLiteName = "Data\\Collection\\" + Model.TaskName + "\\SpiderResult.db";
            DataTable dtData = DbHelper.Query(LocalSQLiteName, "Select * From Content").Tables[0];

            int saveDateType = Model.SaveDataType3.Value;
            string connectionString = Model.SaveDataUrl3;
            string exeSQL = Model.SaveDataSQL3;
            string sql = string.Empty;

            DbHelperDapper.connectionString = Model.SaveDataUrl3;
            switch (saveDateType) {
                case 1://ACCESS
                    DbHelperDapper.dbType = DataBaseType.OleDb;
                    break;
                case 2://MSSQL
                    DbHelperDapper.dbType = DataBaseType.SqlServer;
                    break;
                case 3://SQLITE
                    DbHelperDapper.dbType = DataBaseType.SQLite;
                    break;
                case 4://MYSQL
                    DbHelperDapper.dbType = DataBaseType.MySql;
                    break;
                case 5://Oracle
                    DbHelperDapper.dbType = DataBaseType.Oracle;
                    break;
            }

            using (var conn = DbHelperDapper.GetDbConnection(DbHelperDapper.dbType, Model.SaveDataUrl3)) {
                if (conn == null || conn.State != ConnectionState.Open) {
                    MessageOut("数据库连接失败!不需要发布数据!");
                    return;
                }
            }

            foreach (DataRow dr in dtData.Rows) {
                try {
                    sql = exeSQL;
                    foreach (ModelTaskLabel mTaskLabel in Model.ListTaskLabel) {
                        if (string.IsNullOrEmpty(dr[mTaskLabel.LabelName].ToString())) {
                            break;
                        }
                        sql = sql.Replace("[" + mTaskLabel.LabelName + "]", dr[mTaskLabel.LabelName].ToString().Replace("'", "''").Replace("\\", "/"));
                    }
                    sql = sql.Replace("[Guid]", Guid.NewGuid().ToString());
                    sql = sql.Replace("[Url]", dr["HrefSource"].ToString());

                    DbHelperDapper.Execute(sql);
                    MessageOut(dr["HrefSource"].ToString() + "发布成功!");
                }
                catch (Exception ex) {
                    Log4Helper.Write(LogLevel.Error, dr["HrefSource"].ToString() + ":保存数据库失败!", ex);
                    MessageOut(dr["HrefSource"].ToString() + "发布失败!" + ex);
                    continue;
                }
            }
        }
        #endregion

        #region 发布自定义网站
        private void StartDiyWeb() {
            string LocalSQLiteName = "Data\\Collection\\" + Model.TaskName + "\\SpiderResult.db";
            DataTable dtData = DbHelper.Query(LocalSQLiteName, "Select * From Content").Tables[0];

            var listDiyUrl = DALDiyWebUrlHelper.GetList(" And SelfId=" + Model.ID, "", 0);
            HttpHelper4 http = new HttpHelper4();
            int taskId = Model.ID;
            foreach (DataRow dr in dtData.Rows) {
                int resultId = int.Parse(dr["Id"].ToString());
                foreach (var m in listDiyUrl) {
                    try {

                        string getUrl = m.Url;
                        string postParams = m.UrlParams;
                        StringBuilder sbContent = new StringBuilder();
                        foreach (ModelTaskLabel mTaskLabel in Model.ListTaskLabel) {
                            string pageEncodeContent = dr[mTaskLabel.LabelName].ToString().Replace("'", "''");
                            //可能需要编码实际测试才知道
                            getUrl = getUrl.Replace("[" + mTaskLabel.LabelName + "]", pageEncodeContent);
                            postParams = postParams.Replace("[" + mTaskLabel.LabelName + "]", pageEncodeContent);
                            sbContent.Append(pageEncodeContent);
                        }
                        string md5key = StringHelper.Instance.MD5(taskId.ToString() + resultId.ToString() + sbContent.ToString(), 32).ToLower();
                        //判断该条记录这个weburl是否发过
                        if (!DALDataPublishLogHelper.ChkRecord(
                            Model.ID, resultId, md5key)) {
                            //记录日志
                            DALDataPublishLogHelper.Insert(new ModelDataPublishLog() {
                                TaskId = taskId,
                                ResultId = resultId,
                                DesKey = md5key,
                                CreateTime = DateTime.Now.ToString()
                            });
                        }
                        else {
                            continue;
                        }

                        //开始发布网站
                        var result = http.GetHtml(new HttpItem() {
                            URL = getUrl,
                            Postdata = postParams,
                            ContentType = "application/x-www-form-urlencoded"
                        });
                        var html = result.Html;
                    }
                    catch (Exception ex) {
                        continue;
                    }
                }
            }
            if (PublishCompalteDelegate != null) {
                gatherEv.Message = "发布到自定义Web网站完成!";
                PublishCompalteDelegate(this, gatherEv);
            }
        }
        #endregion


    }

}
