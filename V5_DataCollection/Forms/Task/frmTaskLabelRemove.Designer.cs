namespace V5_DataCollection.Forms.Task
{
    partial class frmTaskLabelRemove
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRemoveStr = new V5_WinControls.V5RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFilterTagOnly = new System.Windows.Forms.RadioButton();
            this.rdbFilterAll = new System.Windows.Forms.RadioButton();
            this.rdbSingleTag = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(208, 183);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtRemoveStr
            // 
            this.txtRemoveStr.Location = new System.Drawing.Point(13, 13);
            this.txtRemoveStr.Name = "txtRemoveStr";
            this.txtRemoveStr.Size = new System.Drawing.Size(351, 128);
            this.txtRemoveStr.TabIndex = 8;
            this.txtRemoveStr.Text = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 185);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 24);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "每行一个字符串,\r\n过滤Html标签用";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSingleTag);
            this.groupBox1.Controls.Add(this.rdbFilterTagOnly);
            this.groupBox1.Controls.Add(this.rdbFilterAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 35);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "过滤方式";
            // 
            // rdbFilterTagOnly
            // 
            this.rdbFilterTagOnly.AutoSize = true;
            this.rdbFilterTagOnly.Location = new System.Drawing.Point(215, 14);
            this.rdbFilterTagOnly.Name = "rdbFilterTagOnly";
            this.rdbFilterTagOnly.Size = new System.Drawing.Size(131, 16);
            this.rdbFilterTagOnly.TabIndex = 0;
            this.rdbFilterTagOnly.Text = "过滤标签但保留内容";
            this.rdbFilterTagOnly.UseVisualStyleBackColor = true;
            // 
            // rdbFilterAll
            // 
            this.rdbFilterAll.AutoSize = true;
            this.rdbFilterAll.Checked = true;
            this.rdbFilterAll.Location = new System.Drawing.Point(81, 13);
            this.rdbFilterAll.Name = "rdbFilterAll";
            this.rdbFilterAll.Size = new System.Drawing.Size(107, 16);
            this.rdbFilterAll.TabIndex = 0;
            this.rdbFilterAll.TabStop = true;
            this.rdbFilterAll.Text = "过滤标签及内容";
            this.rdbFilterAll.UseVisualStyleBackColor = true;
            // 
            // rdbSingleTag
            // 
            this.rdbSingleTag.AutoSize = true;
            this.rdbSingleTag.Location = new System.Drawing.Point(12, 14);
            this.rdbSingleTag.Name = "rdbSingleTag";
            this.rdbSingleTag.Size = new System.Drawing.Size(59, 16);
            this.rdbSingleTag.TabIndex = 1;
            this.rdbSingleTag.TabStop = true;
            this.rdbSingleTag.Text = "单标签";
            this.rdbSingleTag.UseVisualStyleBackColor = true;
            // 
            // frmTaskLabelRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 217);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtRemoveStr);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmTaskLabelRemove";
            this.Text = "字符排除";
            this.Load += new System.EventHandler(this.frmTaskLabelRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private V5_WinControls.V5RichTextBox txtRemoveStr;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFilterTagOnly;
        private System.Windows.Forms.RadioButton rdbFilterAll;
        private System.Windows.Forms.RadioButton rdbSingleTag;
    }
}