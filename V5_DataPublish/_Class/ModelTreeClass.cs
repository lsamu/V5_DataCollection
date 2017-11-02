using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlDatabase.Core;

namespace V5_DataPublish._Class {

    public class ModelTreeClass {

        private string _Guid = Guid.NewGuid().ToString();

        public string Uuid {
            get { return _Guid; }
            set { _Guid = value; }
        }


        #region Model
        private int _classid;
        private string _classname;
        private int? _parentid;
        private string _classcode;
        private string _readme;
        private string _adddatetime;
        private string _updatetime;
        /// <summary>
        /// 
        /// </summary>
        public int ClassID {
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
        public int? ParentID {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClassCode {
            set { _classcode = value; }
            get { return _classcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ReadMe {
            set { _readme = value; }
            get { return _readme; }
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
        #endregion Model


    }
}
