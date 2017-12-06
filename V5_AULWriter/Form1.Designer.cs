namespace AULWriter
{
    partial class frmAULWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAULWriter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prbProd = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProduce = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpBase = new System.Windows.Forms.TabPage();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExpt = new System.Windows.Forms.Button();
            this.txtExpt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDest = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSrc = new System.Windows.Forms.Button();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpOpt = new System.Windows.Forms.TabPage();
            this.ofdSrc = new System.Windows.Forms.OpenFileDialog();
            this.sfdDest = new System.Windows.Forms.SaveFileDialog();
            this.ofdExpt = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "AutoUpdaterList Writer";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prbProd);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnProduce);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 40);
            this.panel2.TabIndex = 1;
            // 
            // prbProd
            // 
            this.prbProd.Location = new System.Drawing.Point(7, 5);
            this.prbProd.Name = "prbProd";
            this.prbProd.Size = new System.Drawing.Size(258, 23);
            this.prbProd.TabIndex = 2;
            this.prbProd.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(352, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出(&X)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProduce
            // 
            this.btnProduce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduce.Location = new System.Drawing.Point(271, 6);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(75, 23);
            this.btnProduce.TabIndex = 0;
            this.btnProduce.Text = "生成(&G)";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpBase);
            this.tabControl1.Controls.Add(this.tbpOpt);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpBase
            // 
            this.tbpBase.Controls.Add(this.txtUrl);
            this.tbpBase.Controls.Add(this.label5);
            this.tbpBase.Controls.Add(this.btnExpt);
            this.tbpBase.Controls.Add(this.txtExpt);
            this.tbpBase.Controls.Add(this.label4);
            this.tbpBase.Controls.Add(this.btnDest);
            this.tbpBase.Controls.Add(this.txtDest);
            this.tbpBase.Controls.Add(this.label3);
            this.tbpBase.Controls.Add(this.btnSrc);
            this.tbpBase.Controls.Add(this.txtSrc);
            this.tbpBase.Controls.Add(this.label2);
            this.tbpBase.Location = new System.Drawing.Point(4, 22);
            this.tbpBase.Name = "tbpBase";
            this.tbpBase.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBase.Size = new System.Drawing.Size(420, 222);
            this.tbpBase.TabIndex = 0;
            this.tbpBase.Text = "※基本信息";
            this.tbpBase.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(70, 38);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(277, 21);
            this.txtUrl.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "更新网址:";
            // 
            // btnExpt
            // 
            this.btnExpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpt.Location = new System.Drawing.Point(353, 162);
            this.btnExpt.Name = "btnExpt";
            this.btnExpt.Size = new System.Drawing.Size(58, 21);
            this.btnExpt.TabIndex = 8;
            this.btnExpt.Text = "选择(&S)";
            this.btnExpt.UseVisualStyleBackColor = true;
            this.btnExpt.Click += new System.EventHandler(this.btnSearExpt_Click);
            // 
            // txtExpt
            // 
            this.txtExpt.Location = new System.Drawing.Point(70, 64);
            this.txtExpt.Multiline = true;
            this.txtExpt.Name = "txtExpt";
            this.txtExpt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExpt.Size = new System.Drawing.Size(277, 119);
            this.txtExpt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "排除文件:";
            // 
            // btnDest
            // 
            this.btnDest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDest.Location = new System.Drawing.Point(353, 189);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(58, 21);
            this.btnDest.TabIndex = 5;
            this.btnDest.Text = "选择(&S)";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnSearDes_Click);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(70, 189);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(277, 21);
            this.txtDest.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "保存位置:";
            // 
            // btnSrc
            // 
            this.btnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSrc.Location = new System.Drawing.Point(353, 12);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(58, 21);
            this.btnSrc.TabIndex = 2;
            this.btnSrc.Text = "选择(&S)";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(70, 13);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(277, 21);
            this.txtSrc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "主程序:";
            // 
            // tbpOpt
            // 
            this.tbpOpt.Location = new System.Drawing.Point(4, 22);
            this.tbpOpt.Name = "tbpOpt";
            this.tbpOpt.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOpt.Size = new System.Drawing.Size(428, 227);
            this.tbpOpt.TabIndex = 1;
            this.tbpOpt.Text = "※选项";
            this.tbpOpt.UseVisualStyleBackColor = true;
            // 
            // ofdSrc
            // 
            this.ofdSrc.DefaultExt = "*.exe";
            this.ofdSrc.Filter = "程序文件(*.exe)|*.exe|所有文件(*.*)|*.*";
            this.ofdSrc.Title = "请选择主程序文件";
            this.ofdSrc.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdDest_FileOk);
            // 
            // sfdDest
            // 
            this.sfdDest.CheckPathExists = false;
            this.sfdDest.DefaultExt = "*.xml";
            this.sfdDest.FileName = "AutoUpdaterList.xml";
            this.sfdDest.Filter = "XML文件(*.xml)|*.xml";
            this.sfdDest.Title = "请选择AutoUpdaterList保存位置";
            this.sfdDest.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSrcPath_FileOk);
            // 
            // ofdExpt
            // 
            this.ofdExpt.DefaultExt = "*.*";
            this.ofdExpt.Filter = "所有文件(*.*)|*.*";
            this.ofdExpt.Multiselect = true;
            this.ofdExpt.Title = "请选择主程序文件";
            this.ofdExpt.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdExpt_FileOk);
            // 
            // frmAULWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 400);
            this.MinimizeBox = false;
            this.Name = "frmAULWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AULWriter for AutoUpdater";
            this.Load += new System.EventHandler(this.frmAULWriter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpBase.ResumeLayout(false);
            this.tbpBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdSrc;
        private System.Windows.Forms.SaveFileDialog sfdDest;
        private System.Windows.Forms.TextBox txtExpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExpt;
        private System.Windows.Forms.OpenFileDialog ofdExpt;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbpOpt;
        private System.Windows.Forms.ProgressBar prbProd;
    }
}

