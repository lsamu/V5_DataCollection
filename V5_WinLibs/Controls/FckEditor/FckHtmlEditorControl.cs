using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using mshtml;
using System.ComponentModel;
using System.IO;
namespace V5.DataPublish.Controls {
    public class FckHtmlEditorControl : UserControl {
        private IContainer components = null;
        private WebBrowser webBrowser1;

        public event EventHandler OnEditorInitialized;

        public event EventHandler OnTextChanged;

        public FckHtmlEditorControl() {
            this.InitializeComponent();
            try {
                InitEditor();
            }
            catch (Exception) {
            }

        }

        protected override void Dispose(bool disposing) {
            if (disposing && (this.components != null)) {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void InitEditor() {
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Url = new Uri(this.EditorPath);
        }

        private void InitializeComponent() {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(384, 232);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowser1_PreviewKeyDown);
            this.Controls.Add(this.webBrowser1);
            this.Name = "FckHtmlEditorControl";
            this.Size = new System.Drawing.Size(384, 232);
            this.ResumeLayout(false);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            if (e.Url.OriginalString.EndsWith("editor.html") && (this.OnEditorInitialized != null)) {
                this.OnEditorInitialized(sender, e);
            }
        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (this.OnTextChanged != null) {
                this.OnTextChanged(sender, e);
            }
        }
        /// <summary>
        /// 编辑器地址
        /// </summary>
        public string EditorPath {
            get { return Path.GetDirectoryName(Application.ExecutablePath) + @"\data\browser\editor\fckeditor\editor.html"; }
        }
        /// <summary>
        /// 获取 设置 FckEditor的值
        /// </summary>
        public string InnerHtml {
            get {
                try {
                    ((IHTMLWindow2)this.webBrowser1.Document.Window.DomWindow).execScript("getFCKValue();", "javascript");
                    return this.webBrowser1.Document.GetElementById("hf_editor").GetAttribute("Value");
                }
                catch {
                    return "";
                }
            }
            set {
                try {
                    this.webBrowser1.Document.GetElementById("FCKeditor1").SetAttribute("value", value);
                    this.webBrowser1.Document.Window.Frames[0].Document.Window.Frames[0].Document.Body.InnerHtml = value;
                }
                catch {
                }
            }
        }

    }
}
