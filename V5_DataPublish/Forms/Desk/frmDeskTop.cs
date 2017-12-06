using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using V5_DataPublish._Class;
using V5_Utility.Core;
using V5_DataPublish.Forms.DiyWeb;
using ScrapySharp.Extensions;
using V5_WinLibs.Core;

namespace V5_DataPublish.Forms.Desk {
    public partial class frmDeskTop : Form {

        #region
        private bool blnMouseDown = false;
        private bool dbShow = false;
        private Point ptMouseCurrrnetPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private frmMain m_frmMain = null;
        #endregion

        public frmDeskTop(frmMain _frmMain) {
            m_frmMain = _frmMain;
            InitializeComponent();
        }


        /// <summary>
        /// 窗体加载
        /// </summary>
        private void frmDeskTop_Load(object sender, EventArgs e) {
            this.Show();
            this.Top = 100;
            this.Left = Screen.PrimaryScreen.Bounds.Width - 100;
            this.Width = 44;
            this.Height = 44;
        }

        /// <summary>
        /// 鼠标按下
        /// </summary>
        private void frmDeskTop_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                blnMouseDown = true;
                ptMouseCurrrnetPos = Control.MousePosition;
                ptFormPos = Location;
            }
        }

        /// <summary>
        /// 鼠标移动
        /// </summary>
        private void frmDeskTop_MouseMove(object sender, MouseEventArgs e) {
            if (blnMouseDown) {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrrnetPos.X + ptFormPos.X;
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrrnetPos.Y + ptFormPos.Y;
                Location = ptFormNewPos;
                ptFormPos = ptFormNewPos;
                ptMouseCurrrnetPos = ptMouseNewPos;
            }
        }


        /// <summary>
        /// 鼠标抬出
        /// </summary>
        private void frmDeskTop_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                blnMouseDown = false;
        }

        /// <summary>
        /// 拖动按入
        /// </summary>
        private void frmDeskTop_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Html) || e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }


        /// <summary>
        /// 拖动按入数据
        /// </summary>
        private void frmDeskTop_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Html)
                || e.Data.GetDataPresent(DataFormats.Text)) {
                object Item;
                MemoryStream vMemoryStream;
                string webTitle = "新标题";
                Item = e.Data.GetData(DataFormats.Html, true);
                bool htmlflag = false;
                if (Item == null) {
                    Item = e.Data.GetData(DataFormats.Text);
                    vMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(Item.ToString()));
                }
                else {
                    htmlflag = true;
                    vMemoryStream = e.Data.GetData("Html Format") as MemoryStream;
                }
                vMemoryStream.Position = 0;
                byte[] vBytes = new byte[vMemoryStream.Length];
                vMemoryStream.Read(vBytes, 0, (int)vMemoryStream.Length);
                string s1 = Encoding.UTF8.GetString(vBytes);
                string webContent = string.Empty;
                if (htmlflag) {
                    Regex regcontent = new Regex(@"<!--StartFragment-->([\s\S]*?)<!--EndFragment-->", RegexOptions.IgnoreCase);
                    webContent = regcontent.Match(s1).ToString();
                    webContent = StringHelper.Instance.Replace(webContent, "<!--StartFragment-->", "");
                    webContent = StringHelper.Instance.Replace(webContent, "<!--EndFragment-->", "");
                    try {
                        webTitle = Regex.Match(s1, "<title>.+?</title>", RegexOptions.IgnoreCase | RegexOptions.Multiline).ToString();
                        webTitle = StringHelper.Instance.Replace(webTitle, "<title>", "");
                        webTitle = StringHelper.Instance.Replace(webTitle, "</title>", "");
                        if (string.IsNullOrEmpty(webTitle)) {
                            Regex regUrl = new Regex(@"SourceURL:([\s\S]*?)\r\n", RegexOptions.IgnoreCase);
                            string webUrl = regUrl.Match(s1).ToString();
                            webUrl = StringHelper.Instance.Replace(webUrl, "SourceURL:", "");
                            webUrl = StringHelper.Instance.Replace(webUrl, "\r\n", "");

                            var http = new HttpHelper4();

                            var httpResult = http.GetHtml(new HttpItem() { 
                                URL = webUrl
                            });

                            var html = httpResult.Html;

                            var doc = new HtmlAgilityPack.HtmlDocument();
                            doc.LoadHtml(html);
                            var docNode = doc.DocumentNode;

                            webTitle = docNode.CssSelect("title").ToArray()[0].InnerText;
                        }
                    }
                    catch {
                        webTitle = "新标题";
                    }
                }
                else {
                    webContent = s1;
                }

                frmHandWebInsert ff = new frmHandWebInsert();
                ff.Title = webTitle;
                ff.Content = webContent;
                ff.Show();
            }
        }

        /// <summary>
        /// 双击
        /// </summary>
        private void frmDeskTop_DoubleClick(object sender, EventArgs e) {
            SwitchToMain();
        }

        /// <summary>
        /// 切换窗体
        /// </summary>
        private void SwitchToMain() {
            if (dbShow) {
                m_frmMain.RestoreWindow();
                dbShow = false;
            }
            else {
                m_frmMain.WindowState = FormWindowState.Minimized;
                dbShow = true;
            }
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e) {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 手动插入
        /// </summary>
        private void ToolStripMenuItem_HandInsert_Click(object sender, EventArgs e) {
            frmHandInsert HandInsert = new frmHandInsert();
            HandInsert.Show(this);
        }

        private void 手动插入自定义接口ToolStripMenuItem_Click(object sender, EventArgs e) {
            new frmHandWebInsert().Show(this);
        }
    }
}
