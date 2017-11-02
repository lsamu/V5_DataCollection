namespace V5_DataCollection.Forms.Task.Tools {
    partial class frmTaskDiyWebUrl {
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
            this.txtDiyWebUrlName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiyWebUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTaskLabel1 = new System.Windows.Forms.Button();
            this.txtUrlPrams = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUrlEncode = new System.Windows.Forms.ComboBox();
            this.txtEditId = new System.Windows.Forms.TextBox();
            this.btnTaskLabel2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // txtDiyWebUrlName
            // 
            this.txtDiyWebUrlName.Location = new System.Drawing.Point(155, 58);
            this.txtDiyWebUrlName.Name = "txtDiyWebUrlName";
            this.txtDiyWebUrlName.Size = new System.Drawing.Size(257, 21);
            this.txtDiyWebUrlName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称";
            // 
            // txtDiyWebUrl
            // 
            this.txtDiyWebUrl.Location = new System.Drawing.Point(155, 119);
            this.txtDiyWebUrl.Multiline = true;
            this.txtDiyWebUrl.Name = "txtDiyWebUrl";
            this.txtDiyWebUrl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiyWebUrl.Size = new System.Drawing.Size(368, 81);
            this.txtDiyWebUrl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "地址";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(316, 317);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTaskLabel1
            // 
            this.btnTaskLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaskLabel1.Location = new System.Drawing.Point(105, 122);
            this.btnTaskLabel1.Name = "btnTaskLabel1";
            this.btnTaskLabel1.Size = new System.Drawing.Size(44, 23);
            this.btnTaskLabel1.TabIndex = 8;
            this.btnTaskLabel1.Text = "标签";
            this.btnTaskLabel1.UseVisualStyleBackColor = true;
            this.btnTaskLabel1.Click += new System.EventHandler(this.btnTaskLabel1_Click);
            // 
            // txtUrlPrams
            // 
            this.txtUrlPrams.Location = new System.Drawing.Point(155, 206);
            this.txtUrlPrams.Multiline = true;
            this.txtUrlPrams.Name = "txtUrlPrams";
            this.txtUrlPrams.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrlPrams.Size = new System.Drawing.Size(368, 60);
            this.txtUrlPrams.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "参数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "编码";
            // 
            // cmbUrlEncode
            // 
            this.cmbUrlEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrlEncode.FormattingEnabled = true;
            this.cmbUrlEncode.Location = new System.Drawing.Point(155, 90);
            this.cmbUrlEncode.Name = "cmbUrlEncode";
            this.cmbUrlEncode.Size = new System.Drawing.Size(121, 20);
            this.cmbUrlEncode.TabIndex = 10;
            // 
            // txtEditId
            // 
            this.txtEditId.Location = new System.Drawing.Point(93, 308);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.Size = new System.Drawing.Size(100, 21);
            this.txtEditId.TabIndex = 11;
            this.txtEditId.Text = "0";
            // 
            // btnTaskLabel2
            // 
            this.btnTaskLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaskLabel2.Location = new System.Drawing.Point(105, 204);
            this.btnTaskLabel2.Name = "btnTaskLabel2";
            this.btnTaskLabel2.Size = new System.Drawing.Size(44, 23);
            this.btnTaskLabel2.TabIndex = 8;
            this.btnTaskLabel2.Text = "标签";
            this.btnTaskLabel2.UseVisualStyleBackColor = true;
            this.btnTaskLabel2.Click += new System.EventHandler(this.btnTaskLabel2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmTaskDiyWebUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 364);
            this.Controls.Add(this.txtEditId);
            this.Controls.Add(this.cmbUrlEncode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTaskLabel2);
            this.Controls.Add(this.btnTaskLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrlPrams);
            this.Controls.Add(this.txtDiyWebUrl);
            this.Controls.Add(this.txtDiyWebUrlName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskDiyWebUrl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自定义访问页面设置";
            this.Load += new System.EventHandler(this.frmTaskDiyWebUrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiyWebUrlName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiyWebUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTaskLabel1;
        private System.Windows.Forms.TextBox txtUrlPrams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUrlEncode;
        private System.Windows.Forms.TextBox txtEditId;
        private System.Windows.Forms.Button btnTaskLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}