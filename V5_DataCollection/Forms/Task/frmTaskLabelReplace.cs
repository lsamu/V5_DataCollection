using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataCollection.Forms.Task {
    public partial class frmTaskLabelReplace : BaseForm {
        public delegate void TaskLabelReplace(int ItemIndex, string oldStr, string newStr, string OpType);
        public TaskLabelReplace TLR;
        private string m_OpType = "add";
        private int _itemIndex = -1;

        public int ItemIndex {
            get { return _itemIndex; }
            set { _itemIndex = value; }
        }
        private string _oldStr = string.Empty;

        public string OldStr {
            get { return _oldStr; }
            set { _oldStr = value; }
        }
        private string _newStr = string.Empty;

        public string NewStr {
            get { return _newStr; }
            set { _newStr = value; }
        }
        public frmTaskLabelReplace() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (this.txtOldReplaceStr.Text.Trim() != "") {
                if (TLR != null) {
                    TLR(this.ItemIndex, this.txtOldReplaceStr.Text, this.txtNewReplaceStr.Text, m_OpType);
                }
            }
            this.Hide();
            this.Close();
        }

        private void frmTaskLabelReplace_Load(object sender, EventArgs e) {
            if (this.OldStr.Trim() != "") {
                this.txtOldReplaceStr.Text = this.OldStr;
                this.txtNewReplaceStr.Text = this.NewStr;
                m_OpType = "edit";
            }
        }
    }
}
