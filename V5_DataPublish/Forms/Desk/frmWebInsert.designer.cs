namespace V5_DataPublish.Forms.Desk
{
    partial class frmWebInsert
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelSelected = new System.Windows.Forms.Button();
            this.checkedListBox_WebSiteClassList = new System.Windows.Forms.CheckedListBox();
            this.btnSelectWebSite = new System.Windows.Forms.Button();
            this.chkIsCheck1 = new System.Windows.Forms.CheckBox();
            this.btnEditContent = new System.Windows.Forms.Button();
            this.chkIsFliterContentHtml = new System.Windows.Forms.CheckBox();
            this.backgroundWorker_Send = new System.ComponentModel.BackgroundWorker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(50, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(414, 21);
            this.txtTitle.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "标题";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(471, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(382, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "确定(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelSelected);
            this.groupBox3.Controls.Add(this.checkedListBox_WebSiteClassList);
            this.groupBox3.Controls.Add(this.btnSelectWebSite);
            this.groupBox3.Controls.Add(this.chkIsCheck1);
            this.groupBox3.Location = new System.Drawing.Point(10, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 239);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "站群发布接口";
            // 
            // btnDelSelected
            // 
            this.btnDelSelected.Location = new System.Drawing.Point(364, 17);
            this.btnDelSelected.Name = "btnDelSelected";
            this.btnDelSelected.Size = new System.Drawing.Size(75, 23);
            this.btnDelSelected.TabIndex = 31;
            this.btnDelSelected.Text = "删除选中项";
            this.btnDelSelected.UseVisualStyleBackColor = true;
            this.btnDelSelected.Click += new System.EventHandler(this.btnDelSelected_Click);
            // 
            // checkedListBox_WebSiteClassList
            // 
            this.checkedListBox_WebSiteClassList.CheckOnClick = true;
            this.checkedListBox_WebSiteClassList.ColumnWidth = 260;
            this.checkedListBox_WebSiteClassList.FormattingEnabled = true;
            this.checkedListBox_WebSiteClassList.Location = new System.Drawing.Point(6, 46);
            this.checkedListBox_WebSiteClassList.MultiColumn = true;
            this.checkedListBox_WebSiteClassList.Name = "checkedListBox_WebSiteClassList";
            this.checkedListBox_WebSiteClassList.ScrollAlwaysVisible = true;
            this.checkedListBox_WebSiteClassList.Size = new System.Drawing.Size(524, 180);
            this.checkedListBox_WebSiteClassList.TabIndex = 30;
            // 
            // btnSelectWebSite
            // 
            this.btnSelectWebSite.Location = new System.Drawing.Point(455, 17);
            this.btnSelectWebSite.Name = "btnSelectWebSite";
            this.btnSelectWebSite.Size = new System.Drawing.Size(75, 23);
            this.btnSelectWebSite.TabIndex = 26;
            this.btnSelectWebSite.Text = "选择站群";
            this.btnSelectWebSite.UseVisualStyleBackColor = true;
            this.btnSelectWebSite.Click += new System.EventHandler(this.btnSelectWebSite_Click);
            // 
            // chkIsCheck1
            // 
            this.chkIsCheck1.AutoSize = true;
            this.chkIsCheck1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIsCheck1.Location = new System.Drawing.Point(7, 21);
            this.chkIsCheck1.Name = "chkIsCheck1";
            this.chkIsCheck1.Size = new System.Drawing.Size(48, 16);
            this.chkIsCheck1.TabIndex = 23;
            this.chkIsCheck1.Text = "选择";
            this.chkIsCheck1.UseVisualStyleBackColor = true;
            // 
            // btnEditContent
            // 
            this.btnEditContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditContent.Location = new System.Drawing.Point(288, 283);
            this.btnEditContent.Name = "btnEditContent";
            this.btnEditContent.Size = new System.Drawing.Size(75, 23);
            this.btnEditContent.TabIndex = 24;
            this.btnEditContent.Text = "编辑(&E)";
            this.btnEditContent.UseVisualStyleBackColor = true;
            this.btnEditContent.Click += new System.EventHandler(this.btnEditContent_Click);
            // 
            // chkIsFliterContentHtml
            // 
            this.chkIsFliterContentHtml.AutoSize = true;
            this.chkIsFliterContentHtml.Checked = true;
            this.chkIsFliterContentHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsFliterContentHtml.Location = new System.Drawing.Point(470, 8);
            this.chkIsFliterContentHtml.Name = "chkIsFliterContentHtml";
            this.chkIsFliterContentHtml.Size = new System.Drawing.Size(72, 16);
            this.chkIsFliterContentHtml.TabIndex = 0;
            this.chkIsFliterContentHtml.Text = "过滤Html";
            this.chkIsFliterContentHtml.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker_Send
            // 
            this.backgroundWorker_Send.WorkerReportsProgress = true;
            this.backgroundWorker_Send.WorkerSupportsCancellation = true;
            this.backgroundWorker_Send.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Send_DoWork);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(15, 288);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 12);
            this.lblResult.TabIndex = 26;
            this.lblResult.Text = "输出结果";
            // 
            // frmWebInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 316);
            this.Controls.Add(this.chkIsFliterContentHtml);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEditContent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWebInsert";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据插入";
            this.Load += new System.EventHandler(this.frmWebInsert_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditContent;
        private System.Windows.Forms.CheckBox chkIsCheck1;
        private System.Windows.Forms.CheckBox chkIsFliterContentHtml;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Send;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSelectWebSite;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckedListBox checkedListBox_WebSiteClassList;
        private System.Windows.Forms.Button btnDelSelected;
    }
}