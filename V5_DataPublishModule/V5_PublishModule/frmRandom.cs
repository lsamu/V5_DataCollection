using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_PublishModule {
    public partial class frmRandom : Form {
        public delegate void OutListViewItemHandler(ListViewItem item, bool EditFlag);
        public OutListViewItemHandler OutRandomDelegate;
        private Object _EditObject;
        /// <summary>
        /// 编辑对象
        /// </summary>
        public Object EditObject {
            get { return _EditObject; }
            set { _EditObject = value; }
        }
        public frmRandom() {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRandom_Load(object sender, EventArgs e) {
            if (EditObject != null) {
                ListViewItem li = (ListViewItem)EditObject;
                this.txtLabelName.Text = li.SubItems[0].Text;
                this.txtRandomUrl.Text = li.SubItems[1].Text;
                this.txtRandomRefUrl.Text = li.SubItems[2].Text;
                this.txtRandomPostData.Text = li.SubItems[3].Text;
                this.txtRandomCutRegex.Text = li.SubItems[4].Text;
                this.cmbRandomLabelType.Text = li.SubItems[5].Text;
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// 编辑保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e) {
            string LabelName = this.txtLabelName.Text;
            string RandomUrl = this.txtRandomUrl.Text;
            string RandomRefUrl = this.txtRandomRefUrl.Text;
            string RandomPostData = this.txtRandomPostData.Text;
            string RandomCutRegex = this.txtRandomCutRegex.Text;
            string RandomLabelType = this.cmbRandomLabelType.Text;
            errorProvider.Clear();
            if (string.IsNullOrEmpty(LabelName)) {
                errorProvider.SetError(this.txtLabelName, "标签名称不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(RandomUrl)) {
                errorProvider.SetError(this.txtRandomUrl, "访问地址不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(RandomLabelType)) {
                errorProvider.SetError(this.cmbRandomLabelType, "随机值类型不能为空!");
                return;
            }
            if (RandomLabelType != "登陆" && RandomLabelType != "列表" && RandomLabelType != "内容") {
                errorProvider.SetError(this.cmbRandomLabelType, "随机值类型不正确!");
                return;
            }
            if (EditObject != null) {
                ListViewItem li = (ListViewItem)EditObject;
                li.SubItems[0].Text = LabelName;
                li.SubItems[1].Text = RandomUrl;
                li.SubItems[2].Text = RandomRefUrl;
                li.SubItems[3].Text = RandomPostData;
                li.SubItems[4].Text = RandomCutRegex;
                li.SubItems[5].Text = RandomLabelType;
                if (OutRandomDelegate != null) {
                    OutRandomDelegate(li, true);
                }
            }
            else {
                ListViewItem li = new ListViewItem(LabelName);
                li.SubItems.Add(RandomUrl);
                li.SubItems.Add(RandomRefUrl);
                li.SubItems.Add(RandomPostData);
                li.SubItems.Add(RandomCutRegex);
                li.SubItems.Add(RandomLabelType);
                if (OutRandomDelegate != null) {
                    OutRandomDelegate(li, false);
                }
            }
            this.Close();
        }
    }
}
