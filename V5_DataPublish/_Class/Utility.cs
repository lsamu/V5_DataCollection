using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using V5_DataPlugins;
using V5_Utility;
using V5_Utility.Core;
using V5_DataPlugins.Model;
using V5_Utility.Utility;
using V5_WinLibs.Core;

namespace V5_DataPublish._Class {
    public class Utility {
        private static string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string PublishModulesPath = AppDomain.CurrentDomain.BaseDirectory + "\\Modules\\";
        /// <summary>
        /// 发布
        /// </summary>
        public static List<IPublish> ListIPublish = new List<IPublish>();
        public static List<IPublishContent> ListIPublishContent = new List<IPublishContent>();
        /// <summary>
        /// 加载插件
        /// </summary>
        public static void LoadAllDlls() {
            #region  发布
            try {
                ListIPublish.Clear();
                string[] publishFiles = Directory.GetFiles(PublishModulesPath, "*Modules.dll");
                foreach (string str2 in publishFiles) {
                    try {
                        Assembly assembly = Assembly.LoadFrom(str2);
                        FileInfo fi = new FileInfo(str2);
                        string ff = fi.Name.Replace(fi.Extension, "");
                        ff = ff.Replace("V5.", "");
                        IPublish item = (IPublish)Activator.CreateInstance(assembly.GetType("V5.DataPlugins." + ff));
                        ListIPublish.Add(item);
                        continue;
                    }
                    catch (Exception ex) {
                        Log4Helper.Write(LogLevel.Error, ex);
                        continue;
                    }
                }
            }
            catch (Exception ex) {
                Log4Helper.Write(LogLevel.Error, ex);
            }
            #endregion

            #region PublishContent
            try {
                ListIPublishContent.Clear();
                string[] publiscContentDirs = Directory.GetDirectories(BaseDirectory + "\\Plugins\\V5.DataPublish.PublishContent\\");
                foreach (string dir in publiscContentDirs) {
                    string[] filess = Directory.GetFiles(dir, "*PublishContent.dll");
                    try {
                        if (filess.Length == 0) {
                            break;
                        }
                        string file = filess[0];
                        Assembly assembly = Assembly.LoadFrom(file);
                        FileInfo fi = new FileInfo(file);
                        string ff = fi.Name.Replace(fi.Extension, "");
                        ff = ff.Replace("V5.", "");
                        IPublishContent item = (IPublishContent)Activator.CreateInstance(assembly.GetType("V5.DataPlugins." + ff));
                        ListIPublishContent.Add(item);
                    }
                    catch (Exception ex) {
                        Log4Helper.Write(LogLevel.Error, ex);
                        continue;
                    }
                }
            }
            catch (Exception ex) {
                Log4Helper.Write(LogLevel.Error, ex);
            }
            #endregion

        }
        /// <summary>
        /// 读取插件
        /// </summary>
        /// <param name="PublishName"></param>
        /// <returns></returns>
        public static IPublish GetIPublishByName(string PublishName) {
            if (PublishName.IndexOf(".pmod") > -1) {
                IPublish iPublish = new PublishCommon();
                iPublish.Publish_Name = PublishName;
                string pathFileName = AppDomain.CurrentDomain.BaseDirectory + "\\Modules\\" + PublishName;
                iPublish.Publish_Model = Load_PublishItem(pathFileName);
                return iPublish;
            }
            else {
                Utility.LoadAllDlls();
                foreach (IPublish p in Utility.ListIPublish) {
                    if (p.Publish_Name == PublishName) {
                        return p;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 加载单个模块数据
        /// </summary>
        /// <param name="pathName"></param>
        private static ModelPublishModuleItem Load_PublishItem(string pathName) {
            ModelPublishModuleItem model = new ModelPublishModuleItem();
            try {
                string fileName = pathName;
                model = (ModelPublishModuleItem)ObjFileStoreHelper.Deserialize(fileName);
            }
            catch {
                model = null;
            }
            return model;
        }
    }
}
