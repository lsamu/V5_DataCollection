using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using V5_DataCollection._Class.Common;
using V5_DataCollection._Class.Model;
using V5_WinLibs.Utility;
using WeifenLuo.WinFormsUI.Docking;

namespace V5_DataCollection.Forms.Docking {
    public partial class frmOutPutBox : BaseContent {

        public frmOutPutBox() {
            InitializeComponent();

            this.txtOutWindowString.Dock = DockStyle.Fill;

            var th = new ThreadMultiHelper(1, 1);
            th.WorkMethod += th_WorkMethod;
            th.CompleteEvent += th_CompleteEvent;
            th.Start();


        }

        #region 日志输出
        /// <summary>
        /// 日志输出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OutPutWindow(object sender, MainEvents.OutPutWindowEventArgs e) {
            if (this.txtOutWindowString.InvokeRequired) {
                this.txtOutWindowString.BeginInvoke(new MethodInvoker(delegate () {
                    this.txtOutWindowString.AppendText("【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "】 " + e.Message);
                    this.txtOutWindowString.AppendText("\r\n");
                    this.txtOutWindowString.ScrollToCaret();
                }));
            }
            else {
                this.txtOutWindowString.AppendText("【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "】 " + e.Message);
                this.txtOutWindowString.AppendText("\r\n");
                this.txtOutWindowString.ScrollToCaret();
            }
        }

        private void toolStripButton_ContentClear_Click(object sender, EventArgs e) {
            this.txtOutWindowString.Clear();
        }
        #endregion

        #region 下载资源
        void th_CompleteEvent() {

        }

        void th_WorkMethod(int taskindex, int threadindex) {
            while (true) {
                ModelDownLoadImg d = null;
                lock (QueueImgHelper.lockObj) {
                    if (QueueImgHelper.Q_DownImgResource.Count > 0) {
                        d = QueueImgHelper.Q_DownImgResource.Dequeue();
                    }
                }
                if (d != null) {
                    OutDownload(d);
                    Thread.Sleep(d.StepTime);
                }
            }
        }


        private void OutDownload(ModelDownLoadImg d) {
            this.Invoke(new MethodInvoker(() => {
                try {
                    var file = new FileInfo(d.LocalImg);
                    if (!Directory.Exists(file.Directory.FullName)) {
                        Directory.CreateDirectory(file.Directory.FullName);
                    }

                    if (File.Exists(d.LocalImg)) {
                        return;
                    }

                    DownLoadFile(d.RemoteImg, d.LocalImg);

                    this.txtLogView.AppendText($"任务ID:{d.TaskId} 远程图片:{d.RemoteImg} 本地图片:{d.LocalImg} 下载完成!");
                    this.txtLogView.AppendText("\r\n");


                }
                catch (Exception ex) {
                    this.txtLogView.AppendText($"任务ID:{d.TaskId} 远程图片:{d.RemoteImg} 本地图片:{d.LocalImg} 失败!{ex.Message}");
                    this.txtLogView.AppendText("\r\n");
                }
            }));
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            this.txtLogView.AppendText($"下载完成!");
            this.txtLogView.AppendText("\r\n");
        }

        private async void DownLoadFile(string remoteFile, string localFile) {
            try {
                WebClient wc = new WebClient();
                await wc.DownloadFileTaskAsync(remoteFile, localFile);
            }
            catch (Exception ex) {
            }
        }

        public async System.Threading.Tasks.Task TestAAA(string remoteFile, string localFile) {
            WebClient wc = new WebClient();
            await wc.DownloadFileTaskAsync(remoteFile, localFile);
            this.txtLogView.AppendText($"远程图片:{remoteFile}本地图片:{localFile} 下载完成!");
            this.txtLogView.AppendText("\r\n");
        }
        private void toolStrip_ClearLog_Click(object sender, EventArgs e) {
            this.txtLogView.Clear();
        }

        private void toolStrip_ViewQueue_Click(object sender, EventArgs e) {
            this.txtLogView.AppendText($"当前队列的个数为{QueueImgHelper.Q_DownImgResource.Count}个!");
            this.txtLogView.AppendText("\r\n");
        }
        #endregion


    }
}
