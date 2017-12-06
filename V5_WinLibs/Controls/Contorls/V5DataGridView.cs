using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace V5_WinControls {
    public partial class V5DataGridView : DataGridView {
        public V5DataGridView() {
            InitializeComponent();
        }

        public V5DataGridView(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            ////新建的行高
            ////总高度 包括行高
            ////表格总宽
            //// 存储四组数字位置及高度
            //// 存储四组数字位置及高度
            //// 存储四组数字位置及高度
            ////线
            ////绘制框
            ////填充颜色
            //// 封装图.FillRectangle(New SolidBrush(Me.RowHeadersDefaultCellStyle.BackColor), rowHeader
        }
    }
}
