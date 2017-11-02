using System;

namespace V5_DataCollection {
    /// <summary>
    /// 
    /// </summary>
    public class MainEvents {
        /// <summary>
        /// 输出
        /// </summary>
        public class OutPutWindowEventArgs : EventArgs {
            public int TaskId { get; set; }
            public string Message { set; get; }
        }

        /// <summary>
        /// 进度条
        /// </summary>
        public class OutPutTaskProgressBarEventArgs : EventArgs {
            /// <summary>
            /// 当前进度个数
            /// </summary>
            public int ProgressNum { get; set; }
            /// <summary>
            /// 记录总个数
            /// </summary>
            public int RecordNum { get; set; }
            /// <summary>
            /// 任务索引
            /// </summary>
            public int TaskIndex { get; set; }
        }

        /// <summary>
        /// 任务树对象
        /// </summary>
        public class TreeViewEventArgs : EventArgs {
            /// <summary>
            /// 操作结果
            /// </summary>
            public string Result { get; set; }
            /// <summary>
            /// 消息结果
            /// </summary>
            public string Message { get; set; }
            /// <summary>
            /// 返回结果对象(any object)
            /// </summary>
            public object ReturnObj { get; set; }
        }


        /// <summary>
        /// 公共委托对象
        /// </summary>
        public class CommonEventArgs : EventArgs {
            /// <summary>
            /// 操作结果
            /// </summary>
            public string Result { get; set; }
            /// <summary>
            /// 消息结果
            /// </summary>
            public string Message { get; set; }
            /// <summary>
            /// 返回结果对象(any object)
            /// </summary>
            public object ReturnObj { get; set; }
        }

        public enum OperationEnum {
            Select = 0,
            Add = 1,
            Edit = 2,
            Delete = 3,
            Error = 4
        }

        public class DataOperationArgs : EventArgs {
            /// <summary>
            ///操作方式
            /// </summary>
            public OperationEnum Operation { get; set; }
            /// <summary>
            /// 消息结果
            /// </summary>
            public string Message { get; set; }
            /// <summary>
            /// 返回结果对象(any object)
            /// </summary>
            public object ReturnObj { get; set; }
        }
    }
}
