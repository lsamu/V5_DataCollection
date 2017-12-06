namespace V5.DataWebBrowser
{
    partial class frmMainBrowser
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainBrowser));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtUrl = new System.Windows.Forms.ComboBox();
            this.butUrl = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.WebBrowserTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSource = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBack = new System.Windows.Forms.ToolStripButton();
            this.toolNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolHome = new System.Windows.Forms.ToolStripButton();
            this.toolSource = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOkExit = new System.Windows.Forms.ToolStripButton();
            this.toolCancleExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.WebBrowserTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtUrl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.butUrl);
            this.splitContainer1.Size = new System.Drawing.Size(992, 22);
            this.splitContainer1.SplitterDistance = 936;
            this.splitContainer1.TabIndex = 11;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.FormattingEnabled = true;
            this.txtUrl.Location = new System.Drawing.Point(0, 0);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(936, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // butUrl
            // 
            this.butUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUrl.Image = ((System.Drawing.Image)(resources.GetObject("butUrl.Image")));
            this.butUrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUrl.Location = new System.Drawing.Point(0, 0);
            this.butUrl.Name = "butUrl";
            this.butUrl.Size = new System.Drawing.Size(52, 22);
            this.butUrl.TabIndex = 2;
            this.butUrl.Text = "转到";
            this.butUrl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.butUrl.UseVisualStyleBackColor = true;
            this.butUrl.Click += new System.EventHandler(this.butUrl_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 72);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.WebBrowserTab);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(992, 504);
            this.splitContainer2.SplitterDistance = 351;
            this.splitContainer2.TabIndex = 12;
            // 
            // WebBrowserTab
            // 
            this.WebBrowserTab.Controls.Add(this.tabPage3);
            this.WebBrowserTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserTab.Location = new System.Drawing.Point(0, 0);
            this.WebBrowserTab.Name = "WebBrowserTab";
            this.WebBrowserTab.SelectedIndex = 0;
            this.WebBrowserTab.Size = new System.Drawing.Size(992, 351);
            this.WebBrowserTab.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(984, 325);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "blank";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 149);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 123);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cookie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(978, 117);
            this.textBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 123);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "POST数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(978, 117);
            this.textBox2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBack,
            this.menuNext,
            this.toolStripSeparator3,
            this.menuSource,
            this.toolStripSeparator4,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(58, 21);
            this.menuFile.Text = "文件(&F)";
            // 
            // menuBack
            // 
            this.menuBack.Enabled = false;
            this.menuBack.Name = "menuBack";
            this.menuBack.Size = new System.Drawing.Size(127, 22);
            this.menuBack.Text = "后退(&B)";
            this.menuBack.Click += new System.EventHandler(this.menuBack_Click);
            // 
            // menuNext
            // 
            this.menuNext.Enabled = false;
            this.menuNext.Name = "menuNext";
            this.menuNext.Size = new System.Drawing.Size(127, 22);
            this.menuNext.Text = "前进(&F)";
            this.menuNext.Click += new System.EventHandler(this.menuNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(124, 6);
            // 
            // menuSource
            // 
            this.menuSource.Name = "menuSource";
            this.menuSource.Size = new System.Drawing.Size(127, 22);
            this.menuSource.Text = "源文件(&S)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(124, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(127, 22);
            this.menuExit.Text = "退出(&E)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(116, 22);
            this.menuAbout.Text = "关于(&A)";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBack,
            this.toolNext,
            this.toolStripSeparator1,
            this.toolHome,
            this.toolSource,
            this.toolStripSeparator2,
            this.toolOkExit,
            this.toolCancleExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBack
            // 
            this.toolBack.Enabled = false;
            this.toolBack.Image = ((System.Drawing.Image)(resources.GetObject("toolBack.Image")));
            this.toolBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBack.Name = "toolBack";
            this.toolBack.Size = new System.Drawing.Size(52, 22);
            this.toolBack.Text = "后退";
            this.toolBack.Click += new System.EventHandler(this.toolBack_Click);
            // 
            // toolNext
            // 
            this.toolNext.Enabled = false;
            this.toolNext.Image = ((System.Drawing.Image)(resources.GetObject("toolNext.Image")));
            this.toolNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNext.Name = "toolNext";
            this.toolNext.Size = new System.Drawing.Size(52, 22);
            this.toolNext.Text = "前进";
            this.toolNext.Click += new System.EventHandler(this.toolNext_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolHome
            // 
            this.toolHome.Image = ((System.Drawing.Image)(resources.GetObject("toolHome.Image")));
            this.toolHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHome.Name = "toolHome";
            this.toolHome.Size = new System.Drawing.Size(52, 22);
            this.toolHome.Text = "主页";
            this.toolHome.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // toolSource
            // 
            this.toolSource.Enabled = false;
            this.toolSource.Image = ((System.Drawing.Image)(resources.GetObject("toolSource.Image")));
            this.toolSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSource.Name = "toolSource";
            this.toolSource.Size = new System.Drawing.Size(64, 22);
            this.toolSource.Text = "源文件";
            this.toolSource.Click += new System.EventHandler(this.toolSource_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolOkExit
            // 
            this.toolOkExit.Image = ((System.Drawing.Image)(resources.GetObject("toolOkExit.Image")));
            this.toolOkExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOkExit.Name = "toolOkExit";
            this.toolOkExit.Size = new System.Drawing.Size(76, 22);
            this.toolOkExit.Text = "确定退出";
            this.toolOkExit.Click += new System.EventHandler(this.toolOkExit_Click);
            // 
            // toolCancleExit
            // 
            this.toolCancleExit.Image = ((System.Drawing.Image)(resources.GetObject("toolCancleExit.Image")));
            this.toolCancleExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancleExit.Name = "toolCancleExit";
            this.toolCancleExit.Size = new System.Drawing.Size(76, 22);
            this.toolCancleExit.Text = "取消退出";
            this.toolCancleExit.Click += new System.EventHandler(this.toolCancleExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(945, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // frmMainBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 598);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMainBrowser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "浏览器";
            this.Load += new System.EventHandler(this.frmWeblink_Load);
            this.Resize += new System.EventHandler(this.frmWeblink_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.WebBrowserTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ComboBox txtUrl;
        private System.Windows.Forms.Button butUrl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl WebBrowserTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripButton toolBack;
        private System.Windows.Forms.ToolStripButton toolNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolOkExit;
        private System.Windows.Forms.ToolStripButton toolCancleExit;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem menuBack;
        private System.Windows.Forms.ToolStripMenuItem menuNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuExit;


    }
}