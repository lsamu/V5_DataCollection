using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_WinLibs.XmlConfig {
    [Serializable]
    public class DataSourceConfigItem {
        int _DataSourceType = 0;
        /// <summary>
        /// 数据源类型
        /// </summary>
        public int DataSourceType {
            get { return _DataSourceType; }
            set { _DataSourceType = value; }
        }

        int _DataBaseType = 0;
        /// <summary>
        /// 自定义数据保存类型
        /// </summary>
        public int DataBaseType {
            get { return _DataBaseType; }
            set { _DataBaseType = value; }
        }

        string _DataBaseUrl = string.Empty;
        /// <summary>
        /// 自定义数据库连接地址
        /// </summary>
        public string DataBaseUrl {
            get { return _DataBaseUrl; }
            set { _DataBaseUrl = value; }
        }
        string _SelectSql = string.Empty;
        /// <summary>
        /// 查询语句
        /// </summary>
        public string SelectSql {
            get { return _SelectSql; }
            set { _SelectSql = value; }
        }

        string _IndexDataDir = string.Empty;
        /// <summary>
        /// 索引库目录
        /// </summary>
        public string IndexDataDir {
            get { return _IndexDataDir; }
            set { _IndexDataDir = value; }
        }

        string _RemoteDataUrl = string.Empty;
        /// <summary>
        /// 网络数据库地址
        /// </summary>
        public string RemoteDataUrl {
            get { return _RemoteDataUrl; }
            set { _RemoteDataUrl = value; }
        }

    }
}
