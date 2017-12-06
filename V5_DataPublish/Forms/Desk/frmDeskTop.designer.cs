namespace V5_DataPublish.Forms.Desk
{
    partial class frmDeskTop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_HandInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.手动插入自定义接口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.web工具列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拾色器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip_Menu
            // 
            this.contextMenuStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_HandInsert,
            this.手动插入自定义接口ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.web工具列表ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.配置ToolStripMenuItem,
            this.ToolStripMenuItem_Exit});
            this.contextMenuStrip_Menu.Name = "contextMenuStrip_Menu";
            this.contextMenuStrip_Menu.Size = new System.Drawing.Size(185, 148);
            // 
            // ToolStripMenuItem_HandInsert
            // 
            this.ToolStripMenuItem_HandInsert.Name = "ToolStripMenuItem_HandInsert";
            this.ToolStripMenuItem_HandInsert.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_HandInsert.Text = "手动插入";
            this.ToolStripMenuItem_HandInsert.Click += new System.EventHandler(this.ToolStripMenuItem_HandInsert_Click);
            // 
            // 手动插入自定义接口ToolStripMenuItem
            // 
            this.手动插入自定义接口ToolStripMenuItem.Name = "手动插入自定义接口ToolStripMenuItem";
            this.手动插入自定义接口ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.手动插入自定义接口ToolStripMenuItem.Text = "手动插入自定义接口";
            this.手动插入自定义接口ToolStripMenuItem.Click += new System.EventHandler(this.手动插入自定义接口ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // web工具列表ToolStripMenuItem
            // 
            this.web工具列表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.截图ToolStripMenuItem,
            this.拾色器ToolStripMenuItem});
            this.web工具列表ToolStripMenuItem.Name = "web工具列表ToolStripMenuItem";
            this.web工具列表ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.web工具列表ToolStripMenuItem.Text = "Web工具列表";
            // 
            // 截图ToolStripMenuItem
            // 
            this.截图ToolStripMenuItem.Name = "截图ToolStripMenuItem";
            this.截图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.截图ToolStripMenuItem.Text = "截图";
            // 
            // 拾色器ToolStripMenuItem
            // 
            this.拾色器ToolStripMenuItem.Name = "拾色器ToolStripMenuItem";
            this.拾色器ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.拾色器ToolStripMenuItem.Text = "拾色器";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_Exit.Text = "退出";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // frmDeskTop
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(109)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(44, 44);
            this.ContextMenuStrip = this.contextMenuStrip_Menu;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeskTop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "悬浮框";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDeskTop_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmDeskTop_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmDeskTop_DragEnter);
            this.DoubleClick += new System.EventHandler(this.frmDeskTop_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDeskTop_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDeskTop_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDeskTop_MouseUp);
            this.contextMenuStrip_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_HandInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem web工具列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 截图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拾色器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手动插入自定义接口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
    }
}