using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPlugins.Model {
    /// <summary>
    /// 随机值
    /// </summary>
    [Serializable]
    public class ModelRandom {
        string _LabelName = string.Empty;
        /// <summary>
        /// 标签名称
        /// </summary>
        public string LabelName {
            get { return _LabelName; }
            set { _LabelName = value; }
        }
        string _RandomLabelType = string.Empty;
        /// <summary>
        /// 是否登录 0 为未登录 1为登录
        /// </summary>
        public string RandomLabelType {
            get { return _RandomLabelType; }
            set { _RandomLabelType = value; }
        }
        string _RandomUrl = string.Empty;
        /// <summary>
        /// 访问地址
        /// </summary>
        public string RandomUrl {
            get { return _RandomUrl; }
            set { _RandomUrl = value; }
        }
        string _RandomRefUrl = string.Empty;
        /// <summary>
        /// 访问来源
        /// </summary>
        public string RandomRefUrl {
            get { return _RandomRefUrl; }
            set { _RandomRefUrl = value; }
        }
        string _RandomPostData = string.Empty;
        /// <summary>
        /// 访问Post数据
        /// </summary>
        public string RandomPostData {
            get { return _RandomPostData; }
            set { _RandomPostData = value; }
        }

        string _RandomCutRegex = string.Empty;
        /// <summary>
        /// 截取表达式
        /// </summary>
        public string RandomCutRegex {
            get { return _RandomCutRegex; }
            set { _RandomCutRegex = value; }
        }
    }
}
