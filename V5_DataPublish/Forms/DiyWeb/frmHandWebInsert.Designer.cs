using V5.DataPublish.Controls;

namespace V5_DataPublish.Forms.DiyWeb {
    partial class frmHandWebInsert {
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
            this.cmbClassList = new System.Windows.Forms.ComboBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutoCreateArticle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbWebSite = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.fckHtmlEditorControl1 = new FckHtmlEditorControl();
            this.SuspendLayout();
            // 
            // cmbClassList
            // 
            this.cmbClassList.FormattingEnabled = true;
            this.cmbClassList.Location = new System.Drawing.Point(319, 41);
            this.cmbClassList.Name = "cmbClassList";
            this.cmbClassList.Size = new System.Drawing.Size(241, 20);
            this.cmbClassList.TabIndex = 60;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.ForeColor = System.Drawing.Color.Red;
            this.lblProcess.Location = new System.Drawing.Point(51, 503);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 12);
            this.lblProcess.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 58;
            this.label4.Text = "状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 56;
            this.label2.Text = "分类";
            // 
            // btnAutoCreateArticle
            // 
            this.btnAutoCreateArticle.Location = new System.Drawing.Point(603, 10);
            this.btnAutoCreateArticle.Name = "btnAutoCreateArticle";
            this.btnAutoCreateArticle.Size = new System.Drawing.Size(121, 23);
            this.btnAutoCreateArticle.TabIndex = 55;
            this.btnAutoCreateArticle.Text = "随机生成一篇文章";
            this.btnAutoCreateArticle.UseVisualStyleBackColor = true;
            this.btnAutoCreateArticle.Click += new System.EventHandler(this.btnAutoCreateArticle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(649, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(556, 495);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 54;
            this.btnSubmit.Text = "确定(&S)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 52;
            this.label3.Text = "内容";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(46, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(547, 21);
            this.txtTitle.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "标题";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 62;
            this.label5.Text = "网站";
            // 
            // cmbWebSite
            // 
            this.cmbWebSite.FormattingEnabled = true;
            this.cmbWebSite.Location = new System.Drawing.Point(47, 42);
            this.cmbWebSite.Name = "cmbWebSite";
            this.cmbWebSite.Size = new System.Drawing.Size(227, 20);
            this.cmbWebSite.TabIndex = 63;
            this.cmbWebSite.SelectedIndexChanged += new System.EventHandler(this.cmbWebSite_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(52, 500);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 64;
            this.lblResult.Text = "label6";
            // 
            // fckHtmlEditorControl1
            // 
            this.fckHtmlEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fckHtmlEditorControl1.InnerHtml = "";
            this.fckHtmlEditorControl1.Location = new System.Drawing.Point(46, 73);
            this.fckHtmlEditorControl1.Name = "fckHtmlEditorControl1";
            this.fckHtmlEditorControl1.Size = new System.Drawing.Size(677, 413);
            this.fckHtmlEditorControl1.TabIndex = 65;
            // 
            // frmHandWebInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 528);
            this.Controls.Add(this.fckHtmlEditorControl1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbWebSite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClassList);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAutoCreateArticle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmHandWebInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自定义接口发布数据";
            this.Load += new System.EventHandler(this.frmHandWebInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClassList;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutoCreateArticle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbWebSite;
        private System.Windows.Forms.Label lblResult;
        private FckHtmlEditorControl fckHtmlEditorControl1;
    }
}