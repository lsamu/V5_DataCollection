namespace V5_DataPublish.Forms.Desk
{
    partial class frmHandInsert
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnAutoCreateArticle = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectWebSite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(48, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(547, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "内容";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(560, 492);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "确定(&S)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(653, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btnAutoCreateArticle
            // 
            this.btnAutoCreateArticle.Location = new System.Drawing.Point(605, 10);
            this.btnAutoCreateArticle.Name = "btnAutoCreateArticle";
            this.btnAutoCreateArticle.Size = new System.Drawing.Size(121, 23);
            this.btnAutoCreateArticle.TabIndex = 26;
            this.btnAutoCreateArticle.Text = "随机生成一篇文章";
            this.btnAutoCreateArticle.UseVisualStyleBackColor = true;
            this.btnAutoCreateArticle.Click += new System.EventHandler(this.btnAutoCreateArticle_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "分类";
            // 
            // btnSelectWebSite
            // 
            this.btnSelectWebSite.Location = new System.Drawing.Point(308, 42);
            this.btnSelectWebSite.Name = "btnSelectWebSite";
            this.btnSelectWebSite.Size = new System.Drawing.Size(75, 23);
            this.btnSelectWebSite.TabIndex = 31;
            this.btnSelectWebSite.Text = "选择网站";
            this.btnSelectWebSite.UseVisualStyleBackColor = true;
            this.btnSelectWebSite.Click += new System.EventHandler(this.btnSelectWebSite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "状态";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.ForeColor = System.Drawing.Color.Red;
            this.lblProcess.Location = new System.Drawing.Point(53, 503);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 12);
            this.lblProcess.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 20);
            this.comboBox1.TabIndex = 36;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(49, 73);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(673, 413);
            this.txtContent.TabIndex = 37;
            this.txtContent.WordWrap = false;
            // 
            // frmHandInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 527);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelectWebSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAutoCreateArticle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHandInsert";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据插入";
            this.Load += new System.EventHandler(this.frmHandInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnAutoCreateArticle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectWebSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtContent;
    }
}