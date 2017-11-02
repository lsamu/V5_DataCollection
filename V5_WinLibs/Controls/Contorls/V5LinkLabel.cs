using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_WinControls {
    public partial class V5LinkLabel : LinkLabel {

        V5RichTextBox _RichTextBox = new V5RichTextBox();

        public V5RichTextBox RichTextBox {
            get { return _RichTextBox; }
            set { _RichTextBox = value; }
        }


        string _LabelValue = string.Empty;

        public string LabelValue {
            get { return _LabelValue; }
            set { _LabelValue = value; }
        }
        public V5LinkLabel() {
            InitializeComponent();
        }

        public V5LinkLabel(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }
        private ToolTip _V5ToolTipControl = new ToolTip();
        protected override void OnMouseClick(MouseEventArgs e) {
            string s = LabelValue;
            int startPos = this.RichTextBox.SelectionStart;
            int l = this.RichTextBox.SelectionLength;

            this.RichTextBox.Text = this.RichTextBox.Text.Substring(0, startPos) + s + this.RichTextBox.Text.Substring(startPos + l, this.RichTextBox.Text.Length - startPos - l);

            this.RichTextBox.SelectionStart = startPos + s.Length;
            this.RichTextBox.ScrollToCaret();
            base.OnMouseClick(e);
        }

        protected override void OnMouseHover(EventArgs e) {
            this._V5ToolTipControl.SetToolTip(this, "×¢ÒâÁ½±ß¿Õ¸ñ!");
            base.OnMouseHover(e);
        }
    }
}
