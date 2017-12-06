using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace V5_WinLibs.XmlConfig {
    public class DataSourceConfig {
        static string dataSourceXmlConfigUrl = AppDomain.CurrentDomain.BaseDirectory + "/Config/DataSourceConfig.config";


        public static void SaveXmlConfig(DataSourceConfigItem model) {
            if (!File.Exists(dataSourceXmlConfigUrl)) {
                File.Create(dataSourceXmlConfigUrl).Close();
            }
            XmlSerializer serializer = new XmlSerializer(typeof(DataSourceConfigItem));
            FileStream fs = new FileStream(dataSourceXmlConfigUrl, FileMode.Create);
            serializer.Serialize(fs, model);
            fs.Close();
        }

        public static DataSourceConfigItem GetXmlConfig() {
            DataSourceConfigItem model = new DataSourceConfigItem();
            if (!File.Exists(dataSourceXmlConfigUrl)) {
                return model;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(DataSourceConfigItem));
            try {
                string fileName = dataSourceXmlConfigUrl;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                model = (DataSourceConfigItem)serializer.Deserialize(fs);
                fs.Close();
            }
            catch { }
            return model;
        }
    }
}
