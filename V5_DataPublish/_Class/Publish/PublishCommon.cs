using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataPlugins;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using V5_DataPublish._Class.Publish;
using V5_Utility.Core;
using System.Text.RegularExpressions;
using System.Web;
using V5_DataPlugins.Model;
using V5_Utility.Utility;
using V5_WinLibs.Core;

namespace V5_DataPlugins {
    /// <summary>
    /// 实现pmod加载方式发布内容
    /// </summary>
    public class PublishCommon : IPublish {
        #region 属性
        private string _Encode = string.Empty;
        private PluginEventHandler.OutPutResult Out;
        private ModelPublishModuleItem _model;
        private string strLoginDir;
        private string _WebSiteUrl;
        /// <summary>
        /// 网站编码
        /// </summary>
        public string Publish_Encode {
            get {
                return _Encode;
            }
            set {
                _Encode = value;
            }
        }
        /// <summary>
        /// 操作类型
        /// </summary>
        public PublishType Publish_Type { set; get; }
        /// <summary>
        /// 回发对象
        /// </summary>
        public PluginEventHandler.OutPutResult Publish_OutResult {
            set { Out = value; }
        }
        /// <summary>
        /// WebBrowser对象
        /// </summary>
        public WebBrowser Publish_WebBrowser {
            set { throw new NotImplementedException(); }
        }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string Publish_Name { set; get; }
        /// <summary>
        /// 访问网站对象
        /// </summary>
        public ModelPublishModuleItem Publish_Model {
            get { return _model; }
            set { _model = value; }
        }
        /// <summary>
        /// 网站地址
        /// </summary>
        public string WebSiteUrl {
            get {
                if (_WebSiteUrl.LastIndexOf("/") == -1) {
                    _WebSiteUrl += "/";
                }
                return _WebSiteUrl;
            }
            set { _WebSiteUrl = value; }
        }
        /// <summary>
        /// 管理登陆目录
        /// </summary>
        public string StrLoginDir {
            get {
                if (strLoginDir.LastIndexOf("/") == -1) {
                    strLoginDir += "/";
                }
                return strLoginDir;
            }
            set { strLoginDir = value; }
        }
        #endregion

        #region 私有变量
        private string cookieHeader = string.Empty;
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        private string strUserName = string.Empty, strUserPwd = string.Empty;
        private string tempLinkUrl = string.Empty, tempLinkContent = string.Empty;
        #endregion

        #region
        /// <summary>
        /// 初始化登陆信息
        /// </summary>
        public void Publish_Init(string strSiteUrl, string strLoginDir, string strUserName, string strUserPwd, int isCookie, string strCookie) {
            this.WebSiteUrl = strSiteUrl;
            if (strLoginDir.ToLower().IndexOf("http://") > -1) {
                this.StrLoginDir = strLoginDir;
            }
            else {
                this.StrLoginDir = strSiteUrl + "/" + strLoginDir;
            }
            this.StrLoginDir += "/";
            this.strUserName = strUserName;
            this.strUserPwd = strUserPwd;
        }

        #region 实现方法

        /// <summary>
        /// 加载随机数
        /// </summary>
        /// <param name="IsLogin">0未登陆 1登陆</param>
        private void Load_RandomList(string RandomLabelType) {
            #region 加载随机数
            Encoding ec = Encoding.GetEncoding("utf-8");
            foreach (ModelRandom m in Publish_Model.ListRandomModel.Where(p => p.RandomLabelType == RandomLabelType)) {
                string randContent = string.Empty;
                if (tempLinkUrl.ToLower() == (StrLoginDir + m.RandomUrl).ToLower()) {
                    randContent = tempLinkContent;
                }
                else {
                    randContent = SimulationHelper.PostPage(StrLoginDir + m.RandomUrl, m.RandomPostData, string.Empty, Publish_Model.PageEncode, ref cookieHeader);
                    tempLinkUrl = StrLoginDir + m.RandomUrl;
                    tempLinkContent = randContent;
                }
                string RandomCutRegex = m.RandomCutRegex;
                RandomCutRegex = RandomCutRegex.Replace("[参数]", "([\\S\\s]*?)");
                string CutStrContent = SimulationHelper.CutStr(randContent, RandomCutRegex)[0];
                if (!dic.ContainsKey(m.LabelName)) {
                    dic.Add(m.LabelName, HttpUtility.UrlEncode(CutStrContent, ec));
                }
            }
            #endregion
        }
        /// <summary>
        /// 后台登陆地址
        /// </summary>
        public string Publish_GetLoginAdminUrl(string strSiteUrl, string strLoginDir) {
            if (strSiteUrl.LastIndexOf("/") == -1) {
                strSiteUrl += "/";
            }
            if (strLoginDir.LastIndexOf("/") == -1) {
                strLoginDir += "/";
            }
            return strSiteUrl + strLoginDir + Publish_Model.LoginUrl;
        }
        /// <summary>
        /// 替换Post参数
        /// </summary>
        /// <returns></returns>
        private string ReplacePostData(string postData) {
            postData = postData.Replace("[用户名]", strUserName);
            postData = postData.Replace("[密码]", strUserPwd);
            postData = postData.Replace("[验证码]", strUserPwd);
            foreach (KeyValuePair<string, string> item in dic) {
                postData = postData.Replace("[" + item.Key + "]", item.Value);
            }
            return postData;
        }
        /// <summary>
        /// 用户登陆
        /// </summary>
        public void Publish_Login() {
            CacheManageHelper cache = CacheManageHelper.Instance;
            if (cache.Contains(this.WebSiteUrl)) {
                cookieHeader = cache.Get(this.WebSiteUrl) as string;
                Load_RandomList("登陆");
                if (Publish_Type == PublishType.Login) {
                    if (Out != null) {
                        Out(this, PublishType.LoginOver, true, "登陆成功!", null);
                    }
                }
            }
            else {
                string postData = Publish_Model.LoginPostData;
                Load_RandomList("登陆");
                postData = ReplacePostData(postData);
                string htmlContent = SimulationHelper.PostLogin(this.StrLoginDir + Publish_Model.LoginUrl, postData, string.Empty, Publish_Model.PageEncode, ref cookieHeader);
                if (htmlContent.IndexOf(Publish_Model.LoginSuccessResult) > -1) {
                    cache.Add(this.WebSiteUrl, cookieHeader);
                    if (Publish_Type == PublishType.Login) {
                        if (Out != null) {
                            Out(this, PublishType.LoginOver, true, "登陆成功!", null);
                        }
                    }
                }
                else {
                    if (Publish_Type == PublishType.Login) {
                        if (Out != null) {
                            Out(this, PublishType.LoginOver, false, "登陆失败!", null);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 创建分类
        /// </summary>
        /// <param name="strClassName"></param>
        public void Publish_CreateClass(string strClassName) {
            //登陆
            if (string.IsNullOrEmpty(cookieHeader)) {
                Publish_Login();
            }
            Load_RandomList("列表");
            string postData = Publish_Model.ListCreatePostData;
            postData = ReplacePostData(postData);
            string htmlContent = SimulationHelper.PostPage(StrLoginDir + Publish_Model.ListCreateUrl,
                Publish_Model.ListCreatePostData,
                StrLoginDir + Publish_Model.ListCreateRefUrl,
                Publish_Model.PageEncode,
                ref cookieHeader);
            string[] errorResult = Publish_Model.ListCreateError.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in errorResult) {
                if (htmlContent.IndexOf(str) > -1) {
                    if (Out != null) {
                        Out(this, PublishType.CreateClassOver, false, "分类创建失败!", strClassName);
                    }
                    break;
                }
            }
            if (!string.IsNullOrEmpty(Publish_Model.ListCreateSuccess)) {
                if (htmlContent.IndexOf(Publish_Model.ContentSuccessResult) > -1) {
                    if (Out != null) {
                        Out(this, PublishType.CreateClassOver, true, "分类创建成功!", strClassName);
                    }
                }
                else {
                    if (Out != null) {
                        Out(this, PublishType.CreateClassOver, false, "分类创建失败!", strClassName);
                    }
                }
            }
            else {
                if (Out != null) {
                    Out(this, PublishType.CreateClassOver, true, "分类创建成功!", strClassName);
                }
            }
        }
        /// <summary>
        /// 获取分类
        /// </summary>
        /// <returns></returns>
        public void Publish_GetClassList() {
            //登陆
            if (string.IsNullOrEmpty(cookieHeader)) {
                Publish_Login();
            }
            string postData = string.Empty;
            string htmlContent = SimulationHelper.PostPage(StrLoginDir + Publish_Model.ListUrl,
                postData,
                StrLoginDir + Publish_Model.ListUrl,
                Publish_Model.PageEncode,
                ref cookieHeader);

            string regexClassID = HtmlHelper.Instance.ParseCollectionStrings(Publish_Model.ListClassIDNameRegex);
            regexClassID = regexClassID.Replace("\\[参数:分类ID]", "([\\S\\s]*?)");
            regexClassID = regexClassID.Replace("\\[参数:分类名称]", ".+?");
            string[] ArrayClassID = CollectionHelper.Instance.CutStr(htmlContent, regexClassID);

            string regexClassName = HtmlHelper.Instance.ParseCollectionStrings(Publish_Model.ListClassIDNameRegex);
            regexClassName = regexClassName.Replace("\\[参数:分类ID]", ".+?");
            regexClassName = regexClassName.Replace("\\[参数:分类名称]", "([\\S\\s]*?)");
            string[] ArrayClassName = CollectionHelper.Instance.CutStr(htmlContent, regexClassName);

            List<ModelClassItem> dicClassList = new List<ModelClassItem>();
            for (int i = 0; i < ArrayClassID.Length; i++) {
                string ClassID = ArrayClassID[i];
                string ClassName = ArrayClassName[i];
                ModelClassItem m = new ModelClassItem();
                m.ClassID = ClassID;
                m.ClassName = ClassName;
                dicClassList.Add(m);
            }

            if (Out != null) {
                Out(this, PublishType.GetClassListOver, true, "获取分类列表成功!", dicClassList);
            }
        }

        /// <summary>
        /// 发送文章
        /// </summary>
        /// <param name="mlistPost"></param>
        /// <param name="mClassList"></param>
        /// <returns></returns>
        public void Publish_PostData(ModelGatherItem mlistPost, ModelClassItem mClassList) {
            //登陆
            if (string.IsNullOrEmpty(cookieHeader)) {
                Publish_Login();
            }
            Load_RandomList("内容");
            string postData = Publish_Model.ContentPostData;
            postData = ReplacePostData(postData);
            postData = postData.Replace("[标题]", mlistPost.Title);
            postData = postData.Replace("[内容]", System.Web.HttpUtility.UrlEncode(mlistPost.Content));
            //替换分类
            postData = postData.Replace("[分类ID]", mClassList.ClassID);
            postData = postData.Replace("[分类名称]", mClassList.ClassName);
            string htmlContent = SimulationHelper.PostPage(StrLoginDir + Publish_Model.ContentUrl,
                postData,
                StrLoginDir + Publish_Model.ContentRefUrl,
                Publish_Model.PageEncode,
                ref cookieHeader);
            string[] errorResult = Publish_Model.ContentErrorResult.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in errorResult) {
                if (htmlContent.IndexOf(str) > -1) {
                    if (Out != null) {
                        Out(this, PublishType.PostDataOver, false, "文章发布失败!", mlistPost);
                    }
                    break;
                }
            }
            if (!string.IsNullOrEmpty(Publish_Model.ContentSuccessResult)) {
                if (htmlContent.IndexOf(Publish_Model.ContentSuccessResult) > -1) {
                    if (Out != null) {
                        Out(this, PublishType.PostDataOver, true, "文章发布成功!", mlistPost);
                    }
                }
                else {
                    if (Out != null) {
                        Out(this, PublishType.PostDataOver, false, "文章发布失败!", mlistPost);
                    }
                }
            }
            else {
                if (Out != null) {
                    Out(this, PublishType.PostDataOver, true, "文章发布成功!", mlistPost);
                }
            }
        }
        #endregion

        #endregion
    }
}
