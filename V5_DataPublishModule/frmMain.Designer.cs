namespace V5_DataPublishModuleEdit {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmbModuleList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestSiteUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestUserPwd = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResultView = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtHtmlView = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTestLogin = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbClassList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnTestClassListCreate = new System.Windows.Forms.Button();
            this.btnTestClassList = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmbViewClassList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTestContent = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnCreateHtmlGet = new System.Windows.Forms.Button();
            this.cmbCreateHtmlList = new System.Windows.Forms.ComboBox();
            this.btnCreateHtml = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTestSiteAdminUrl = new System.Windows.Forms.TextBox();
            this.btnSaveTestConfig = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker_TestModule = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbModuleList
            // 
            this.cmbModuleList.FormattingEnabled = true;
            this.cmbModuleList.Location = new System.Drawing.Point(87, 6);
            this.cmbModuleList.Name = "cmbModuleList";
            this.cmbModuleList.Size = new System.Drawing.Size(121, 20);
            this.cmbModuleList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "测试模块";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "测试网站";
            // 
            // txtTestSiteUrl
            // 
            this.txtTestSiteUrl.Location = new System.Drawing.Point(87, 39);
            this.txtTestSiteUrl.Name = "txtTestSiteUrl";
            this.txtTestSiteUrl.Size = new System.Drawing.Size(325, 21);
            this.txtTestSiteUrl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "账号";
            // 
            // txtTestUserName
            // 
            this.txtTestUserName.Location = new System.Drawing.Point(87, 97);
            this.txtTestUserName.Name = "txtTestUserName";
            this.txtTestUserName.Size = new System.Drawing.Size(173, 21);
            this.txtTestUserName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "密码";
            // 
            // txtTestUserPwd
            // 
            this.txtTestUserPwd.Location = new System.Drawing.Point(87, 124);
            this.txtTestUserPwd.Name = "txtTestUserPwd";
            this.txtTestUserPwd.PasswordChar = '*';
            this.txtTestUserPwd.Size = new System.Drawing.Size(173, 21);
            this.txtTestUserPwd.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 339);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 144);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResultView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 118);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "结果";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResultView
            // 
            this.txtResultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultView.Location = new System.Drawing.Point(3, 3);
            this.txtResultView.Multiline = true;
            this.txtResultView.Name = "txtResultView";
            this.txtResultView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultView.Size = new System.Drawing.Size(573, 112);
            this.txtResultView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtHtmlView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 118);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Html";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtHtmlView
            // 
            this.txtHtmlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHtmlView.Location = new System.Drawing.Point(3, 3);
            this.txtHtmlView.Multiline = true;
            this.txtHtmlView.Name = "txtHtmlView";
            this.txtHtmlView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHtmlView.Size = new System.Drawing.Size(573, 112);
            this.txtHtmlView.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(10, 156);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(587, 177);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnTestLogin);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(579, 151);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "登陆";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTestLogin
            // 
            this.btnTestLogin.Location = new System.Drawing.Point(206, 63);
            this.btnTestLogin.Name = "btnTestLogin";
            this.btnTestLogin.Size = new System.Drawing.Size(75, 23);
            this.btnTestLogin.TabIndex = 0;
            this.btnTestLogin.Text = "测试登陆";
            this.btnTestLogin.UseVisualStyleBackColor = true;
            this.btnTestLogin.Click += new System.EventHandler(this.btnTestLogin_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbClassList);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtClassName);
            this.tabPage4.Controls.Add(this.btnTestClassListCreate);
            this.tabPage4.Controls.Add(this.btnTestClassList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(579, 151);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "分类";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbClassList
            // 
            this.cmbClassList.FormattingEnabled = true;
            this.cmbClassList.Location = new System.Drawing.Point(73, 17);
            this.cmbClassList.Name = "cmbClassList";
            this.cmbClassList.Size = new System.Drawing.Size(134, 20);
            this.cmbClassList.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "分类列表";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "分类名称";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(73, 64);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(134, 21);
            this.txtClassName.TabIndex = 2;
            // 
            // btnTestClassListCreate
            // 
            this.btnTestClassListCreate.Location = new System.Drawing.Point(236, 64);
            this.btnTestClassListCreate.Name = "btnTestClassListCreate";
            this.btnTestClassListCreate.Size = new System.Drawing.Size(75, 23);
            this.btnTestClassListCreate.TabIndex = 1;
            this.btnTestClassListCreate.Text = "创建分类";
            this.btnTestClassListCreate.UseVisualStyleBackColor = true;
            this.btnTestClassListCreate.Click += new System.EventHandler(this.btnTestClassListCreate_Click);
            // 
            // btnTestClassList
            // 
            this.btnTestClassList.Location = new System.Drawing.Point(236, 14);
            this.btnTestClassList.Name = "btnTestClassList";
            this.btnTestClassList.Size = new System.Drawing.Size(75, 23);
            this.btnTestClassList.TabIndex = 0;
            this.btnTestClassList.Text = "获取分类";
            this.btnTestClassList.UseVisualStyleBackColor = true;
            this.btnTestClassList.Click += new System.EventHandler(this.btnTestClassList_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cmbViewClassList);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.txtContent);
            this.tabPage5.Controls.Add(this.txtTitle);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.btnTestContent);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(579, 151);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "内容";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cmbViewClassList
            // 
            this.cmbViewClassList.FormattingEnabled = true;
            this.cmbViewClassList.Location = new System.Drawing.Point(94, 42);
            this.cmbViewClassList.Name = "cmbViewClassList";
            this.cmbViewClassList.Size = new System.Drawing.Size(134, 20);
            this.cmbViewClassList.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "分类列表";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(94, 70);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(372, 69);
            this.txtContent.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(94, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 21);
            this.txtTitle.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "内容";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "标题";
            // 
            // btnTestContent
            // 
            this.btnTestContent.Location = new System.Drawing.Point(472, 116);
            this.btnTestContent.Name = "btnTestContent";
            this.btnTestContent.Size = new System.Drawing.Size(75, 23);
            this.btnTestContent.TabIndex = 0;
            this.btnTestContent.Text = "测试发布";
            this.btnTestContent.UseVisualStyleBackColor = true;
            this.btnTestContent.Click += new System.EventHandler(this.btnTestContent_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.comboBox1);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(579, 151);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "随机值";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(236, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "测试随机值";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnCreateHtmlGet);
            this.tabPage7.Controls.Add(this.cmbCreateHtmlList);
            this.tabPage7.Controls.Add(this.btnCreateHtml);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(579, 151);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "生成静态";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnCreateHtmlGet
            // 
            this.btnCreateHtmlGet.Location = new System.Drawing.Point(171, 14);
            this.btnCreateHtmlGet.Name = "btnCreateHtmlGet";
            this.btnCreateHtmlGet.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHtmlGet.TabIndex = 2;
            this.btnCreateHtmlGet.Text = "获取";
            this.btnCreateHtmlGet.UseVisualStyleBackColor = true;
            // 
            // cmbCreateHtmlList
            // 
            this.cmbCreateHtmlList.FormattingEnabled = true;
            this.cmbCreateHtmlList.Location = new System.Drawing.Point(19, 43);
            this.cmbCreateHtmlList.Name = "cmbCreateHtmlList";
            this.cmbCreateHtmlList.Size = new System.Drawing.Size(121, 20);
            this.cmbCreateHtmlList.TabIndex = 1;
            // 
            // btnCreateHtml
            // 
            this.btnCreateHtml.Location = new System.Drawing.Point(171, 43);
            this.btnCreateHtml.Name = "btnCreateHtml";
            this.btnCreateHtml.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHtml.TabIndex = 0;
            this.btnCreateHtml.Text = "生成静态";
            this.btnCreateHtml.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.button6);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(579, 151);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "上传";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "测试上传";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "测试网站后台";
            // 
            // txtTestSiteAdminUrl
            // 
            this.txtTestSiteAdminUrl.Location = new System.Drawing.Point(87, 66);
            this.txtTestSiteAdminUrl.Name = "txtTestSiteAdminUrl";
            this.txtTestSiteAdminUrl.Size = new System.Drawing.Size(325, 21);
            this.txtTestSiteAdminUrl.TabIndex = 2;
            // 
            // btnSaveTestConfig
            // 
            this.btnSaveTestConfig.Location = new System.Drawing.Point(434, 100);
            this.btnSaveTestConfig.Name = "btnSaveTestConfig";
            this.btnSaveTestConfig.Size = new System.Drawing.Size(163, 50);
            this.btnSaveTestConfig.TabIndex = 7;
            this.btnSaveTestConfig.Text = "保存配置";
            this.btnSaveTestConfig.UseVisualStyleBackColor = true;
            this.btnSaveTestConfig.Click += new System.EventHandler(this.btnSaveTestConfig_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(441, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "http://www.xxx.com/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(441, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "http://www.xxx.com/admin/";
            // 
            // backgroundWorker_TestModule
            // 
            this.backgroundWorker_TestModule.WorkerReportsProgress = true;
            this.backgroundWorker_TestModule.WorkerSupportsCancellation = true;
            // 
            // frmTestModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 495);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveTestConfig);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtTestUserPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTestUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTestSiteAdminUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTestSiteUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModuleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestModule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试模块";
            this.Load += new System.EventHandler(this.frmTestModule_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModuleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTestSiteUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestUserPwd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTestSiteAdminUrl;
        private System.Windows.Forms.Button btnTestLogin;
        private System.Windows.Forms.Button btnTestClassList;
        private System.Windows.Forms.Button btnTestContent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbCreateHtmlList;
        private System.Windows.Forms.Button btnCreateHtml;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtResultView;
        private System.Windows.Forms.TextBox txtHtmlView;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnTestClassListCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveTestConfig;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateHtmlGet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbClassList;
        private System.Windows.Forms.ComboBox cmbViewClassList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker_TestModule;
    }
}