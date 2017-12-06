using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPlugins.Model {
    /// <summary>
    /// 生成静态
    /// </summary>
    [Serializable]
    public class ModelCreateHtml {
        string _CreateName = string.Empty;
        /// <summary>
        /// 名称
        /// </summary>
        public string CreateName {
            get { return _CreateName; }
            set { _CreateName = value; }
        }
        string _CreateHtmlUrl = string.Empty;
        /// <summary>
        /// 生成地址
        /// </summary>
        public string CreateHtmlUrl {
            get { return _CreateHtmlUrl; }
            set { _CreateHtmlUrl = value; }
        }
        string _CreateHtmlRefUrl = string.Empty;
        /// <summary>
        /// 生成来源
        /// </summary>
        public string CreateHtmlRefUrl {
            get { return _CreateHtmlRefUrl; }
            set { _CreateHtmlRefUrl = value; }
        }
        string _CreateHtmlPostData = string.Empty;
        /// <summary>
        /// 来源地址
        /// </summary>
        public string CreateHtmlPostData {
            get { return _CreateHtmlPostData; }
            set { _CreateHtmlPostData = value; }
        }
    }
}
