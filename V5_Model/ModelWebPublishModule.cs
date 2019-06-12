using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_Model {
    [Serializable]
    /// <summary>
    /// 网站发布模块实体类
    /// </summary>
    public class ModelWebPublishModule {
        #region Model
        private int _id;
        private int? _taskid;
        private string _modulename;
        private string _siteurl;
        private int? _iscookieslogin;
        private string _cookiesvalue;
        private int? _classid;
        private string _classname;
        private string _loginusername;
        private string _loginuserpwd;
        private string _modulenamefile;
        private string _createtime;
        /// <summary>
        /// 
        /// </summary>
        public int ID {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? TaskID {
            set { _taskid = value; }
            get { return _taskid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ModuleName {
            set { _modulename = value; }
            get { return _modulename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SiteUrl {
            set { _siteurl = value; }
            get { return _siteurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsCookiesLogin {
            set { _iscookieslogin = value; }
            get { return _iscookieslogin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CookiesValue {
            set { _cookiesvalue = value; }
            get { return _cookiesvalue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ClassID {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClassName {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LoginUserName {
            set { _loginusername = value; }
            get { return _loginusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LoginUserPwd {
            set { _loginuserpwd = value; }
            get { return _loginuserpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ModuleNameFile {
            set { _modulenamefile = value; }
            get { return _modulenamefile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CreateTime {
            set { _createtime = value; }
            get { return _createtime; }
        }
        #endregion Model
    }
}
