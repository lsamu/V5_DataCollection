using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPublish._Class {
    public class ModelBaiduNewsHelper {
        /// <summary>
        /// 采集地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 采集目录
        /// </summary>
        public string DataDir { get; set; }
        /// <summary>
        /// 分词关键词列表
        /// </summary>
        public string Keywordlist { get; set; }
    }
}
