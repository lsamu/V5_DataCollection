using System;
using System.Windows.Forms;

namespace V5_DataCollection
{
    public partial class frmSplashForm : Form {

        public bool IsShow { get; set; }

        public frmSplashForm() {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) {
            this.IsShow = true;
            this.Close();
            this.Dispose();
        }
    }
}
