using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataPublish {
    public partial class frmOption : V5_DataPublish.BaseForm {
        public frmOption() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        private void frmOption_Load(object sender, EventArgs e) {
            this.tabControl1.Region = new Region(new RectangleF(this.tabPage1.Left, this.tabPage1.Top, this.tabPage1.Width, this.tabPage1.Height));

            this.tabControl1.Top = this.tabControl1.Top - 20;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            this.tabControl1.SelectedIndex = int.Parse("0" + e.Node.Tag);
        }
    }
}
