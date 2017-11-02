using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Threading;

namespace AULWriter
{
    public partial class frmAULWriter : Form
    {

        #region [基本入口构造函数]

        public frmAULWriter()
        {
            InitializeComponent();
        }

        #endregion [基本入口构造函数]

        #region [关闭写程序界面]

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        #endregion [关闭写程序界面]

        #region [选择文件保存路径]

        private void btnSearDes_Click(object sender, EventArgs e)
        {
            this.sfdDest.ShowDialog(this);
        }       

        private void sfdSrcPath_FileOk(object sender, CancelEventArgs e)
        {
            this.txtDest.Text = this.sfdDest.FileName.Substring(0,this.sfdDest.FileName.LastIndexOf(@"\"))+@"\AutoUpdaterList.xml";
        }

        #endregion [选择文件保存路径]
      
        #region [选择排除文件]

        private void btnSearExpt_Click(object sender, EventArgs e)
        {
            this.ofdExpt.ShowDialog(this);
        }

        private void ofdExpt_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string _filePath in this.ofdExpt.FileNames)
            {
                this.txtExpt.Text += @_filePath.ToString() + "\n\r;";
            }
        }

        #endregion [选择排除文件]

        #region [选择主程序]

        private void btnSrc_Click(object sender, EventArgs e)
        {
            this.ofdSrc.ShowDialog(this);
        }

        private void ofdDest_FileOk(object sender, CancelEventArgs e)
        {
            this.txtSrc.Text = this.ofdSrc.FileName;
        }

        #endregion [选择主程序]

        #region [主窗体加载]

        private void frmAULWriter_Load(object sender, EventArgs e)
        {
            
        }

        #endregion [主窗体加载]

        #region [生成文件]

        private void btnProduce_Click(object sender, EventArgs e)
        {
            Thread thrdProduce = new Thread(new ThreadStart(WriterAUList));

            if (this.btnProduce.Text == "生成(&G)")
            {

                #region [检测基本条件]

                if (!File.Exists(this.txtSrc.Text))
                {
                    MessageBox.Show(this, "请选择主入口程序!", "AutoUpdater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnSrc_Click(sender, e);
                }

                #region [请输入自动更新网址]

                if (this.txtUrl.Text.Trim().Length == 0)
                {
                    MessageBox.Show(this, "请输入自动更新网址!", "AutoUpdater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUrl.Focus();

                    return;
                }


                #endregion [请输入自动更新网址]

                if (this.txtDest.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(this, "请选择AutoUpdaterList保存位置!", "AutoUpdater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnSearDes_Click(sender, e);
                }

                #endregion [检测基本条件]

                #region [新线程写文件]

                thrdProduce.IsBackground = true;
                thrdProduce.Start();

                #endregion [新线程写文件]

                this.btnProduce.Text = "停止(&S)";
            }
            else
            {
                Application.DoEvents();
                if (MessageBox.Show(this, "是否停止文件生成更新文件?", "AutoUpdater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (thrdProduce.IsAlive)
                    {
                        thrdProduce.Abort();
                        thrdProduce.Join();
                    }
                    this.btnProduce.Text = "生成(&G)";
                }
            }
        }

        #region [写AutoUpdaterList]

        void WriterAUList()
        {
            #region [写AutoUpdaterlist]

            string strEntryPoint = this.txtSrc.Text.Trim().Substring(this.txtSrc.Text.Trim().LastIndexOf(@"\") + 1, this.txtSrc.Text.Trim().Length - this.txtSrc.Text.Trim().LastIndexOf(@"\") - 1);
            string strFilePath = this.txtDest.Text.Trim();

            FileStream fs = new FileStream(strFilePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            sw.Write("<?xml version=\"1.0\" encoding=\"gb2312\" ?>");
            sw.Write("\r\n<AutoUpdater>\r\n");

            #region[description]

            sw.Write("\t<Description>");
            sw.Write(strEntryPoint.Substring(0, strEntryPoint.LastIndexOf(".")) + " autoUpdate");
            sw.Write("</Description>\r\n");

            #endregion[description]

            #region [Updater]

            sw.Write("\t<Updater>\r\n");

            sw.Write("\t\t<Url>");
            sw.Write(this.txtUrl.Text.Trim());
            sw.Write("</Url>\r\n");

            sw.Write("\t\t<LastUpdateTime>");
            sw.Write(DateTime.Now.AddDays(-15).ToString("yyyy-MM-dd"));
            sw.Write("</LastUpdateTime>\r\n");

            sw.Write("\t</Updater>\r\n");

            #endregion [Updater]

            #region [application]

            sw.Write("\t<Application applicationId = \"" + strEntryPoint.Substring(0, strEntryPoint.LastIndexOf(".")) + "\">\r\n");

            sw.Write("\t\t<EntryPoint>");
            sw.Write(strEntryPoint);
            sw.Write("</EntryPoint>\r\n");

            sw.Write("\t\t<Location>");
            sw.Write(".");
            sw.Write("</Location>\r\n");

            FileVersionInfo _lcObjFVI = FileVersionInfo.GetVersionInfo(this.txtSrc.Text);

            sw.Write("\t\t<Version>");
            sw.Write(string.Format("{0}.{1}.{2}.{3}", _lcObjFVI.FileMajorPart, _lcObjFVI.FileMinorPart, _lcObjFVI.FileBuildPart, _lcObjFVI.FilePrivatePart));
            sw.Write("</Version>\r\n");


            sw.Write("\t</Application>\r\n");


            #endregion [application]

            #region [Files]

            sw.Write("\t<Files>\r\n");

            StringCollection strColl = GetAllFiles(this.txtSrc.Text.Substring(0, this.txtSrc.Text.LastIndexOf(@"\")));
            this.prbProd.Visible = true;
            this.prbProd.Minimum = 0;
            this.prbProd.Maximum = strColl.Count;

            for (int i = 0; i < strColl.Count; i++)
            {
                if (!CheckExist(strColl[i].Trim()))
                {

                    FileVersionInfo m_lcObjFVI = FileVersionInfo.GetVersionInfo(strColl[i].ToString());

                    string rootDir = this.txtSrc.Text.Substring(0, this.txtSrc.Text.LastIndexOf(@"\")) + @"\";

                    sw.Write("\t\t<File Ver=\""
                        + string.Format("{0}.{1}.{2}.{3}", _lcObjFVI.FileMajorPart, _lcObjFVI.FileMinorPart, _lcObjFVI.FileBuildPart, _lcObjFVI.FilePrivatePart)
                        + "\" Name= \"" + @strColl[i].Replace(@rootDir, "")
                        + "\" />\r\n");
                }

                prbProd.Value = i;
            }
            #endregion [Files]

            sw.Write("\t</Files>\r\n");

            sw.Write("</AutoUpdater>");
            sw.Close();
            fs.Close();


            #region [Notification]

            MessageBox.Show(this, "自动更新文件生成成功:" + this.txtDest.Text.Trim(), "AutoUpdater", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.prbProd.Value = 0;
            this.prbProd.Visible = false;

            #endregion [Notification]

            #endregion [写AutoUpdaterlist]
        }

        #endregion [写AutoUpdaterList]

        #region [遍历子目录]

        private StringCollection GetAllFiles(string rootdir)
        {
            StringCollection result = new StringCollection();
            GetAllFiles(rootdir, result);
            return result;
        }

        private void GetAllFiles(string parentDir, StringCollection result)
        {
            string[] dir = Directory.GetDirectories(parentDir);
            for (int i = 0; i < dir.Length; i++)
                GetAllFiles(dir[i], result);
            string[] file = Directory.GetFiles(parentDir);
            for (int i = 0; i < file.Length; i++)
                result.Add(file[i]);
        }

        #endregion [遍历子目录]

        #region [排除不需要的文件]

        private bool CheckExist(string filePath)
        {
            bool isExist = false;

            foreach (string strCheck in this.txtExpt.Text.Split(';'))
            {
                if (filePath.Trim() == strCheck.Trim())
                {
                    isExist = true;

                    break;
                }
            }

            return isExist;
        }

        #endregion [排除不需要的文件]

        #endregion [生成文件]


    }
}