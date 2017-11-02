namespace V5_DataCollection.Forms.LeftTree {
    partial class frmLeftTreeClass {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTreeClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTreeClassReadMe = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEditID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分类名称";
            // 
            // txtTreeClassName
            // 
            this.txtTreeClassName.Location = new System.Drawing.Point(82, 9);
            this.txtTreeClassName.Name = "txtTreeClassName";
            this.txtTreeClassName.Size = new System.Drawing.Size(302, 21);
            this.txtTreeClassName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "分类说明";
            // 
            // txtTreeClassReadMe
            // 
            this.txtTreeClassReadMe.Location = new System.Drawing.Point(82, 48);
            this.txtTreeClassReadMe.Multiline = true;
            this.txtTreeClassReadMe.Name = "txtTreeClassReadMe";
            this.txtTreeClassReadMe.Size = new System.Drawing.Size(302, 95);
            this.txtTreeClassReadMe.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(215, 161);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "(S)确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(309, 161);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "(&C)取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(66, 161);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(100, 21);
            this.txtEditID.TabIndex = 3;
            this.txtEditID.Text = "0";
            this.txtEditID.Visible = false;
            // 
            // frmLeftTreeClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 196);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTreeClassReadMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTreeClassName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLeftTreeClass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务分类添加";
            this.Load += new System.EventHandler(this.frmLeftTreeClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTreeClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTreeClassReadMe;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtEditID;
    }
}