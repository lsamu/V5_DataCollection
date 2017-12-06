using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPublish._Class {
    public class WebSiteClassHelper {

        #region Model
        private int _id;
        private int? _websiteid;
        private int? _classid;
        private string _classname;
        private string _keywordlist;
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
        public int? WebSiteID {
            set { _websiteid = value; }
            get { return _websiteid; }
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
        public string KeywordList {
            set { _keywordlist = value; }
            get { return _keywordlist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AddDateTime {
            set { _adddatetime = value; }
            get { return _adddatetime; }
        }
        #endregion Model



    }
}
