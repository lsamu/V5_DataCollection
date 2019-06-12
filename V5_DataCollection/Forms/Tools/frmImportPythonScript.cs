using System;

namespace V5_DataCollection.Forms.Tools
{
    public partial class frmImportPythonScript : BaseForm {
        public frmImportPythonScript() {
            InitializeComponent();

            this.cmbScriptType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.CloseForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            this.CloseForm();
        }
    }
}
