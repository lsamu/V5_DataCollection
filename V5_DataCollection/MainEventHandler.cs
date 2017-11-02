
namespace V5_DataCollection {
    /// <summary>
    /// 
    /// </summary>
    public class MainEventHandler {
        /// <summary>
        /// 输出窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void OutPutWindowHandler(object sender, MainEvents.OutPutWindowEventArgs e);

        /// <summary>
        /// 任务进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void OutPutTaskProgressBarHandler(object sender, MainEvents.OutPutTaskProgressBarEventArgs e);

        /// <summary>
        ///任务树委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void TreeViewEventHandler(object sender, MainEvents.TreeViewEventArgs e);

        /// <summary>
        /// 公共委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void CommonEventHandler(object sender, MainEvents.CommonEventArgs e);

        /// <summary>
        /// 数据操作委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void DataOperationHandler(object sender, MainEvents.DataOperationArgs e);
    }
}
