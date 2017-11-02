using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V5_DataPublish {
    public partial class frmSplash : V5_DataPublish.BaseForm {
        public bool IsShow { get; set; }
        public frmSplash() {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) {
            this.IsShow = true;
            this.Close();
            this.Dispose();
        }
    }
}
