namespace V5_DataCollection
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip_Bottom = new System.Windows.Forms.StatusStrip();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_TaskNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_TaskEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_TaskDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_SoftOption = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SoftAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Operate = new System.Windows.Forms.ToolStripMenuItem();
            this.重新启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Operate_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_View = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_View_TaskTree = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_View_TaskView = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_View_OutWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入WebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布模块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入PythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Tool_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_CommonSite = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ManageSite = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SoftUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.v5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Bottom
            // 
            this.statusStrip_Bottom.Location = new System.Drawing.Point(0, 540);
            this.statusStrip_Bottom.Name = "statusStrip_Bottom";
            this.statusStrip_Bottom.Size = new System.Drawing.Size(784, 22);
            this.statusStrip_Bottom.TabIndex = 0;
            this.statusStrip_Bottom.Text = "statusStrip1";
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.Control;
            this.dockPanel.Location = new System.Drawing.Point(0, 81);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.ShowDocumentIcon = true;
            this.dockPanel.Size = new System.Drawing.Size(784, 459);
            this.dockPanel.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::V5_DataCollection.Properties.Resources.背景2;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_TaskNew,
            this.toolStripButton_TaskEdit,
            this.toolStripButton_TaskDelete,
            this.toolStripSeparator1,
            this.toolStripButton_SoftOption,
            this.toolStripButton_SoftAbout,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 56);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_TaskNew
            // 
            this.toolStripButton_TaskNew.Image = global::V5_DataCollection.Properties.Resources.pic037;
            this.toolStripButton_TaskNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_TaskNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_TaskNew.Name = "toolStripButton_TaskNew";
            this.toolStripButton_TaskNew.Size = new System.Drawing.Size(36, 53);
            this.toolStripButton_TaskNew.Text = "新建";
            this.toolStripButton_TaskNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_TaskNew.Click += new System.EventHandler(this.toolStripButton_TaskNew_Click);
            // 
            // toolStripButton_TaskEdit
            // 
            this.toolStripButton_TaskEdit.Image = global::V5_DataCollection.Properties.Resources.pic040;
            this.toolStripButton_TaskEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_TaskEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_TaskEdit.Name = "toolStripButton_TaskEdit";
            this.toolStripButton_TaskEdit.Size = new System.Drawing.Size(36, 53);
            this.toolStripButton_TaskEdit.Text = "修改";
            this.toolStripButton_TaskEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_TaskEdit.Click += new System.EventHandler(this.toolStripButton_TaskEdit_Click);
            // 
            // toolStripButton_TaskDelete
            // 
            this.toolStripButton_TaskDelete.Image = global::V5_DataCollection.Properties.Resources.pic049;
            this.toolStripButton_TaskDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_TaskDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_TaskDelete.Name = "toolStripButton_TaskDelete";
            this.toolStripButton_TaskDelete.Size = new System.Drawing.Size(36, 53);
            this.toolStripButton_TaskDelete.Text = "删除";
            this.toolStripButton_TaskDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_TaskDelete.Click += new System.EventHandler(this.toolStripButton_TaskDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // toolStripButton_SoftOption
            // 
            this.toolStripButton_SoftOption.Image = global::V5_DataCollection.Properties.Resources.pic041;
            this.toolStripButton_SoftOption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_SoftOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SoftOption.Name = "toolStripButton_SoftOption";
            this.toolStripButton_SoftOption.Size = new System.Drawing.Size(36, 53);
            this.toolStripButton_SoftOption.Text = "选项";
            this.toolStripButton_SoftOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_SoftOption.Click += new System.EventHandler(this.toolStripButton_SoftOption_Click);
            // 
            // toolStripButton_SoftAbout
            // 
            this.toolStripButton_SoftAbout.Image = global::V5_DataCollection.Properties.Resources.pic062;
            this.toolStripButton_SoftAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_SoftAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SoftAbout.Name = "toolStripButton_SoftAbout";
            this.toolStripButton_SoftAbout.Size = new System.Drawing.Size(36, 53);
            this.toolStripButton_SoftAbout.Text = "帮助";
            this.toolStripButton_SoftAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_SoftAbout.Click += new System.EventHandler(this.toolStripButton_SoftAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.BackgroundImage = global::V5_DataCollection.Properties.Resources.背景1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Operate,
            this.ToolStripMenuItem_View,
            this.导入ToolStripMenuItem,
            this.ToolStripMenuItem_Config,
            this.ToolStripMenuItem_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Operate
            // 
            this.ToolStripMenuItem_Operate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新启动ToolStripMenuItem,
            this.ToolStripMenuItem_Operate_Exit});
            this.ToolStripMenuItem_Operate.Name = "ToolStripMenuItem_Operate";
            this.ToolStripMenuItem_Operate.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Operate.Text = "&操作";
            // 
            // 重新启动ToolStripMenuItem
            // 
            this.重新启动ToolStripMenuItem.Name = "重新启动ToolStripMenuItem";
            this.重新启动ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新启动ToolStripMenuItem.Text = "重新启动";
            this.重新启动ToolStripMenuItem.Click += new System.EventHandler(this.重新启动ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Operate_Exit
            // 
            this.ToolStripMenuItem_Operate_Exit.Name = "ToolStripMenuItem_Operate_Exit";
            this.ToolStripMenuItem_Operate_Exit.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_Operate_Exit.Text = "退出";
            this.ToolStripMenuItem_Operate_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Operate_Exit_Click);
            // 
            // ToolStripMenuItem_View
            // 
            this.ToolStripMenuItem_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_View_TaskTree,
            this.ToolStripMenuItem_View_TaskView,
            this.ToolStripMenuItem_View_OutWindow});
            this.ToolStripMenuItem_View.Name = "ToolStripMenuItem_View";
            this.ToolStripMenuItem_View.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_View.Text = "&视图";
            // 
            // ToolStripMenuItem_View_TaskTree
            // 
            this.ToolStripMenuItem_View_TaskTree.Name = "ToolStripMenuItem_View_TaskTree";
            this.ToolStripMenuItem_View_TaskTree.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_View_TaskTree.Text = "任务列表树";
            this.ToolStripMenuItem_View_TaskTree.Click += new System.EventHandler(this.ToolStripMenuItem_View_TaskTree_Click);
            // 
            // ToolStripMenuItem_View_TaskView
            // 
            this.ToolStripMenuItem_View_TaskView.Name = "ToolStripMenuItem_View_TaskView";
            this.ToolStripMenuItem_View_TaskView.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_View_TaskView.Text = "任务列表";
            this.ToolStripMenuItem_View_TaskView.Click += new System.EventHandler(this.ToolStripMenuItem_View_TaskView_Click);
            // 
            // ToolStripMenuItem_View_OutWindow
            // 
            this.ToolStripMenuItem_View_OutWindow.Name = "ToolStripMenuItem_View_OutWindow";
            this.ToolStripMenuItem_View_OutWindow.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_View_OutWindow.Text = "输出窗口";
            this.ToolStripMenuItem_View_OutWindow.Click += new System.EventHandler(this.ToolStripMenuItem_View_OutWindow_Click);
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入WebToolStripMenuItem,
            this.发布模块ToolStripMenuItem,
            this.导入PythonToolStripMenuItem});
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.导入ToolStripMenuItem.Text = "&导入";
            // 
            // 导入WebToolStripMenuItem
            // 
            this.导入WebToolStripMenuItem.Name = "导入WebToolStripMenuItem";
            this.导入WebToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.导入WebToolStripMenuItem.Text = "导入采集规则";
            this.导入WebToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_ImportWebCollection_Click);
            // 
            // 发布模块ToolStripMenuItem
            // 
            this.发布模块ToolStripMenuItem.Name = "发布模块ToolStripMenuItem";
            this.发布模块ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.发布模块ToolStripMenuItem.Text = "导入发布模块";
            this.发布模块ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_ImportWebPublish_Click);
            // 
            // 导入PythonToolStripMenuItem
            // 
            this.导入PythonToolStripMenuItem.Name = "导入PythonToolStripMenuItem";
            this.导入PythonToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.导入PythonToolStripMenuItem.Text = "导入Python脚本";
            this.导入PythonToolStripMenuItem.Click += new System.EventHandler(this.导入PythonToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Config
            // 
            this.ToolStripMenuItem_Config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Tool_Config,
            this.toolStripMenuItem2,
            this.ToolStripMenuItem_CommonSite,
            this.测试ToolStripMenuItem});
            this.ToolStripMenuItem_Config.Name = "ToolStripMenuItem_Config";
            this.ToolStripMenuItem_Config.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Config.Text = "&工具";
            // 
            // ToolStripMenuItem_Tool_Config
            // 
            this.ToolStripMenuItem_Tool_Config.Name = "ToolStripMenuItem_Tool_Config";
            this.ToolStripMenuItem_Tool_Config.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Tool_Config.Text = "选项";
            this.ToolStripMenuItem_Tool_Config.Click += new System.EventHandler(this.ToolStripMenuItem_Tool_Config_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStripMenuItem_CommonSite
            // 
            this.ToolStripMenuItem_CommonSite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ManageSite});
            this.ToolStripMenuItem_CommonSite.Name = "ToolStripMenuItem_CommonSite";
            this.ToolStripMenuItem_CommonSite.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_CommonSite.Text = "常用工具";
            // 
            // ToolStripMenuItem_ManageSite
            // 
            this.ToolStripMenuItem_ManageSite.Name = "ToolStripMenuItem_ManageSite";
            this.ToolStripMenuItem_ManageSite.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_ManageSite.Text = "管理工具";
            this.ToolStripMenuItem_ManageSite.Click += new System.EventHandler(this.ToolStripMenuItem_ManageSite_Click);
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SoftUpdate,
            this.ToolStripMenuItem_AboutUs,
            this.v5ToolStripMenuItem});
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_About.Text = "&关于";
            // 
            // ToolStripMenuItem_SoftUpdate
            // 
            this.ToolStripMenuItem_SoftUpdate.Name = "ToolStripMenuItem_SoftUpdate";
            this.ToolStripMenuItem_SoftUpdate.Size = new System.Drawing.Size(127, 22);
            this.ToolStripMenuItem_SoftUpdate.Text = "软件更新";
            this.ToolStripMenuItem_SoftUpdate.Click += new System.EventHandler(this.ToolStripMenuItem_SoftUpdate_Click);
            // 
            // ToolStripMenuItem_AboutUs
            // 
            this.ToolStripMenuItem_AboutUs.Name = "ToolStripMenuItem_AboutUs";
            this.ToolStripMenuItem_AboutUs.Size = new System.Drawing.Size(127, 22);
            this.ToolStripMenuItem_AboutUs.Text = "关于我们";
            this.ToolStripMenuItem_AboutUs.Click += new System.EventHandler(this.ToolStripMenuItem_AboutUs_Click);
            // 
            // v5ToolStripMenuItem
            // 
            this.v5ToolStripMenuItem.Name = "v5ToolStripMenuItem";
            this.v5ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.v5ToolStripMenuItem.Text = "V5软件网";
            this.v5ToolStripMenuItem.Click += new System.EventHandler(this.v5ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip_Bottom);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V5软件采集系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Bottom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Operate;
        private System.Windows.Forms.ToolStripButton toolStripButton_TaskNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Operate_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_View;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_View_TaskTree;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_View_TaskView;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_View_OutWindow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Config;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tool_Config;
        private System.Windows.Forms.ToolStripButton toolStripButton_TaskEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton_TaskDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_SoftOption;
        private System.Windows.Forms.ToolStripButton toolStripButton_SoftAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入WebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布模块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AboutUs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SoftUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CommonSite;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ManageSite;
        private System.Windows.Forms.ToolStripMenuItem 重新启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 导入PythonToolStripMenuItem;
    }
}

