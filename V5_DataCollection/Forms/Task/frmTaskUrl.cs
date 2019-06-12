using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace V5_DataCollection.Forms.Task
{
    public partial class frmTaskUrl : BaseForm {
        public TaskEventHandler.AddLinkUrl AddUrl;
        private TaskEvents.AddLinkUrlEvents ev = new TaskEvents.AddLinkUrlEvents();

        private ListBox.ObjectCollection _EditUrl = null;

        public ListBox.ObjectCollection EditUrl {
            get { return _EditUrl; }
            set { _EditUrl = value; }
        }
        public frmTaskUrl() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (AddUrl != null) {
                ev.LinkObject = this.listBoxUrlList.Items;
                AddUrl(this, ev);
            }
            this.Hide();
            this.Close();
        }

        #region 添加链接类型1
        private void btnAddLinkUrl1_Click(object sender, EventArgs e) {
            ev.LinkType = 1;
            string formatUrl = this.txtLinkUrl.Text;
            string[] listUrl = formatUrl.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in listUrl) {
                this.listBoxUrlList.Items.Insert(0, item);
            }
        }
        #endregion

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            Match s;
            if (Regex.IsMatch(e.ClickedItem.ToString(), "[{].*[}]")) {
                s = Regex.Match(e.ClickedItem.ToString(), "[{].*[}]");
            }
            else {
                s = Regex.Match(e.ClickedItem.ToString(), "[<].*[>]");
            }

            int startPos = this.txtLinkUrl.SelectionStart;
            int l = this.txtLinkUrl.SelectionLength;

            this.txtLinkUrl.Text = this.txtLinkUrl.Text.Substring(0, startPos) + s.Groups[0].Value + this.txtLinkUrl.Text.Substring(startPos + l, this.txtLinkUrl.Text.Length - startPos - l);

            this.txtLinkUrl.SelectionStart = startPos + s.Groups[0].Value.Length;
            this.txtLinkUrl.ScrollToCaret();
        }

        private void btnAddUrlParams_Click(object sender, EventArgs e) {
            this.contextMenuStrip1.Show(this.btnAddUrlParams, 0, 21);
        }

        private void frmTaskUrl_Load(object sender, EventArgs e) {
            if (EditUrl != null) {
                foreach (string str in EditUrl) {
                    this.txtLinkUrl.AppendText(str);
                    this.txtLinkUrl.AppendText("\r\n");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }
    }
}
