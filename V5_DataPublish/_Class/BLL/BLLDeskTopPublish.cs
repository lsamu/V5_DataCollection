using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataPublish._Class.Model;
using System.IO;
using System.Xml.Serialization;

namespace V5_DataPublish._Class.BLL {
    public class BLLDeskTopPublish {

        #region Web站点配置操作
        private string dataSourceXmlConfigUrl = AppDomain.CurrentDomain.BaseDirectory + "/Config/DeskTop_WebSite.config";

        /// <summary>
        /// 保存网站列表
        /// </summary>
        /// <param name="list"></param>
        public void SaveXmlConfig(List<ModelWebSiteChecked> list) {
            if (!File.Exists(dataSourceXmlConfigUrl)) {
                File.Create(dataSourceXmlConfigUrl).Close();
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<ModelWebSiteChecked>));
            FileStream fs = new FileStream(dataSourceXmlConfigUrl, FileMode.Create);
            serializer.Serialize(fs, list);
            fs.Close();
        }
        /// <summary>
        /// 获取网站列表配置
        /// </summary>
        /// <returns></returns>
        public List<ModelWebSiteChecked> GetXmlConfig() {
            List<ModelWebSiteChecked> list = new List<ModelWebSiteChecked>();
            if (!File.Exists(dataSourceXmlConfigUrl)) {
                return list;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<ModelWebSiteChecked>));
            try {
                string fileName = dataSourceXmlConfigUrl;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                list = (List<ModelWebSiteChecked>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch { }
            return list;
        }
        #endregion
    }
}
