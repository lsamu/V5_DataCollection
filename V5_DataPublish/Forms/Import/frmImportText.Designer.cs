namespace V5_DataPublish.Forms.Import {
    partial class frmImportText {
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.btnsss = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtTextFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnIndexTest = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(306, 119);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "上传(&S)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(401, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelProgress);
            this.groupBox1.Controls.Add(this.btnsss);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtTextFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文本文件上传";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(408, 71);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(17, 12);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "0%";
            // 
            // btnsss
            // 
            this.btnsss.AutoSize = true;
            this.btnsss.Location = new System.Drawing.Point(23, 72);
            this.btnsss.Name = "btnsss";
            this.btnsss.Size = new System.Drawing.Size(29, 12);
            this.btnsss.TabIndex = 4;
            this.btnsss.Text = "进度";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(81, 67);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(321, 23);
            this.progressBar.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(408, 27);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(28, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtTextFile
            // 
            this.txtTextFile.Location = new System.Drawing.Point(81, 27);
            this.txtTextFile.Name = "txtTextFile";
            this.txtTextFile.Size = new System.Drawing.Size(321, 21);
            this.txtTextFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件地址";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnIndexTest
            // 
            this.btnIndexTest.Location = new System.Drawing.Point(210, 119);
            this.btnIndexTest.Name = "btnIndexTest";
            this.btnIndexTest.Size = new System.Drawing.Size(75, 23);
            this.btnIndexTest.TabIndex = 2;
            this.btnIndexTest.Text = "测试";
            this.btnIndexTest.UseVisualStyleBackColor = true;
            this.btnIndexTest.Click += new System.EventHandler(this.btnIndexTest_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmImportText
            // 
            this.ClientSize = new System.Drawing.Size(488, 158);
            this.Controls.Add(this.btnIndexTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportText";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "文本数据上传";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtTextFile;
        private System.Windows.Forms.Label btnsss;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnIndexTest;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
