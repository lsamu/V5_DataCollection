using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPublish._Class {
    public class WebSiteHelper {

        private string _Guid = Guid.NewGuid().ToString();

        public string Uuid {
            get { return _Guid; }
            set { _Guid = value; }
        }

        #region Model
        private int _id;
        private string _classid;
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
        private string _updatetime;
        private int? _datasourcetype;
        private string _datatype;
        private string _datalinkurl;
        private string _dataquerysql;
        private string _filesourcepath;
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
        public string ClassID {
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
        /// <summary>
        /// 
        /// </summary>
        public string UpdateTime {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DataSourceType {
            set { _datasourcetype = value; }
            get { return _datasourcetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DataType {
            set { _datatype = value; }
            get { return _datatype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DataLinkUrl {
            set { _datalinkurl = value; }
            get { return _datalinkurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DataQuerySQL {
            set { _dataquerysql = value; }
            get { return _dataquerysql; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FileSourcePath {
            set { _filesourcepath = value; }
            get { return _filesourcepath; }
        }
        #endregion Model

    }
}
