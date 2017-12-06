using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_Model {
    /// <summary>
    /// 采集任务标签实体类
    /// </summary>
    public class ModelTaskLabel {
        #region Model
        public string TestViewUrl { get; set; } = string.Empty;
        public int IsLoop { get; set; } = 0;
        private int _id = 0;
        private string _labelname = string.Empty;
        private string _labelnamecutregex = string.Empty;
        private string _labelhtmlremove = string.Empty;
        private string _labelremove = string.Empty;
        private string _labelreplace = string.Empty;
        private int? _taskid = 0;
        private string _guidnum = string.Empty;
        private int? _orderid = 0;
        private DateTime? _createtime = DateTime.Now;
        private string _spiderlabelplugin = string.Empty;
        private int? _isdownresource = 0;
        private string _downresourceexts = string.Empty;
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
        public string LabelName {
            set { _labelname = value; }
            get { return _labelname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LabelNameCutRegex {
            set { _labelnamecutregex = value; }
            get { return _labelnamecutregex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LabelHtmlRemove {
            set { _labelhtmlremove = value; }
            get { return _labelhtmlremove; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LabelRemove {
            set { _labelremove = value; }
            get { return _labelremove; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LabelReplace {
            set { _labelreplace = value; }
            get { return _labelreplace; }
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
        public string GuidNum {
            set { _guidnum = value; }
            get { return _guidnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OrderID {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SpiderLabelPlugin {
            set { _spiderlabelplugin = value; }
            get { return _spiderlabelplugin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsDownResource {
            set { _isdownresource = value; }
            get { return _isdownresource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DownResourceExts {
            set { _downresourceexts = value; }
            get { return _downresourceexts; }
        }
        #endregion Model
    }
}
