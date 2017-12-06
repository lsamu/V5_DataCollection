using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataCollection._Class.Model;

namespace V5_DataCollection._Class.Common {
    /// <summary>
    /// 队列列表
    /// </summary>
    public class QueueImgHelper {
        public readonly static object lockObj = new object();
        /// <summary>
        /// 下载图片资源
        /// </summary>
        public static Queue<ModelDownLoadImg> Q_DownImgResource = new Queue<ModelDownLoadImg>();


        public static void AddImg(int TaskId,string localPic, string remotePic,int stepTime) {
            var d = new ModelDownLoadImg();
            d.TaskId = TaskId;
            d.LocalImg = localPic;
            d.RemoteImg = remotePic;
            d.StepTime = stepTime;

            lock (lockObj) {
                Q_DownImgResource.Enqueue(d);
            }
        }

        public static ModelDownLoadImg DequeueImg() {
            ModelDownLoadImg d = null ;
            lock (lockObj) {
                d = Q_DownImgResource.Dequeue();
            }
            if (d != null) {
                return d;
            }
            return null;
        }

        public void SaveImgQueue() {

        }

        public void LoadImgQueue() {

        }
    }
}
