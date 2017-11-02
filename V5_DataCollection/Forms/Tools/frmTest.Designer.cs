
using V5_WinControls;
using V5_WinControls.DataGrid;

namespace V5_DataCollection.Forms.Tools {
    partial class frmTest {
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
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.v5DataGridView1 = new V5_WinControls.V5DataGridView(this.components);
            this.Name_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pross_1 = new V5_WinControls.DataGrid.DataGridViewProgressBarColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProgressBarColumn1 = new V5_WinControls.DataGrid.DataGridViewProgressBarColumn();
            this.btnTestPython = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v5DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(35, 12);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(120, 23);
            this.btnDownLoad.TabIndex = 0;
            this.btnDownLoad.Text = "测试下载队列";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "动态添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "测试返回HTML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(35, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试HTML类库";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "测试句柄";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // v5DataGridView1
            // 
            this.v5DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v5DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_1,
            this.Pross_1});
            this.v5DataGridView1.Location = new System.Drawing.Point(35, 90);
            this.v5DataGridView1.Name = "v5DataGridView1";
            this.v5DataGridView1.RowHeadersVisible = false;
            this.v5DataGridView1.RowTemplate.Height = 23;
            this.v5DataGridView1.Size = new System.Drawing.Size(423, 161);
            this.v5DataGridView1.TabIndex = 3;
            // 
            // Name_1
            // 
            this.Name_1.HeaderText = "名称";
            this.Name_1.Name = "Name_1";
            // 
            // Pross_1
            // 
            this.Pross_1.HeaderText = "进度";
            this.Pross_1.Maximum = 100;
            this.Pross_1.Mimimum = 0;
            this.Pross_1.Name = "Pross_1";
            this.Pross_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewProgressBarColumn1
            // 
            this.dataGridViewProgressBarColumn1.HeaderText = "进度";
            this.dataGridViewProgressBarColumn1.Maximum = 100;
            this.dataGridViewProgressBarColumn1.Mimimum = 0;
            this.dataGridViewProgressBarColumn1.Name = "dataGridViewProgressBarColumn1";
            this.dataGridViewProgressBarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnTestPython
            // 
            this.btnTestPython.Location = new System.Drawing.Point(271, 330);
            this.btnTestPython.Name = "btnTestPython";
            this.btnTestPython.Size = new System.Drawing.Size(75, 23);
            this.btnTestPython.TabIndex = 9;
            this.btnTestPython.Text = "测试Python";
            this.btnTestPython.UseVisualStyleBackColor = true;
            this.btnTestPython.Click += new System.EventHandler(this.btnTestPython_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 418);
            this.Controls.Add(this.btnTestPython);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.v5DataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDownLoad);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v5DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewProgressBarColumn dataGridViewProgressBarColumn1;
        private V5DataGridView v5DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_1;
        private DataGridViewProgressBarColumn Pross_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTestPython;
    }
}