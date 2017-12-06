using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataCollection.Forms.Tools {
    public partial class frmUserTool : BaseForm {
        public delegate void ReturnResult(string msg);

        public event ReturnResult OutReturnResult;

        public frmUserTool() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {

            var al = new ArrayList();

            foreach (var item in this.listBox1.Items) {
                al.Add(item);
            }

            var data = new {
                data = al.ToArray()
            };

            Bind_SaveUserTools(data);

            OutReturnResult?.Invoke("操作成功!");

            this.CloseForm();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.CloseForm();
        }

        private void Bind_SaveUserTools(object data) {

            var path = AppDomain.CurrentDomain.BaseDirectory + "System\\UserTools\\";
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            var j = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            File.WriteAllText(path + "list.json", j);
        }

        /// <summary>
        /// 加载用户工具
        /// </summary>
        private void Bind_UserTools() {
            this.listBox1.Items.Clear();
            if (File.Exists(@"System\UserTools\list.json")) {
                var fileText = File.ReadAllText(@"System\UserTools\list.json");
                var json = Newtonsoft.Json.Linq.JObject.Parse(fileText);
                foreach (var j in json["data"]) {
                    var name = j.Value<string>("name");
                    var path = j.Value<string>("path");
                    this.listBox1.Items.Add(
                        new {
                            name = name,
                            path = path
                        }
                        );
                }
                this.listBox1.DisplayMember = "name";
            }
        }

        private void frmUserToolEdit_Load(object sender, EventArgs e) {
            this.Bind_UserTools();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            var item = this.listBox1.SelectedItem as dynamic;

            if (item != null) {
                this.txtAppName.Text = item.name;
                this.txtAppPath.Text = item.path;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var item = new {
                name = "新工具",
                path = ""
            };

            this.listBox1.Items.Add(
                 item
                );
            this.listBox1.SelectedItem = item;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            var itemSelected = this.listBox1.SelectedItem as dynamic;
            var itemIndex = this.listBox1.SelectedIndex;
            if (itemSelected != null) {
                this.listBox1.Items.RemoveAt(itemIndex);
                this.listBox1.Items.Insert(itemIndex, new {
                    name = this.txtAppName.Text,
                    path = this.txtAppPath.Text
                });
            }
            this.listBox1.SelectedIndex = itemIndex;



            var al = new ArrayList();

            foreach (var item in this.listBox1.Items) {
                al.Add(item);
            }

            var data = new {
                data = al.ToArray()
            };

            Bind_SaveUserTools(data);

            OutReturnResult?.Invoke("操作成功!");
        }

        private void frmUserToolEdit_FormClosing(object sender, FormClosingEventArgs e) {
            OutReturnResult?.Invoke("操作成功!");
        }

        private void btnBrowser_Click(object sender, EventArgs e) {
            var file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK) {
                this.txtAppPath.Text = file.FileName;
            }

        }

        private void txtAppPath_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Link;
                this.txtAppPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtAppPath_DragDrop(object sender, DragEventArgs e) {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.txtAppPath.Text = path;
            this.txtAppPath.Cursor = System.Windows.Forms.Cursors.IBeam;
        }

        private void btnMoveUp_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex > 0) {
                object selstr = listBox1.Items[listBox1.SelectedIndex - 1];
                listBox1.Items[listBox1.SelectedIndex - 1] = listBox1.SelectedItem;
                listBox1.Items[listBox1.SelectedIndex] = selstr;
                listBox1.SelectedItem = listBox1.Items[listBox1.SelectedIndex - 1];
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex > -1) {
                object selstr = listBox1.Items[listBox1.SelectedIndex + 1];
                listBox1.Items[listBox1.SelectedIndex + 1] = listBox1.SelectedItem;
                listBox1.Items[listBox1.SelectedIndex] = selstr;
                listBox1.SelectedItem = listBox1.Items[listBox1.SelectedIndex + 1];
            }
        }

        private void btnDel_Click(object sender, EventArgs e) {
            if (MessageBox.Show("确定要删除吗?", "删除不可恢复!", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
        }
    }
}
