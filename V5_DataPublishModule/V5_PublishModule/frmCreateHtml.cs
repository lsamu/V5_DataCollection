using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_PublishModule {
    public partial class frmCreateHtml : Form {

        public delegate void OutListViewItem(ListViewItem item, bool EditFlag);
        public OutListViewItem OutLVICreateHtml;
        Object _EditObject;
        /// <summary>
        /// ±‡º≠∂‘œÛ
        /// </summary>
        public Object EditObject {
            get { return _EditObject; }
            set { _EditObject = value; }
        }

        public frmCreateHtml() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (EditObject != null) {
                ListViewItem li = (ListViewItem)EditObject;
                li.SubItems[0].Text = this.txtCreateName.Text;
                li.SubItems[1].Text = this.txtCreateHtmlUrl.Text;
                li.SubItems[2].Text = this.txtCreateHtmlRefUrl.Text;
                li.SubItems[3].Text = this.txtCreateHtmlPostData.Text;
                if (OutLVICreateHtml != null) {
                    OutLVICreateHtml(li, true);
                }
            }
            else {
                ListViewItem li = new ListViewItem(this.txtCreateName.Text);
                li.SubItems.Add(this.txtCreateHtmlUrl.Text);
                li.SubItems.Add(this.txtCreateHtmlRefUrl.Text);
                li.SubItems.Add(this.txtCreateHtmlPostData.Text);
                if (OutLVICreateHtml != null) {
                    OutLVICreateHtml(li, false);
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        private void frmCreateHtml_Load(object sender, EventArgs e) {
            if (EditObject != null) {
                ListViewItem li = (ListViewItem)EditObject;
                this.txtCreateName.Text = li.SubItems[0].Text;
                this.txtCreateHtmlUrl.Text = li.SubItems[1].Text;
                this.txtCreateHtmlRefUrl.Text = li.SubItems[2].Text;
                this.txtCreateHtmlPostData.Text = li.SubItems[3].Text;
            }
        }
    }
}
