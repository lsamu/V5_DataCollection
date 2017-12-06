namespace V5_DataPublish.Forms.Desk {
    partial class frmAutoCreateArticle {
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
            this.txtContentKeyWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContentLength = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSubmitInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键词";
            // 
            // txtContentKeyWord
            // 
            this.txtContentKeyWord.Location = new System.Drawing.Point(70, 12);
            this.txtContentKeyWord.Name = "txtContentKeyWord";
            this.txtContentKeyWord.Size = new System.Drawing.Size(275, 21);
            this.txtContentKeyWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "字数";
            // 
            // txtContentLength
            // 
            this.txtContentLength.Location = new System.Drawing.Point(70, 39);
            this.txtContentLength.Name = "txtContentLength";
            this.txtContentLength.Size = new System.Drawing.Size(51, 21);
            this.txtContentLength.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(515, 314);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "确定(&S)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(605, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_List);
            this.groupBox1.Location = new System.Drawing.Point(26, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "内容列表";
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView_List.Location = new System.Drawing.Point(57, 20);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.Size = new System.Drawing.Size(581, 150);
            this.dataGridView_List.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "标题";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Url";
            this.Column3.HeaderText = "地址";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Summary";
            this.Column2.HeaderText = "简介";
            this.Column2.Name = "Column2";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(575, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "随机生成文章";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSubmitInsert
            // 
            this.btnSubmitInsert.Location = new System.Drawing.Point(390, 314);
            this.btnSubmitInsert.Name = "btnSubmitInsert";
            this.btnSubmitInsert.Size = new System.Drawing.Size(105, 23);
            this.btnSubmitInsert.TabIndex = 5;
            this.btnSubmitInsert.Text = "确定并插入(&O)";
            this.btnSubmitInsert.UseVisualStyleBackColor = true;
            this.btnSubmitInsert.Click += new System.EventHandler(this.btnSubmitInsert_Click);
            // 
            // frmAutoCreateArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 352);
            this.Controls.Add(this.btnSubmitInsert);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtContentLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContentKeyWord);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutoCreateArticle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "随机生成文章";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContentKeyWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContentLength;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSubmitInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}