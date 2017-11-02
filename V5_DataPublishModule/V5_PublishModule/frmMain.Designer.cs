using V5_WinUtility;
using V5_WinUtility.Controls;

namespace V5_PublishModule
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtOldModuleName = new System.Windows.Forms.TextBox();
            this.txtLoginPostData = new V5RichTextBox();
            this.btnLoginLabelInsert = new System.Windows.Forms.Button();
            this.contextMenuStrip_LoginLabelInsert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoginSuccessResult = new System.Windows.Forms.TextBox();
            this.txtLoginErrorResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginVerCodeUrl = new System.Windows.Forms.TextBox();
            this.txtLoginRefUrl = new System.Windows.Forms.TextBox();
            this.txtLoginUrl = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtLoginChkUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnListLabelInsert = new System.Windows.Forms.Button();
            this.txtListCreatePostData = new V5RichTextBox();
            this.txtListCreateError = new System.Windows.Forms.TextBox();
            this.txtListCreateSuccess = new System.Windows.Forms.TextBox();
            this.txtListCreateRefUrl = new System.Windows.Forms.TextBox();
            this.txtListCreateUrl = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel3 = new V5LinkLabel(this.components);
            this.txtListClassIDNameRegex = new V5RichTextBox();
            this.v5LinkLabel2 = new V5LinkLabel(this.components);
            this.v5LinkLabel1 = new V5LinkLabel(this.components);
            this.txtListStartCut = new V5RichTextBox();
            this.txtListUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtListEndCut = new System.Windows.Forms.TextBox();
            this.txtListRefUrl = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.listView_Random = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label20 = new System.Windows.Forms.Label();
            this.buttonDelRandom = new System.Windows.Forms.Button();
            this.buttonEditRandom = new System.Windows.Forms.Button();
            this.buttonNewRandom = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtContentPostData = new V5RichTextBox();
            this.btnViewLabelInsert = new System.Windows.Forms.Button();
            this.txtContentSuccessResult = new System.Windows.Forms.TextBox();
            this.txtContentErrorResult = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContentRefUrl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContentUrl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.txtUploadPostData = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtUploadRefUrl = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUploadUrl = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.btnCreateHtmlDel = new System.Windows.Forms.Button();
            this.btnCreateHtmlEdit = new System.Windows.Forms.Button();
            this.btnCreateHtmlAdd = new System.Windows.Forms.Button();
            this.listView_CreateHtml = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.txtModuleReadMe = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ddlPageEncode = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPublishModuleName = new System.Windows.Forms.TextBox();
            this.btnPublishModuleSave = new System.Windows.Forms.Button();
            this.contextMenuStrip_ViewLabelInsert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxPublishModule = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_TestModule = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TestModule = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPublishModuleClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Bottom = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_ListLabelInsert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.测试模块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip_TestModule.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(178, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 392);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.txtOldModuleName);
            this.tabPage1.Controls.Add(this.txtLoginPostData);
            this.tabPage1.Controls.Add(this.btnLoginLabelInsert);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtLoginSuccessResult);
            this.tabPage1.Controls.Add(this.txtLoginErrorResult);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLoginVerCodeUrl);
            this.tabPage1.Controls.Add(this.txtLoginRefUrl);
            this.tabPage1.Controls.Add(this.txtLoginUrl);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.txtLoginChkUrl);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登录设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(415, 100);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(215, 12);
            this.label31.TabIndex = 13;
            this.label31.Text = "*最好把验证码给去掉!留空检查验证码!\r\n";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(415, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 12);
            this.label30.TabIndex = 12;
            this.label30.Text = "例如:login.aspx";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(415, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 12);
            this.label28.TabIndex = 12;
            this.label28.Text = "例如:chklogin.aspx";
            // 
            // txtOldModuleName
            // 
            this.txtOldModuleName.Location = new System.Drawing.Point(28, 289);
            this.txtOldModuleName.Name = "txtOldModuleName";
            this.txtOldModuleName.Size = new System.Drawing.Size(100, 21);
            this.txtOldModuleName.TabIndex = 11;
            // 
            // txtLoginPostData
            // 
            this.txtLoginPostData.Location = new System.Drawing.Point(116, 129);
            this.txtLoginPostData.Name = "txtLoginPostData";
            this.txtLoginPostData.Size = new System.Drawing.Size(543, 68);
            this.txtLoginPostData.TabIndex = 10;
            this.txtLoginPostData.Text = "";
            // 
            // btnLoginLabelInsert
            // 
            this.btnLoginLabelInsert.ContextMenuStrip = this.contextMenuStrip_LoginLabelInsert;
            this.btnLoginLabelInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginLabelInsert.Location = new System.Drawing.Point(665, 129);
            this.btnLoginLabelInsert.Name = "btnLoginLabelInsert";
            this.btnLoginLabelInsert.Size = new System.Drawing.Size(57, 23);
            this.btnLoginLabelInsert.TabIndex = 9;
            this.btnLoginLabelInsert.Text = "参数";
            this.btnLoginLabelInsert.UseVisualStyleBackColor = true;
            this.btnLoginLabelInsert.Click += new System.EventHandler(this.btnLoginLabelInsert_Click);
            // 
            // contextMenuStrip_LoginLabelInsert
            // 
            this.contextMenuStrip_LoginLabelInsert.Name = "contextMenuStrip_LoginLabelInsert";
            this.contextMenuStrip_LoginLabelInsert.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "登录成功";
            // 
            // txtLoginSuccessResult
            // 
            this.txtLoginSuccessResult.Location = new System.Drawing.Point(460, 203);
            this.txtLoginSuccessResult.Multiline = true;
            this.txtLoginSuccessResult.Name = "txtLoginSuccessResult";
            this.txtLoginSuccessResult.Size = new System.Drawing.Size(233, 71);
            this.txtLoginSuccessResult.TabIndex = 5;
            // 
            // txtLoginErrorResult
            // 
            this.txtLoginErrorResult.Location = new System.Drawing.Point(116, 203);
            this.txtLoginErrorResult.Multiline = true;
            this.txtLoginErrorResult.Name = "txtLoginErrorResult";
            this.txtLoginErrorResult.Size = new System.Drawing.Size(230, 71);
            this.txtLoginErrorResult.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "登录失败";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "登录Post数据";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "登录验证码后缀";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "来源页面后缀";
            // 
            // txtLoginVerCodeUrl
            // 
            this.txtLoginVerCodeUrl.Location = new System.Drawing.Point(116, 97);
            this.txtLoginVerCodeUrl.Name = "txtLoginVerCodeUrl";
            this.txtLoginVerCodeUrl.Size = new System.Drawing.Size(293, 21);
            this.txtLoginVerCodeUrl.TabIndex = 1;
            // 
            // txtLoginRefUrl
            // 
            this.txtLoginRefUrl.Location = new System.Drawing.Point(116, 65);
            this.txtLoginRefUrl.Name = "txtLoginRefUrl";
            this.txtLoginRefUrl.Size = new System.Drawing.Size(293, 21);
            this.txtLoginRefUrl.TabIndex = 1;
            // 
            // txtLoginUrl
            // 
            this.txtLoginUrl.Location = new System.Drawing.Point(116, 6);
            this.txtLoginUrl.Name = "txtLoginUrl";
            this.txtLoginUrl.Size = new System.Drawing.Size(293, 21);
            this.txtLoginUrl.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(24, 11);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "登录地址后缀";
            // 
            // txtLoginChkUrl
            // 
            this.txtLoginChkUrl.Location = new System.Drawing.Point(116, 33);
            this.txtLoginChkUrl.Name = "txtLoginChkUrl";
            this.txtLoginChkUrl.Size = new System.Drawing.Size(293, 21);
            this.txtLoginChkUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录验证后缀";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "分类列表设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnListLabelInsert);
            this.groupBox4.Controls.Add(this.txtListCreatePostData);
            this.groupBox4.Controls.Add(this.txtListCreateError);
            this.groupBox4.Controls.Add(this.txtListCreateSuccess);
            this.groupBox4.Controls.Add(this.txtListCreateRefUrl);
            this.groupBox4.Controls.Add(this.txtListCreateUrl);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(6, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(716, 187);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "创建分类";
            // 
            // btnListLabelInsert
            // 
            this.btnListLabelInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListLabelInsert.Location = new System.Drawing.Point(665, 70);
            this.btnListLabelInsert.Name = "btnListLabelInsert";
            this.btnListLabelInsert.Size = new System.Drawing.Size(46, 23);
            this.btnListLabelInsert.TabIndex = 4;
            this.btnListLabelInsert.Text = "参数";
            this.btnListLabelInsert.UseVisualStyleBackColor = true;
            this.btnListLabelInsert.Click += new System.EventHandler(this.btnListLabelInsert_Click);
            // 
            // txtListCreatePostData
            // 
            this.txtListCreatePostData.Location = new System.Drawing.Point(121, 70);
            this.txtListCreatePostData.Name = "txtListCreatePostData";
            this.txtListCreatePostData.Size = new System.Drawing.Size(536, 52);
            this.txtListCreatePostData.TabIndex = 3;
            this.txtListCreatePostData.Text = "";
            // 
            // txtListCreateError
            // 
            this.txtListCreateError.Location = new System.Drawing.Point(453, 128);
            this.txtListCreateError.Multiline = true;
            this.txtListCreateError.Name = "txtListCreateError";
            this.txtListCreateError.Size = new System.Drawing.Size(204, 39);
            this.txtListCreateError.TabIndex = 2;
            // 
            // txtListCreateSuccess
            // 
            this.txtListCreateSuccess.Location = new System.Drawing.Point(121, 131);
            this.txtListCreateSuccess.Multiline = true;
            this.txtListCreateSuccess.Name = "txtListCreateSuccess";
            this.txtListCreateSuccess.Size = new System.Drawing.Size(248, 39);
            this.txtListCreateSuccess.TabIndex = 2;
            // 
            // txtListCreateRefUrl
            // 
            this.txtListCreateRefUrl.Location = new System.Drawing.Point(121, 44);
            this.txtListCreateRefUrl.Name = "txtListCreateRefUrl";
            this.txtListCreateRefUrl.Size = new System.Drawing.Size(401, 21);
            this.txtListCreateRefUrl.TabIndex = 2;
            // 
            // txtListCreateUrl
            // 
            this.txtListCreateUrl.Location = new System.Drawing.Point(121, 18);
            this.txtListCreateUrl.Name = "txtListCreateUrl";
            this.txtListCreateUrl.Size = new System.Drawing.Size(401, 21);
            this.txtListCreateUrl.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(382, 133);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 1;
            this.label25.Text = "错误标示";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(30, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "正确标示";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "Post参数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "来源地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "发表地址";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.v5LinkLabel3);
            this.groupBox3.Controls.Add(this.v5LinkLabel2);
            this.groupBox3.Controls.Add(this.v5LinkLabel1);
            this.groupBox3.Controls.Add(this.txtListStartCut);
            this.groupBox3.Controls.Add(this.txtListClassIDNameRegex);
            this.groupBox3.Controls.Add(this.txtListUrl);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtListEndCut);
            this.groupBox3.Controls.Add(this.txtListRefUrl);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 161);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "获取分类";
            // 
            // v5LinkLabel3
            // 
            this.v5LinkLabel3.AutoSize = true;
            this.v5LinkLabel3.LabelValue = "(*)";
            this.v5LinkLabel3.Location = new System.Drawing.Point(634, 49);
            this.v5LinkLabel3.Name = "v5LinkLabel3";
            this.v5LinkLabel3.RichTextBox = this.txtListClassIDNameRegex;
            this.v5LinkLabel3.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel3.TabIndex = 5;
            this.v5LinkLabel3.TabStop = true;
            this.v5LinkLabel3.Text = "(*)";
            // 
            // txtListClassIDNameRegex
            // 
            this.txtListClassIDNameRegex.Location = new System.Drawing.Point(521, 71);
            this.txtListClassIDNameRegex.Name = "txtListClassIDNameRegex";
            this.txtListClassIDNameRegex.Size = new System.Drawing.Size(189, 84);
            this.txtListClassIDNameRegex.TabIndex = 3;
            this.txtListClassIDNameRegex.Text = "";
            // 
            // v5LinkLabel2
            // 
            this.v5LinkLabel2.AutoSize = true;
            this.v5LinkLabel2.LabelValue = "[参数:分类名称]";
            this.v5LinkLabel2.Location = new System.Drawing.Point(575, 49);
            this.v5LinkLabel2.Name = "v5LinkLabel2";
            this.v5LinkLabel2.RichTextBox = this.txtListClassIDNameRegex;
            this.v5LinkLabel2.Size = new System.Drawing.Size(53, 12);
            this.v5LinkLabel2.TabIndex = 5;
            this.v5LinkLabel2.TabStop = true;
            this.v5LinkLabel2.Text = "分类名称";
            // 
            // v5LinkLabel1
            // 
            this.v5LinkLabel1.AutoSize = true;
            this.v5LinkLabel1.LabelValue = "[参数:分类ID]";
            this.v5LinkLabel1.Location = new System.Drawing.Point(528, 49);
            this.v5LinkLabel1.Name = "v5LinkLabel1";
            this.v5LinkLabel1.RichTextBox = this.txtListClassIDNameRegex;
            this.v5LinkLabel1.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel1.TabIndex = 5;
            this.v5LinkLabel1.TabStop = true;
            this.v5LinkLabel1.Text = "分类ID";
            // 
            // txtListStartCut
            // 
            this.txtListStartCut.Location = new System.Drawing.Point(121, 68);
            this.txtListStartCut.Name = "txtListStartCut";
            this.txtListStartCut.Size = new System.Drawing.Size(130, 87);
            this.txtListStartCut.TabIndex = 4;
            this.txtListStartCut.Text = "";
            // 
            // txtListUrl
            // 
            this.txtListUrl.Location = new System.Drawing.Point(121, 14);
            this.txtListUrl.Name = "txtListUrl";
            this.txtListUrl.Size = new System.Drawing.Size(401, 21);
            this.txtListUrl.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "刷新列表页";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "列表表达式";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(257, 68);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "列表结束";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(27, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "列表开始";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "来源页面";
            // 
            // txtListEndCut
            // 
            this.txtListEndCut.Location = new System.Drawing.Point(316, 68);
            this.txtListEndCut.Multiline = true;
            this.txtListEndCut.Name = "txtListEndCut";
            this.txtListEndCut.Size = new System.Drawing.Size(131, 87);
            this.txtListEndCut.TabIndex = 1;
            // 
            // txtListRefUrl
            // 
            this.txtListRefUrl.Location = new System.Drawing.Point(121, 40);
            this.txtListRefUrl.Name = "txtListRefUrl";
            this.txtListRefUrl.Size = new System.Drawing.Size(401, 21);
            this.txtListRefUrl.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.listView_Random);
            this.tabPage7.Controls.Add(this.label20);
            this.tabPage7.Controls.Add(this.buttonDelRandom);
            this.tabPage7.Controls.Add(this.buttonEditRandom);
            this.tabPage7.Controls.Add(this.buttonNewRandom);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(729, 366);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "随机值设置";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // listView_Random
            // 
            this.listView_Random.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader10});
            this.listView_Random.FullRowSelect = true;
            this.listView_Random.GridLines = true;
            this.listView_Random.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Random.Location = new System.Drawing.Point(16, 42);
            this.listView_Random.Name = "listView_Random";
            this.listView_Random.Size = new System.Drawing.Size(569, 258);
            this.listView_Random.TabIndex = 3;
            this.listView_Random.UseCompatibleStateImageBehavior = false;
            this.listView_Random.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "访问地址";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "来源地址";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Post参数";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "标签表达式";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "类型";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(222, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(221, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "* 有些网站提交需要随机值请在这里添加";
            // 
            // buttonDelRandom
            // 
            this.buttonDelRandom.Location = new System.Drawing.Point(141, 13);
            this.buttonDelRandom.Name = "buttonDelRandom";
            this.buttonDelRandom.Size = new System.Drawing.Size(57, 23);
            this.buttonDelRandom.TabIndex = 1;
            this.buttonDelRandom.Text = "删除";
            this.buttonDelRandom.UseVisualStyleBackColor = true;
            this.buttonDelRandom.Click += new System.EventHandler(this.btnDelRandom_Click);
            // 
            // buttonEditRandom
            // 
            this.buttonEditRandom.Location = new System.Drawing.Point(78, 13);
            this.buttonEditRandom.Name = "buttonEditRandom";
            this.buttonEditRandom.Size = new System.Drawing.Size(57, 23);
            this.buttonEditRandom.TabIndex = 1;
            this.buttonEditRandom.Text = "修改";
            this.buttonEditRandom.UseVisualStyleBackColor = true;
            this.buttonEditRandom.Click += new System.EventHandler(this.btnEditRandom_Click);
            // 
            // buttonNewRandom
            // 
            this.buttonNewRandom.Location = new System.Drawing.Point(15, 13);
            this.buttonNewRandom.Name = "buttonNewRandom";
            this.buttonNewRandom.Size = new System.Drawing.Size(57, 23);
            this.buttonNewRandom.TabIndex = 1;
            this.buttonNewRandom.Text = "添加";
            this.buttonNewRandom.UseVisualStyleBackColor = true;
            this.buttonNewRandom.Click += new System.EventHandler(this.btnNewRandom_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtContentPostData);
            this.tabPage3.Controls.Add(this.btnViewLabelInsert);
            this.tabPage3.Controls.Add(this.txtContentSuccessResult);
            this.tabPage3.Controls.Add(this.txtContentErrorResult);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtContentRefUrl);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtContentUrl);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(729, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "内容发表设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtContentPostData
            // 
            this.txtContentPostData.Location = new System.Drawing.Point(100, 71);
            this.txtContentPostData.Name = "txtContentPostData";
            this.txtContentPostData.Size = new System.Drawing.Size(549, 103);
            this.txtContentPostData.TabIndex = 11;
            this.txtContentPostData.Text = "";
            // 
            // btnViewLabelInsert
            // 
            this.btnViewLabelInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewLabelInsert.Location = new System.Drawing.Point(655, 71);
            this.btnViewLabelInsert.Name = "btnViewLabelInsert";
            this.btnViewLabelInsert.Size = new System.Drawing.Size(63, 23);
            this.btnViewLabelInsert.TabIndex = 10;
            this.btnViewLabelInsert.Text = "参数";
            this.btnViewLabelInsert.UseVisualStyleBackColor = true;
            this.btnViewLabelInsert.Click += new System.EventHandler(this.btnViewLabelInsert_Click);
            // 
            // txtContentSuccessResult
            // 
            this.txtContentSuccessResult.Location = new System.Drawing.Point(454, 180);
            this.txtContentSuccessResult.Multiline = true;
            this.txtContentSuccessResult.Name = "txtContentSuccessResult";
            this.txtContentSuccessResult.Size = new System.Drawing.Size(264, 85);
            this.txtContentSuccessResult.TabIndex = 2;
            // 
            // txtContentErrorResult
            // 
            this.txtContentErrorResult.Location = new System.Drawing.Point(100, 180);
            this.txtContentErrorResult.Multiline = true;
            this.txtContentErrorResult.Name = "txtContentErrorResult";
            this.txtContentErrorResult.Size = new System.Drawing.Size(265, 93);
            this.txtContentErrorResult.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "发表成功标示";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "发表错误标示";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "发表Post数据";
            // 
            // txtContentRefUrl
            // 
            this.txtContentRefUrl.Location = new System.Drawing.Point(100, 44);
            this.txtContentRefUrl.Name = "txtContentRefUrl";
            this.txtContentRefUrl.Size = new System.Drawing.Size(434, 21);
            this.txtContentRefUrl.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "页面来源地址";
            // 
            // txtContentUrl
            // 
            this.txtContentUrl.Location = new System.Drawing.Point(100, 17);
            this.txtContentUrl.Name = "txtContentUrl";
            this.txtContentUrl.Size = new System.Drawing.Size(434, 21);
            this.txtContentUrl.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "发表地址";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label33);
            this.tabPage8.Controls.Add(this.txtUploadPostData);
            this.tabPage8.Controls.Add(this.label39);
            this.tabPage8.Controls.Add(this.txtUploadRefUrl);
            this.tabPage8.Controls.Add(this.label17);
            this.tabPage8.Controls.Add(this.txtUploadUrl);
            this.tabPage8.Controls.Add(this.label38);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(729, 366);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "上传地址设置";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(543, 26);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 12);
            this.label33.TabIndex = 2;
            this.label33.Text = "此设置为上传使用!";
            // 
            // txtUploadPostData
            // 
            this.txtUploadPostData.Location = new System.Drawing.Point(84, 85);
            this.txtUploadPostData.Multiline = true;
            this.txtUploadPostData.Name = "txtUploadPostData";
            this.txtUploadPostData.Size = new System.Drawing.Size(412, 52);
            this.txtUploadPostData.TabIndex = 1;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(29, 88);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 12);
            this.label39.TabIndex = 0;
            this.label39.Text = "Post值";
            // 
            // txtUploadRefUrl
            // 
            this.txtUploadRefUrl.Location = new System.Drawing.Point(84, 53);
            this.txtUploadRefUrl.Name = "txtUploadRefUrl";
            this.txtUploadRefUrl.Size = new System.Drawing.Size(412, 21);
            this.txtUploadRefUrl.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "来源";
            // 
            // txtUploadUrl
            // 
            this.txtUploadUrl.Location = new System.Drawing.Point(84, 26);
            this.txtUploadUrl.Name = "txtUploadUrl";
            this.txtUploadUrl.Size = new System.Drawing.Size(412, 21);
            this.txtUploadUrl.TabIndex = 1;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(29, 29);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(29, 12);
            this.label38.TabIndex = 0;
            this.label38.Text = "地址";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label32);
            this.tabPage9.Controls.Add(this.btnCreateHtmlDel);
            this.tabPage9.Controls.Add(this.btnCreateHtmlEdit);
            this.tabPage9.Controls.Add(this.btnCreateHtmlAdd);
            this.tabPage9.Controls.Add(this.listView_CreateHtml);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(729, 366);
            this.tabPage9.TabIndex = 6;
            this.tabPage9.Text = "生成静态设置";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(584, 36);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(125, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "此设置为生成静态使用";
            // 
            // btnCreateHtmlDel
            // 
            this.btnCreateHtmlDel.Location = new System.Drawing.Point(184, 7);
            this.btnCreateHtmlDel.Name = "btnCreateHtmlDel";
            this.btnCreateHtmlDel.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHtmlDel.TabIndex = 1;
            this.btnCreateHtmlDel.Text = "删除";
            this.btnCreateHtmlDel.UseVisualStyleBackColor = true;
            this.btnCreateHtmlDel.Click += new System.EventHandler(this.btnCreateHtmlDel_Click);
            // 
            // btnCreateHtmlEdit
            // 
            this.btnCreateHtmlEdit.Location = new System.Drawing.Point(99, 7);
            this.btnCreateHtmlEdit.Name = "btnCreateHtmlEdit";
            this.btnCreateHtmlEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHtmlEdit.TabIndex = 1;
            this.btnCreateHtmlEdit.Text = "修改";
            this.btnCreateHtmlEdit.UseVisualStyleBackColor = true;
            this.btnCreateHtmlEdit.Click += new System.EventHandler(this.btnCreateHtmlEdit_Click);
            // 
            // btnCreateHtmlAdd
            // 
            this.btnCreateHtmlAdd.Location = new System.Drawing.Point(18, 8);
            this.btnCreateHtmlAdd.Name = "btnCreateHtmlAdd";
            this.btnCreateHtmlAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHtmlAdd.TabIndex = 1;
            this.btnCreateHtmlAdd.Text = "添加";
            this.btnCreateHtmlAdd.UseVisualStyleBackColor = true;
            this.btnCreateHtmlAdd.Click += new System.EventHandler(this.btnCreateHtmlAdd_Click);
            // 
            // listView_CreateHtml
            // 
            this.listView_CreateHtml.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_CreateHtml.FullRowSelect = true;
            this.listView_CreateHtml.GridLines = true;
            this.listView_CreateHtml.Location = new System.Drawing.Point(18, 36);
            this.listView_CreateHtml.Name = "listView_CreateHtml";
            this.listView_CreateHtml.Size = new System.Drawing.Size(549, 254);
            this.listView_CreateHtml.TabIndex = 0;
            this.listView_CreateHtml.UseCompatibleStateImageBehavior = false;
            this.listView_CreateHtml.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "名称";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "访问地址";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "来源地址";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Post参数";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.txtModuleReadMe);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(729, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "发布模块说明";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "模块制作者 以及简介说明!";
            // 
            // txtModuleReadMe
            // 
            this.txtModuleReadMe.Location = new System.Drawing.Point(92, 52);
            this.txtModuleReadMe.Multiline = true;
            this.txtModuleReadMe.Name = "txtModuleReadMe";
            this.txtModuleReadMe.Size = new System.Drawing.Size(616, 228);
            this.txtModuleReadMe.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(39, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "说明";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(523, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "网站编码";
            // 
            // ddlPageEncode
            // 
            this.ddlPageEncode.FormattingEnabled = true;
            this.ddlPageEncode.Location = new System.Drawing.Point(590, 33);
            this.ddlPageEncode.Name = "ddlPageEncode";
            this.ddlPageEncode.Size = new System.Drawing.Size(98, 20);
            this.ddlPageEncode.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(184, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "模块名称";
            // 
            // txtPublishModuleName
            // 
            this.txtPublishModuleName.Location = new System.Drawing.Point(238, 32);
            this.txtPublishModuleName.Name = "txtPublishModuleName";
            this.txtPublishModuleName.Size = new System.Drawing.Size(256, 21);
            this.txtPublishModuleName.TabIndex = 7;
            // 
            // btnPublishModuleSave
            // 
            this.btnPublishModuleSave.Location = new System.Drawing.Point(783, 28);
            this.btnPublishModuleSave.Name = "btnPublishModuleSave";
            this.btnPublishModuleSave.Size = new System.Drawing.Size(60, 23);
            this.btnPublishModuleSave.TabIndex = 9;
            this.btnPublishModuleSave.Text = "保存";
            this.btnPublishModuleSave.UseVisualStyleBackColor = true;
            this.btnPublishModuleSave.Click += new System.EventHandler(this.btnPublishModuleSave_Click);
            // 
            // contextMenuStrip_ViewLabelInsert
            // 
            this.contextMenuStrip_ViewLabelInsert.Name = "contextMenuStrip_ViewLabelInsert";
            this.contextMenuStrip_ViewLabelInsert.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_ViewLabelInsert.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ViewLabelInsert_ItemClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxPublishModule);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 429);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模块列表";
            // 
            // listBoxPublishModule
            // 
            this.listBoxPublishModule.ContextMenuStrip = this.contextMenuStrip_TestModule;
            this.listBoxPublishModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPublishModule.FormattingEnabled = true;
            this.listBoxPublishModule.ItemHeight = 12;
            this.listBoxPublishModule.Location = new System.Drawing.Point(3, 42);
            this.listBoxPublishModule.Name = "listBoxPublishModule";
            this.listBoxPublishModule.Size = new System.Drawing.Size(166, 384);
            this.listBoxPublishModule.TabIndex = 1;
            this.listBoxPublishModule.DoubleClick += new System.EventHandler(this.listBoxPublishModule_DoubleClick);
            // 
            // contextMenuStrip_TestModule
            // 
            this.contextMenuStrip_TestModule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试模块ToolStripMenuItem});
            this.contextMenuStrip_TestModule.Name = "contextMenuStrip_TestModule";
            this.contextMenuStrip_TestModule.Size = new System.Drawing.Size(125, 26);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(166, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::V5_PublishModule.Properties.Resources.pic037;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "添加";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::V5_PublishModule.Properties.Resources.pic049;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "删除";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "刷新";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_TestModule,
            this.退出ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // ToolStripMenuItem_TestModule
            // 
            this.ToolStripMenuItem_TestModule.Name = "ToolStripMenuItem_TestModule";
            this.ToolStripMenuItem_TestModule.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_TestModule.Text = "测试模块";
            this.ToolStripMenuItem_TestModule.Click += new System.EventHandler(this.ToolStripMenuItem_TestModule_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // btnPublishModuleClose
            // 
            this.btnPublishModuleClose.Location = new System.Drawing.Point(853, 28);
            this.btnPublishModuleClose.Name = "btnPublishModuleClose";
            this.btnPublishModuleClose.Size = new System.Drawing.Size(60, 23);
            this.btnPublishModuleClose.TabIndex = 9;
            this.btnPublishModuleClose.Text = "关闭";
            this.btnPublishModuleClose.UseVisualStyleBackColor = true;
            this.btnPublishModuleClose.Click += new System.EventHandler(this.btnPublishModuleClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Bottom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Bottom
            // 
            this.toolStripStatusLabel_Bottom.Name = "toolStripStatusLabel_Bottom";
            this.toolStripStatusLabel_Bottom.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "访问地址";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "标签前";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "标签后";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // contextMenuStrip_ListLabelInsert
            // 
            this.contextMenuStrip_ListLabelInsert.Name = "contextMenuStrip_ListLabelInsert";
            this.contextMenuStrip_ListLabelInsert.Size = new System.Drawing.Size(61, 4);
            // 
            // 测试模块ToolStripMenuItem
            // 
            this.测试模块ToolStripMenuItem.Name = "测试模块ToolStripMenuItem";
            this.测试模块ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.测试模块ToolStripMenuItem.Text = "测试模块";
            this.测试模块ToolStripMenuItem.Click += new System.EventHandler(this.测试模块ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPublishModuleName);
            this.Controls.Add(this.ddlPageEncode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPublishModuleClose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPublishModuleSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "站点发布模块配置";
            this.Load += new System.EventHandler(this.frmPublishModule_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip_TestModule.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoginSuccessResult;
        private System.Windows.Forms.TextBox txtLoginErrorResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginVerCodeUrl;
        private System.Windows.Forms.TextBox txtLoginRefUrl;
        private System.Windows.Forms.TextBox txtLoginChkUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtListRefUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtListUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtContentSuccessResult;
        private System.Windows.Forms.TextBox txtContentErrorResult;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtContentRefUrl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContentUrl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ddlPageEncode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPublishModuleName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnPublishModuleSave;
        private System.Windows.Forms.TextBox txtModuleReadMe;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnViewLabelInsert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ViewLabelInsert;
        private System.Windows.Forms.Button btnLoginLabelInsert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_LoginLabelInsert;
        private V5RichTextBox txtLoginPostData;
        private V5RichTextBox txtContentPostData;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button buttonDelRandom;
        private System.Windows.Forms.Button buttonEditRandom;
        private System.Windows.Forms.Button buttonNewRandom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ListBox listBoxPublishModule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox txtOldModuleName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtListCreateError;
        private System.Windows.Forms.TextBox txtListCreateSuccess;
        private System.Windows.Forms.TextBox txtListCreateRefUrl;
        private System.Windows.Forms.TextBox txtListCreateUrl;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtListEndCut;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtLoginUrl;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnPublishModuleClose;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ListView listView_Random;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtUploadUrl;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtUploadPostData;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ListView listView_CreateHtml;
        private System.Windows.Forms.Button btnCreateHtmlDel;
        private System.Windows.Forms.Button btnCreateHtmlEdit;
        private System.Windows.Forms.Button btnCreateHtmlAdd;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtUploadRefUrl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TestModule;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private V5RichTextBox txtListClassIDNameRegex;
        private V5RichTextBox txtListCreatePostData;
        private V5RichTextBox txtListStartCut;
        private V5LinkLabel v5LinkLabel2;
        private V5LinkLabel v5LinkLabel1;
        private V5LinkLabel v5LinkLabel3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Bottom;
        private System.Windows.Forms.Button btnListLabelInsert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListLabelInsert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_TestModule;
        private System.Windows.Forms.ToolStripMenuItem 测试模块ToolStripMenuItem;
    }
}