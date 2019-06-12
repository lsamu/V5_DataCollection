using System;

namespace V5_DataCollection.Forms.Task
{
    public partial class frmTaskLabelRemove : BaseForm {
        public delegate void TaskLabelRemove(int ItemIndex, string RemoveStr, string CheckLabel, string OpType);
        public TaskLabelRemove TLR;

        private int _ItemIndex = -1;

        public int ItemIndex {
            get { return _ItemIndex; }
            set { _ItemIndex = value; }
        }

        private string _OldName = string.Empty;

        public string OldName {
            get { return _OldName; }
            set { _OldName = value; }
        }
        private string _RemoveName = string.Empty;
        public string RemoveLabel {
            get { return _RemoveName; }
            set { _RemoveName = value; }
        }

        public frmTaskLabelRemove() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            string OpType = "add";
            if (this.OldName.Trim() != "")
                OpType = "edit";
            if (this.txtRemoveStr.Text.Trim() != "") {
                if (rdbSingleTag.Checked)
                {
                    TLR?.Invoke(this.ItemIndex, this.txtRemoveStr.Text, "1", OpType);
                }
                else  if (rdbFilterAll.Checked)
                {
                    TLR?.Invoke(this.ItemIndex, this.txtRemoveStr.Text, "2", OpType);
                }
                else
                {
                    TLR?.Invoke(this.ItemIndex, this.txtRemoveStr.Text, "3", OpType);
                }
            }
            this.Hide();
            this.Close();
        }

        private void frmTaskLabelRemove_Load(object sender, EventArgs e) {
            if (this.OldName.Trim() != "") {
                this.txtRemoveStr.Text = this.OldName;
                this.rdbFilterTagOnly.Checked = RemoveLabel == "3";
                this.rdbSingleTag.Checked = RemoveLabel == "1";
                this.rdbFilterAll.Checked = RemoveLabel == "2";
            }
        }
    }
}
