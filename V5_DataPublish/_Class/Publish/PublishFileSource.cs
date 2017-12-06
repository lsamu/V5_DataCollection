using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using V5_DataPlugins;
using V5_Utility.Core;
using V5_Utility;
using V5_DataPublish._Class;
using V5_Utility.Utility;
using V5_WinLibs.Utility;

namespace V5_DataPublish._Class.Publish {
    /// <summary>
    /// 发布文件源任务
    /// </summary>
    public class PublishFileSource {
        public WebSiteHelper Model = null;
        private ThreadMultiHelper thHelper = null;
        public MainEventHandler.PublishOutPutWindowHandler PublishOP;
        private MainEvents.OutPutWindowEventArgs ope = new MainEvents.OutPutWindowEventArgs();

        private static bool IsOpen = true;
        public void Start() {
            thHelper = new ThreadMultiHelper(1, 1);
            thHelper.WorkMethod += WorkMethod;
            thHelper.CompleteEvent += CompleteEvent;
            thHelper.Start();
        }

        public void Stop() {
            thHelper.Stop();
        }

        private void WorkMethod(int taskindex, int threadindex) {
            string Title = string.Empty, Content = string.Empty;
            StringBuilder sbContent = new StringBuilder();
            if (Model != null) {
                IPublish iPublish = Utility.GetIPublishByName(Model.PublishName);
                iPublish.Publish_Init(Model.WebSiteUrl, Model.WebSiteLoginUrl,
                    Model.LoginUserName, Model.LoginUserPwd,
                    0, string.Empty);
                iPublish.Publish_OutResult = OPR_SendData;
                string[] files = Directory.GetFiles(Model.FileSourcePath, "*.html");
                int lLen = files.Length;
                for (int i = 0; i < lLen; i++) {
                    if (IsOpen) {
                        IsOpen = false;
                        try {
                            string file = files[i];
                            FileInfo fiFile = new FileInfo(file);
                            Title = fiFile.Name.Replace(fiFile.Extension, "");
                            int l = fiFile.Name.LastIndexOf("_");
                            if (l > -1) {
                                Title = Title.Substring(0, l);
                            }
                            StreamReader sr = new StreamReader(file, Encoding.Default);
                            sbContent.Append(sr.ReadToEnd());
                            sr.Close();
                            if (sbContent.Length >= 300) {
                                ModelGatherItem mGatherItem = new ModelGatherItem();
                                mGatherItem.Title = Title;
                                mGatherItem.Content = sbContent.ToString();
                                ModelClassItem mClassList = new ModelClassItem();
                                mClassList.ClassID = "1";
                                mClassList.ClassName = "美容知识";
                                iPublish.Publish_PostData(mGatherItem, mClassList);
                            }
                            sbContent.Remove(0, sbContent.Length);
                            File.Delete(file);
                            Thread.Sleep(1000);
                        }
                        catch (Exception ex) {
                            Log4Helper.Write(LogLevel.Error, "文件发布错误!", ex);
                            continue;
                        }
                    }
                    else {
                        Thread.Sleep(5000);
                    }
                }
            }
        }

        private void CompleteEvent() {
            ope.Message = Model.WebSiteName + "_发布完成!";
            if (PublishOP != null) {
                PublishOP(this, ope);
            }
        }

        private void OPR_SendData(object sender, PublishType pt, bool isLogin, string Msg, object oResult) {
            if (pt == PublishType.PostDataOver) {
                IsOpen = true;
                ModelGatherItem modelArticle = (ModelGatherItem)oResult;
                ope.Message = modelArticle.Title + "_" + Msg;
                if (PublishOP != null) {
                    PublishOP(this, ope);
                }
            }
        }
    }
}
