using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using SHDocVw;
using System.Runtime.InteropServices;
using mshtml;

public struct OLECMDTEXT {
    public uint cmdtextf;
    public uint cwActual;
    public uint cwBuf;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
    public char rgwz;
}

[StructLayout(LayoutKind.Sequential)]
public struct OLECMD {
    public uint cmdID;
    public uint cmdf;
}

[ComImport,
Guid("b722bccb-4e68-101b-a2bc-00aa00404770"),
InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IOleCommandTarget {
    void QueryStatus(ref Guid pguidCmdGroup, UInt32 cCmds,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] OLECMD[] prgCmds, ref OLECMDTEXT CmdText);
    void Exec(ref Guid pguidCmdGroup, uint nCmdId, uint nCmdExecOpt, ref object pvaIn, ref object pvaOut);
}

namespace V5.DataWebBrowser {
    public partial class frmMainBrowser : Form {
        private bool IsInvoke = false;
        public delegate void ReturnCookie(string Cookie);
        public ReturnCookie rCookie;

        public delegate void ReturnExportCookie(string Cookie);
        public ReturnExportCookie rExportCookie;

        public delegate void ReturnPOST(string cookie, string pData);
        public ReturnPOST rPData;

        public delegate void ReturnExportPOST(string cookie, string pData);
        public ReturnExportPOST rExportPData;

        ///如果为
        /// 0-返回采集数据的cookie（运行时采集和任务填写cookie时采集），
        ///1-返回采集数据post数据，
        ///2-返回导出数据的cookie，
        ///3-返回导出数据的post数据，
        ///4-正常的浏览器
        private int m_GetFlag = 4;

        private Guid cmdGuid = new Guid("ED016940-BD5B-11CF-BA4E-00C04FD70816");
        private enum MiscCommandTarget { Find = 1, ViewSource, Options }

        public int getFlag {
            get { return m_GetFlag; }
            set { m_GetFlag = value; }
        }

        public frmMainBrowser() {
            InitializeComponent();
        }

        public frmMainBrowser(string Url) {
            InitializeComponent();

            this.txtUrl.Text = Url;

        }

        private void wb_NavigateComplete2(object pDisp, ref object URL) {

            Cursor.Current = Cursors.Default;
            toolStripProgressBar1.Value = 0;

            this.txtUrl.Text = ((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).Url.ToString();
            this.textBox1.Text = ((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).Document.Cookie.ToString();
        }

        private void frmWeblink_Resize(object sender, EventArgs e) {
            this.txtUrl.Width = this.Width - this.txtUrl.Left - this.butUrl.Width - 50;
            this.butUrl.Left = this.txtUrl.Left + this.txtUrl.Width;
        }

        private void frmWeblink_Load(object sender, EventArgs e) {

            this.splitContainer2.SplitterDistance = this.splitContainer2.Height - 100;

            switch (this.getFlag) {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    this.toolCancleExit.Text = "关闭";
                    break;
                default:
                    break;
            }

            if (this.txtUrl.Text.Trim() != "" || this.txtUrl.Text != null) {
                GoUrl();
            }
        }

        private void wb_NewWindow2(ref object ppDisp, ref bool Cancel) {
            SHDocVw.WebBrowser _axWebBrowser = CreateNewWebBrowser();
            ppDisp = _axWebBrowser.Application;
            _axWebBrowser.RegisterAsBrowser = true;
        }

        private void wb_BeforeNavigate2(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel) {
            this.textBox2.Text = System.Text.Encoding.ASCII.GetString(PostData as byte[]);

            this.textBox1.Text = ((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).Document.Cookie.ToString();
        }

        private void toolSource_Click(object sender, EventArgs e) {
            IOleCommandTarget cmdt;
            Object o = new object();
            try {
                cmdt = (IOleCommandTarget)GetDocument();
                cmdt.Exec(ref cmdGuid, (uint)MiscCommandTarget.ViewSource,
                    (uint)SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref o, ref o);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private HTMLDocument GetDocument() {
            try {
                SHDocVw.WebBrowser wb = (SHDocVw.WebBrowser)((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).ActiveXInstance;

                HTMLDocument htm = (HTMLDocument)wb.Document;
                return htm;
            }
            catch (System.Exception ex) {
                throw (ex);
            }

        }


        private void GoUrl() {
            string url = this.txtUrl.Text;

            SHDocVw.WebBrowser wb = CreateNewWebBrowser();


            if (url == "")
                return;

            try {
                Cursor.Current = Cursors.WaitCursor;
                Object o = null;
                wb.Navigate(url, ref o, ref o, ref o, ref o);
            }
            finally {
                int i = this.txtUrl.Items.IndexOf(url);
                if (i == -1)
                    this.txtUrl.Items.Add(url);

                Cursor.Current = Cursors.Default;
            }
        }

        private void wb_DocumentComplete(object pDisp, ref object URL) {
            SHDocVw.WebBrowser wb = (SHDocVw.WebBrowser)((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).ActiveXInstance;

            if (wb.ReadyState == SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE) {

                this.txtUrl.Text = wb.LocationURL;


                this.toolStripProgressBar1.Value = 0;
                this.toolStripProgressBar1.Visible = false;

            }

            this.textBox1.Text = ((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).Document.Cookie.ToString();

        }

        private void wb_ProgressChange(int Progress, int ProgressMax) {
            this.toolStripProgressBar1.Visible = true;

            SHDocVw.WebBrowser wb = (SHDocVw.WebBrowser)((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).ActiveXInstance;

            if ((Progress > 0) && (ProgressMax > 0)) {
                this.toolStripProgressBar1.Maximum = ProgressMax;
                this.toolStripProgressBar1.Step = Progress;
                this.toolStripProgressBar1.PerformStep();
            }
            else if (wb.ReadyState == SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE) {
                this.toolStripProgressBar1.Value = 0;
                this.toolStripProgressBar1.Visible = false;
            }
        }

        private void wb_StatusTextChange(string Text) {
            this.toolStripStatusLabel1.Text = Text;
        }

        private SHDocVw.WebBrowser CreateNewWebBrowser() {
            this.toolSource.Enabled = true;

            System.Windows.Forms.WebBrowser TmpWebBrowser = new System.Windows.Forms.WebBrowser();

            if (this.WebBrowserTab.TabPages.Count == 1 && this.WebBrowserTab.TabPages[0].Controls.Count == 0) {
                this.WebBrowserTab.TabPages[0].Controls.Add(TmpWebBrowser);

            }
            else {

                this.WebBrowserTab.TabPages[0].Controls.Clear();

                this.WebBrowserTab.TabPages[0].Controls.Add(TmpWebBrowser);

            }
            TmpWebBrowser.Dock = DockStyle.Fill;

            SHDocVw.WebBrowser wb = (SHDocVw.WebBrowser)TmpWebBrowser.ActiveXInstance;

            wb.CommandStateChange += new SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler(this.wb_CommandStateChange);
            wb.BeforeNavigate2 += new SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler(this.wb_BeforeNavigate2);
            wb.ProgressChange += new SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler(this.wb_ProgressChange);
            wb.StatusTextChange += new SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler(this.wb_StatusTextChange);
            wb.NavigateError += new SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler(this.wb_NavigateError);
            wb.NavigateComplete2 += new SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler(this.wb_NavigateComplete2);
            wb.TitleChange += new SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler(this.wb_TitleChange);
            wb.DocumentComplete += new SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.wb_DocumentComplete);
            wb.NewWindow2 += new SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler(this.wb_NewWindow2);

            return wb;
        }

        private void wb_CommandStateChange(int Command, bool Enable) {
            switch (Command) {
                case ((int)CommandStateChangeConstants.CSC_NAVIGATEFORWARD):
                    this.toolNext.Enabled = Enable;
                    this.menuNext.Enabled = Enable;
                    break;

                case ((int)CommandStateChangeConstants.CSC_NAVIGATEBACK):
                    this.toolBack.Enabled = Enable;
                    this.menuBack.Enabled = Enable;
                    break;

                default:
                    break;
            }
        }

        private void wb_NavigateError(object pDisp, ref object URL, ref object Frame, ref object StatusCode, ref bool Cancel) {
        }

        private void butUrl_Click(object sender, EventArgs e) {
            GoUrl();
        }

        private void wb_TitleChange(string Text) {
            this.WebBrowserTab.TabPages[0].Text = Text;
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                GoUrl();
            }
        }

        private void OkExit() {
            switch (this.getFlag) {
                case 0:
                    if (rCookie != null) {
                        rCookie(this.textBox1.Text);
                    }
                    break;
                case 1:
                    if (rPData != null) {
                        rPData(this.textBox1.Text, this.textBox2.Text);
                    }
                    break;
                case 2:
                    if (rExportCookie != null) {
                        rExportCookie(this.textBox1.Text);
                    }
                    break;
                case 3:
                    if (rExportPData != null) {
                        rExportPData(this.textBox1.Text, this.textBox2.Text);
                    }
                    break;
                case 4:
                    break;
                default:
                    break;
            }


            this.DialogResult = DialogResult.OK;
        }

        private void menuAbout_Click(object sender, EventArgs e) {
        }

        private void menuExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        private void toolCancleExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        private void toolHome_Click(object sender, EventArgs e) {
            this.txtUrl.Text = "http://www.v5soft.com";
            GoUrl();
        }

        private void toolOkExit_Click(object sender, EventArgs e) {
            Console.Write(this.textBox1.Text);
            System.Environment.Exit(-1);
        }

        private void toolBack_Click(object sender, EventArgs e) {
            ((SHDocVw.WebBrowser)((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).ActiveXInstance).GoBack();
        }

        private void menuBack_Click(object sender, EventArgs e) {
            ((SHDocVw.WebBrowser)((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).ActiveXInstance).GoBack();
        }

        private void menuNext_Click(object sender, EventArgs e) {
            ((SHDocVw.WebBrowser)((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).ActiveXInstance).GoForward();
        }

        private void toolNext_Click(object sender, EventArgs e) {
            ((SHDocVw.WebBrowser)((System.Windows.Forms.WebBrowser)this.WebBrowserTab.TabPages[0].Controls[0]).ActiveXInstance).GoForward();
        }

    }

}