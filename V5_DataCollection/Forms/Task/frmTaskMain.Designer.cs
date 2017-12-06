using V5_WinControls;
using V5_WinControls.DataGrid;

namespace V5_DataCollection.Forms.Task {
    partial class FrmTaskMain {
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
            this.contextMenuStrip_TaskList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_TaskNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TaskEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TaskDel = new System.Windows.Forms.ToolStripMenuItem();
            this.复制任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_TaskStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TaskPause = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TaskStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_ClearTaskAllData = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ReCreateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ViewTaskData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.计划任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出采集规则ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_TaskList = new V5_WinControls.V5DataGridView(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskProps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressBar = new V5_WinControls.DataGrid.DataGridViewProgressBarColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_TaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip_TaskList
            // 
            this.contextMenuStrip_TaskList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_TaskNew,
            this.ToolStripMenuItem_TaskEdit,
            this.ToolStripMenuItem_TaskDel,
            this.复制任务ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ToolStripMenuItem_TaskStart,
            this.ToolStripMenuItem_TaskPause,
            this.ToolStripMenuItem_TaskStop,
            this.toolStripMenuItem2,
            this.ToolStripMenuItem_ClearTaskAllData,
            this.ToolStripMenuItem_ReCreateTable,
            this.ToolStripMenuItem_ViewTaskData,
            this.toolStripMenuItem3,
            this.计划任务ToolStripMenuItem,
            this.导出采集规则ToolStripMenuItem});
            this.contextMenuStrip_TaskList.Name = "contextMenuStrip_TaskList";
            this.contextMenuStrip_TaskList.Size = new System.Drawing.Size(185, 286);
            // 
            // ToolStripMenuItem_TaskNew
            // 
            this.ToolStripMenuItem_TaskNew.Name = "ToolStripMenuItem_TaskNew";
            this.ToolStripMenuItem_TaskNew.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_TaskNew.Text = "新建任务";
            this.ToolStripMenuItem_TaskNew.Click += new System.EventHandler(this.ToolStripMenuItem_TaskNew_Click);
            // 
            // ToolStripMenuItem_TaskEdit
            // 
            this.ToolStripMenuItem_TaskEdit.Name = "ToolStripMenuItem_TaskEdit";
            this.ToolStripMenuItem_TaskEdit.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_TaskEdit.Text = "编辑任务";
            this.ToolStripMenuItem_TaskEdit.Click += new System.EventHandler(this.ToolStripMenuItem_TaskEdit_Click);
            // 
            // ToolStripMenuItem_TaskDel
            // 
            this.ToolStripMenuItem_TaskDel.Name = "ToolStripMenuItem_TaskDel";
            this.ToolStripMenuItem_TaskDel.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_TaskDel.Text = "删除任务";
            this.ToolStripMenuItem_TaskDel.Click += new System.EventHandler(this.ToolStripMenuItem_TaskDel_Click);
            // 
            // 复制任务ToolStripMenuItem
            // 
            this.复制任务ToolStripMenuItem.Name = "复制任务ToolStripMenuItem";
            this.复制任务ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.复制任务ToolStripMenuItem.Text = "复制任务";
            this.复制任务ToolStripMenuItem.Click += new System.EventHandler(this.复制任务ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // ToolStripMenuItem_TaskStart
            // 
            this.ToolStripMenuItem_TaskStart.Name = "ToolStripMenuItem_TaskStart";
            this.ToolStripMenuItem_TaskStart.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_TaskStart.Text = "开始任务";
            this.ToolStripMenuItem_TaskStart.Click += new System.EventHandler(this.ToolStripMenuItem_TaskStart_Click);
            // 
            // ToolStripMenuItem_TaskPause
            // 
            this.ToolStripMenuItem_TaskPause.Name = "ToolStripMenuItem_TaskPause";
            this.ToolStripMenuItem_TaskPause.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_TaskPause.Text = "暂停任务";
            this.ToolStripMenuItem_TaskPause.Click += new System.EventHandler(this.ToolStripMenuItem_TaskPause_Click);
            // 
            // ToolStripMenuItem_TaskStop
            // 
            this.ToolStripMenuItem_TaskStop.Name = "ToolStripMenuItem_TaskStop";
            this.ToolStripMenuItem_TaskStop.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_TaskStop.Text = "停止任务";
            this.ToolStripMenuItem_TaskStop.Click += new System.EventHandler(this.ToolStripMenuItem_TaskStop_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // ToolStripMenuItem_ClearTaskAllData
            // 
            this.ToolStripMenuItem_ClearTaskAllData.Name = "ToolStripMenuItem_ClearTaskAllData";
            this.ToolStripMenuItem_ClearTaskAllData.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_ClearTaskAllData.Text = "清除此任务所有数据";
            this.ToolStripMenuItem_ClearTaskAllData.Click += new System.EventHandler(this.ToolStripMenuItem_ClearTaskAllData_Click);
            // 
            // ToolStripMenuItem_ReCreateTable
            // 
            this.ToolStripMenuItem_ReCreateTable.Name = "ToolStripMenuItem_ReCreateTable";
            this.ToolStripMenuItem_ReCreateTable.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_ReCreateTable.Text = "重新建立数据库结构";
            this.ToolStripMenuItem_ReCreateTable.Click += new System.EventHandler(this.ToolStripMenuItem_ReCreateTable_Click);
            // 
            // ToolStripMenuItem_ViewTaskData
            // 
            this.ToolStripMenuItem_ViewTaskData.Name = "ToolStripMenuItem_ViewTaskData";
            this.ToolStripMenuItem_ViewTaskData.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_ViewTaskData.Text = "查看此任务数据";
            this.ToolStripMenuItem_ViewTaskData.Click += new System.EventHandler(this.ToolStripMenuItem_ViewTaskData_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
            // 
            // 计划任务ToolStripMenuItem
            // 
            this.计划任务ToolStripMenuItem.Name = "计划任务ToolStripMenuItem";
            this.计划任务ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.计划任务ToolStripMenuItem.Text = "计划任务";
            this.计划任务ToolStripMenuItem.Click += new System.EventHandler(this.计划任务ToolStripMenuItem_Click);
            // 
            // 导出采集规则ToolStripMenuItem
            // 
            this.导出采集规则ToolStripMenuItem.Name = "导出采集规则ToolStripMenuItem";
            this.导出采集规则ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.导出采集规则ToolStripMenuItem.Text = "导出采集规则";
            this.导出采集规则ToolStripMenuItem.Click += new System.EventHandler(this.导出采集规则ToolStripMenuItem_Click);
            // 
            // dataGridView_TaskList
            // 
            this.dataGridView_TaskList.AllowUserToAddRows = false;
            this.dataGridView_TaskList.AllowUserToDeleteRows = false;
            this.dataGridView_TaskList.AllowUserToResizeRows = false;
            this.dataGridView_TaskList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_TaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Col_ClassId,
            this.Status,
            this.Column2,
            this.TaskProps,
            this.Col_TaskId,
            this.ProgressBar,
            this.Column1});
            this.dataGridView_TaskList.ContextMenuStrip = this.contextMenuStrip_TaskList;
            this.dataGridView_TaskList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_TaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_TaskList.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_TaskList.Name = "dataGridView_TaskList";
            this.dataGridView_TaskList.ReadOnly = true;
            this.dataGridView_TaskList.RowHeadersVisible = false;
            this.dataGridView_TaskList.RowTemplate.Height = 23;
            this.dataGridView_TaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TaskList.Size = new System.Drawing.Size(738, 465);
            this.dataGridView_TaskList.TabIndex = 1;
            this.dataGridView_TaskList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TaskList_CellDoubleClick);
            this.dataGridView_TaskList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_TaskList_CellFormatting);
            this.dataGridView_TaskList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_TaskList_CellMouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "状态";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TaskName";
            this.dataGridViewTextBoxColumn3.HeaderText = "任务名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Col_ClassId
            // 
            this.Col_ClassId.DataPropertyName = "ClassName";
            this.Col_ClassId.HeaderText = "所属分类";
            this.Col_ClassId.Name = "Col_ClassId";
            this.Col_ClassId.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TaskName";
            this.Column2.HeaderText = "任务名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // TaskProps
            // 
            this.TaskProps.HeaderText = "任务属性";
            this.TaskProps.Name = "TaskProps";
            this.TaskProps.ReadOnly = true;
            // 
            // Col_TaskId
            // 
            this.Col_TaskId.DataPropertyName = "IsPlan";
            this.Col_TaskId.HeaderText = "计划任务";
            this.Col_TaskId.Name = "Col_TaskId";
            this.Col_TaskId.ReadOnly = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.HeaderText = "进度";
            this.ProgressBar.Maximum = 100;
            this.ProgressBar.Mimimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ReadOnly = true;
            this.ProgressBar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FrmTaskMain
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 465);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.dataGridView_TaskList);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideOnClose = true;
            this.Name = "FrmTaskMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "采集任务";
            this.Load += new System.EventHandler(this.FrmTaskMain_Load);
            this.contextMenuStrip_TaskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_TaskList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TaskNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TaskEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TaskDel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TaskStart;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TaskPause;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TaskStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private V5DataGridView dataGridView_TaskList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ClearTaskAllData;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ReCreateTable;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ViewTaskData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 计划任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出采集规则ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskProps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TaskId;
        private DataGridViewProgressBarColumn ProgressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}