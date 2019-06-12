using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using V5_DataPlugins;

namespace V5_DataCollection._Class {
    /// <summary>
    /// 插件工具类
    /// </summary>
    public class PluginUtility {
        public static List<IPlugin> ListIPublishContentPlugin = new List<IPlugin>();
        public static List<IPlugin> ListISaveContentPlugin = new List<IPlugin>();
        public static List<IPlugin> ListISpiderContentPlugin = new List<IPlugin>();
        public static List<IPlugin> ListISpiderUrlPlugin = new List<IPlugin>();
        public static List<IOutPutFormat> ListIOutputFormatPlugin = new List<IOutPutFormat>();

        public static string SpiderUrlPluginPath = AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\SpiderUrl\\";
        public static string SpiderContentPluginPath = AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\SpiderContent\\";
        public static string SaveContentPluginPath = AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\SaveContent\\";
        public static string PublishContentPluginPath = AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\PublishContent\\";

        static PluginUtility() {
            // LoadAllDlls();
            AppDomain curDomain = AppDomain.CurrentDomain;
            curDomain.AssemblyResolve += (object sender, ResolveEventArgs args) =>
            {

                string module = new AssemblyName(args.Name).Name;
                if (module.EndsWith(".resources"))
                    return null;
                string dll = Path.Combine(SaveContentPluginPath, string.Format("{0}.dll", module));
                return Assembly.LoadFrom(dll);
            };
        }

        public static void LoadAllDlls() {
            string[] publishFiles;
            #region  采集地址
            ListISpiderUrlPlugin.Clear();
            if (!Directory.Exists(SpiderUrlPluginPath)) {
                Directory.CreateDirectory(SpiderUrlPluginPath);
            }
            else {
                var exts = new[] { "*Plugin.dll", "*.py" };
                foreach (var ext in exts) {
                    publishFiles = Directory.GetFiles(SpiderUrlPluginPath, ext);
                    foreach (string str2 in publishFiles) {
                        try {
                            Assembly assembly = Assembly.LoadFrom(str2);
                            FileInfo fi = new FileInfo(str2);
                            string ff = fi.Name.Replace(fi.Extension, "");
                            ff = ff.Replace("Plugin", "");
                            IPlugin item = (IPlugin)Activator.CreateInstance(assembly.GetType("V5.DataCollection.Core." + ff));
                            ListISpiderUrlPlugin.Add(item);
                        }
                        catch (Exception) { }
                    }
                }

            }
            #endregion

            #region 采集内容
            ListISpiderContentPlugin.Clear();
            if (!Directory.Exists(SpiderContentPluginPath)) {
                Directory.CreateDirectory(SpiderContentPluginPath);
            }
            else {
                publishFiles = Directory.GetFiles(SpiderContentPluginPath, "*Plugin.dll");
                foreach (string str2 in publishFiles) {
                    try {
                        Assembly assembly = Assembly.LoadFrom(str2);
                        FileInfo fi = new FileInfo(str2);
                        string ff = fi.Name.Replace(fi.Extension, "");
                        ff = ff.Replace("Plugin", "");
                        IPlugin item = (IPlugin)Activator.CreateInstance(assembly.GetType("V5.DataCollection.Core." + ff));
                        ListISpiderContentPlugin.Add(item);
                    }
                    catch (Exception) { }
                }
            }
            #endregion

            #region 发布内容
            ListIPublishContentPlugin.Clear();
            if (!Directory.Exists(PublishContentPluginPath)) {
                Directory.CreateDirectory(PublishContentPluginPath);
            }
            else {
                publishFiles = Directory.GetFiles(PublishContentPluginPath, "*Plugin.dll");
                foreach (string str2 in publishFiles) {
                    try {
                        Assembly assembly = Assembly.LoadFrom(str2);
                        FileInfo fi = new FileInfo(str2);
                        string ff = fi.Name.Replace(fi.Extension, "");
                        ff = ff.Replace("Plugin", "");
                        IPlugin item = (IPlugin)Activator.CreateInstance(assembly.GetType("V5.DataCollection.Core." + ff));
                        ListIPublishContentPlugin.Add(item);
                    }
                    catch (Exception) { }
                }
            }
            #endregion

            #region 保存内容
            ListISaveContentPlugin.Clear();
            if (!Directory.Exists(SaveContentPluginPath)) {
                Directory.CreateDirectory(SaveContentPluginPath);
            }
            else {
                publishFiles = Directory.GetFiles(SaveContentPluginPath, "*Plugin.dll");
                foreach (string str2 in publishFiles) {
                    try {
                        Assembly assembly = Assembly.LoadFrom(str2);
                        FileInfo fi = new FileInfo(str2);
                        string ff = fi.Name.Replace(fi.Extension, "");
                        ff = ff.Replace("Plugin", "");
                        IPlugin item = (IPlugin)Activator.CreateInstance(assembly.GetType("V5.DataCollection.Core." + ff));
                        ListISaveContentPlugin.Add(item);
                    }
                    catch (Exception) { }
                }
            }
            #endregion

            #region 保存内容
            ListIOutputFormatPlugin.Clear();
            if (!Directory.Exists(SaveContentPluginPath))
            {
                Directory.CreateDirectory(SaveContentPluginPath);
            }
            else
            {
                
                publishFiles = Directory.GetFiles(SaveContentPluginPath, "*Plugin.dll");
                foreach (string str2 in publishFiles)
                {
                    try
                    {
                        Assembly assembly = Assembly.LoadFrom(str2);
                      //  FileInfo fi = new FileInfo(str2);
                       // string ff = fi.Name.Replace(fi.Extension, "");
                       // ff = ff.Replace("Plugin", "");
                       // IPlugin item = (IPlugin)Activator.CreateInstance(assembly.GetType("V5.DataCollection.Core." + ff));
                       // ListISaveContentPlugin.Add(item);
                    }
                    catch (Exception) { }
                }
              var ass=  AppDomain.CurrentDomain.GetAssemblies();
                var types = ass.SelectMany(x => x.GetTypes()).Where(t => t.GetInterface(typeof(IOutPutFormat).Name)!=null);
                foreach (var t in types)
                {
                    IOutPutFormat item = (IOutPutFormat)Activator.CreateInstance(t);
                    ListIOutputFormatPlugin.Add(item);
                }


            }
            #endregion
        }
        /// <summary>
        ///  根据名称获取插件 Type 1,2,3,4
        /// </summary>
        public static IPlugin GetPluginByName(string PluginName, int Type) {
            LoadAllDlls();
            IPlugin myPlugin = null;
            if (Type == 1) {
                foreach (IPlugin plugin in PluginUtility.ListISpiderUrlPlugin) {
                    if (plugin.PluginName == PluginName) {
                        myPlugin = plugin;
                        break;
                    }
                }
            }
            else if (Type == 2) {
                foreach (IPlugin plugin in PluginUtility.ListISpiderContentPlugin) {
                    if (plugin.PluginName == PluginName) {
                        myPlugin = plugin;
                        break;
                    }
                }
            }
            else if (Type == 3) {
                foreach (IPlugin plugin in PluginUtility.ListISaveContentPlugin) {
                    if (plugin.PluginName == PluginName) {
                        myPlugin = plugin;
                        break;
                    }
                }
            }
            else if (Type == 4) {
                foreach (IPlugin plugin in PluginUtility.ListIPublishContentPlugin) {
                    if (plugin.PluginName == PluginName) {
                        myPlugin = plugin;
                        break;
                    }
                }
            }
            return myPlugin;
        }
    }
}
