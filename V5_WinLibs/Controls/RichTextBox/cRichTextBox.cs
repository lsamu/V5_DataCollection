using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_WinControls {
    public partial class cRichTextBox : Panel {
        public cRichTextBox() {
            InitializeComponent();
        }

        public cRichTextBox(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }
    }
}
