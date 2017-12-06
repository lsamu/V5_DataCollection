namespace V5_DataPublish.Forms.Desk {
    partial class frmSelectGroupSite {
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSiteClassList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWebSiteList = new System.Windows.Forms.ComboBox();
            this.btnSubmitSite = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClassList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "站群分类";
            // 
            // cmbSiteClassList
            // 
            this.cmbSiteClassList.FormattingEnabled = true;
            this.cmbSiteClassList.Location = new System.Drawing.Point(115, 10);
            this.cmbSiteClassList.Name = "cmbSiteClassList";
            this.cmbSiteClassList.Size = new System.Drawing.Size(208, 20);
            this.cmbSiteClassList.TabIndex = 3;
            this.cmbSiteClassList.SelectedIndexChanged += new System.EventHandler(this.cmbSiteClassList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "站群网站列表";
            // 
            // cmbWebSiteList
            // 
            this.cmbWebSiteList.FormattingEnabled = true;
            this.cmbWebSiteList.Location = new System.Drawing.Point(115, 45);
            this.cmbWebSiteList.Name = "cmbWebSiteList";
            this.cmbWebSiteList.Size = new System.Drawing.Size(208, 20);
            this.cmbWebSiteList.TabIndex = 3;
            this.cmbWebSiteList.SelectedIndexChanged += new System.EventHandler(this.cmbWebSiteList_SelectedIndexChanged);
            // 
            // btnSubmitSite
            // 
            this.btnSubmitSite.Location = new System.Drawing.Point(152, 116);
            this.btnSubmitSite.Name = "btnSubmitSite";
            this.btnSubmitSite.Size = new System.Drawing.Size(102, 23);
            this.btnSubmitSite.TabIndex = 4;
            this.btnSubmitSite.Text = "确定选择站点";
            this.btnSubmitSite.UseVisualStyleBackColor = true;
            this.btnSubmitSite.Click += new System.EventHandler(this.btnSubmitSite_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(20, 121);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "网站分类";
            // 
            // cmbClassList
            // 
            this.cmbClassList.FormattingEnabled = true;
            this.cmbClassList.Location = new System.Drawing.Point(115, 76);
            this.cmbClassList.Name = "cmbClassList";
            this.cmbClassList.Size = new System.Drawing.Size(208, 20);
            this.cmbClassList.TabIndex = 3;
            // 
            // frmSelectGroupSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 160);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitSite);
            this.Controls.Add(this.cmbClassList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbWebSiteList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSiteClassList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectGroupSite";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选一个站点";
            this.Load += new System.EventHandler(this.frmSelectGroupSite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSiteClassList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWebSiteList;
        private System.Windows.Forms.Button btnSubmitSite;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClassList;
    }
}