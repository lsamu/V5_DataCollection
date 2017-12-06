using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace V5_DataPlugins.Model {
    [Serializable]
    public class ModelPublishItem {
        private String m_Url;
        private String m_Title;
        private String m_Content;
        private String m_Abstract;
        private DateTime m_Time;
        /// <summary>
        /// 链接
        /// </summary>
        public String Url {
            get {
                return m_Url;
            }
            set {
                m_Url = value;
            }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public String Title {
            get {
                return m_Title;
            }
            set {
                m_Title = value;
            }
        }

        /// <summary>
        /// 正文
        /// </summary>
        public String Content {
            get {
                return m_Content;
            }
            set {
                m_Content = value;
            }
        }

        /// <summary>
        /// 搜索摘要
        /// </summary>
        public String Abstract {
            get {
                return m_Abstract;
            }
            set {
                m_Abstract = value;
            }
        }


        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime Time {
            get {
                return m_Time;
            }
            set {
                m_Time = value;
            }
        }
    }
}
