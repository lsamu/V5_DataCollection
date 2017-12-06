namespace V5_DataCollection.Forms.Task
{
    partial class frmTaskUrl
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
            this.btnAddLinkUrl1 = new System.Windows.Forms.Button();
            this.listBoxUrlList = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddUrlParams = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.递增变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.递减变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.字幕递增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字母递减ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinkUrl = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.日期DateyyyyMMddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日期DateyyyyMMddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddLinkUrl1
            // 
            this.btnAddLinkUrl1.Location = new System.Drawing.Point(470, 164);
            this.btnAddLinkUrl1.Name = "btnAddLinkUrl1";
            this.btnAddLinkUrl1.Size = new System.Drawing.Size(54, 23);
            this.btnAddLinkUrl1.TabIndex = 1;
            this.btnAddLinkUrl1.Text = "添加";
            this.btnAddLinkUrl1.UseVisualStyleBackColor = true;
            this.btnAddLinkUrl1.Click += new System.EventHandler(this.btnAddLinkUrl1_Click);
            // 
            // listBoxUrlList
            // 
            this.listBoxUrlList.FormattingEnabled = true;
            this.listBoxUrlList.ItemHeight = 12;
            this.listBoxUrlList.Location = new System.Drawing.Point(14, 193);
            this.listBoxUrlList.Name = "listBoxUrlList";
            this.listBoxUrlList.Size = new System.Drawing.Size(446, 100);
            this.listBoxUrlList.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(406, 299);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(54, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddUrlParams
            // 
            this.btnAddUrlParams.ContextMenuStrip = this.contextMenuStrip1;
            this.btnAddUrlParams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUrlParams.Location = new System.Drawing.Point(466, 28);
            this.btnAddUrlParams.Name = "btnAddUrlParams";
            this.btnAddUrlParams.Size = new System.Drawing.Size(61, 23);
            this.btnAddUrlParams.TabIndex = 2;
            this.btnAddUrlParams.Text = "参数变量";
            this.btnAddUrlParams.UseVisualStyleBackColor = true;
            this.btnAddUrlParams.Click += new System.EventHandler(this.btnAddUrlParams_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.递增变量ToolStripMenuItem,
            this.递减变量ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.字幕递增ToolStripMenuItem,
            this.字母递减ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.日期DateyyyyMMddToolStripMenuItem,
            this.日期DateyyyyMMddToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 170);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // 递增变量ToolStripMenuItem
            // 
            this.递增变量ToolStripMenuItem.Name = "递增变量ToolStripMenuItem";
            this.递增变量ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.递增变量ToolStripMenuItem.Text = "递增变量{Num:1,100,1}";
            // 
            // 递减变量ToolStripMenuItem
            // 
            this.递减变量ToolStripMenuItem.Name = "递减变量ToolStripMenuItem";
            this.递减变量ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.递减变量ToolStripMenuItem.Text = "递减变量{Num:1,100,-1}";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // 字幕递增ToolStripMenuItem
            // 
            this.字幕递增ToolStripMenuItem.Name = "字幕递增ToolStripMenuItem";
            this.字幕递增ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.字幕递增ToolStripMenuItem.Text = "字母递增{Letter:a,z}";
            // 
            // 字母递减ToolStripMenuItem
            // 
            this.字母递减ToolStripMenuItem.Name = "字母递减ToolStripMenuItem";
            this.字母递减ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.字母递减ToolStripMenuItem.Text = "字母递减字{Letter:z,a}";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "单条网址一行一个";
            // 
            // txtLinkUrl
            // 
            this.txtLinkUrl.Location = new System.Drawing.Point(12, 28);
            this.txtLinkUrl.Multiline = true;
            this.txtLinkUrl.Name = "txtLinkUrl";
            this.txtLinkUrl.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLinkUrl.Size = new System.Drawing.Size(448, 159);
            this.txtLinkUrl.TabIndex = 0;
            this.txtLinkUrl.WordWrap = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // 日期DateyyyyMMddToolStripMenuItem
            // 
            this.日期DateyyyyMMddToolStripMenuItem.Name = "日期DateyyyyMMddToolStripMenuItem";
            this.日期DateyyyyMMddToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.日期DateyyyyMMddToolStripMenuItem.Text = "日期{Date:yyyyMMdd}";
            // 
            // 日期DateyyyyMMddToolStripMenuItem1
            // 
            this.日期DateyyyyMMddToolStripMenuItem1.Name = "日期DateyyyyMMddToolStripMenuItem1";
            this.日期DateyyyyMMddToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.日期DateyyyyMMddToolStripMenuItem1.Text = "日期{Date:yyyy-MM-dd}";
            // 
            // frmTaskUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 333);
            this.Controls.Add(this.btnAddUrlParams);
            this.Controls.Add(this.listBoxUrlList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLinkUrl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAddLinkUrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskUrl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网址信息";
            this.Load += new System.EventHandler(this.frmTaskUrl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLinkUrl1;
        private System.Windows.Forms.ListBox listBoxUrlList;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLinkUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUrlParams;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 递增变量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 递减变量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 字幕递增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字母递减ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem 日期DateyyyyMMddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日期DateyyyyMMddToolStripMenuItem1;
    }
}