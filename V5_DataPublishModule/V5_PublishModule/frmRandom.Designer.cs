using V5_WinUtility;
using V5_WinUtility.Controls;

namespace V5_PublishModule {
    partial class frmRandom {
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
            this.txtLabelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRandomUrl = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtRandomRefUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRandomPostData = new System.Windows.Forms.TextBox();
            this.txtRandomCutRegex = new V5RichTextBox();
            this.v5LinkLabel1 = new V5LinkLabel(this.components);
            this.v5LinkLabel3 = new V5LinkLabel(this.components);
            this.cmbRandomLabelType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标签名称﹕";
            // 
            // txtLabelName
            // 
            this.txtLabelName.Location = new System.Drawing.Point(81, 12);
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.Size = new System.Drawing.Size(188, 21);
            this.txtLabelName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "访问地址﹕";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "表达式﹕";
            // 
            // txtRandomUrl
            // 
            this.txtRandomUrl.Location = new System.Drawing.Point(81, 41);
            this.txtRandomUrl.Name = "txtRandomUrl";
            this.txtRandomUrl.Size = new System.Drawing.Size(286, 21);
            this.txtRandomUrl.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(358, 218);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "(&S)确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "(&C)取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "来源地址﹕";
            // 
            // txtRandomRefUrl
            // 
            this.txtRandomRefUrl.Location = new System.Drawing.Point(81, 69);
            this.txtRandomRefUrl.Name = "txtRandomRefUrl";
            this.txtRandomRefUrl.Size = new System.Drawing.Size(286, 21);
            this.txtRandomRefUrl.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Post参数﹕";
            // 
            // txtRandomPostData
            // 
            this.txtRandomPostData.Location = new System.Drawing.Point(81, 98);
            this.txtRandomPostData.Multiline = true;
            this.txtRandomPostData.Name = "txtRandomPostData";
            this.txtRandomPostData.Size = new System.Drawing.Size(429, 53);
            this.txtRandomPostData.TabIndex = 1;
            // 
            // txtRandomCutRegex
            // 
            this.txtRandomCutRegex.Location = new System.Drawing.Point(81, 155);
            this.txtRandomCutRegex.Name = "txtRandomCutRegex";
            this.txtRandomCutRegex.Size = new System.Drawing.Size(429, 57);
            this.txtRandomCutRegex.TabIndex = 3;
            this.txtRandomCutRegex.Text = "";
            // 
            // v5LinkLabel1
            // 
            this.v5LinkLabel1.AutoSize = true;
            this.v5LinkLabel1.LabelValue = "[参数]";
            this.v5LinkLabel1.Location = new System.Drawing.Point(512, 158);
            this.v5LinkLabel1.Name = "v5LinkLabel1";
            this.v5LinkLabel1.RichTextBox = this.txtRandomCutRegex;
            this.v5LinkLabel1.Size = new System.Drawing.Size(29, 12);
            this.v5LinkLabel1.TabIndex = 4;
            this.v5LinkLabel1.TabStop = true;
            this.v5LinkLabel1.Text = "参数";
            // 
            // v5LinkLabel3
            // 
            this.v5LinkLabel3.AutoSize = true;
            this.v5LinkLabel3.LabelValue = "(*)";
            this.v5LinkLabel3.Location = new System.Drawing.Point(516, 181);
            this.v5LinkLabel3.Name = "v5LinkLabel3";
            this.v5LinkLabel3.RichTextBox = this.txtRandomCutRegex;
            this.v5LinkLabel3.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel3.TabIndex = 6;
            this.v5LinkLabel3.TabStop = true;
            this.v5LinkLabel3.Text = "(*)";
            // 
            // cmbRandomLabelType
            // 
            this.cmbRandomLabelType.FormattingEnabled = true;
            this.cmbRandomLabelType.Items.AddRange(new object[] {
            "登陆",
            "列表",
            "内容"});
            this.cmbRandomLabelType.Location = new System.Drawing.Point(432, 41);
            this.cmbRandomLabelType.Name = "cmbRandomLabelType";
            this.cmbRandomLabelType.Size = new System.Drawing.Size(109, 20);
            this.cmbRandomLabelType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "类型﹕";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 253);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRandomLabelType);
            this.Controls.Add(this.v5LinkLabel3);
            this.Controls.Add(this.v5LinkLabel1);
            this.Controls.Add(this.txtRandomCutRegex);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRandomPostData);
            this.Controls.Add(this.txtRandomRefUrl);
            this.Controls.Add(this.txtRandomUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLabelName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRandom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建随机值";
            this.Load += new System.EventHandler(this.frmRandom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRandomUrl;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtRandomRefUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRandomPostData;
        private System.Windows.Forms.Label label5;
        private V5RichTextBox txtRandomCutRegex;
        private V5LinkLabel v5LinkLabel1;
        private V5LinkLabel v5LinkLabel3;
        private System.Windows.Forms.ComboBox cmbRandomLabelType;
        private System.Windows.Forms.Label label6;
    }
}