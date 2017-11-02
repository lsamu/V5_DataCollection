using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using V5_DAL;
using System.Data;
using V5_DataPlugins;
using V5_DataPublish._Class;
namespace V5_DataPublish._Class.Publish {
    public class PublishThread {
        #region 委托
        public MainEventHandler.PublishOutPutWindowHandler PublishOP;
        #endregion

        #region Properties
        public bool IsRunning { get; set; }
        public bool Enabled { get; set; }
        public bool Stopped { get; set; }
        #endregion

        #region 变量
        string Msg = string.Empty;
        private static Thread th;
        private static Thread[] threads;
        Queue<WebSiteHelper> queuePublishItem = new Queue<WebSiteHelper>();
        List<WebSiteHelper> listPublishItem = new List<WebSiteHelper>();
        #endregion 

        #region Base
        /// <summary>
        /// 开始任务
        /// </summary>
        public void StartTask() {
            ThreadPool.QueueUserWorkItem(new WaitCallback(StartBase));
            ThreadPool.QueueUserWorkItem(new WaitCallback(StartBase_Publish));
        }
        /// <summary>
        /// 停止任务
        /// </summary>
        public void StopTask() {
            StopBase();
            StopBase_Publish();
        }
        #endregion

        #region 读取要发布的网站
        private void StartBase(object args) {
            if (!this.Stopped) {
                th = new Thread(RunBase);
                th.Start();
            }
        }
        /// <summary>
        /// 每30分钟检查一次是否有网站发布 一个网站一天只发一次文章
        /// </summary>
        private void RunBase(object args) {
            while (true) {
                if (this.Stopped)
                    break;
                var list = Common.GetList<WebSiteHelper>(p=>p.Uuid!=string.Empty);
                foreach (var model in list) {
                    if (!queuePublishItem.Contains(model)) {
                        queuePublishItem.Enqueue(model);
                    }
                }
                Thread.Sleep(5 * 1000);
            }
        }

        private bool StopBase() {
            this.Stopped = true;
            th.Abort();
            return true;
        }
        #endregion

        #region 发布网站
        /// <summary>
        /// 发布文章线程
        /// </summary>
        private void StartBase_Publish(object args) {
            threads = new Thread[2];
            for (int i = 0; i < 2; i++) {
                threads[i] = new Thread(RunBase_Publish);
                threads[i].Start(i);
            }
        }
        /// <summary>
        /// 发布文章任务
        /// </summary>
        private void RunBase_Publish(object args) {
            while (true) {
                if (this.Stopped)
                    break;
                WebSiteHelper model = null;
                lock (queuePublishItem) {
                    if (queuePublishItem.Count > 0) {
                        model = queuePublishItem.Dequeue();
                    }
                }
                if (model != null) {
                    if (!listPublishItem.Contains(model)) {
                        listPublishItem.Add(model);
                        PublishTask PublishTask = new PublishTask();
                        PublishTask.PublishOP = PublishOP;
                        PublishTask.OverOP = OverOP;
                        PublishTask.ThreadSendContent(model);
                    }
                }
                Thread.Sleep(100);
            }
        }
        /// <summary>
        /// 停止发布文章
        /// </summary>
        /// <returns></returns>
        private bool StopBase_Publish() {
            this.Stopped = true;
            foreach (Thread th in threads) {
                th.Abort();
            }
            return true;
        }

        private void OverOP(WebSiteHelper model) {
            listPublishItem.Remove(model);
        }
        #endregion
    }
}
