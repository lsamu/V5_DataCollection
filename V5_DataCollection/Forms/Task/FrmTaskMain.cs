using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using V5_Model;
using V5_DataCollection._Class.Common;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;
using V5_DataCollection._Class.Gather;
using V5_DataCollection.Forms.Task.TaskData;
using V5_DataCollection.Forms.Task.Tools;
using V5_DataCollection._Class.DAL;
using V5_WinLibs.Core;
using V5_Utility.Utility;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection.Forms.Task {

    public partial class FrmTaskMain : BaseContent {

        #region 变量参数
        Dictionary<string, SpiderHelper> listGatherTask = new Dictionary<string, SpiderHelper>();

        public MainEventHandler.OutPutWindowHandler OutPutWindowDelegate;

        public int ClassID { get; set; } = 0;
        #endregion

        #region 主窗体操作
        public FrmTaskMain() {
            InitializeComponent();
            this.dataGridView_TaskList.AutoGenerateColumns = false;
            this.dataGridView_TaskList.AllowUserToAddRows = false;
        }

        private void FrmTaskMain_Load(object sender, EventArgs e) {
            Bind_DataList();
        }

        /// <summary>
        /// 绑定任务列表
        /// </summary>
        public void Bind_DataList() {
            Bind_DataList(string.Empty);
        }

        public void Bind_DataList(string strWhere) {
            if (this.ClassID > 0) {
                strWhere += " And TaskClassID=" + this.ClassID + " ";
            }
            strWhere += " Order by Id Desc ";
            DALTask dal = new DALTask();
            DataTable dt = dal.GetList(strWhere).Tables[0];
            this.dataGridView_TaskList.DataSource = dt.DefaultView;

            for (int i = 0; i < this.dataGridView_TaskList.Rows.Count; i++) {
                var row = this.dataGridView_TaskList.Rows[i];
                row.Selected = false;
                if (i == m_RowIndex) {
                    row.Selected = true;
                }
            }
        }


        /// <summary>
        /// 数据格式化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_TaskList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (this.dataGridView_TaskList.Columns[e.ColumnIndex].Name.ToLower() == "status") {
                string s = e.Value.ToString();
                if (s == "1") {
                    e.Value = "正常";
                }
                else {
                    e.Value = "暂停";
                }
            }

            if (this.dataGridView_TaskList.Columns[e.ColumnIndex].Name.ToLower() == "col_taskid") {
                string s = e.Value.ToString();
                if (s == "1") {
                    e.Value = "运行中";
                }
                else {
                    e.Value = "停止";
                }
            }
            if (this.dataGridView_TaskList.Columns[e.ColumnIndex].Name.ToLower() == "col_classid") {
                string s = e.Value.ToString();
                if (s == string.Empty) {
                    e.Value = "未分类";
                }
            }
        }

        private void dataGridView_TaskList_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var viewIds = Get_DataViewIDs();

            var FormTaskEdit = new FrmTaskEdit();
            FormTaskEdit.TaskOpDelegate = OutTaskOpDelegate;
            FormTaskEdit.ID = int.Parse(viewIds[0]);
            FormTaskEdit.TaskIndex = this.dataGridView_TaskList.SelectedRows[0].Index;
            FormTaskEdit.ShowDialog(this);
        }

        int m_RowIndex = 0;
        private void dataGridView_TaskList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left) {
                if (e.RowIndex >= 0) {
                    dataGridView_TaskList.ClearSelection();
                    dataGridView_TaskList.Rows[e.RowIndex].Selected = true;

                    m_RowIndex = e.RowIndex;
                }
            }
        }
        #endregion

        #region 新建 编辑 删除
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_TaskNew_Click(object sender, EventArgs e) {
            FrmTaskEdit FormTaskEdit = new FrmTaskEdit();
            FormTaskEdit.TaskOpDelegate = OutTaskOpDelegate;
            FormTaskEdit.ShowDialog(this);
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_TaskEdit_Click(object sender, EventArgs e) {
            FrmTaskEdit FormTaskEdit = new FrmTaskEdit();
            FormTaskEdit.TaskOpDelegate = OutTaskOpDelegate;
            FormTaskEdit.ID = Get_DataViewID();
            FormTaskEdit.TaskIndex = this.dataGridView_TaskList.SelectedRows[0].Index;
            FormTaskEdit.ShowDialog(this);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_TaskDel_Click(object sender, EventArgs e) {
            if (MessageBox.Show("你确定要删除吗?删除不可恢复!", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                DALTask dal = new DALTask();
                ModelTask model = dal.GetModel(Get_DataViewID());
                string TaskName = model.TaskName;
                string RootPath = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\";
                string TaskPath = RootPath + TaskName;
                if (Directory.Exists(TaskPath)) {
                    Directory.Delete(TaskPath, true);
                }
                dal.Delete(Get_DataViewID());
                this.Bind_DataList();
            }
        }
        /// <summary>
        /// 获取任务Id
        /// </summary>
        /// <returns></returns>
        public int Get_DataViewID() {
            DataGridViewSelectedRowCollection row = this.dataGridView_TaskList.SelectedRows;
            if (row.Count > 0) {
                return StringHelper.Instance.SetNumber(row[0].Cells[0].Value.ToString());
            }
            return 0;
        }
        /// <summary>
        /// 获取所有选中的任务Id
        /// </summary>
        /// <returns></returns>
        public string[] Get_DataViewIDs() {
            StringBuilder sb = new StringBuilder();
            DataGridViewSelectedRowCollection row = this.dataGridView_TaskList.SelectedRows;
            foreach (DataGridViewRow r in row) {
                sb.Append(r.Cells[0].Value.ToString() + ",");
            }
            if (sb.Length > 0) {
                sb = sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries); ;
        }
        /// <summary>
        /// 添加 编辑 任务 委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OutTaskOpDelegate(object sender, TaskEvents.TaskOpEvents e) {
            if (e.OpType == 0 || e.OpType == 1) {
                Bind_DataList();
            }
            else {
                this.dataGridView_TaskList.Rows[0].Selected = false;
                this.dataGridView_TaskList.Rows[e.TaskIndex].Selected = true;
            }
        }
        #endregion

        #region  任务开始 暂停 结束
        /// <summary>
        /// 任务开始
        /// </summary>
        private void ToolStripMenuItem_TaskStart_Click(object sender, EventArgs e) {
            try {
                DALTask dal = new DALTask();
                ModelTask model = new ModelTask();
                int ID = Get_DataViewID();

                if (listGatherTask.ContainsKey(ID.ToString())) {
                    var Spider = listGatherTask.FirstOrDefault().Value;
                    if (Spider.Stopped) {
                        Spider.Start();
                    }
                }
                else {
                    model = dal.GetModelSingleTask(ID);
                    if (model.Status != 1) {
                        MainEvents.OutPutWindowEventArgs ev = new MainEvents.OutPutWindowEventArgs();
                        ev.Message = "任务关闭中.不可采集...";
                        OutPutWindowDelegate?.Invoke(this, ev);
                        return;
                    }
                    string baseDir = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\";
                    string SQLiteName = baseDir + model.TaskName + "\\SpiderResult.db";
                    if (!File.Exists(SQLiteName)) {
                        CreateDataFile(model.TaskName, ID);
                    }
                    var Spider = new SpiderHelper();
                    Spider.modelTask = model;
                    Spider.GatherWorkDelegate = OutUrl;
                    Spider.GatherComplateDelegate = GatherOverDelegate;
                    Spider.OutPutTaskProgressBarDelegate = OutPutTaskProgressBarDelegate;
                    Spider.TaskIndex = this.dataGridView_TaskList.SelectedRows[0].Index;
                    Spider.Start();
                    lock (listGatherTask) {
                        if (!listGatherTask.ContainsKey(ID.ToString())) {
                            listGatherTask.Add(ID.ToString(), Spider);
                        }
                    }
                }
            }
            catch (Exception ex) {
                Log4Helper.Write(LogLevel.Error, ex.StackTrace, ex);
            }

        }

        /// <summary>
        /// 输出进度条委托信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutPutTaskProgressBarDelegate(object sender, MainEvents.OutPutTaskProgressBarEventArgs e) {
            int TaskIndex = e.TaskIndex;
            int ProgressNum, RecordNum;
            ProgressNum = e.ProgressNum;
            RecordNum = e.RecordNum;
            double fPerNum = double.Parse(ProgressNum.ToString()) / double.Parse(RecordNum.ToString());
            double perNumF = double.Parse(fPerNum.ToString("f2")) * 100;
            int perNum = Convert.ToInt32(perNumF);
            this.dataGridView_TaskList.Rows[TaskIndex].Cells["ProgressBar"].Value = perNum;
        }


        /// <summary>
        /// 任务结果输出
        /// </summary>
        public void OutUrl(object sender, GatherEvents.GatherLinkEvents e) {
            MainEvents.OutPutWindowEventArgs ev = new MainEvents.OutPutWindowEventArgs();
            ev.Message = e.Message;
            OutPutWindowDelegate?.Invoke(this, ev);
        }
        /// <summary>
        /// 任务暂停
        /// </summary>
        private void ToolStripMenuItem_TaskPause_Click(object sender, EventArgs e) {
            MessageBox.Show("暂停功能暂时不可用!", "警告!");
        }
        /// <summary>
        /// 任务结束
        /// </summary>
        private void ToolStripMenuItem_TaskStop_Click(object sender, EventArgs e) {
            int ID = Get_DataViewID();
            if (listGatherTask.ContainsKey(ID.ToString())) {
                var Spider = listGatherTask.FirstOrDefault().Value;
                listGatherTask.Remove(ID.ToString());
                Spider.Stop();

                OutPutWindowDelegate?.Invoke(this, new MainEvents.OutPutWindowEventArgs() {
                    Message = "任务已经停止!",
                    TaskId = ID
                });
            }
        }
        /// <summary>
        /// 采集结束
        /// </summary>
        /// <param name="model"></param>
        private void GatherOverDelegate(ModelTask model) {
            if (model == null)
                return;
            if (listGatherTask.ContainsKey(model.ID.ToString())) {
                var Spider = listGatherTask.FirstOrDefault().Value;
                listGatherTask.Remove(model.ID.ToString());
                Spider.Start();
            }
        }
        #endregion

        #region 清除 重新构建 查看
        /// <summary>
        /// 清除所有任务数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_ClearTaskAllData_Click(object sender, EventArgs e) {
            if (MessageBox.Show("你确定要清除数据吗?清除不可恢复!", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                ModelTask model = new ModelTask();
                int ID = Get_DataViewID();
                DALTask dal = new DALTask();
                model = dal.GetModelSingleTask(ID);
                string LocalSQLiteName = "Data\\Collection\\" + model.TaskName + "\\SpiderResult.db";
                string sql = " DELETE FROM Content";
                DbHelper.Execute(LocalSQLiteName, sql);
            }

        }

        /// <summary>
        /// 重新建立数据结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_ReCreateTable_Click(object sender, EventArgs e) {
            if (MessageBox.Show("你确定要重新建立数据结构吗?清除不可恢复!", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                DataGridViewSelectedRowCollection row = this.dataGridView_TaskList.SelectedRows;
                string TaskName = "";
                if (row.Count > 0) {
                    TaskName = row[0].Cells[3].Value.ToString();
                }
                int ID = Get_DataViewID();
                CreateDataFile(TaskName, ID);
            }
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="taskName"></param>
        private void CreateDataFile(string taskName, int taskID) {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\";
            string SQLiteName = baseDir + taskName + "\\SpiderResult.db";
            string LocalSQLiteName = "Data\\Collection\\" + taskName + "\\SpiderResult.db";
            string SQL = string.Empty;
            if (!Directory.Exists(baseDir + taskName + "\\")) {
                Directory.CreateDirectory(baseDir + taskName + "\\");
            }
            if (!File.Exists(SQLiteName)) {
                DbHelper.CreateDataBase(SQLiteName);
                DALTask dal = new DALTask();
                string createSQL = string.Empty;
                DataTable dt = new DALTaskLabel().GetList(" TaskID=" + taskID).Tables[0];
                foreach (DataRow dr in dt.Rows) {
                    createSQL += @"
                     " + dr["LabelName"] + @" varchar,";
                }
                if (createSQL.Trim() != "") {
                    createSQL = createSQL.Remove(createSQL.Length - 1);
                }
                SQL = @"
                create table Content(
                    ID integer primary key autoincrement,
                    [HrefSource] varchar,
                    [已采] int,
                    [已发] int,
                    " + createSQL + @"
                );
            ";
                DbHelper.Execute(LocalSQLiteName, SQL);
            }
            else {
                DataTable dt = new DALTaskLabel().GetList(" TaskID=" + taskID).Tables[0];
                foreach (DataRow dr in dt.Rows) {
                    try {
                        DbHelper.Execute(LocalSQLiteName, " ALTER TABLE Content ADD COLUMN [" + dr["LabelName"] + "] VARCHAR; ");
                    }
                    catch {
                        continue;
                    }
                }

            }
        }

        private void ToolStripMenuItem_ViewTaskData_Click(object sender, EventArgs e) {
            ModelTask model = new ModelTask();
            int ID = Get_DataViewID();
            DALTask dal = new DALTask();
            model = dal.GetModelSingleTask(ID);

            frmTaskDataList FromTaskDataList = new frmTaskDataList();
            FromTaskDataList.TaskName = model.TaskName;
            FromTaskDataList.ShowDialog(this);
        }

        private void 复制任务ToolStripMenuItem_Click(object sender, EventArgs e) {
            int ID = Get_DataViewID();
            DALTask dal = new DALTask();

            int currentMaxId = dal.GetMaxId();
            ModelTask model = dal.GetModelSingleTask(ID);
            string currentTaskName = model.TaskName + "复制" + DateTime.Now.Millisecond;


            model.ID = currentMaxId;
            model.TaskName = currentTaskName;
            dal.Add(model);
            DALTaskLabel dalLable = new DALTaskLabel();
            DataTable dt = dalLable.GetList(" TaskId=" + ID).Tables[0];
            if (dt != null && dt.Rows.Count > 0) {
                foreach (DataRow dr in dt.Rows) {
                    ModelTaskLabel modelLabel = dalLable.GetModel(StringHelper.Instance.SetNumber(dr["Id"].ToString()));
                    modelLabel.TaskID = currentMaxId;
                    dalLable.Add(modelLabel);
                }
            }
            CreateDataFile(currentTaskName, currentMaxId);
            this.ClassID = model.TaskClassID.Value;
            Bind_DataList();
        }
        #endregion

        #region 计划任务

        private void 计划任务ToolStripMenuItem_Click(object sender, EventArgs e) {
            int ID = Get_DataViewID();
            var f = new frmTaskPlanSet();
            f.ShowDialog(this);
        }

        private void 导出采集规则ToolStripMenuItem_Click(object sender, EventArgs e) {
            var id = this.Get_DataViewID();
            if (id > 0) {
                var dal = new DALTask();
                var model = dal.GetModelSingleTask(id);

            }
        }
        #endregion

    }
}
