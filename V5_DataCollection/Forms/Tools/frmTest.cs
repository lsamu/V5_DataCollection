using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using V5_DataCollection._Class.Common;
using V5_DataCollection._Class.PythonExt;
using V5_WinLibs.Utility;

namespace V5_DataCollection.Forms.Tools {
    public partial class frmTest : BaseForm {
        public frmTest() {
            InitializeComponent();
        }

        private void btnDownLoad_Click(object sender, EventArgs e) {
            
        }

        Queue<DataGridViewRow> rr = new Queue<DataGridViewRow>();

        readonly static object oo = new object();

        private void button1_Click(object sender, EventArgs e) {


            DataGridViewRow row = new DataGridViewRow();
            foreach (DataGridViewColumn c in v5DataGridView1.Columns) {
                row.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);//给行添加单元格
            }

            row.Cells[0].Value = "01111";
            row.Cells[1].Value = 0;

            this.v5DataGridView1.Rows.Add(row);

            rr.Enqueue(row);

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void frmTest_Load(object sender, EventArgs e) {

            var th = new ThreadMultiHelper(1, 1);
            th.WorkMethod += (int taskindex, int threadindex) => {
                while (true) {
                    DataGridViewRow row = null;
                    if (rr != null && rr.Count > 0) {
                        row = rr.Dequeue();
                    }
                    if (row != null) {

                        for (int i = 0; i < 100; i++) {
                            row.Cells[1].Value = i.ToString();
                            Thread.Sleep(1);
                        }
                        this.Invoke(new MethodInvoker(() => {
                            this.v5DataGridView1.Rows.Remove(row);
                        }));
                    }

                    Thread.Sleep(500);
                }
            };
            th.Start();

        }

        private void button3_Click(object sender, EventArgs e) {
        }

        private void button4_Click(object sender, EventArgs e) {
            MessageBox.Show(this.textBox1.Handle.ToString());
        }

        private void btnTestPython_Click(object sender, EventArgs e) {
            var s = PythonExtHelper.RunPython(@"Plugins\SpiderUrl\test.py", new object[] { "你好啊随碟附送大放送的"});
        }
    }
}
