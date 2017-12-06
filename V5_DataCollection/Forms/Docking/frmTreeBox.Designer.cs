namespace V5_DataCollection.Forms.Docking
{
    partial class frmTreeBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeBox));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("任务计划");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("采集分类");
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton__AddTaskTreeClass = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_EditTaskTreeClass = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DelTaskTreeClass = new System.Windows.Forms.ToolStripButton();
            this.treeView_TaskList = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_Tree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_AddTaskTreeClass = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EditTaskTreeClass = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DelTaskTreeClass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip_Tree.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::V5_DataCollection.Properties.Resources.背景;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton__AddTaskTreeClass,
            this.toolStripButton_EditTaskTreeClass,
            this.toolStripButton_DelTaskTreeClass});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(345, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton__AddTaskTreeClass
            // 
            this.toolStripButton__AddTaskTreeClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton__AddTaskTreeClass.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton__AddTaskTreeClass.Image")));
            this.toolStripButton__AddTaskTreeClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton__AddTaskTreeClass.Name = "toolStripButton__AddTaskTreeClass";
            this.toolStripButton__AddTaskTreeClass.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton__AddTaskTreeClass.Text = "添加";
            this.toolStripButton__AddTaskTreeClass.Click += new System.EventHandler(this.toolStripButton_AddTaskTreeClass_Click);
            // 
            // toolStripButton_EditTaskTreeClass
            // 
            this.toolStripButton_EditTaskTreeClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_EditTaskTreeClass.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_EditTaskTreeClass.Image")));
            this.toolStripButton_EditTaskTreeClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_EditTaskTreeClass.Name = "toolStripButton_EditTaskTreeClass";
            this.toolStripButton_EditTaskTreeClass.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_EditTaskTreeClass.Text = "修改";
            this.toolStripButton_EditTaskTreeClass.Click += new System.EventHandler(this.toolStripButton_EditTaskTreeClass_Click);
            // 
            // toolStripButton_DelTaskTreeClass
            // 
            this.toolStripButton_DelTaskTreeClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_DelTaskTreeClass.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DelTaskTreeClass.Image")));
            this.toolStripButton_DelTaskTreeClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DelTaskTreeClass.Name = "toolStripButton_DelTaskTreeClass";
            this.toolStripButton_DelTaskTreeClass.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_DelTaskTreeClass.Text = "删除";
            this.toolStripButton_DelTaskTreeClass.Click += new System.EventHandler(this.toolStripButton_DelTaskTreeClass_Click);
            // 
            // treeView_TaskList
            // 
            this.treeView_TaskList.ContextMenuStrip = this.contextMenuStrip_Tree;
            this.treeView_TaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TaskList.Location = new System.Drawing.Point(0, 25);
            this.treeView_TaskList.Name = "treeView_TaskList";
            treeNode1.Name = "节点2";
            treeNode1.Text = "任务计划";
            treeNode2.Name = "节点0";
            treeNode2.Text = "采集分类";
            this.treeView_TaskList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView_TaskList.Size = new System.Drawing.Size(345, 422);
            this.treeView_TaskList.TabIndex = 1;
            this.treeView_TaskList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_TaskList_AfterSelect);
            // 
            // contextMenuStrip_Tree
            // 
            this.contextMenuStrip_Tree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddTaskTreeClass,
            this.ToolStripMenuItem_EditTaskTreeClass,
            this.ToolStripMenuItem_DelTaskTreeClass,
            this.toolStripMenuItem2});
            this.contextMenuStrip_Tree.Name = "contextMenuStrip_Tree";
            this.contextMenuStrip_Tree.Size = new System.Drawing.Size(149, 76);
            // 
            // ToolStripMenuItem_AddTaskTreeClass
            // 
            this.ToolStripMenuItem_AddTaskTreeClass.Name = "ToolStripMenuItem_AddTaskTreeClass";
            this.ToolStripMenuItem_AddTaskTreeClass.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_AddTaskTreeClass.Text = "添加任务分类";
            this.ToolStripMenuItem_AddTaskTreeClass.Click += new System.EventHandler(this.ToolStripMenuItem_AddTaskTreeClass_Click);
            // 
            // ToolStripMenuItem_EditTaskTreeClass
            // 
            this.ToolStripMenuItem_EditTaskTreeClass.Name = "ToolStripMenuItem_EditTaskTreeClass";
            this.ToolStripMenuItem_EditTaskTreeClass.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_EditTaskTreeClass.Text = "修改任务分类";
            this.ToolStripMenuItem_EditTaskTreeClass.Click += new System.EventHandler(this.ToolStripMenuItem_EditTaskTreeClass_Click);
            // 
            // ToolStripMenuItem_DelTaskTreeClass
            // 
            this.ToolStripMenuItem_DelTaskTreeClass.Name = "ToolStripMenuItem_DelTaskTreeClass";
            this.ToolStripMenuItem_DelTaskTreeClass.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_DelTaskTreeClass.Text = "删除任务分类";
            this.ToolStripMenuItem_DelTaskTreeClass.Click += new System.EventHandler(this.ToolStripMenuItem_DelTaskTreeClass_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // frmTreeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 447);
            this.Controls.Add(this.treeView_TaskList);
            this.Controls.Add(this.toolStrip1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HideOnClose = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTreeBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "菜单列表";
            this.Load += new System.EventHandler(this.frmTreeBox_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip_Tree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView treeView_TaskList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Tree;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddTaskTreeClass;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DelTaskTreeClass;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton toolStripButton__AddTaskTreeClass;
        private System.Windows.Forms.ToolStripButton toolStripButton_EditTaskTreeClass;
        private System.Windows.Forms.ToolStripButton toolStripButton_DelTaskTreeClass;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EditTaskTreeClass;
    }
}