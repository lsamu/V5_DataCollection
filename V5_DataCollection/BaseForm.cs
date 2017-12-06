using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataCollection {
    public partial class BaseForm : Form {

        public BaseForm() {
            InitializeComponent();
        }

        public void CloseForm() {
            this.Hide();
            this.Opacity = 0;
            this.Visible = false;
            this.Close();
        }

    }
}
