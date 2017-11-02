namespace V5_PublishModule
{
    partial class frmLoginVerCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginVerCode = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbVerCode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginPassWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "验证码";
            // 
            // txtLoginVerCode
            // 
            this.txtLoginVerCode.Location = new System.Drawing.Point(99, 83);
            this.txtLoginVerCode.Name = "txtLoginVerCode";
            this.txtLoginVerCode.Size = new System.Drawing.Size(71, 21);
            this.txtLoginVerCode.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(129, 121);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "(&S)确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "(&C)取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbVerCode
            // 
            this.pbVerCode.Location = new System.Drawing.Point(176, 83);
            this.pbVerCode.Name = "pbVerCode";
            this.pbVerCode.Size = new System.Drawing.Size(114, 21);
            this.pbVerCode.TabIndex = 3;
            this.pbVerCode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号";
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Location = new System.Drawing.Point(99, 22);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(211, 21);
            this.txtLoginUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码";
            // 
            // txtLoginPassWord
            // 
            this.txtLoginPassWord.Location = new System.Drawing.Point(99, 49);
            this.txtLoginPassWord.Name = "txtLoginPassWord";
            this.txtLoginPassWord.Size = new System.Drawing.Size(211, 21);
            this.txtLoginPassWord.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "刷";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLoginVerCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLoginPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbVerCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLoginVerCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginVerCode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录验证码";
            this.Load += new System.EventHandler(this.frmLoginVerCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVerCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginVerCode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbVerCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginPassWord;
        private System.Windows.Forms.Button button1;
    }
}