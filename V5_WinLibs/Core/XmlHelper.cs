using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace V5_WinLibs.Core {
    public class XmlHelper {
        /// <summary>
        /// Xml获取DatTable
        /// </summary>
        /// <param name="xmlStr"></param>
        /// <returns></returns>
        public static DataTable GetSmsDataTable(string xmlStr) {
            if (xmlStr.Length > 0) {
                StringReader StrStream = null;
                XmlTextReader Xmlrdr = null;
                try {
                    DataSet ds = new DataSet();
                    StrStream = new StringReader(xmlStr);
                    Xmlrdr = new XmlTextReader(StrStream);
                    ds.ReadXml(Xmlrdr);
                    return ds.Tables[0];
                }
                catch (Exception e) {
                    throw e;
                }
                finally {
                    if (Xmlrdr != null) {
                        Xmlrdr.Close();
                        StrStream.Close();
                    }
                }
            }
            else {
                return null;
            }
        }




        /// <summary>
        /// 保存未处理完得数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool DoBufListToXml<T>(T list, string path) {
            try {
                if (!File.Exists(path)) {
                    File.Create(path);
                }
                string fileName = path;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                FileStream fs = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(fs, list);
                fs.Close();
                return true;
            }
            catch (Exception ex) {

            }
            return false;
        }
        /// <summary>
        /// 获取未处理完得数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T DoBufXmlToList<T>(string path, T clearData) {
            if (!File.Exists(path)) {
                File.Create(path);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            string fileName = path;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            T list = (T)serializer.Deserialize(fs);
            fs.Close();
            DoBufListToXml(clearData, path);
            return list;
        }


    }
}
