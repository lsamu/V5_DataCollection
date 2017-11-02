namespace V5_DataCollection.Forms.Tools {
    partial class frmSQL {
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
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(12, 43);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(679, 151);
            this.txtSQL.TabIndex = 0;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 14);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Ö´ÐÐSQL";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(679, 212);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtSQL);
            this.Name = "frmSQL";
            this.Text = "frmSQL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}