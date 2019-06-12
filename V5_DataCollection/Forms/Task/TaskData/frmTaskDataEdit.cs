using System;
using System.Windows.Forms;
using V5_DataCollection._Class.DAL;

namespace V5_DataCollection.Forms.Task.TaskData
{
    public partial class frmTaskDataEdit : BaseForm {

        public delegate void OutDataEdit(DataGridViewCell cell, string result);

        public OutDataEdit OutEdit;

        public string TaskName = string.Empty;

        public string Id;

        public string HeaderText;

        public DataGridViewCell Cell;

        public frmTaskDataEdit() {
            InitializeComponent();

        }

        private bool isHtml = true;

        private void frmTaskDataEdit_Load(object sender, EventArgs e) {

            if (!string.IsNullOrEmpty(Id)) {

                object oo = DALContentHelper.GetContent(this.TaskName, this.Id, this.HeaderText);

                if (oo.ToString().IndexOf("</") == -1) {
                    isHtml = false;
                }

                this.htmlEditor.InnerHtml = oo.ToString();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e) {

            string ss = isHtml ? this.htmlEditor.InnerHtml : this.htmlEditor.InnerText;

            DALContentHelper.UpdateContent(this.TaskName, this.Id, this.HeaderText, ss);

            if (OutEdit != null) {
                OutEdit(this.Cell, ss);
            }

            this.Hide();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }


    }
}
