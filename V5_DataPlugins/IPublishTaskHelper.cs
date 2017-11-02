using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataPlugins.Model;

namespace V5_DataPlugins {
    public interface IPublishTaskHelper {
        /// <summary>
        /// 获取数据源
        /// </summary>
        List<ModelPublishItem> GetDataList(string keyword);
        /// <summary>
        /// 获取数据源  
        /// </summary>
        List<ModelPublishItem> GetDataList(string keyword, int topNum);
    }
}
