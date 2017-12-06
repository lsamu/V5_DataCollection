using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_DataCollection._Class.DAL;
using V5_WinLibs.Expand;

namespace V5_DataCollection.Forms.Task.Tools {
    public partial class frmTaskDiyWebUrl : BaseForm {

        private object _EditItem;

        public object EditItem {
            get { return _EditItem; }
            set { _EditItem = value; }
        }

        private int _TaskId;

        public int TaskId {
            get { return _TaskId; }
            set { _TaskId = value; }
        }

        public event MainEventHandler.DataOperationHandler OnDataOperation;
        private MainEvents.DataOperationArgs ee = new MainEvents.DataOperationArgs();

        public frmTaskDiyWebUrl() {
            InitializeComponent();
        }

        private void BindLabel_W(TextBox rtb, string s) {
            int startPos = rtb.SelectionStart;
            int l = rtb.SelectionLength;

            rtb.Text = rtb.Text.Substring(0, startPos) + s + rtb.Text.Substring(startPos + l, rtb.Text.Length - startPos - l);

            rtb.SelectionStart = startPos + s.Length;
            rtb.ScrollToCaret();
        }

        private void frmTaskDiyWebUrl_Load(object sender, EventArgs e) {
            if (this.EditItem != null) {
                var model = DALDiyWebUrlHelper.GetList("And Id=" + this.EditItem, "", 1).SingleOrDefault();
                if (model != null) {
                    this.txtDiyWebUrlName.Text = model.Name;
                    this.txtDiyWebUrl.Text = model.Url;
                    this.cmbUrlEncode.Text = model.UrlEncode;
                    this.txtUrlPrams.Text = model.UrlParams;
                    this.txtEditId.Text = this.EditItem.ToString();
                }
            }
            Bind_UrlEncode();
        }

        /// <summary>
        /// °ó¶¨±àÂë
        /// </summary>
        private void Bind_UrlEncode() {
            var data = cPageEncode.GetPageEnCode(); ;
            this.cmbUrlEncode.DataSource = data;
            this.cmbUrlEncode.DisplayMember = "Text";
            this.cmbUrlEncode.ValueMember = "Value";
        }

        public void Delete() {
            if (this.EditItem != null) {
                DALDiyWebUrlHelper.Delete(int.Parse(this.EditItem.ToString()));
            }
            if (OnDataOperation != null) {
                OnDataOperation(this, ee);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            string Name = this.txtDiyWebUrlName.Text;
            string Url = this.txtDiyWebUrl.Text;
            string Encode = this.cmbUrlEncode.Text;
            string UrlParams = this.txtUrlPrams.Text;
            ModelDiyWebUrl model = new ModelDiyWebUrl();
            model.Name = Name;
            model.Url = Url;
            model.UrlEncode = Encode;
            model.UrlParams = UrlParams;
            model.SelfId = this.TaskId;
            if (this.EditItem == null) {
                model.CreateTime = DateTime.Now.ToString();
                DALDiyWebUrlHelper.Insert(model);
            }
            else {
                DALDiyWebUrlHelper.Update(model, int.Parse(this.EditItem.ToString()));
            }
            if (OnDataOperation != null) {
                OnDataOperation(this, ee);
            }
            this.Hide();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void btnTaskLabel1_Click(object sender, EventArgs e) {
            this.contextMenuStrip1 = new ContextMenuStrip();
            this.contextMenuStrip1.ItemClicked += (object sender1, ToolStripItemClickedEventArgs e1) => {
                if (e1.ClickedItem.Text.ToLower() == "md5") {
                    this.BindLabel_W(this.txtDiyWebUrl, "[" + e1.ClickedItem.Text + "][/" + e1.ClickedItem.Text + "]");
                }
                else {
                    this.BindLabel_W(this.txtDiyWebUrl, "[" + e1.ClickedItem.Text + "]");
                }
            };
            Bind_contextMenuStrip_Label(contextMenuStrip1);
            this.contextMenuStrip1.Show(btnTaskLabel1, 0, 21);
        }

        private void btnTaskLabel2_Click(object sender, EventArgs e) {
            this.contextMenuStrip1 = new ContextMenuStrip();
            this.contextMenuStrip1.ItemClicked += (object sender1, ToolStripItemClickedEventArgs e1) => {
                if (e1.ClickedItem.Text.ToLower() == "md5") {
                    this.BindLabel_W(this.txtUrlPrams, "[" + e1.ClickedItem.Text + "][/" + e1.ClickedItem.Text + "]");
                }
                else {
                    this.BindLabel_W(this.txtUrlPrams, "[" + e1.ClickedItem.Text + "]");
                }
            };
            Bind_contextMenuStrip_Label(contextMenuStrip1);
            this.contextMenuStrip1.Show(btnTaskLabel1, 0, 21);
        }


        private void Bind_contextMenuStrip_Label(ContextMenuStrip cms) {
            cms.Items.Clear();
            cms.Items.Add("Guid");
            cms.Items.Add("Url");
            cms.Items.Add("Md5");
            DALTaskLabel dal = new DALTaskLabel();
            DataTable dt = dal.GetList(" TaskID=" + this.TaskId + " Order by OrderID Asc").Tables[0];
            foreach (DataRow dr in dt.Rows) {
                cms.Items.Add(dr["LabelName"].ToString());
            }
        }
    }
}
