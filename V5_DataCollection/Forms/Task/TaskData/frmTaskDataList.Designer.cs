

using V5_WinControls.Pager;

namespace V5_DataCollection.Forms.Task.TaskData {
    partial class frmTaskDataList {
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView_DataList = new System.Windows.Forms.DataGridView();
            this.Pager = new Pager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(861, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView_DataList
            // 
            this.dataGridView_DataList.AllowUserToAddRows = false;
            this.dataGridView_DataList.AllowUserToOrderColumns = true;
            this.dataGridView_DataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DataList.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_DataList.MultiSelect = false;
            this.dataGridView_DataList.Name = "dataGridView_DataList";
            this.dataGridView_DataList.ReadOnly = true;
            this.dataGridView_DataList.RowTemplate.Height = 23;
            this.dataGridView_DataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DataList.ShowCellToolTips = false;
            this.dataGridView_DataList.Size = new System.Drawing.Size(861, 517);
            this.dataGridView_DataList.TabIndex = 2;
            this.dataGridView_DataList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DataList_CellContentDoubleClick);
            // 
            // Pager
            // 
            this.Pager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pager.Location = new System.Drawing.Point(0, 542);
            this.Pager.Name = "Pager";
            this.Pager.NMax = 0;
            this.Pager.PageCount = 0;
            this.Pager.PageCurrent = 0;
            this.Pager.PageSize = 20;
            this.Pager.Size = new System.Drawing.Size(861, 30);
            this.Pager.TabIndex = 1;
            this.Pager.EventPaging += new EventPagingHandler(this.Pager_EventPaging);
            // 
            // frmTaskDataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 572);
            this.Controls.Add(this.dataGridView_DataList);
            this.Controls.Add(this.Pager);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskDataList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务所有数据";
            this.Load += new System.EventHandler(this.frmTaskDataList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Pager Pager;
        private System.Windows.Forms.DataGridView dataGridView_DataList;
    }
}