using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_Model {
    public class ModelWebSiteItem {
        #region Model
        private int _id;
        private int? _classid;
        private string _websitename;
        private string _websiteurl;
        private string _websiteloginurl;
        private string _loginusername;
        private string _loginuserpwd;
        private string _publishname;
        private string _cookiesvalue;
        private int? _iscookie;
        private int? _status;
        private int? _islinkpic;
        private int? _islinkword;
        private int? _islinkpdf;
        private int? _islinkvideo;
        private int? _istitlefalse;
        private int? _iscontentfalse;
        private int? _isaddtask;
        private string _adddatetime;
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
        public int? ClassID {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WebSiteName {
            set { _websitename = value; }
            get { return _websitename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WebSiteUrl {
            set { _websiteurl = value; }
            get { return _websiteurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WebSiteLoginUrl {
            set { _websiteloginurl = value; }
            get { return _websiteloginurl; }
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
        public string PublishName {
            set { _publishname = value; }
            get { return _publishname; }
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
        public int? IsCookie {
            set { _iscookie = value; }
            get { return _iscookie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Status {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsLinkPic {
            set { _islinkpic = value; }
            get { return _islinkpic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsLinkWord {
            set { _islinkword = value; }
            get { return _islinkword; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsLinkPdf {
            set { _islinkpdf = value; }
            get { return _islinkpdf; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsLinkVideo {
            set { _islinkvideo = value; }
            get { return _islinkvideo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsTitleFalse {
            set { _istitlefalse = value; }
            get { return _istitlefalse; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsContentFalse {
            set { _iscontentfalse = value; }
            get { return _iscontentfalse; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsAddTask {
            set { _isaddtask = value; }
            get { return _isaddtask; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AddDateTime {
            set { _adddatetime = value; }
            get { return _adddatetime; }
        }
        #endregion Model

        #region 2012  2 22
        int? _DataSourceType = 0;
        /// <summary>
        /// 数据来源
        /// </summary>
        public int? DataSourceType {
            get { return _DataSourceType; }
            set { _DataSourceType = value; }
        }

        string _DataType;
        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType {
            get { return _DataType; }
            set { _DataType = value; }
        }
        string _DataLinkUrl;
        /// <summary>
        /// 链接数据库字符串
        /// </summary>
        public string DataLinkUrl {
            get { return _DataLinkUrl; }
            set { _DataLinkUrl = value; }
        }
        string _DataQuerySQL;
        /// <summary>
        /// 查询数据SQL语句
        /// </summary>
        public string DataQuerySQL {
            get { return _DataQuerySQL; }
            set { _DataQuerySQL = value; }
        }
        string _FileSourcePath;
        /// <summary>
        /// 本地来源
        /// </summary>
        public string FileSourcePath {
            get { return _FileSourcePath; }
            set { _FileSourcePath = value; }
        }
        #endregion
    }
}
