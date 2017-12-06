using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace V5_DataPublish {
    public class MainEventHandler {
        /// <summary>
        /// 输出窗口
        /// </summary>
        public delegate void OutPutWindowHandler(object sender, MainEvents.OutPutWindowEventArgs e);
        /// <summary>
        /// 日志委托
        /// </summary>
        public delegate void PublishOutPutWindowHandler(object sender, MainEvents.OutPutWindowEventArgs e);
    }
}
