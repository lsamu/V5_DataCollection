namespace V5_DataCollection.Forms.Tools {
    partial class frmImportPythonScript {
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
            this.cmbScriptType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别:";
            // 
            // cmbScriptType
            // 
            this.cmbScriptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScriptType.FormattingEnabled = true;
            this.cmbScriptType.Items.AddRange(new object[] {
            "采集列表",
            "采集内容",
            "分析标签",
            "发布内容"});
            this.cmbScriptType.Location = new System.Drawing.Point(88, 18);
            this.cmbScriptType.Name = "cmbScriptType";
            this.cmbScriptType.Size = new System.Drawing.Size(189, 20);
            this.cmbScriptType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "脚本:";
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(88, 55);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(229, 21);
            this.txtScript.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(197, 92);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(323, 55);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(30, 23);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // frmImportPythonScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 127);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.cmbScriptType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmImportPythonScript";
            this.Text = "导入Python脚本";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbScriptType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowser;
    }
}