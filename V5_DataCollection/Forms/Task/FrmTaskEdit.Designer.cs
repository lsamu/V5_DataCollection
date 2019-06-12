using V5_WinControls;

namespace V5_DataCollection.Forms.Task {
    partial class FrmTaskEdit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>txtSaveDataSQL3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSiteClassID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsPublishContent = new System.Windows.Forms.CheckBox();
            this.chkIsSpiderContent = new System.Windows.Forms.CheckBox();
            this.chkIsSpiderUrl = new System.Windows.Forms.CheckBox();
            this.tabControlTaskEdit = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkSpiderListPlugin = new System.Windows.Forms.LinkLabel();
            this.cmbSpiderUrlPlugins = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel_List1 = new System.Windows.Forms.Panel();
            this.listBoxLinkUrl = new System.Windows.Forms.ListBox();
            this.txtLinkUrlDelete = new System.Windows.Forms.Button();
            this.btnLinkUrlEdit = new System.Windows.Forms.Button();
            this.btnWizardEdit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel6 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLinkUrlNoMustIncludeStr = new V5_WinControls.V5RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.v5LinkLabel5 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLinkUrlMustIncludeStr = new V5_WinControls.V5RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel8 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtHandCollectionUrlRegex = new V5_WinControls.V5RichTextBox();
            this.v5LinkLabel7 = new V5_WinControls.V5LinkLabel(this.components);
            this.v5LinkLabel2 = new V5_WinControls.V5LinkLabel(this.components);
            this.v5LinkLabel1 = new V5_WinControls.V5LinkLabel(this.components);
            this.chkIsHandGetUrl = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel4 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLinkUrlCutAreaEnd = new V5_WinControls.V5RichTextBox();
            this.v5LinkLabel3 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLinkUrlCutAreaStart = new V5_WinControls.V5RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIsSource = new System.Windows.Forms.CheckBox();
            this.txtDemoListUrl = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlItemEncode = new System.Windows.Forms.ComboBox();
            this.btnLinkUrlTest = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.txtChooseSavePath = new System.Windows.Forms.TextBox();
            this.btnChooseSavePath = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cmbSaveConentPlugins = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtTestViewUrlShow = new V5_WinControls.V5RichTextBox();
            this.btnTestViewUrl = new System.Windows.Forms.Button();
            this.txtTextViewUrl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLabelDown = new System.Windows.Forms.Button();
            this.btnLabelUp = new System.Windows.Forms.Button();
            this.btnTaskLabelCopy = new System.Windows.Forms.Button();
            this.btnCutLabelDel = new System.Windows.Forms.Button();
            this.btnCutLabelEdit = new System.Windows.Forms.Button();
            this.btnCutLabelAdd = new System.Windows.Forms.Button();
            this.listViewTaskLabel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cmbPublishContentPlugins = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnDiyWebUrlDelete = new System.Windows.Forms.Button();
            this.btnDiyWebUrlEdit = new System.Windows.Forms.Button();
            this.btnDiyWebUrlAdd = new System.Windows.Forms.Button();
            this.listView_DiyUrlWeb = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkPublish04 = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.btnChooseDbPath = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSaveDataUrl3 = new System.Windows.Forms.ComboBox();
            this.btnDataBaseLabelTag = new System.Windows.Forms.Button();
            this.txtSaveDataSQL3 = new V5_WinControls.V5RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rbtnOracle = new System.Windows.Forms.RadioButton();
            this.btnSaveDataBaseConfig = new System.Windows.Forms.Button();
            this.rbtnMySql = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.rbtnSqlite = new System.Windows.Forms.RadioButton();
            this.rbtnMsSql = new System.Windows.Forms.RadioButton();
            this.rbtnAccess = new System.Windows.Forms.RadioButton();
            this.chkPublish03 = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.txtSaveHtmlTemplate2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSaveLocalHtmlTemplatePath = new System.Windows.Forms.Button();
            this.btnSaveLocalPath = new System.Windows.Forms.Button();
            this.txtSaveDirectory2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ddlSaveFileFormat2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkPublish02 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnWebModuleDelete = new System.Windows.Forms.Button();
            this.btnWebModuleEdit = new System.Windows.Forms.Button();
            this.btnWebModuleAdd = new System.Windows.Forms.Button();
            this.listViewWebModule = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkPublish01 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetCookies = new System.Windows.Forms.Button();
            this.txtCollectionCookies = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtHiddenPlanFormat = new System.Windows.Forms.TextBox();
            this.chkTaskSetStatus = new System.Windows.Forms.CheckBox();
            this.btnTaskSet = new System.Windows.Forms.Button();
            this.txtTaskSetFormat = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numFtpPort = new System.Windows.Forms.NumericUpDown();
            this.chkFtpStatus = new System.Windows.Forms.CheckBox();
            this.txtFtpRemoteDir = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFtpUserPwd = new System.Windows.Forms.TextBox();
            this.txtFtpUserName = new System.Windows.Forms.TextBox();
            this.txtFtpIp = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.nudPublishContentStepTimeMax = new System.Windows.Forms.NumericUpDown();
            this.nudPublishContentStepTimeMin = new System.Windows.Forms.NumericUpDown();
            this.nudCollectionContentStepTime = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.nudPublishContentThreadCount = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.nudCollectionUrlStepTime = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.nudCollectionContentThreadCount = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.treeViewUrlTest = new System.Windows.Forms.TreeView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtOldTaskName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip_Label = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tabControlTaskEdit.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_List1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpPort)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentStepTimeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentStepTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentStepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentThreadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionUrlStepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentThreadCount)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属站点";
            // 
            // cmbSiteClassID
            // 
            this.cmbSiteClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiteClassID.FormattingEnabled = true;
            this.cmbSiteClassID.Location = new System.Drawing.Point(71, 4);
            this.cmbSiteClassID.Name = "cmbSiteClassID";
            this.cmbSiteClassID.Size = new System.Drawing.Size(102, 20);
            this.cmbSiteClassID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "任务名";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(226, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(172, 21);
            this.txtTaskName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsPublishContent);
            this.groupBox1.Controls.Add(this.chkIsSpiderContent);
            this.groupBox1.Controls.Add(this.chkIsSpiderUrl);
            this.groupBox1.Location = new System.Drawing.Point(518, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 37);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // chkIsPublishContent
            // 
            this.chkIsPublishContent.AutoSize = true;
            this.chkIsPublishContent.Checked = true;
            this.chkIsPublishContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsPublishContent.Location = new System.Drawing.Point(176, 15);
            this.chkIsPublishContent.Name = "chkIsPublishContent";
            this.chkIsPublishContent.Size = new System.Drawing.Size(72, 16);
            this.chkIsPublishContent.TabIndex = 0;
            this.chkIsPublishContent.Text = "发布内容";
            this.chkIsPublishContent.UseVisualStyleBackColor = true;
            // 
            // chkIsSpiderContent
            // 
            this.chkIsSpiderContent.AutoSize = true;
            this.chkIsSpiderContent.Checked = true;
            this.chkIsSpiderContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsSpiderContent.Location = new System.Drawing.Point(92, 15);
            this.chkIsSpiderContent.Name = "chkIsSpiderContent";
            this.chkIsSpiderContent.Size = new System.Drawing.Size(72, 16);
            this.chkIsSpiderContent.TabIndex = 0;
            this.chkIsSpiderContent.Text = "采集内容";
            this.chkIsSpiderContent.UseVisualStyleBackColor = true;
            // 
            // chkIsSpiderUrl
            // 
            this.chkIsSpiderUrl.AutoSize = true;
            this.chkIsSpiderUrl.Checked = true;
            this.chkIsSpiderUrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsSpiderUrl.Location = new System.Drawing.Point(8, 15);
            this.chkIsSpiderUrl.Name = "chkIsSpiderUrl";
            this.chkIsSpiderUrl.Size = new System.Drawing.Size(72, 16);
            this.chkIsSpiderUrl.TabIndex = 0;
            this.chkIsSpiderUrl.Text = "采集网址";
            this.chkIsSpiderUrl.UseVisualStyleBackColor = true;
            // 
            // tabControlTaskEdit
            // 
            this.tabControlTaskEdit.Controls.Add(this.tabPage1);
            this.tabControlTaskEdit.Controls.Add(this.tabPage2);
            this.tabControlTaskEdit.Controls.Add(this.tabPage3);
            this.tabControlTaskEdit.Controls.Add(this.tabPage4);
            this.tabControlTaskEdit.Controls.Add(this.tabPage5);
            this.tabControlTaskEdit.Location = new System.Drawing.Point(14, 26);
            this.tabControlTaskEdit.Name = "tabControlTaskEdit";
            this.tabControlTaskEdit.SelectedIndex = 0;
            this.tabControlTaskEdit.Size = new System.Drawing.Size(757, 480);
            this.tabControlTaskEdit.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkSpiderListPlugin);
            this.tabPage1.Controls.Add(this.cmbSpiderUrlPlugins);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnLinkUrlTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第一步:采集网址规则";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkSpiderListPlugin
            // 
            this.linkSpiderListPlugin.AutoSize = true;
            this.linkSpiderListPlugin.Location = new System.Drawing.Point(477, 423);
            this.linkSpiderListPlugin.Name = "linkSpiderListPlugin";
            this.linkSpiderListPlugin.Size = new System.Drawing.Size(29, 12);
            this.linkSpiderListPlugin.TabIndex = 18;
            this.linkSpiderListPlugin.TabStop = true;
            this.linkSpiderListPlugin.Text = "编辑";
            this.linkSpiderListPlugin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSpiderListPlugin_LinkClicked);
            // 
            // cmbSpiderUrlPlugins
            // 
            this.cmbSpiderUrlPlugins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpiderUrlPlugins.FormattingEnabled = true;
            this.cmbSpiderUrlPlugins.Location = new System.Drawing.Point(313, 419);
            this.cmbSpiderUrlPlugins.Name = "cmbSpiderUrlPlugins";
            this.cmbSpiderUrlPlugins.Size = new System.Drawing.Size(158, 20);
            this.cmbSpiderUrlPlugins.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(206, 423);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 16;
            this.label19.Text = "采集网址插件列表";
            // 
            // panel_List1
            // 
            this.panel_List1.Controls.Add(this.listBoxLinkUrl);
            this.panel_List1.Controls.Add(this.txtLinkUrlDelete);
            this.panel_List1.Controls.Add(this.btnLinkUrlEdit);
            this.panel_List1.Controls.Add(this.btnWizardEdit);
            this.panel_List1.Location = new System.Drawing.Point(4, 16);
            this.panel_List1.Name = "panel_List1";
            this.panel_List1.Padding = new System.Windows.Forms.Padding(5);
            this.panel_List1.Size = new System.Drawing.Size(724, 91);
            this.panel_List1.TabIndex = 15;
            // 
            // listBoxLinkUrl
            // 
            this.listBoxLinkUrl.FormattingEnabled = true;
            this.listBoxLinkUrl.ItemHeight = 12;
            this.listBoxLinkUrl.Location = new System.Drawing.Point(8, 6);
            this.listBoxLinkUrl.Name = "listBoxLinkUrl";
            this.listBoxLinkUrl.Size = new System.Drawing.Size(635, 76);
            this.listBoxLinkUrl.TabIndex = 1;
            // 
            // txtLinkUrlDelete
            // 
            this.txtLinkUrlDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtLinkUrlDelete.Location = new System.Drawing.Point(650, 59);
            this.txtLinkUrlDelete.Name = "txtLinkUrlDelete";
            this.txtLinkUrlDelete.Size = new System.Drawing.Size(68, 23);
            this.txtLinkUrlDelete.TabIndex = 3;
            this.txtLinkUrlDelete.Text = "删除";
            this.txtLinkUrlDelete.UseVisualStyleBackColor = true;
            this.txtLinkUrlDelete.Click += new System.EventHandler(this.txtLinkUrlDelete_Click);
            // 
            // btnLinkUrlEdit
            // 
            this.btnLinkUrlEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLinkUrlEdit.Location = new System.Drawing.Point(650, 31);
            this.btnLinkUrlEdit.Name = "btnLinkUrlEdit";
            this.btnLinkUrlEdit.Size = new System.Drawing.Size(68, 23);
            this.btnLinkUrlEdit.TabIndex = 3;
            this.btnLinkUrlEdit.Text = "修改";
            this.btnLinkUrlEdit.UseVisualStyleBackColor = true;
            this.btnLinkUrlEdit.Click += new System.EventHandler(this.btnLinkUrlEdit_Click);
            // 
            // btnWizardEdit
            // 
            this.btnWizardEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWizardEdit.Location = new System.Drawing.Point(649, 5);
            this.btnWizardEdit.Name = "btnWizardEdit";
            this.btnWizardEdit.Size = new System.Drawing.Size(68, 23);
            this.btnWizardEdit.TabIndex = 3;
            this.btnWizardEdit.Text = "添加";
            this.btnWizardEdit.UseVisualStyleBackColor = true;
            this.btnWizardEdit.Click += new System.EventHandler(this.btnWizardEdit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(128, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "点击设置";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 424);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "需要登录才能采集？";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.groupBox20);
            this.groupBox3.Controls.Add(this.groupBox19);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(6, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 374);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "采集链接设置";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.v5LinkLabel6);
            this.groupBox20.Controls.Add(this.label4);
            this.groupBox20.Controls.Add(this.v5LinkLabel5);
            this.groupBox20.Controls.Add(this.label5);
            this.groupBox20.Controls.Add(this.txtLinkUrlMustIncludeStr);
            this.groupBox20.Controls.Add(this.txtLinkUrlNoMustIncludeStr);
            this.groupBox20.Location = new System.Drawing.Point(380, 256);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(350, 110);
            this.groupBox20.TabIndex = 14;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "链接过滤";
            // 
            // v5LinkLabel6
            // 
            this.v5LinkLabel6.AutoSize = true;
            this.v5LinkLabel6.LabelValue = "(*)";
            this.v5LinkLabel6.Location = new System.Drawing.Point(318, 74);
            this.v5LinkLabel6.Name = "v5LinkLabel6";
            this.v5LinkLabel6.RichTextBox = this.txtLinkUrlNoMustIncludeStr;
            this.v5LinkLabel6.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel6.TabIndex = 13;
            this.v5LinkLabel6.TabStop = true;
            this.v5LinkLabel6.Text = "(*)";
            // 
            // txtLinkUrlNoMustIncludeStr
            // 
            this.txtLinkUrlNoMustIncludeStr.Location = new System.Drawing.Point(180, 20);
            this.txtLinkUrlNoMustIncludeStr.Name = "txtLinkUrlNoMustIncludeStr";
            this.txtLinkUrlNoMustIncludeStr.Size = new System.Drawing.Size(135, 83);
            this.txtLinkUrlNoMustIncludeStr.TabIndex = 8;
            this.txtLinkUrlNoMustIncludeStr.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 58);
            this.label4.TabIndex = 0;
            this.label4.Text = "必须包含";
            // 
            // v5LinkLabel5
            // 
            this.v5LinkLabel5.AutoSize = true;
            this.v5LinkLabel5.LabelValue = "(*)";
            this.v5LinkLabel5.Location = new System.Drawing.Point(4, 82);
            this.v5LinkLabel5.Name = "v5LinkLabel5";
            this.v5LinkLabel5.RichTextBox = this.txtLinkUrlMustIncludeStr;
            this.v5LinkLabel5.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel5.TabIndex = 12;
            this.v5LinkLabel5.TabStop = true;
            this.v5LinkLabel5.Text = "(*)";
            // 
            // txtLinkUrlMustIncludeStr
            // 
            this.txtLinkUrlMustIncludeStr.Location = new System.Drawing.Point(30, 20);
            this.txtLinkUrlMustIncludeStr.Name = "txtLinkUrlMustIncludeStr";
            this.txtLinkUrlMustIncludeStr.Size = new System.Drawing.Size(135, 82);
            this.txtLinkUrlMustIncludeStr.TabIndex = 8;
            this.txtLinkUrlMustIncludeStr.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(320, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 51);
            this.label5.TabIndex = 2;
            this.label5.Text = "不包含";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.v5LinkLabel8);
            this.groupBox19.Controls.Add(this.v5LinkLabel7);
            this.groupBox19.Controls.Add(this.v5LinkLabel2);
            this.groupBox19.Controls.Add(this.v5LinkLabel1);
            this.groupBox19.Controls.Add(this.chkIsHandGetUrl);
            this.groupBox19.Controls.Add(this.label36);
            this.groupBox19.Controls.Add(this.txtHandCollectionUrlRegex);
            this.groupBox19.Location = new System.Drawing.Point(0, 147);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(740, 104);
            this.groupBox19.TabIndex = 6;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "手动设置获取内容页规则";
            // 
            // v5LinkLabel8
            // 
            this.v5LinkLabel8.AutoSize = true;
            this.v5LinkLabel8.LabelValue = "[封面]";
            this.v5LinkLabel8.Location = new System.Drawing.Point(614, 74);
            this.v5LinkLabel8.Name = "v5LinkLabel8";
            this.v5LinkLabel8.RichTextBox = this.txtHandCollectionUrlRegex;
            this.v5LinkLabel8.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel8.TabIndex = 12;
            this.v5LinkLabel8.TabStop = true;
            this.v5LinkLabel8.Text = "[封面]";
            // 
            // txtHandCollectionUrlRegex
            // 
            this.txtHandCollectionUrlRegex.Enabled = false;
            this.txtHandCollectionUrlRegex.Location = new System.Drawing.Point(79, 17);
            this.txtHandCollectionUrlRegex.Name = "txtHandCollectionUrlRegex";
            this.txtHandCollectionUrlRegex.Size = new System.Drawing.Size(530, 82);
            this.txtHandCollectionUrlRegex.TabIndex = 8;
            this.txtHandCollectionUrlRegex.Text = "";
            // 
            // v5LinkLabel7
            // 
            this.v5LinkLabel7.AutoSize = true;
            this.v5LinkLabel7.LabelValue = "[标题]";
            this.v5LinkLabel7.Location = new System.Drawing.Point(614, 49);
            this.v5LinkLabel7.Name = "v5LinkLabel7";
            this.v5LinkLabel7.RichTextBox = this.txtHandCollectionUrlRegex;
            this.v5LinkLabel7.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel7.TabIndex = 11;
            this.v5LinkLabel7.TabStop = true;
            this.v5LinkLabel7.Text = "[标题]";
            // 
            // v5LinkLabel2
            // 
            this.v5LinkLabel2.AutoSize = true;
            this.v5LinkLabel2.LabelValue = "[链接]";
            this.v5LinkLabel2.Location = new System.Drawing.Point(614, 24);
            this.v5LinkLabel2.Name = "v5LinkLabel2";
            this.v5LinkLabel2.RichTextBox = this.txtHandCollectionUrlRegex;
            this.v5LinkLabel2.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel2.TabIndex = 10;
            this.v5LinkLabel2.TabStop = true;
            this.v5LinkLabel2.Text = "[链接]";
            // 
            // v5LinkLabel1
            // 
            this.v5LinkLabel1.AutoSize = true;
            this.v5LinkLabel1.LabelValue = "(*)";
            this.v5LinkLabel1.Location = new System.Drawing.Point(674, 24);
            this.v5LinkLabel1.Name = "v5LinkLabel1";
            this.v5LinkLabel1.RichTextBox = this.txtHandCollectionUrlRegex;
            this.v5LinkLabel1.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel1.TabIndex = 9;
            this.v5LinkLabel1.TabStop = true;
            this.v5LinkLabel1.Text = "(*)";
            // 
            // chkIsHandGetUrl
            // 
            this.chkIsHandGetUrl.AutoSize = true;
            this.chkIsHandGetUrl.Location = new System.Drawing.Point(10, 51);
            this.chkIsHandGetUrl.Name = "chkIsHandGetUrl";
            this.chkIsHandGetUrl.Size = new System.Drawing.Size(36, 16);
            this.chkIsHandGetUrl.TabIndex = 2;
            this.chkIsHandGetUrl.Text = "是";
            this.chkIsHandGetUrl.UseVisualStyleBackColor = true;
            this.chkIsHandGetUrl.CheckedChanged += new System.EventHandler(this.IsHandGetUrl_CheckedChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(8, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 12);
            this.label36.TabIndex = 0;
            this.label36.Text = "提取规则：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.v5LinkLabel4);
            this.groupBox4.Controls.Add(this.v5LinkLabel3);
            this.groupBox4.Controls.Add(this.txtLinkUrlCutAreaEnd);
            this.groupBox4.Controls.Add(this.txtLinkUrlCutAreaStart);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(10, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设置内容页区域(选定区域采集)";
            // 
            // v5LinkLabel4
            // 
            this.v5LinkLabel4.AutoSize = true;
            this.v5LinkLabel4.LabelValue = "(*)";
            this.v5LinkLabel4.Location = new System.Drawing.Point(168, 76);
            this.v5LinkLabel4.Name = "v5LinkLabel4";
            this.v5LinkLabel4.RichTextBox = this.txtLinkUrlCutAreaEnd;
            this.v5LinkLabel4.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel4.TabIndex = 11;
            this.v5LinkLabel4.TabStop = true;
            this.v5LinkLabel4.Text = "(*)";
            // 
            // txtLinkUrlCutAreaEnd
            // 
            this.txtLinkUrlCutAreaEnd.Location = new System.Drawing.Point(200, 19);
            this.txtLinkUrlCutAreaEnd.Name = "txtLinkUrlCutAreaEnd";
            this.txtLinkUrlCutAreaEnd.Size = new System.Drawing.Size(135, 83);
            this.txtLinkUrlCutAreaEnd.TabIndex = 9;
            this.txtLinkUrlCutAreaEnd.Text = "";
            // 
            // v5LinkLabel3
            // 
            this.v5LinkLabel3.AutoSize = true;
            this.v5LinkLabel3.LabelValue = "(*)";
            this.v5LinkLabel3.Location = new System.Drawing.Point(6, 76);
            this.v5LinkLabel3.Name = "v5LinkLabel3";
            this.v5LinkLabel3.RichTextBox = this.txtLinkUrlCutAreaStart;
            this.v5LinkLabel3.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel3.TabIndex = 10;
            this.v5LinkLabel3.TabStop = true;
            this.v5LinkLabel3.Text = "(*)";
            // 
            // txtLinkUrlCutAreaStart
            // 
            this.txtLinkUrlCutAreaStart.Location = new System.Drawing.Point(30, 19);
            this.txtLinkUrlCutAreaStart.Name = "txtLinkUrlCutAreaStart";
            this.txtLinkUrlCutAreaStart.Size = new System.Drawing.Size(135, 83);
            this.txtLinkUrlCutAreaStart.TabIndex = 8;
            this.txtLinkUrlCutAreaStart.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "到";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "从";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIsSource);
            this.groupBox2.Controls.Add(this.txtDemoListUrl);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ddlItemEncode);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 40);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // chkIsSource
            // 
            this.chkIsSource.AutoSize = true;
            this.chkIsSource.Location = new System.Drawing.Point(683, 16);
            this.chkIsSource.Name = "chkIsSource";
            this.chkIsSource.Size = new System.Drawing.Size(48, 16);
            this.chkIsSource.TabIndex = 4;
            this.chkIsSource.Text = "源码";
            this.chkIsSource.UseVisualStyleBackColor = true;
            this.chkIsSource.CheckedChanged += new System.EventHandler(this.chkIsSource_CheckedChanged);
            // 
            // txtDemoListUrl
            // 
            this.txtDemoListUrl.Location = new System.Drawing.Point(276, 13);
            this.txtDemoListUrl.Name = "txtDemoListUrl";
            this.txtDemoListUrl.Size = new System.Drawing.Size(404, 21);
            this.txtDemoListUrl.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(205, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "采集示例页";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "网页编码";
            // 
            // ddlItemEncode
            // 
            this.ddlItemEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlItemEncode.FormattingEnabled = true;
            this.ddlItemEncode.Location = new System.Drawing.Point(75, 14);
            this.ddlItemEncode.Name = "ddlItemEncode";
            this.ddlItemEncode.Size = new System.Drawing.Size(105, 20);
            this.ddlItemEncode.TabIndex = 0;
            // 
            // btnLinkUrlTest
            // 
            this.btnLinkUrlTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLinkUrlTest.Location = new System.Drawing.Point(627, 419);
            this.btnLinkUrlTest.Name = "btnLinkUrlTest";
            this.btnLinkUrlTest.Size = new System.Drawing.Size(100, 23);
            this.btnLinkUrlTest.TabIndex = 5;
            this.btnLinkUrlTest.Text = "网页采集测试";
            this.btnLinkUrlTest.UseVisualStyleBackColor = true;
            this.btnLinkUrlTest.Click += new System.EventHandler(this.btnLinkUrlTest_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.txtChooseSavePath);
            this.tabPage2.Controls.Add(this.btnChooseSavePath);
            this.tabPage2.Controls.Add(this.linkLabel2);
            this.tabPage2.Controls.Add(this.cmbSaveConentPlugins);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "第二步:采集内容规则";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(22, 427);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 12);
            this.label33.TabIndex = 11;
            this.label33.Text = "资源保存地址";
            // 
            // txtChooseSavePath
            // 
            this.txtChooseSavePath.Location = new System.Drawing.Point(101, 423);
            this.txtChooseSavePath.Name = "txtChooseSavePath";
            this.txtChooseSavePath.Size = new System.Drawing.Size(134, 21);
            this.txtChooseSavePath.TabIndex = 10;
            // 
            // btnChooseSavePath
            // 
            this.btnChooseSavePath.Location = new System.Drawing.Point(240, 423);
            this.btnChooseSavePath.Name = "btnChooseSavePath";
            this.btnChooseSavePath.Size = new System.Drawing.Size(63, 23);
            this.btnChooseSavePath.TabIndex = 9;
            this.btnChooseSavePath.Text = "选择";
            this.btnChooseSavePath.UseVisualStyleBackColor = true;
            this.btnChooseSavePath.Click += new System.EventHandler(this.btnChooseSavePath_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(314, 401);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 12);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "设置";
            // 
            // cmbSaveConentPlugins
            // 
            this.cmbSaveConentPlugins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaveConentPlugins.FormattingEnabled = true;
            this.cmbSaveConentPlugins.Location = new System.Drawing.Point(83, 397);
            this.cmbSaveConentPlugins.Name = "cmbSaveConentPlugins";
            this.cmbSaveConentPlugins.Size = new System.Drawing.Size(219, 20);
            this.cmbSaveConentPlugins.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 401);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "保存内容";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtTestViewUrlShow);
            this.groupBox7.Controls.Add(this.btnTestViewUrl);
            this.groupBox7.Controls.Add(this.txtTextViewUrl);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(308, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(434, 370);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "采集页面测试";
            // 
            // txtTestViewUrlShow
            // 
            this.txtTestViewUrlShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestViewUrlShow.Location = new System.Drawing.Point(8, 43);
            this.txtTestViewUrlShow.Name = "txtTestViewUrlShow";
            this.txtTestViewUrlShow.Size = new System.Drawing.Size(420, 321);
            this.txtTestViewUrlShow.TabIndex = 3;
            this.txtTestViewUrlShow.Text = "";
            // 
            // btnTestViewUrl
            // 
            this.btnTestViewUrl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestViewUrl.Location = new System.Drawing.Point(392, 14);
            this.btnTestViewUrl.Name = "btnTestViewUrl";
            this.btnTestViewUrl.Size = new System.Drawing.Size(38, 23);
            this.btnTestViewUrl.TabIndex = 2;
            this.btnTestViewUrl.Text = "测试";
            this.btnTestViewUrl.UseVisualStyleBackColor = true;
            this.btnTestViewUrl.Click += new System.EventHandler(this.btnTestViewUrl_Click);
            // 
            // txtTextViewUrl
            // 
            this.txtTextViewUrl.Location = new System.Drawing.Point(65, 16);
            this.txtTextViewUrl.Name = "txtTextViewUrl";
            this.txtTextViewUrl.Size = new System.Drawing.Size(321, 21);
            this.txtTextViewUrl.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "测试页面";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLabelDown);
            this.groupBox6.Controls.Add(this.btnLabelUp);
            this.groupBox6.Controls.Add(this.btnTaskLabelCopy);
            this.groupBox6.Controls.Add(this.btnCutLabelDel);
            this.groupBox6.Controls.Add(this.btnCutLabelEdit);
            this.groupBox6.Controls.Add(this.btnCutLabelAdd);
            this.groupBox6.Controls.Add(this.listViewTaskLabel);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(296, 385);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "页面内容标签定义";
            // 
            // btnLabelDown
            // 
            this.btnLabelDown.Location = new System.Drawing.Point(38, 139);
            this.btnLabelDown.Name = "btnLabelDown";
            this.btnLabelDown.Size = new System.Drawing.Size(25, 23);
            this.btnLabelDown.TabIndex = 2;
            this.btnLabelDown.Text = "↓";
            this.btnLabelDown.UseVisualStyleBackColor = true;
            this.btnLabelDown.Click += new System.EventHandler(this.btnLabelDown_Click);
            // 
            // btnLabelUp
            // 
            this.btnLabelUp.Location = new System.Drawing.Point(7, 139);
            this.btnLabelUp.Name = "btnLabelUp";
            this.btnLabelUp.Size = new System.Drawing.Size(25, 23);
            this.btnLabelUp.TabIndex = 2;
            this.btnLabelUp.Text = "↑";
            this.btnLabelUp.UseVisualStyleBackColor = true;
            this.btnLabelUp.Click += new System.EventHandler(this.btnLabelUp_Click);
            // 
            // btnTaskLabelCopy
            // 
            this.btnTaskLabelCopy.Location = new System.Drawing.Point(6, 107);
            this.btnTaskLabelCopy.Name = "btnTaskLabelCopy";
            this.btnTaskLabelCopy.Size = new System.Drawing.Size(63, 23);
            this.btnTaskLabelCopy.TabIndex = 1;
            this.btnTaskLabelCopy.Text = "复制标签";
            this.btnTaskLabelCopy.UseVisualStyleBackColor = true;
            this.btnTaskLabelCopy.Click += new System.EventHandler(this.btnTaskLabelCopy_Click);
            // 
            // btnCutLabelDel
            // 
            this.btnCutLabelDel.Location = new System.Drawing.Point(6, 78);
            this.btnCutLabelDel.Name = "btnCutLabelDel";
            this.btnCutLabelDel.Size = new System.Drawing.Size(63, 23);
            this.btnCutLabelDel.TabIndex = 1;
            this.btnCutLabelDel.Text = "删除标签";
            this.btnCutLabelDel.UseVisualStyleBackColor = true;
            this.btnCutLabelDel.Click += new System.EventHandler(this.btnCutLabelDel_Click);
            // 
            // btnCutLabelEdit
            // 
            this.btnCutLabelEdit.Location = new System.Drawing.Point(6, 49);
            this.btnCutLabelEdit.Name = "btnCutLabelEdit";
            this.btnCutLabelEdit.Size = new System.Drawing.Size(63, 23);
            this.btnCutLabelEdit.TabIndex = 1;
            this.btnCutLabelEdit.Text = "修改标签";
            this.btnCutLabelEdit.UseVisualStyleBackColor = true;
            this.btnCutLabelEdit.Click += new System.EventHandler(this.btnCutLabelEdit_Click);
            // 
            // btnCutLabelAdd
            // 
            this.btnCutLabelAdd.Location = new System.Drawing.Point(6, 20);
            this.btnCutLabelAdd.Name = "btnCutLabelAdd";
            this.btnCutLabelAdd.Size = new System.Drawing.Size(63, 23);
            this.btnCutLabelAdd.TabIndex = 1;
            this.btnCutLabelAdd.Text = "添加标签";
            this.btnCutLabelAdd.UseVisualStyleBackColor = true;
            this.btnCutLabelAdd.Click += new System.EventHandler(this.btnCutLabelAdd_Click);
            // 
            // listViewTaskLabel
            // 
            this.listViewTaskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTaskLabel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewTaskLabel.FullRowSelect = true;
            this.listViewTaskLabel.GridLines = true;
            this.listViewTaskLabel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTaskLabel.Location = new System.Drawing.Point(75, 20);
            this.listViewTaskLabel.MultiSelect = false;
            this.listViewTaskLabel.Name = "listViewTaskLabel";
            this.listViewTaskLabel.Size = new System.Drawing.Size(215, 359);
            this.listViewTaskLabel.TabIndex = 0;
            this.listViewTaskLabel.UseCompatibleStateImageBehavior = false;
            this.listViewTaskLabel.View = System.Windows.Forms.View.Details;
            this.listViewTaskLabel.DoubleClick += new System.EventHandler(this.listViewTaskLabel_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "标签名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "截取标签表达式";
            this.columnHeader2.Width = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel3);
            this.tabPage3.Controls.Add(this.cmbPublishContentPlugins);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.groupBox16);
            this.tabPage3.Controls.Add(this.groupBox15);
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(749, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "第三步:发布内容规则";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(694, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(29, 12);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "设置";
            // 
            // cmbPublishContentPlugins
            // 
            this.cmbPublishContentPlugins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublishContentPlugins.FormattingEnabled = true;
            this.cmbPublishContentPlugins.Location = new System.Drawing.Point(507, 5);
            this.cmbPublishContentPlugins.Name = "cmbPublishContentPlugins";
            this.cmbPublishContentPlugins.Size = new System.Drawing.Size(170, 20);
            this.cmbPublishContentPlugins.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(446, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "发布内容";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(318, 8);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 16);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "数据发布进行编码";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(135, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "0不限制";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "最大发布记录个数";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.btnDiyWebUrlDelete);
            this.groupBox16.Controls.Add(this.btnDiyWebUrlEdit);
            this.groupBox16.Controls.Add(this.btnDiyWebUrlAdd);
            this.groupBox16.Controls.Add(this.listView_DiyUrlWeb);
            this.groupBox16.Controls.Add(this.chkPublish04);
            this.groupBox16.Location = new System.Drawing.Point(352, 224);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(306, 195);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "4.自定义Web地址";
            // 
            // btnDiyWebUrlDelete
            // 
            this.btnDiyWebUrlDelete.Location = new System.Drawing.Point(254, 13);
            this.btnDiyWebUrlDelete.Name = "btnDiyWebUrlDelete";
            this.btnDiyWebUrlDelete.Size = new System.Drawing.Size(46, 23);
            this.btnDiyWebUrlDelete.TabIndex = 9;
            this.btnDiyWebUrlDelete.Text = "删除";
            this.btnDiyWebUrlDelete.UseVisualStyleBackColor = true;
            this.btnDiyWebUrlDelete.Click += new System.EventHandler(this.btnDiyWebUrlDelete_Click);
            // 
            // btnDiyWebUrlEdit
            // 
            this.btnDiyWebUrlEdit.Location = new System.Drawing.Point(202, 14);
            this.btnDiyWebUrlEdit.Name = "btnDiyWebUrlEdit";
            this.btnDiyWebUrlEdit.Size = new System.Drawing.Size(46, 23);
            this.btnDiyWebUrlEdit.TabIndex = 9;
            this.btnDiyWebUrlEdit.Text = "修改";
            this.btnDiyWebUrlEdit.UseVisualStyleBackColor = true;
            this.btnDiyWebUrlEdit.Click += new System.EventHandler(this.btnDiyWebUrlEdit_Click);
            // 
            // btnDiyWebUrlAdd
            // 
            this.btnDiyWebUrlAdd.Location = new System.Drawing.Point(146, 13);
            this.btnDiyWebUrlAdd.Name = "btnDiyWebUrlAdd";
            this.btnDiyWebUrlAdd.Size = new System.Drawing.Size(46, 23);
            this.btnDiyWebUrlAdd.TabIndex = 9;
            this.btnDiyWebUrlAdd.Text = "添加";
            this.btnDiyWebUrlAdd.UseVisualStyleBackColor = true;
            this.btnDiyWebUrlAdd.Click += new System.EventHandler(this.btnDiyWebUrlAdd_Click);
            // 
            // listView_DiyUrlWeb
            // 
            this.listView_DiyUrlWeb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7});
            this.listView_DiyUrlWeb.FullRowSelect = true;
            this.listView_DiyUrlWeb.GridLines = true;
            this.listView_DiyUrlWeb.Location = new System.Drawing.Point(6, 44);
            this.listView_DiyUrlWeb.Name = "listView_DiyUrlWeb";
            this.listView_DiyUrlWeb.Size = new System.Drawing.Size(294, 145);
            this.listView_DiyUrlWeb.TabIndex = 8;
            this.listView_DiyUrlWeb.UseCompatibleStateImageBehavior = false;
            this.listView_DiyUrlWeb.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "网站";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "网址";
            this.columnHeader7.Width = 144;
            // 
            // chkPublish04
            // 
            this.chkPublish04.AutoSize = true;
            this.chkPublish04.Location = new System.Drawing.Point(6, 20);
            this.chkPublish04.Name = "chkPublish04";
            this.chkPublish04.Size = new System.Drawing.Size(48, 16);
            this.chkPublish04.TabIndex = 0;
            this.chkPublish04.Text = "启用";
            this.chkPublish04.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txtDbPath);
            this.groupBox15.Controls.Add(this.btnChooseDbPath);
            this.groupBox15.Controls.Add(this.label20);
            this.groupBox15.Controls.Add(this.txtSaveDataUrl3);
            this.groupBox15.Controls.Add(this.btnDataBaseLabelTag);
            this.groupBox15.Controls.Add(this.txtSaveDataSQL3);
            this.groupBox15.Controls.Add(this.label18);
            this.groupBox15.Controls.Add(this.rbtnOracle);
            this.groupBox15.Controls.Add(this.btnSaveDataBaseConfig);
            this.groupBox15.Controls.Add(this.rbtnMySql);
            this.groupBox15.Controls.Add(this.label17);
            this.groupBox15.Controls.Add(this.rbtnSqlite);
            this.groupBox15.Controls.Add(this.rbtnMsSql);
            this.groupBox15.Controls.Add(this.rbtnAccess);
            this.groupBox15.Controls.Add(this.chkPublish03);
            this.groupBox15.Location = new System.Drawing.Point(13, 224);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(306, 227);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "3.保存到数据库";
            // 
            // txtDbPath
            // 
            this.txtDbPath.Location = new System.Drawing.Point(77, 69);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.Size = new System.Drawing.Size(137, 21);
            this.txtDbPath.TabIndex = 12;
            this.txtDbPath.TextChanged += new System.EventHandler(this.txtDbPath_TextChanged);
            // 
            // btnChooseDbPath
            // 
            this.btnChooseDbPath.Location = new System.Drawing.Point(225, 66);
            this.btnChooseDbPath.Name = "btnChooseDbPath";
            this.btnChooseDbPath.Size = new System.Drawing.Size(46, 23);
            this.btnChooseDbPath.TabIndex = 11;
            this.btnChooseDbPath.Text = "测试";
            this.btnChooseDbPath.UseVisualStyleBackColor = true;
            this.btnChooseDbPath.Click += new System.EventHandler(this.btnChooseDbPath_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 9;
            this.label20.Text = "数据库地址";
            // 
            // txtSaveDataUrl3
            // 
            this.txtSaveDataUrl3.FormattingEnabled = true;
            this.txtSaveDataUrl3.Items.AddRange(new object[] {
            "server=.;uid=sa;pwd=sa;database=v5;",
            "Server=localhost;Database=v5;Uid=root;Pwd=root; ",
            "Database=d:\\v5.db; "});
            this.txtSaveDataUrl3.Location = new System.Drawing.Point(7, 114);
            this.txtSaveDataUrl3.Name = "txtSaveDataUrl3";
            this.txtSaveDataUrl3.Size = new System.Drawing.Size(241, 20);
            this.txtSaveDataUrl3.TabIndex = 8;
            // 
            // btnDataBaseLabelTag
            // 
            this.btnDataBaseLabelTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataBaseLabelTag.Location = new System.Drawing.Point(225, 137);
            this.btnDataBaseLabelTag.Name = "btnDataBaseLabelTag";
            this.btnDataBaseLabelTag.Size = new System.Drawing.Size(75, 23);
            this.btnDataBaseLabelTag.TabIndex = 7;
            this.btnDataBaseLabelTag.Text = "标签";
            this.btnDataBaseLabelTag.UseVisualStyleBackColor = true;
            this.btnDataBaseLabelTag.Click += new System.EventHandler(this.btnDataBaseLabelTag_Click);
            // 
            // txtSaveDataSQL3
            // 
            this.txtSaveDataSQL3.Location = new System.Drawing.Point(6, 162);
            this.txtSaveDataSQL3.Name = "txtSaveDataSQL3";
            this.txtSaveDataSQL3.Size = new System.Drawing.Size(294, 57);
            this.txtSaveDataSQL3.TabIndex = 6;
            this.txtSaveDataSQL3.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "SQL语句";
            // 
            // rbtnOracle
            // 
            this.rbtnOracle.AutoSize = true;
            this.rbtnOracle.Location = new System.Drawing.Point(247, 43);
            this.rbtnOracle.Name = "rbtnOracle";
            this.rbtnOracle.Size = new System.Drawing.Size(59, 16);
            this.rbtnOracle.TabIndex = 4;
            this.rbtnOracle.Text = "Oracle";
            this.rbtnOracle.UseVisualStyleBackColor = true;
            // 
            // btnSaveDataBaseConfig
            // 
            this.btnSaveDataBaseConfig.Location = new System.Drawing.Point(254, 110);
            this.btnSaveDataBaseConfig.Name = "btnSaveDataBaseConfig";
            this.btnSaveDataBaseConfig.Size = new System.Drawing.Size(46, 23);
            this.btnSaveDataBaseConfig.TabIndex = 4;
            this.btnSaveDataBaseConfig.Text = "测试";
            this.btnSaveDataBaseConfig.UseVisualStyleBackColor = true;
            this.btnSaveDataBaseConfig.Click += new System.EventHandler(this.btnSaveDataBaseConfig_Click);
            // 
            // rbtnMySql
            // 
            this.rbtnMySql.AutoSize = true;
            this.rbtnMySql.Location = new System.Drawing.Point(188, 42);
            this.rbtnMySql.Name = "rbtnMySql";
            this.rbtnMySql.Size = new System.Drawing.Size(53, 16);
            this.rbtnMySql.TabIndex = 4;
            this.rbtnMySql.Text = "MySql";
            this.rbtnMySql.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "数据库连接";
            // 
            // rbtnSqlite
            // 
            this.rbtnSqlite.AutoSize = true;
            this.rbtnSqlite.Checked = true;
            this.rbtnSqlite.Location = new System.Drawing.Point(122, 43);
            this.rbtnSqlite.Name = "rbtnSqlite";
            this.rbtnSqlite.Size = new System.Drawing.Size(59, 16);
            this.rbtnSqlite.TabIndex = 1;
            this.rbtnSqlite.TabStop = true;
            this.rbtnSqlite.Text = "Sqlite";
            this.rbtnSqlite.UseVisualStyleBackColor = true;
            this.rbtnSqlite.CheckedChanged += new System.EventHandler(this.rbtnSqlite_CheckedChanged);
            // 
            // rbtnMsSql
            // 
            this.rbtnMsSql.AutoSize = true;
            this.rbtnMsSql.Location = new System.Drawing.Point(68, 42);
            this.rbtnMsSql.Name = "rbtnMsSql";
            this.rbtnMsSql.Size = new System.Drawing.Size(53, 16);
            this.rbtnMsSql.TabIndex = 1;
            this.rbtnMsSql.Text = "MsSql";
            this.rbtnMsSql.UseVisualStyleBackColor = true;
            // 
            // rbtnAccess
            // 
            this.rbtnAccess.AutoSize = true;
            this.rbtnAccess.Location = new System.Drawing.Point(7, 42);
            this.rbtnAccess.Name = "rbtnAccess";
            this.rbtnAccess.Size = new System.Drawing.Size(59, 16);
            this.rbtnAccess.TabIndex = 1;
            this.rbtnAccess.Text = "Access";
            this.rbtnAccess.UseVisualStyleBackColor = true;
            this.rbtnAccess.CheckedChanged += new System.EventHandler(this.rbtnSqlite_CheckedChanged);
            // 
            // chkPublish03
            // 
            this.chkPublish03.AutoSize = true;
            this.chkPublish03.Location = new System.Drawing.Point(6, 20);
            this.chkPublish03.Name = "chkPublish03";
            this.chkPublish03.Size = new System.Drawing.Size(48, 16);
            this.chkPublish03.TabIndex = 0;
            this.chkPublish03.Text = "启用";
            this.chkPublish03.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox18);
            this.groupBox14.Controls.Add(this.chkPublish02);
            this.groupBox14.Location = new System.Drawing.Point(352, 39);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(350, 179);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "2.保存本地文件";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.txtSaveHtmlTemplate2);
            this.groupBox18.Controls.Add(this.label15);
            this.groupBox18.Controls.Add(this.btnSaveLocalHtmlTemplatePath);
            this.groupBox18.Controls.Add(this.btnSaveLocalPath);
            this.groupBox18.Controls.Add(this.txtSaveDirectory2);
            this.groupBox18.Controls.Add(this.label14);
            this.groupBox18.Controls.Add(this.ddlSaveFileFormat2);
            this.groupBox18.Controls.Add(this.label13);
            this.groupBox18.Location = new System.Drawing.Point(6, 42);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(306, 105);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            // 
            // txtSaveHtmlTemplate2
            // 
            this.txtSaveHtmlTemplate2.Enabled = false;
            this.txtSaveHtmlTemplate2.Location = new System.Drawing.Point(87, 77);
            this.txtSaveHtmlTemplate2.Name = "txtSaveHtmlTemplate2";
            this.txtSaveHtmlTemplate2.Size = new System.Drawing.Size(159, 21);
            this.txtSaveHtmlTemplate2.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "模板";
            // 
            // btnSaveLocalHtmlTemplatePath
            // 
            this.btnSaveLocalHtmlTemplatePath.Enabled = false;
            this.btnSaveLocalHtmlTemplatePath.Location = new System.Drawing.Point(250, 76);
            this.btnSaveLocalHtmlTemplatePath.Name = "btnSaveLocalHtmlTemplatePath";
            this.btnSaveLocalHtmlTemplatePath.Size = new System.Drawing.Size(32, 23);
            this.btnSaveLocalHtmlTemplatePath.TabIndex = 4;
            this.btnSaveLocalHtmlTemplatePath.Text = "...";
            this.btnSaveLocalHtmlTemplatePath.UseVisualStyleBackColor = true;
            this.btnSaveLocalHtmlTemplatePath.Click += new System.EventHandler(this.btnSaveLocalHtmlTemplatePath_Click);
            // 
            // btnSaveLocalPath
            // 
            this.btnSaveLocalPath.Location = new System.Drawing.Point(250, 43);
            this.btnSaveLocalPath.Name = "btnSaveLocalPath";
            this.btnSaveLocalPath.Size = new System.Drawing.Size(32, 23);
            this.btnSaveLocalPath.TabIndex = 4;
            this.btnSaveLocalPath.Text = "...";
            this.btnSaveLocalPath.UseVisualStyleBackColor = true;
            this.btnSaveLocalPath.Click += new System.EventHandler(this.btnSaveLocalPath_Click);
            // 
            // txtSaveDirectory2
            // 
            this.txtSaveDirectory2.Location = new System.Drawing.Point(87, 45);
            this.txtSaveDirectory2.Name = "txtSaveDirectory2";
            this.txtSaveDirectory2.Size = new System.Drawing.Size(159, 21);
            this.txtSaveDirectory2.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "保存位置";
            // 
            // ddlSaveFileFormat2
            // 
            this.ddlSaveFileFormat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSaveFileFormat2.FormattingEnabled = true;
            this.ddlSaveFileFormat2.Items.AddRange(new object[] {
            ".Txt",
            ".Html",
            ".Sql",
            ".xlsx"});
            this.ddlSaveFileFormat2.Location = new System.Drawing.Point(87, 17);
            this.ddlSaveFileFormat2.Name = "ddlSaveFileFormat2";
            this.ddlSaveFileFormat2.Size = new System.Drawing.Size(121, 20);
            this.ddlSaveFileFormat2.TabIndex = 1;
            this.ddlSaveFileFormat2.SelectedIndexChanged += new System.EventHandler(this.ddlSaveLocalFileFormat_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "保存文件格式";
            // 
            // chkPublish02
            // 
            this.chkPublish02.AutoSize = true;
            this.chkPublish02.Location = new System.Drawing.Point(6, 20);
            this.chkPublish02.Name = "chkPublish02";
            this.chkPublish02.Size = new System.Drawing.Size(48, 16);
            this.chkPublish02.TabIndex = 0;
            this.chkPublish02.Text = "启用";
            this.chkPublish02.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnWebModuleDelete);
            this.groupBox9.Controls.Add(this.btnWebModuleEdit);
            this.groupBox9.Controls.Add(this.btnWebModuleAdd);
            this.groupBox9.Controls.Add(this.listViewWebModule);
            this.groupBox9.Controls.Add(this.chkPublish01);
            this.groupBox9.Location = new System.Drawing.Point(13, 39);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(306, 179);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "1.Web模块在线发布";
            // 
            // btnWebModuleDelete
            // 
            this.btnWebModuleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebModuleDelete.Location = new System.Drawing.Point(258, 16);
            this.btnWebModuleDelete.Name = "btnWebModuleDelete";
            this.btnWebModuleDelete.Size = new System.Drawing.Size(42, 23);
            this.btnWebModuleDelete.TabIndex = 2;
            this.btnWebModuleDelete.Text = "删除";
            this.btnWebModuleDelete.UseVisualStyleBackColor = true;
            this.btnWebModuleDelete.Click += new System.EventHandler(this.btnWebModuleDelete_Click);
            // 
            // btnWebModuleEdit
            // 
            this.btnWebModuleEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebModuleEdit.Location = new System.Drawing.Point(212, 17);
            this.btnWebModuleEdit.Name = "btnWebModuleEdit";
            this.btnWebModuleEdit.Size = new System.Drawing.Size(42, 23);
            this.btnWebModuleEdit.TabIndex = 2;
            this.btnWebModuleEdit.Text = "修改";
            this.btnWebModuleEdit.UseVisualStyleBackColor = true;
            this.btnWebModuleEdit.Click += new System.EventHandler(this.btnWebModuleEdit_Click);
            // 
            // btnWebModuleAdd
            // 
            this.btnWebModuleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebModuleAdd.Location = new System.Drawing.Point(167, 16);
            this.btnWebModuleAdd.Name = "btnWebModuleAdd";
            this.btnWebModuleAdd.Size = new System.Drawing.Size(42, 23);
            this.btnWebModuleAdd.TabIndex = 2;
            this.btnWebModuleAdd.Text = "添加";
            this.btnWebModuleAdd.UseVisualStyleBackColor = true;
            this.btnWebModuleAdd.Click += new System.EventHandler(this.btnWebModuleAdd_Click);
            // 
            // listViewWebModule
            // 
            this.listViewWebModule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewWebModule.FullRowSelect = true;
            this.listViewWebModule.GridLines = true;
            this.listViewWebModule.Location = new System.Drawing.Point(7, 44);
            this.listViewWebModule.Name = "listViewWebModule";
            this.listViewWebModule.Size = new System.Drawing.Size(293, 129);
            this.listViewWebModule.TabIndex = 1;
            this.listViewWebModule.UseCompatibleStateImageBehavior = false;
            this.listViewWebModule.View = System.Windows.Forms.View.Details;
            this.listViewWebModule.DoubleClick += new System.EventHandler(this.listViewWebModule_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "网站发布配置";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "分类ID";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "分类名称";
            this.columnHeader6.Width = 143;
            // 
            // chkPublish01
            // 
            this.chkPublish01.AutoSize = true;
            this.chkPublish01.Location = new System.Drawing.Point(6, 20);
            this.chkPublish01.Name = "chkPublish01";
            this.chkPublish01.Size = new System.Drawing.Size(48, 16);
            this.chkPublish01.TabIndex = 0;
            this.chkPublish01.Text = "启用";
            this.chkPublish01.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.groupBox12);
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(749, 454);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "高级部分";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetCookies);
            this.groupBox5.Controls.Add(this.txtCollectionCookies);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(369, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(363, 111);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "登录设置";
            // 
            // btnGetCookies
            // 
            this.btnGetCookies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetCookies.Location = new System.Drawing.Point(13, 68);
            this.btnGetCookies.Name = "btnGetCookies";
            this.btnGetCookies.Size = new System.Drawing.Size(60, 23);
            this.btnGetCookies.TabIndex = 2;
            this.btnGetCookies.Text = "登录";
            this.btnGetCookies.UseVisualStyleBackColor = true;
            this.btnGetCookies.Click += new System.EventHandler(this.btnGetCookies_Click);
            // 
            // txtCollectionCookies
            // 
            this.txtCollectionCookies.Location = new System.Drawing.Point(85, 21);
            this.txtCollectionCookies.Multiline = true;
            this.txtCollectionCookies.Name = "txtCollectionCookies";
            this.txtCollectionCookies.Size = new System.Drawing.Size(272, 75);
            this.txtCollectionCookies.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "采集需要Cookies";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtHiddenPlanFormat);
            this.groupBox8.Controls.Add(this.chkTaskSetStatus);
            this.groupBox8.Controls.Add(this.btnTaskSet);
            this.groupBox8.Controls.Add(this.txtTaskSetFormat);
            this.groupBox8.Location = new System.Drawing.Point(369, 136);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(363, 90);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "计划任务";
            // 
            // txtHiddenPlanFormat
            // 
            this.txtHiddenPlanFormat.Location = new System.Drawing.Point(257, 42);
            this.txtHiddenPlanFormat.Name = "txtHiddenPlanFormat";
            this.txtHiddenPlanFormat.Size = new System.Drawing.Size(24, 21);
            this.txtHiddenPlanFormat.TabIndex = 3;
            // 
            // chkTaskSetStatus
            // 
            this.chkTaskSetStatus.AutoSize = true;
            this.chkTaskSetStatus.Location = new System.Drawing.Point(303, 25);
            this.chkTaskSetStatus.Name = "chkTaskSetStatus";
            this.chkTaskSetStatus.Size = new System.Drawing.Size(48, 16);
            this.chkTaskSetStatus.TabIndex = 2;
            this.chkTaskSetStatus.Text = "启用";
            this.chkTaskSetStatus.UseVisualStyleBackColor = true;
            // 
            // btnTaskSet
            // 
            this.btnTaskSet.Location = new System.Drawing.Point(302, 52);
            this.btnTaskSet.Name = "btnTaskSet";
            this.btnTaskSet.Size = new System.Drawing.Size(48, 23);
            this.btnTaskSet.TabIndex = 1;
            this.btnTaskSet.Text = "设置";
            this.btnTaskSet.UseVisualStyleBackColor = true;
            this.btnTaskSet.Click += new System.EventHandler(this.btnTaskSet_Click);
            // 
            // txtTaskSetFormat
            // 
            this.txtTaskSetFormat.Location = new System.Drawing.Point(10, 20);
            this.txtTaskSetFormat.Multiline = true;
            this.txtTaskSetFormat.Name = "txtTaskSetFormat";
            this.txtTaskSetFormat.ReadOnly = true;
            this.txtTaskSetFormat.Size = new System.Drawing.Size(285, 55);
            this.txtTaskSetFormat.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numFtpPort);
            this.groupBox12.Controls.Add(this.chkFtpStatus);
            this.groupBox12.Controls.Add(this.txtFtpRemoteDir);
            this.groupBox12.Controls.Add(this.label26);
            this.groupBox12.Controls.Add(this.label25);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.txtFtpUserPwd);
            this.groupBox12.Controls.Add(this.txtFtpUserName);
            this.groupBox12.Controls.Add(this.txtFtpIp);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Location = new System.Drawing.Point(12, 236);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(337, 179);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "数据发布完成时Ftp设置";
            // 
            // numFtpPort
            // 
            this.numFtpPort.Location = new System.Drawing.Point(70, 105);
            this.numFtpPort.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numFtpPort.Name = "numFtpPort";
            this.numFtpPort.Size = new System.Drawing.Size(51, 21);
            this.numFtpPort.TabIndex = 7;
            this.numFtpPort.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // chkFtpStatus
            // 
            this.chkFtpStatus.AutoSize = true;
            this.chkFtpStatus.Location = new System.Drawing.Point(195, 110);
            this.chkFtpStatus.Name = "chkFtpStatus";
            this.chkFtpStatus.Size = new System.Drawing.Size(90, 16);
            this.chkFtpStatus.TabIndex = 6;
            this.chkFtpStatus.Text = "启用Ftp设置";
            this.chkFtpStatus.UseVisualStyleBackColor = true;
            // 
            // txtFtpRemoteDir
            // 
            this.txtFtpRemoteDir.Location = new System.Drawing.Point(109, 137);
            this.txtFtpRemoteDir.Name = "txtFtpRemoteDir";
            this.txtFtpRemoteDir.Size = new System.Drawing.Size(149, 21);
            this.txtFtpRemoteDir.TabIndex = 5;
            this.txtFtpRemoteDir.Text = "/";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 140);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 12);
            this.label26.TabIndex = 4;
            this.label26.Text = "文件上传根目录";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 3;
            this.label25.Text = "端口";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 77);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 3;
            this.label24.Text = "密码";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 3;
            this.label23.Text = "用户";
            // 
            // txtFtpUserPwd
            // 
            this.txtFtpUserPwd.Location = new System.Drawing.Point(70, 77);
            this.txtFtpUserPwd.Name = "txtFtpUserPwd";
            this.txtFtpUserPwd.Size = new System.Drawing.Size(100, 21);
            this.txtFtpUserPwd.TabIndex = 2;
            this.txtFtpUserPwd.Text = "test";
            // 
            // txtFtpUserName
            // 
            this.txtFtpUserName.Location = new System.Drawing.Point(70, 50);
            this.txtFtpUserName.Name = "txtFtpUserName";
            this.txtFtpUserName.Size = new System.Drawing.Size(100, 21);
            this.txtFtpUserName.TabIndex = 2;
            this.txtFtpUserName.Text = "test";
            // 
            // txtFtpIp
            // 
            this.txtFtpIp.Location = new System.Drawing.Point(70, 23);
            this.txtFtpIp.Name = "txtFtpIp";
            this.txtFtpIp.Size = new System.Drawing.Size(227, 21);
            this.txtFtpIp.TabIndex = 1;
            this.txtFtpIp.Text = "192.168.1.100";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "IP";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.nudPublishContentStepTimeMax);
            this.groupBox10.Controls.Add(this.nudPublishContentStepTimeMin);
            this.groupBox10.Controls.Add(this.nudCollectionContentStepTime);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.nudPublishContentThreadCount);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.nudCollectionUrlStepTime);
            this.groupBox10.Controls.Add(this.label37);
            this.groupBox10.Controls.Add(this.nudCollectionContentThreadCount);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Location = new System.Drawing.Point(12, 14);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(337, 212);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "任务运行设置";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(198, 160);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 12);
            this.label34.TabIndex = 2;
            this.label34.Text = "随机值";
            // 
            // nudPublishContentStepTimeMax
            // 
            this.nudPublishContentStepTimeMax.Location = new System.Drawing.Point(106, 156);
            this.nudPublishContentStepTimeMax.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudPublishContentStepTimeMax.Name = "nudPublishContentStepTimeMax";
            this.nudPublishContentStepTimeMax.Size = new System.Drawing.Size(69, 21);
            this.nudPublishContentStepTimeMax.TabIndex = 1;
            this.nudPublishContentStepTimeMax.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // nudPublishContentStepTimeMin
            // 
            this.nudPublishContentStepTimeMin.Location = new System.Drawing.Point(106, 129);
            this.nudPublishContentStepTimeMin.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudPublishContentStepTimeMin.Name = "nudPublishContentStepTimeMin";
            this.nudPublishContentStepTimeMin.Size = new System.Drawing.Size(69, 21);
            this.nudPublishContentStepTimeMin.TabIndex = 1;
            this.nudPublishContentStepTimeMin.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudCollectionContentStepTime
            // 
            this.nudCollectionContentStepTime.Location = new System.Drawing.Point(106, 75);
            this.nudCollectionContentStepTime.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudCollectionContentStepTime.Name = "nudCollectionContentStepTime";
            this.nudCollectionContentStepTime.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionContentStepTime.TabIndex = 1;
            this.nudCollectionContentStepTime.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 131);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(77, 12);
            this.label32.TabIndex = 0;
            this.label32.Text = "发布内容间隔";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 77);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "采集内容间隔";
            // 
            // nudPublishContentThreadCount
            // 
            this.nudPublishContentThreadCount.Location = new System.Drawing.Point(106, 102);
            this.nudPublishContentThreadCount.Name = "nudPublishContentThreadCount";
            this.nudPublishContentThreadCount.Size = new System.Drawing.Size(69, 21);
            this.nudPublishContentThreadCount.TabIndex = 1;
            this.nudPublishContentThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "发布内容线程";
            // 
            // nudCollectionUrlStepTime
            // 
            this.nudCollectionUrlStepTime.Location = new System.Drawing.Point(106, 20);
            this.nudCollectionUrlStepTime.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudCollectionUrlStepTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCollectionUrlStepTime.Name = "nudCollectionUrlStepTime";
            this.nudCollectionUrlStepTime.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionUrlStepTime.TabIndex = 1;
            this.nudCollectionUrlStepTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(12, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 12);
            this.label37.TabIndex = 0;
            this.label37.Text = "采集地址间隔";
            // 
            // nudCollectionContentThreadCount
            // 
            this.nudCollectionContentThreadCount.Location = new System.Drawing.Point(106, 48);
            this.nudCollectionContentThreadCount.Name = "nudCollectionContentThreadCount";
            this.nudCollectionContentThreadCount.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionContentThreadCount.TabIndex = 1;
            this.nudCollectionContentThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 50);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "采集内容线程";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox17);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(749, 454);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "测试数据";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.treeViewUrlTest);
            this.groupBox17.Location = new System.Drawing.Point(14, 16);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(728, 396);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "测试数据采集";
            // 
            // treeViewUrlTest
            // 
            this.treeViewUrlTest.LabelEdit = true;
            this.treeViewUrlTest.Location = new System.Drawing.Point(6, 20);
            this.treeViewUrlTest.Name = "treeViewUrlTest";
            this.treeViewUrlTest.Size = new System.Drawing.Size(716, 370);
            this.treeViewUrlTest.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(573, 515);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(675, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(305, 515);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "0";
            this.txtID.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtOldTaskName
            // 
            this.txtOldTaskName.Location = new System.Drawing.Point(76, 515);
            this.txtOldTaskName.Name = "txtOldTaskName";
            this.txtOldTaskName.Size = new System.Drawing.Size(183, 21);
            this.txtOldTaskName.TabIndex = 8;
            this.txtOldTaskName.Visible = false;
            // 
            // contextMenuStrip_Label
            // 
            this.contextMenuStrip_Label.Name = "contextMenuStrip_Label";
            this.contextMenuStrip_Label.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "状态";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "正常",
            "关闭"});
            this.cmbStatus.Location = new System.Drawing.Point(439, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(70, 20);
            this.cmbStatus.TabIndex = 10;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.panel_List1);
            this.groupBox11.Location = new System.Drawing.Point(0, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(736, 116);
            this.groupBox11.TabIndex = 15;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "列表页规则";
            // 
            // FrmTaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 542);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOldTaskName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tabControlTaskEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSiteClassID);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FrmTaskEdit";
            this.Text = "添加任务";
            this.Load += new System.EventHandler(this.FrmTaskEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlTaskEdit.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel_List1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpPort)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentStepTimeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentStepTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentStepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentThreadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionUrlStepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentThreadCount)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSiteClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIsPublishContent;
        private System.Windows.Forms.CheckBox chkIsSpiderContent;
        private System.Windows.Forms.CheckBox chkIsSpiderUrl;
        private System.Windows.Forms.TabControl tabControlTaskEdit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlItemEncode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxLinkUrl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listViewTaskLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCutLabelDel;
        private System.Windows.Forms.Button btnCutLabelEdit;
        private System.Windows.Forms.Button btnCutLabelAdd;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox txtTextViewUrl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTestViewUrl;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TreeView treeViewUrlTest;
        private System.Windows.Forms.Button txtLinkUrlDelete;
        private System.Windows.Forms.Button btnLinkUrlEdit;
        private System.Windows.Forms.Button btnLinkUrlTest;
        private V5RichTextBox txtTestViewUrlShow;
        private System.Windows.Forms.CheckBox chkPublish01;
        private System.Windows.Forms.CheckBox chkPublish04;
        private System.Windows.Forms.CheckBox chkPublish03;
        private System.Windows.Forms.CheckBox chkPublish02;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddlSaveFileFormat2;
        private System.Windows.Forms.Button btnSaveLocalPath;
        private System.Windows.Forms.TextBox txtSaveDirectory2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSaveHtmlTemplate2;
        private System.Windows.Forms.Button btnSaveLocalHtmlTemplatePath;
        private System.Windows.Forms.RadioButton rbtnSqlite;
        private System.Windows.Forms.RadioButton rbtnMsSql;
        private System.Windows.Forms.RadioButton rbtnAccess;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbtnMySql;
        private System.Windows.Forms.RadioButton rbtnOracle;
        private System.Windows.Forms.Label label18;
        private V5RichTextBox txtSaveDataSQL3;
        private System.Windows.Forms.ListView listViewWebModule;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSaveDataBaseConfig;
        private V5RichTextBox txtLinkUrlCutAreaStart;
        private V5RichTextBox txtLinkUrlCutAreaEnd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnWebModuleDelete;
        private System.Windows.Forms.Button btnWebModuleAdd;
        private System.Windows.Forms.Button btnWebModuleEdit;
        private System.Windows.Forms.Button btnLabelDown;
        private System.Windows.Forms.Button btnLabelUp;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtFtpIp;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtFtpUserName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtFtpUserPwd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtFtpRemoteDir;
        private System.Windows.Forms.TextBox txtCollectionCookies;
        private System.Windows.Forms.Button btnGetCookies;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDemoListUrl;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox chkFtpStatus;
        private System.Windows.Forms.NumericUpDown nudPublishContentStepTimeMin;
        private System.Windows.Forms.NumericUpDown nudCollectionContentStepTime;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown nudPublishContentThreadCount;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown nudCollectionContentThreadCount;
        private System.Windows.Forms.NumericUpDown numFtpPort;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown nudPublishContentStepTimeMax;
        private System.Windows.Forms.Button btnWizardEdit;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.CheckBox chkIsHandGetUrl;
        private System.Windows.Forms.Label label36;
        private V5RichTextBox txtHandCollectionUrlRegex;
        private V5LinkLabel v5LinkLabel1;
        private V5LinkLabel v5LinkLabel2;
        private V5LinkLabel v5LinkLabel3;
        private V5LinkLabel v5LinkLabel4;
        private V5RichTextBox txtLinkUrlMustIncludeStr;
        private V5LinkLabel v5LinkLabel5;
        private V5RichTextBox txtLinkUrlNoMustIncludeStr;
        private V5LinkLabel v5LinkLabel6;
        private System.Windows.Forms.Button btnTaskLabelCopy;
        private System.Windows.Forms.TextBox txtOldTaskName;
        private System.Windows.Forms.Button btnDataBaseLabelTag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtTaskSetFormat;
        private System.Windows.Forms.Button btnTaskSet;
        private System.Windows.Forms.CheckBox chkTaskSetStatus;
        private System.Windows.Forms.ListView listView_DiyUrlWeb;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnDiyWebUrlDelete;
        private System.Windows.Forms.Button btnDiyWebUrlEdit;
        private System.Windows.Forms.Button btnDiyWebUrlAdd;
        private System.Windows.Forms.TextBox txtHiddenPlanFormat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox txtSaveDataUrl3;
        private System.Windows.Forms.CheckBox chkIsSource;
        private System.Windows.Forms.Panel panel_List1;
        private System.Windows.Forms.ComboBox cmbSpiderUrlPlugins;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkSpiderListPlugin;
        private System.Windows.Forms.NumericUpDown nudCollectionUrlStepTime;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cmbSaveConentPlugins;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox cmbPublishContentPlugins;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private V5LinkLabel v5LinkLabel7;
        private V5LinkLabel v5LinkLabel8;
        private System.Windows.Forms.Button btnChooseDbPath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtChooseSavePath;
        private System.Windows.Forms.Button btnChooseSavePath;
        private System.Windows.Forms.GroupBox groupBox11;
    }
}