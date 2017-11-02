using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_WinControls {
    public partial class V5ToolTip : Button {

        private string _Message = string.Empty;

        public string Message {
            get { return _Message; }
            set { _Message = value; }
        }

        private ToolTip _V5ToolTipControl = new ToolTip();

        public ToolTip V5ToolTipControl {
            get { return _V5ToolTipControl; }
            set { _V5ToolTipControl = value; }
        }

        public V5ToolTip() {
            InitializeComponent();
        }

        public V5ToolTip(IContainer container) {
            container.Add(this);
            InitializeComponent();
        }

        protected override void OnMouseHover(EventArgs e) {
            base.OnMouseHover(e);
        }

        protected override void OnMouseClick(MouseEventArgs e) {
            this.V5ToolTipControl.SetToolTip(this, this.Message);
            base.OnMouseClick(e);
        }
    }
}
