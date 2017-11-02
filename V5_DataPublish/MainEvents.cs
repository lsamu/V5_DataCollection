using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPublish {
    /// <summary>
    /// 系统事件
    /// </summary>
    public class MainEvents {
        /// <summary>
        /// 委托操作类型
        /// </summary>
        public enum OutPutWindowType {
            Option,
            Collecton,
            Publish
        }
        /// <summary>
        /// 输入出委托参数
        /// </summary>
        public class OutPutWindowEventArgs : EventArgs {
            private string _Message = string.Empty;
            private OutPutWindowType _OutPutWindowType;
            private object oData;
            #region Model
            /// <summary>
            /// 信息
            /// </summary>
            public string Message {
                get { return _Message; }
                set {
                    if (!string.IsNullOrEmpty(value))
                        _Message = "【" + DateTime.Now + "】 " + value;
                }
            }
            /// <summary>
            /// 委托类型
            /// </summary>
            public OutPutWindowType OutPutWindowType {
                get { return _OutPutWindowType; }
                set { _OutPutWindowType = value; }
            }
            /// <summary>
            /// 返回数据
            /// </summary>
            public object OData {
                get { return oData; }
                set { oData = value; }
            }
            #endregion
        }
    }
}
