using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace V5_DataCollection._Class.Common {
    public class SerializeHelper {
        /// <summary>
        /// 获取未处理完的队列
        /// </summary>
        private T DeserializeObject<T>() {
            T t = default(T);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try {
                string apppath = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = apppath + "Config\\MtBuf.config";
                FileStream fs = new FileStream(fileName, FileMode.Open);
                t = (T)serializer.Deserialize(fs);
                fs.Close();
            }
            catch {
            }
            return t;
        }
        /// <summary>
        /// 保存未处理完的队列
        /// </summary>
        private bool SerializeObject<T>(T ListBuf) {
            try {
                string apppath = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = apppath + "Config\\MtBuf.config";
                if (!File.Exists(fileName)) {
                    File.Create(fileName).Close();
                }
                lock (this) {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    serializer.Serialize(fs, ListBuf);
                    fs.Close();
                }
                return true;
            }
            catch {
            }
            return false;
        }
    }
}
