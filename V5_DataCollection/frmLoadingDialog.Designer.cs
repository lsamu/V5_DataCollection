namespace V5_DataCollection {
    partial class frmLoadingDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadingDialog));
            this.lblProcess = new System.Windows.Forms.Label();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProcess.Location = new System.Drawing.Point(2, 2);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(56, 18);
            this.lblProcess.TabIndex = 0;
            this.lblProcess.Text = "处理中";
            // 
            // pbxLoading
            // 
            this.pbxLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoading.Image")));
            this.pbxLoading.Location = new System.Drawing.Point(20, 52);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(32, 32);
            this.pbxLoading.TabIndex = 1;
            this.pbxLoading.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.Location = new System.Drawing.Point(63, 60);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(102, 15);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "处理中-请稍等...";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPercentage.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPercentage.Location = new System.Drawing.Point(180, 60);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 13);
            this.lblPercentage.TabIndex = 3;
            // 
            // LoadingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 109);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbxLoading);
            this.Controls.Add(this.lblProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoadingDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPercentage;

    }
}