namespace V5_DataCollection.Forms.Tools {
    partial class frmImportWebCollectionModule {
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
            this.txtWebCollectionModule = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBroswer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSiteClass = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件地址";
            // 
            // txtWebCollectionModule
            // 
            this.txtWebCollectionModule.Enabled = false;
            this.txtWebCollectionModule.Location = new System.Drawing.Point(91, 25);
            this.txtWebCollectionModule.Name = "txtWebCollectionModule";
            this.txtWebCollectionModule.Size = new System.Drawing.Size(290, 21);
            this.txtWebCollectionModule.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(256, 92);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "导入";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBroswer
            // 
            this.btnBroswer.Location = new System.Drawing.Point(387, 23);
            this.btnBroswer.Name = "btnBroswer";
            this.btnBroswer.Size = new System.Drawing.Size(33, 23);
            this.btnBroswer.TabIndex = 3;
            this.btnBroswer.Text = "...";
            this.btnBroswer.UseVisualStyleBackColor = true;
            this.btnBroswer.Click += new System.EventHandler(this.btnBroswer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "站点分类";
            // 
            // cmbSiteClass
            // 
            this.cmbSiteClass.FormattingEnabled = true;
            this.cmbSiteClass.Location = new System.Drawing.Point(91, 64);
            this.cmbSiteClass.Name = "cmbSiteClass";
            this.cmbSiteClass.Size = new System.Drawing.Size(121, 20);
            this.cmbSiteClass.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmImportWebCollectionModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 128);
            this.Controls.Add(this.cmbSiteClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBroswer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtWebCollectionModule);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportWebCollectionModule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入采集模块";
            this.Load += new System.EventHandler(this.frmImportWebCollectionModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebCollectionModule;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBroswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSiteClass;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}