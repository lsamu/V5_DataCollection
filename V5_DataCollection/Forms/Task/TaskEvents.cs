using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_Model;

namespace V5_DataCollection.Forms.Task {
    public class TaskEvents {
        /// <summary>
        /// 添加ListUrl
        /// </summary>
        public class AddLinkUrlEvents : EventArgs {
            /// <summary>
            /// 链接类型
            /// </summary>
            public int LinkType { set; get; }
            /// <summary>
            /// 链接列表
            /// </summary>
            public ListBox.ObjectCollection LinkObject { set; get; }
        }
        /// <summary>
        /// 添加LabelName
        /// </summary>
        public class AddViewLabelEvents : EventArgs {
            /// <summary>
            /// 操作类型
            /// </summary>
            public string OPType { set; get; }
            /// <summary>
            /// 标签索引
            /// </summary>
            public int LabelIndex { set; get; }
            private ModelTaskLabel _LabelModel = new ModelTaskLabel();
            /// <summary>
            /// 标签模型
            /// </summary>
            public ModelTaskLabel LabelModel {
                get { return _LabelModel; }
                set { _LabelModel = value; }
            }
            private ModelTaskLabel _LabelModelOld = new ModelTaskLabel();
            /// <summary>
            /// 标签Old模型
            /// </summary>
            public ModelTaskLabel LabelModelOld {
                get { return _LabelModelOld; }
                set { _LabelModelOld = value; }
            }
        }
        /// <summary>
        /// 任务操作
        /// </summary>
        public class TaskOpEvents : EventArgs {
            /// <summary>
            /// 任务索引
            /// </summary>
            public int TaskIndex { get; set; }

            private int _OpType = 0;
            /// <summary>
            /// 操作类型 0 添加 1为修改
            /// </summary>
            public int OpType {
                get { return _OpType; }
                set { _OpType = value; }
            }

        }
    }
}
