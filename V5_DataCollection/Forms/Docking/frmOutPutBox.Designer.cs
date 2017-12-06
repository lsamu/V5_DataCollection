namespace V5_DataCollection.Forms.Docking
{
    partial class frmOutPutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutPutBox));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton_ContentClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtOutWindowString = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip_QueutCount = new System.Windows.Forms.ToolStrip();
            this.toolStrip_ViewQueue = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_ClearLog = new System.Windows.Forms.ToolStripButton();
            this.txtLogView = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip_QueutCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::V5_DataCollection.Properties.Resources.背景;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripButton_ContentClear,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton_ContentClear
            // 
            this.toolStripButton_ContentClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_ContentClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ContentClear.Image")));
            this.toolStripButton_ContentClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ContentClear.Name = "toolStripButton_ContentClear";
            this.toolStripButton_ContentClear.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton_ContentClear.Text = "清除文本内容";
            this.toolStripButton_ContentClear.Click += new System.EventHandler(this.toolStripButton_ContentClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 284);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtOutWindowString);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "输出日志";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtOutWindowString
            // 
            this.txtOutWindowString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutWindowString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutWindowString.Location = new System.Drawing.Point(3, 28);
            this.txtOutWindowString.Name = "txtOutWindowString";
            this.txtOutWindowString.Size = new System.Drawing.Size(661, 227);
            this.txtOutWindowString.TabIndex = 6;
            this.txtOutWindowString.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLogView);
            this.tabPage2.Controls.Add(this.toolStrip_QueutCount);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "资源下载";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip_QueutCount
            // 
            this.toolStrip_QueutCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_ViewQueue,
            this.toolStrip_ClearLog});
            this.toolStrip_QueutCount.Location = new System.Drawing.Point(3, 3);
            this.toolStrip_QueutCount.Name = "toolStrip_QueutCount";
            this.toolStrip_QueutCount.Size = new System.Drawing.Size(661, 25);
            this.toolStrip_QueutCount.TabIndex = 0;
            this.toolStrip_QueutCount.Text = "toolStrip2";
            // 
            // toolStrip_ViewQueue
            // 
            this.toolStrip_ViewQueue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_ViewQueue.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_ViewQueue.Image")));
            this.toolStrip_ViewQueue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_ViewQueue.Name = "toolStrip_ViewQueue";
            this.toolStrip_ViewQueue.Size = new System.Drawing.Size(60, 22);
            this.toolStrip_ViewQueue.Text = "查看队列";
            this.toolStrip_ViewQueue.Click += new System.EventHandler(this.toolStrip_ViewQueue_Click);
            // 
            // toolStrip_ClearLog
            // 
            this.toolStrip_ClearLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_ClearLog.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_ClearLog.Image")));
            this.toolStrip_ClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_ClearLog.Name = "toolStrip_ClearLog";
            this.toolStrip_ClearLog.Size = new System.Drawing.Size(60, 22);
            this.toolStrip_ClearLog.Text = "清除日志";
            this.toolStrip_ClearLog.Click += new System.EventHandler(this.toolStrip_ClearLog_Click);
            // 
            // txtLogView
            // 
            this.txtLogView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogView.Location = new System.Drawing.Point(3, 28);
            this.txtLogView.Name = "txtLogView";
            this.txtLogView.Size = new System.Drawing.Size(661, 227);
            this.txtLogView.TabIndex = 4;
            this.txtLogView.Text = "";
            // 
            // frmOutPutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 284);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideOnClose = true;
            this.Name = "frmOutPutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "输出窗口";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip_QueutCount.ResumeLayout(false);
            this.toolStrip_QueutCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton_ContentClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip_QueutCount;
        private System.Windows.Forms.ToolStripButton toolStrip_ViewQueue;
        private System.Windows.Forms.ToolStripButton toolStrip_ClearLog;
        private System.Windows.Forms.RichTextBox txtOutWindowString;
        private System.Windows.Forms.RichTextBox txtLogView;
    }
}