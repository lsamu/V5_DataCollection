namespace V5_DataCollection.Forms.Publish
{
    partial class frmPublishEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebPublishName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCookies = new System.Windows.Forms.CheckBox();
            this.txtWebPublishCookies = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWebPublishUserName = new System.Windows.Forms.TextBox();
            this.txtWebPublishPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWebPublishUrl = new System.Windows.Forms.TextBox();
            this.btnTestWebPublish = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.combClassList = new System.Windows.Forms.ComboBox();
            this.btnGetClass = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPublishModule = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLogView = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetCookies = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模块名称";
            // 
            // txtWebPublishName
            // 
            this.txtWebPublishName.Location = new System.Drawing.Point(96, 24);
            this.txtWebPublishName.Name = "txtWebPublishName";
            this.txtWebPublishName.Size = new System.Drawing.Size(265, 21);
            this.txtWebPublishName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // chkCookies
            // 
            this.chkCookies.AutoSize = true;
            this.chkCookies.Location = new System.Drawing.Point(97, 79);
            this.chkCookies.Name = "chkCookies";
            this.chkCookies.Size = new System.Drawing.Size(114, 16);
            this.chkCookies.TabIndex = 4;
            this.chkCookies.Text = "Cookies直接登录";
            this.chkCookies.UseVisualStyleBackColor = true;
            // 
            // txtWebPublishCookies
            // 
            this.txtWebPublishCookies.Location = new System.Drawing.Point(97, 101);
            this.txtWebPublishCookies.Multiline = true;
            this.txtWebPublishCookies.Name = "txtWebPublishCookies";
            this.txtWebPublishCookies.Size = new System.Drawing.Size(265, 111);
            this.txtWebPublishCookies.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(537, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(57, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(599, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // txtWebPublishUserName
            // 
            this.txtWebPublishUserName.Location = new System.Drawing.Point(98, 297);
            this.txtWebPublishUserName.Name = "txtWebPublishUserName";
            this.txtWebPublishUserName.Size = new System.Drawing.Size(100, 21);
            this.txtWebPublishUserName.TabIndex = 7;
            // 
            // txtWebPublishPassWord
            // 
            this.txtWebPublishPassWord.Location = new System.Drawing.Point(297, 297);
            this.txtWebPublishPassWord.Name = "txtWebPublishPassWord";
            this.txtWebPublishPassWord.PasswordChar = '*';
            this.txtWebPublishPassWord.Size = new System.Drawing.Size(100, 21);
            this.txtWebPublishPassWord.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "网站地址";
            // 
            // txtWebPublishUrl
            // 
            this.txtWebPublishUrl.Location = new System.Drawing.Point(96, 52);
            this.txtWebPublishUrl.Name = "txtWebPublishUrl";
            this.txtWebPublishUrl.Size = new System.Drawing.Size(265, 21);
            this.txtWebPublishUrl.TabIndex = 9;
            // 
            // btnTestWebPublish
            // 
            this.btnTestWebPublish.Location = new System.Drawing.Point(475, 295);
            this.btnTestWebPublish.Name = "btnTestWebPublish";
            this.btnTestWebPublish.Size = new System.Drawing.Size(57, 23);
            this.btnTestWebPublish.TabIndex = 10;
            this.btnTestWebPublish.Text = "测试";
            this.btnTestWebPublish.UseVisualStyleBackColor = true;
            this.btnTestWebPublish.Click += new System.EventHandler(this.btnTestWebPublish_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "分类";
            // 
            // combClassList
            // 
            this.combClassList.FormattingEnabled = true;
            this.combClassList.Location = new System.Drawing.Point(97, 218);
            this.combClassList.Name = "combClassList";
            this.combClassList.Size = new System.Drawing.Size(121, 20);
            this.combClassList.TabIndex = 14;
            this.combClassList.SelectedIndexChanged += new System.EventHandler(this.combClassList_SelectedIndexChanged);
            // 
            // btnGetClass
            // 
            this.btnGetClass.Location = new System.Drawing.Point(274, 218);
            this.btnGetClass.Name = "btnGetClass";
            this.btnGetClass.Size = new System.Drawing.Size(75, 23);
            this.btnGetClass.TabIndex = 15;
            this.btnGetClass.Text = "获取";
            this.btnGetClass.UseVisualStyleBackColor = true;
            this.btnGetClass.Click += new System.EventHandler(this.btnGetClass_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "分类ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "分类名称";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(99, 253);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(100, 21);
            this.txtClassID.TabIndex = 18;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(297, 253);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 21);
            this.txtClassName.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPublishModule);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 226);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网站模块";
            // 
            // listBoxPublishModule
            // 
            this.listBoxPublishModule.FormattingEnabled = true;
            this.listBoxPublishModule.ItemHeight = 12;
            this.listBoxPublishModule.Location = new System.Drawing.Point(6, 20);
            this.listBoxPublishModule.Name = "listBoxPublishModule";
            this.listBoxPublishModule.Size = new System.Drawing.Size(238, 196);
            this.listBoxPublishModule.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 324);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 155);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLogView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 129);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "结果";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLogView
            // 
            this.txtLogView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogView.Location = new System.Drawing.Point(3, 3);
            this.txtLogView.Multiline = true;
            this.txtLogView.Name = "txtLogView";
            this.txtLogView.Size = new System.Drawing.Size(631, 123);
            this.txtLogView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 129);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Html";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetCookies
            // 
            this.btnGetCookies.Location = new System.Drawing.Point(287, 75);
            this.btnGetCookies.Name = "btnGetCookies";
            this.btnGetCookies.Size = new System.Drawing.Size(75, 23);
            this.btnGetCookies.TabIndex = 21;
            this.btnGetCookies.Text = "获取Cookies";
            this.btnGetCookies.UseVisualStyleBackColor = true;
            this.btnGetCookies.Click += new System.EventHandler(this.btnGetCookies_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(432, 256);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 22;
            this.txtID.Text = "0";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmPublishEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 481);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGetCookies);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGetClass);
            this.Controls.Add(this.combClassList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTestWebPublish);
            this.Controls.Add(this.txtWebPublishUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWebPublishPassWord);
            this.Controls.Add(this.txtWebPublishUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkCookies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWebPublishCookies);
            this.Controls.Add(this.txtWebPublishName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPublishEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网站模块编辑";
            this.Load += new System.EventHandler(this.frmPublishEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebPublishName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCookies;
        private System.Windows.Forms.TextBox txtWebPublishCookies;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWebPublishUserName;
        private System.Windows.Forms.TextBox txtWebPublishPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWebPublishUrl;
        private System.Windows.Forms.Button btnTestWebPublish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combClassList;
        private System.Windows.Forms.Button btnGetClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPublishModule;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGetCookies;
        private System.Windows.Forms.TextBox txtLogView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}