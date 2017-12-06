using V5_WinControls.Pager;

namespace V5_DataPublish.Forms.WebSite {
    partial class frmWebSiteLogList {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebSiteLogList));
            this.pager1 = new Pager();
            this.dataGridView_LogList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.s删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LogList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pager1
            // 
            this.pager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager1.Location = new System.Drawing.Point(0, 399);
            this.pager1.Name = "pager1";
            this.pager1.NMax = 0;
            this.pager1.PageCount = 0;
            this.pager1.PageCurrent = 0;
            this.pager1.PageSize = 20;
            this.pager1.Size = new System.Drawing.Size(728, 30);
            this.pager1.TabIndex = 1;
            // 
            // dataGridView_LogList
            // 
            this.dataGridView_LogList.AllowUserToAddRows = false;
            this.dataGridView_LogList.AllowUserToDeleteRows = false;
            this.dataGridView_LogList.AllowUserToResizeRows = false;
            this.dataGridView_LogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LogList.ColumnHeadersVisible = false;
            this.dataGridView_LogList.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LogList.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_LogList.Name = "dataGridView_LogList";
            this.dataGridView_LogList.RowHeadersVisible = false;
            this.dataGridView_LogList.RowTemplate.Height = 23;
            this.dataGridView_LogList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LogList.Size = new System.Drawing.Size(728, 374);
            this.dataGridView_LogList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s删除ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // s删除ToolStripMenuItem
            // 
            this.s删除ToolStripMenuItem.Name = "s删除ToolStripMenuItem";
            this.s删除ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.s删除ToolStripMenuItem.Text = "删除";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton1.Text = "查看";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton2.Text = "删除";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "删除所有";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton4.Text = "关闭";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // frmWebSiteLogList
            // 
            this.ClientSize = new System.Drawing.Size(728, 429);
            this.Controls.Add(this.dataGridView_LogList);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWebSiteLogList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "网站发布日志查看";
            this.Load += new System.EventHandler(this.frmWebSiteLogList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LogList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pager pager1;
        private System.Windows.Forms.DataGridView dataGridView_LogList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem s删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}
