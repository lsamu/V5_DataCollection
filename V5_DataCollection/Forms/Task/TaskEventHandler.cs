using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataCollection.Forms.Task
{
    public class TaskEventHandler
    {
        /// <summary>
        /// 添加链接
        /// </summary>
        public delegate void AddLinkUrl(object sender, TaskEvents.AddLinkUrlEvents e);
        /// <summary>
        /// 添加View连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void AddViewLabel(object sender, TaskEvents.AddViewLabelEvents e);
        /// <summary>
        /// 任务操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void TaskOpHandler(object sender, TaskEvents.TaskOpEvents e);
    }
}
