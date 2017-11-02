namespace V5_DataPublish.Forms.WebSiteClass {
    partial class frmWebSiteClass {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebSiteClassName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtHideValue = new System.Windows.Forms.TextBox();
            this.txtReadMe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分类名称";
            // 
            // txtWebSiteClassName
            // 
            this.txtWebSiteClassName.Location = new System.Drawing.Point(84, 8);
            this.txtWebSiteClassName.Name = "txtWebSiteClassName";
            this.txtWebSiteClassName.Size = new System.Drawing.Size(202, 21);
            this.txtWebSiteClassName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(196, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "确定(&S)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtHideValue
            // 
            this.txtHideValue.Location = new System.Drawing.Point(84, 150);
            this.txtHideValue.Name = "txtHideValue";
            this.txtHideValue.Size = new System.Drawing.Size(100, 21);
            this.txtHideValue.TabIndex = 3;
            this.txtHideValue.Visible = false;
            // 
            // txtReadMe
            // 
            this.txtReadMe.Location = new System.Drawing.Point(84, 45);
            this.txtReadMe.Multiline = true;
            this.txtReadMe.Name = "txtReadMe";
            this.txtReadMe.Size = new System.Drawing.Size(286, 89);
            this.txtReadMe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "分类说明";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmWebSiteClass
            // 
            this.ClientSize = new System.Drawing.Size(389, 185);
            this.Controls.Add(this.txtHideValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReadMe);
            this.Controls.Add(this.txtWebSiteClassName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWebSiteClass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "网站分类";
            this.Load += new System.EventHandler(this.frmWebSiteClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebSiteClassName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtHideValue;
        private System.Windows.Forms.TextBox txtReadMe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
