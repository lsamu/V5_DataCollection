using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataPublish {
    public class BaseForm : Form {

        public frmLoadingDialog loadingDialog = null;
        public BaseForm() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(457, 295);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V5վȺϵͳ";
            this.ResumeLayout(false);

        }
    }
}
