namespace V5_PublishModule {
    partial class frmCreateHtml {
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
            this.txtCreateHtmlPostData = new System.Windows.Forms.TextBox();
            this.txtCreateHtmlUrl = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateHtmlRefUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCreateHtmlPostData
            // 
            this.txtCreateHtmlPostData.Location = new System.Drawing.Point(72, 96);
            this.txtCreateHtmlPostData.Multiline = true;
            this.txtCreateHtmlPostData.Name = "txtCreateHtmlPostData";
            this.txtCreateHtmlPostData.Size = new System.Drawing.Size(493, 44);
            this.txtCreateHtmlPostData.TabIndex = 5;
            // 
            // txtCreateHtmlUrl
            // 
            this.txtCreateHtmlUrl.Location = new System.Drawing.Point(72, 39);
            this.txtCreateHtmlUrl.Name = "txtCreateHtmlUrl";
            this.txtCreateHtmlUrl.Size = new System.Drawing.Size(392, 21);
            this.txtCreateHtmlUrl.TabIndex = 6;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(13, 96);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 12);
            this.label33.TabIndex = 4;
            this.label33.Text = "Post参数";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 42);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 3;
            this.label32.Text = "提交地址";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(400, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(490, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称";
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(72, 12);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(154, 21);
            this.txtCreateName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "来源地址";
            // 
            // txtCreateHtmlRefUrl
            // 
            this.txtCreateHtmlRefUrl.Location = new System.Drawing.Point(72, 66);
            this.txtCreateHtmlRefUrl.Name = "txtCreateHtmlRefUrl";
            this.txtCreateHtmlRefUrl.Size = new System.Drawing.Size(392, 21);
            this.txtCreateHtmlRefUrl.TabIndex = 6;
            // 
            // frmCreateHtml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 178);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCreateHtmlPostData);
            this.Controls.Add(this.txtCreateName);
            this.Controls.Add(this.txtCreateHtmlRefUrl);
            this.Controls.Add(this.txtCreateHtmlUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateHtml";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "静态生成";
            this.Load += new System.EventHandler(this.frmCreateHtml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreateHtmlPostData;
        private System.Windows.Forms.TextBox txtCreateHtmlUrl;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreateHtmlRefUrl;
    }
}