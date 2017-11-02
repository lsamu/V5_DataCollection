using V5_WinControls;

namespace V5_DataCollection.Forms.Task
{
    partial class frmTaskSpiderLabel
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel6 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLabelNameCutRegex = new V5_WinControls.V5RichTextBox();
            this.v5LinkLabel5 = new V5_WinControls.V5LinkLabel(this.components);
            this.chkLabelIsLoop = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkhref = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.chkScript = new System.Windows.Forms.CheckBox();
            this.chkFont = new System.Windows.Forms.CheckBox();
            this.chkTable = new System.Windows.Forms.CheckBox();
            this.chkAllHtml = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDownResourceExt = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.chkDownResource = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnContentRemoveDel = new System.Windows.Forms.Button();
            this.btnContentRemoveEdit = new System.Windows.Forms.Button();
            this.btnContentRemoveAdd = new System.Windows.Forms.Button();
            this.listViewContentRemove = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnContentReplaceDel = new System.Windows.Forms.Button();
            this.listViewContentReplace = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnContentReplaceEdit = new System.Windows.Forms.Button();
            this.btnContentReplaceAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTestUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSpiderPlugin = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtLogView = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(339, 462);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 21);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "0";
            this.txtID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.v5LinkLabel6);
            this.groupBox2.Controls.Add(this.v5LinkLabel5);
            this.groupBox2.Controls.Add(this.chkLabelIsLoop);
            this.groupBox2.Controls.Add(this.txtLabelNameCutRegex);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "截取";
            // 
            // v5LinkLabel6
            // 
            this.v5LinkLabel6.AutoSize = true;
            this.v5LinkLabel6.LabelValue = "(*)";
            this.v5LinkLabel6.Location = new System.Drawing.Point(652, 41);
            this.v5LinkLabel6.Name = "v5LinkLabel6";
            this.v5LinkLabel6.RichTextBox = this.txtLabelNameCutRegex;
            this.v5LinkLabel6.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel6.TabIndex = 12;
            this.v5LinkLabel6.TabStop = true;
            this.v5LinkLabel6.Text = "(*)";
            // 
            // txtLabelNameCutRegex
            // 
            this.txtLabelNameCutRegex.Location = new System.Drawing.Point(65, 16);
            this.txtLabelNameCutRegex.Name = "txtLabelNameCutRegex";
            this.txtLabelNameCutRegex.Size = new System.Drawing.Size(583, 71);
            this.txtLabelNameCutRegex.TabIndex = 10;
            this.txtLabelNameCutRegex.Text = "";
            // 
            // v5LinkLabel5
            // 
            this.v5LinkLabel5.AutoSize = true;
            this.v5LinkLabel5.LabelValue = "[参数]";
            this.v5LinkLabel5.Location = new System.Drawing.Point(650, 17);
            this.v5LinkLabel5.Name = "v5LinkLabel5";
            this.v5LinkLabel5.RichTextBox = this.txtLabelNameCutRegex;
            this.v5LinkLabel5.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel5.TabIndex = 11;
            this.v5LinkLabel5.TabStop = true;
            this.v5LinkLabel5.Text = "[参数]";
            // 
            // chkLabelIsLoop
            // 
            this.chkLabelIsLoop.AutoSize = true;
            this.chkLabelIsLoop.Location = new System.Drawing.Point(11, 58);
            this.chkLabelIsLoop.Name = "chkLabelIsLoop";
            this.chkLabelIsLoop.Size = new System.Drawing.Size(48, 16);
            this.chkLabelIsLoop.TabIndex = 3;
            this.chkLabelIsLoop.Text = "循环";
            this.chkLabelIsLoop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "标签表达式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkhref);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.chkScript);
            this.groupBox3.Controls.Add(this.chkFont);
            this.groupBox3.Controls.Add(this.chkTable);
            this.groupBox3.Controls.Add(this.chkAllHtml);
            this.groupBox3.Location = new System.Drawing.Point(6, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Html标签排除";
            // 
            // chkhref
            // 
            this.chkhref.AutoSize = true;
            this.chkhref.Checked = true;
            this.chkhref.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkhref.Location = new System.Drawing.Point(241, 19);
            this.chkhref.Name = "chkhref";
            this.chkhref.Size = new System.Drawing.Size(30, 16);
            this.chkhref.TabIndex = 4;
            this.chkhref.Text = "A";
            this.chkhref.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(111, 41);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 16);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "p";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // chkScript
            // 
            this.chkScript.AutoSize = true;
            this.chkScript.Checked = true;
            this.chkScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScript.Location = new System.Drawing.Point(111, 18);
            this.chkScript.Name = "chkScript";
            this.chkScript.Size = new System.Drawing.Size(60, 16);
            this.chkScript.TabIndex = 4;
            this.chkScript.Text = "script";
            this.chkScript.UseVisualStyleBackColor = true;
            // 
            // chkFont
            // 
            this.chkFont.AutoSize = true;
            this.chkFont.Location = new System.Drawing.Point(11, 41);
            this.chkFont.Name = "chkFont";
            this.chkFont.Size = new System.Drawing.Size(84, 16);
            this.chkFont.TabIndex = 2;
            this.chkFont.Text = "font<span>";
            this.chkFont.UseVisualStyleBackColor = true;
            // 
            // chkTable
            // 
            this.chkTable.AutoSize = true;
            this.chkTable.Location = new System.Drawing.Point(11, 19);
            this.chkTable.Name = "chkTable";
            this.chkTable.Size = new System.Drawing.Size(54, 16);
            this.chkTable.TabIndex = 1;
            this.chkTable.Text = "Table";
            this.chkTable.UseVisualStyleBackColor = true;
            // 
            // chkAllHtml
            // 
            this.chkAllHtml.AutoSize = true;
            this.chkAllHtml.Location = new System.Drawing.Point(241, 42);
            this.chkAllHtml.Name = "chkAllHtml";
            this.chkAllHtml.Size = new System.Drawing.Size(48, 16);
            this.chkAllHtml.TabIndex = 0;
            this.chkAllHtml.Text = "所有";
            this.chkAllHtml.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDownResourceExt);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.chkDownResource);
            this.groupBox4.Location = new System.Drawing.Point(359, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 65);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "下载选项";
            // 
            // txtDownResourceExt
            // 
            this.txtDownResourceExt.Location = new System.Drawing.Point(171, 18);
            this.txtDownResourceExt.Multiline = true;
            this.txtDownResourceExt.Name = "txtDownResourceExt";
            this.txtDownResourceExt.Size = new System.Drawing.Size(163, 43);
            this.txtDownResourceExt.TabIndex = 5;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(161, 12);
            this.label33.TabIndex = 4;
            this.label33.Text = "下载文件后缀;分开,留空全下";
            // 
            // chkDownResource
            // 
            this.chkDownResource.AutoSize = true;
            this.chkDownResource.Location = new System.Drawing.Point(11, 18);
            this.chkDownResource.Name = "chkDownResource";
            this.chkDownResource.Size = new System.Drawing.Size(96, 16);
            this.chkDownResource.TabIndex = 2;
            this.chkDownResource.Text = "下载图片资源";
            this.chkDownResource.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnContentRemoveDel);
            this.groupBox5.Controls.Add(this.btnContentRemoveEdit);
            this.groupBox5.Controls.Add(this.btnContentRemoveAdd);
            this.groupBox5.Controls.Add(this.listViewContentRemove);
            this.groupBox5.Location = new System.Drawing.Point(6, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 110);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "内容排除";
            // 
            // btnContentRemoveDel
            // 
            this.btnContentRemoveDel.Location = new System.Drawing.Point(15, 81);
            this.btnContentRemoveDel.Name = "btnContentRemoveDel";
            this.btnContentRemoveDel.Size = new System.Drawing.Size(50, 23);
            this.btnContentRemoveDel.TabIndex = 1;
            this.btnContentRemoveDel.Text = "删除";
            this.btnContentRemoveDel.UseVisualStyleBackColor = true;
            this.btnContentRemoveDel.Click += new System.EventHandler(this.btnContentRemoveDel_Click);
            // 
            // btnContentRemoveEdit
            // 
            this.btnContentRemoveEdit.Location = new System.Drawing.Point(15, 51);
            this.btnContentRemoveEdit.Name = "btnContentRemoveEdit";
            this.btnContentRemoveEdit.Size = new System.Drawing.Size(50, 23);
            this.btnContentRemoveEdit.TabIndex = 1;
            this.btnContentRemoveEdit.Text = "修改";
            this.btnContentRemoveEdit.UseVisualStyleBackColor = true;
            this.btnContentRemoveEdit.Click += new System.EventHandler(this.btnContentRemoveEdit_Click);
            // 
            // btnContentRemoveAdd
            // 
            this.btnContentRemoveAdd.Location = new System.Drawing.Point(15, 21);
            this.btnContentRemoveAdd.Name = "btnContentRemoveAdd";
            this.btnContentRemoveAdd.Size = new System.Drawing.Size(50, 23);
            this.btnContentRemoveAdd.TabIndex = 1;
            this.btnContentRemoveAdd.Text = "添加";
            this.btnContentRemoveAdd.UseVisualStyleBackColor = true;
            this.btnContentRemoveAdd.Click += new System.EventHandler(this.btnContentRemoveAdd_Click);
            // 
            // listViewContentRemove
            // 
            this.listViewContentRemove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.listViewContentRemove.FullRowSelect = true;
            this.listViewContentRemove.GridLines = true;
            this.listViewContentRemove.Location = new System.Drawing.Point(71, 17);
            this.listViewContentRemove.MultiSelect = false;
            this.listViewContentRemove.Name = "listViewContentRemove";
            this.listViewContentRemove.Size = new System.Drawing.Size(260, 85);
            this.listViewContentRemove.TabIndex = 0;
            this.listViewContentRemove.UseCompatibleStateImageBehavior = false;
            this.listViewContentRemove.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "字符串";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "过滤整个标签";
            this.columnHeader4.Width = 90;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnContentReplaceDel);
            this.groupBox6.Controls.Add(this.listViewContentReplace);
            this.groupBox6.Controls.Add(this.btnContentReplaceEdit);
            this.groupBox6.Controls.Add(this.btnContentReplaceAdd);
            this.groupBox6.Location = new System.Drawing.Point(359, 229);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 110);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "内容替换";
            // 
            // btnContentReplaceDel
            // 
            this.btnContentReplaceDel.Location = new System.Drawing.Point(16, 80);
            this.btnContentReplaceDel.Name = "btnContentReplaceDel";
            this.btnContentReplaceDel.Size = new System.Drawing.Size(50, 23);
            this.btnContentReplaceDel.TabIndex = 1;
            this.btnContentReplaceDel.Text = "删除";
            this.btnContentReplaceDel.UseVisualStyleBackColor = true;
            this.btnContentReplaceDel.Click += new System.EventHandler(this.btnContentReplaceDel_Click);
            // 
            // listViewContentReplace
            // 
            this.listViewContentReplace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listViewContentReplace.FullRowSelect = true;
            this.listViewContentReplace.GridLines = true;
            this.listViewContentReplace.Location = new System.Drawing.Point(71, 18);
            this.listViewContentReplace.MultiSelect = false;
            this.listViewContentReplace.Name = "listViewContentReplace";
            this.listViewContentReplace.Size = new System.Drawing.Size(260, 85);
            this.listViewContentReplace.TabIndex = 0;
            this.listViewContentReplace.UseCompatibleStateImageBehavior = false;
            this.listViewContentReplace.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "原字符串";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "替换后字符串";
            this.columnHeader3.Width = 125;
            // 
            // btnContentReplaceEdit
            // 
            this.btnContentReplaceEdit.Location = new System.Drawing.Point(15, 50);
            this.btnContentReplaceEdit.Name = "btnContentReplaceEdit";
            this.btnContentReplaceEdit.Size = new System.Drawing.Size(50, 23);
            this.btnContentReplaceEdit.TabIndex = 1;
            this.btnContentReplaceEdit.Text = "修改";
            this.btnContentReplaceEdit.UseVisualStyleBackColor = true;
            this.btnContentReplaceEdit.Click += new System.EventHandler(this.btnContentReplaceEdit_Click);
            // 
            // btnContentReplaceAdd
            // 
            this.btnContentReplaceAdd.Location = new System.Drawing.Point(16, 21);
            this.btnContentReplaceAdd.Name = "btnContentReplaceAdd";
            this.btnContentReplaceAdd.Size = new System.Drawing.Size(50, 23);
            this.btnContentReplaceAdd.TabIndex = 1;
            this.btnContentReplaceAdd.Text = "添加";
            this.btnContentReplaceAdd.UseVisualStyleBackColor = true;
            this.btnContentReplaceAdd.Click += new System.EventHandler(this.btnContentReplaceAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(536, 459);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(621, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标签名称";
            // 
            // txtLabelName
            // 
            this.txtLabelName.Location = new System.Drawing.Point(65, 13);
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.Size = new System.Drawing.Size(159, 21);
            this.txtLabelName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTestUrl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLabelName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本配置";
            // 
            // txtTestUrl
            // 
            this.txtTestUrl.Location = new System.Drawing.Point(291, 13);
            this.txtTestUrl.Name = "txtTestUrl";
            this.txtTestUrl.Size = new System.Drawing.Size(393, 21);
            this.txtTestUrl.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "测试地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "插件:";
            // 
            // cmbSpiderPlugin
            // 
            this.cmbSpiderPlugin.FormattingEnabled = true;
            this.cmbSpiderPlugin.Location = new System.Drawing.Point(49, 463);
            this.cmbSpiderPlugin.Name = "cmbSpiderPlugin";
            this.cmbSpiderPlugin.Size = new System.Drawing.Size(169, 20);
            this.cmbSpiderPlugin.TabIndex = 10;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtLogView);
            this.groupBox10.Location = new System.Drawing.Point(6, 343);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(693, 110);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "日志";
            // 
            // txtLogView
            // 
            this.txtLogView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogView.Location = new System.Drawing.Point(3, 17);
            this.txtLogView.MaxLength = 0;
            this.txtLogView.Multiline = true;
            this.txtLogView.Name = "txtLogView";
            this.txtLogView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogView.Size = new System.Drawing.Size(687, 90);
            this.txtLogView.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(448, 459);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(224, 468);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "编辑";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmTaskSpiderLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 492);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.cmbSpiderPlugin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTaskSpiderLabel";
            this.Text = "内容页标签编辑";
            this.Load += new System.EventHandler(this.frmTaskSpiderLabel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listViewContentRemove;
        private System.Windows.Forms.ListView listViewContentReplace;
        private System.Windows.Forms.Button btnContentRemoveDel;
        private System.Windows.Forms.Button btnContentRemoveEdit;
        private System.Windows.Forms.Button btnContentRemoveAdd;
        private System.Windows.Forms.Button btnContentReplaceDel;
        private System.Windows.Forms.Button btnContentReplaceEdit;
        private System.Windows.Forms.Button btnContentReplaceAdd;
        private System.Windows.Forms.CheckBox chkAllHtml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox chkTable;
        private System.Windows.Forms.CheckBox chkFont;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkScript;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox chkhref;
        private System.Windows.Forms.CheckBox chkDownResource;
        private System.Windows.Forms.TextBox txtDownResourceExt;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLabelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLabelIsLoop;
        private V5LinkLabel v5LinkLabel6;
        private V5RichTextBox txtLabelNameCutRegex;
        private V5LinkLabel v5LinkLabel5;
        private System.Windows.Forms.ComboBox cmbSpiderPlugin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTestUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtLogView;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}