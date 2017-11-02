using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataCollection.Forms.Task {
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
                TLR?.Invoke(this.ItemIndex, this.txtRemoveStr.Text, "0", OpType);
            }
            this.Hide();
            this.Close();
        }

        private void frmTaskLabelRemove_Load(object sender, EventArgs e) {
            if (this.OldName.Trim() != "") {
                this.txtRemoveStr.Text = this.OldName;
            }
        }
    }
}
