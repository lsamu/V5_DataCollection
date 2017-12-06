using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using V5_DataPublish._Class;
using V5_DAL;
using V5_DataPublish._Class.Publish;
using V5_DataPublish.Forms;
using V5_DataPublish.Forms.Desk;
using V5_DataPublish.Forms.Import;
using V5_DataPublish.Forms.WebSite;
using V5_DataPublish.Forms.WebSiteClass;
using V5_Utility;
using V5_DataPlugins;
using V5_Utility.Core;
using V5_DataPublish._Class.BaiduHelper;
using V5_Utility.Utility;
using V5_WinLibs.Core;

namespace V5_DataPublish {
    public partial class frmMain : BaseForm {


        public frmMain() {
            InitializeComponent();
        }

        #region 后台采集任务
        /// <summary>
        /// 绑定采集分类
        /// </summary>
        private void Bind_ClassCollection() {
            foreach (DataRow dr in new DALWebSiteClassList().GetClassNewWork().Rows) {
                if (!string.IsNullOrEmpty(dr["KeyWordList"].ToString())) {
                    ThreadGetBaiduResultUtility ThreadGetBaiduResult = new ThreadGetBaiduResultUtility();
                    ThreadGetBaiduResult.KeyWord = "美女";
                    ThreadGetBaiduResult.BaseDir = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\NetWork\\" + dr["WebSiteID"].ToString() + "-" + dr["ClassID"].ToString();
                    ThreadGetBaiduResult.Start();
                }
            }
        }
        #endregion

        #region SEO菜单
        /// <summary>
        /// 绑定SEO菜单
        /// </summary>
        private void Bind_LoadSeoMenu() {
            DataSet ds = new DataSet();
            ds.ReadXml(@"System\SeoMenu.xml");
            DataView dv = ds.Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                ToolStripMenuItem topMenu = new ToolStripMenuItem();
                topMenu.Text = dv[i]["text"].ToString();
                topMenu.Tag = dv[i]["url"].ToString();
                topMenu.Click += new EventHandler(topMenu_Click);
                this.ToolStripMenuItem_Tool_SEO.DropDownItems.Add(topMenu);
            }
        }
        /// <summary>
        /// SEO菜单地址运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topMenu_Click(object sender, EventArgs e) {
            ToolStripMenuItem tmi = (ToolStripMenuItem)sender;
            System.Diagnostics.Process.Start(tmi.Tag.ToString());
        }
        #endregion

        #region 输出操作日志
        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WritePublishMessage(object sender, MainEvents.OutPutWindowEventArgs e) {
            this.txtOpLogView.Invoke(new MethodInvoker(delegate() {
                this.txtOpLogView.AppendText(e.Message);
                this.txtOpLogView.AppendText("\r\n");
            }));

            this.txtCollectionLog.Invoke(new MethodInvoker(delegate() {
                if (e.OutPutWindowType == MainEvents.OutPutWindowType.Collecton) {
                    this.txtCollectionLog.AppendText(e.Message);
                    this.txtCollectionLog.AppendText("\r\n");
                }
            }));

            this.txtPublishLog.Invoke(new MethodInvoker(delegate() {
                if (e.OutPutWindowType == MainEvents.OutPutWindowType.Publish) {
                    this.txtPublishLog.AppendText(e.Message);
                    this.txtPublishLog.AppendText("\r\n");
                }
            }));
        }
        /// <summary>
        /// 设置输入出日志颜色
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="msg"></param>
        /// <param name="color"></param>
        private void SetRichTextBoxColor(RichTextBox rt, string msg, Color color) {
            try {
                int SelectionStart = rt.Text.IndexOf(msg);
                rt.Select(SelectionStart, msg.Length);
                rt.SelectionColor = color;
            }
            catch { }
        }
        #endregion

        #region DeskTop
        private frmDeskTop m_frmDeskTop = null;
        private FormWindowState fwsPrevious;
        #region NotifyIcon
        private bool _state = true;
        public bool State 
        {
            get { return _state; }
            set { _state = value; }
        }
        #endregion
        /// <summary>
        /// 恢复窗体
        /// </summary>
        public void RestoreWindow() {
            this.MinimizedToNormal();
        }

        /// <summary>
        /// 窗体大小改变发生时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_SizeChanged(object sender, System.EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized)
            {
                m_frmDeskTop.Show();
                NormalToMinimized();
            }
            else if (this.WindowState != fwsPrevious) {
                fwsPrevious = this.WindowState;
            }
        }

        private void MinimizedToNormal() {
            this.WindowState = FormWindowState.Maximized;
            notifyIcon.Visible = false;
            this.Show();
        }
        private void NormalToMinimized() {
            this.WindowState = FormWindowState.Minimized;
            this.notifyIcon.Visible = true;
            this.Hide();
        }
        #endregion

        #region 主窗体事件
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e) {
            _Class.Utility.LoadAllDlls();
            Bind_TreeClassList();
            #region 浮动窗体
            m_frmDeskTop = new frmDeskTop(this);
            m_frmDeskTop.Show();
            this.notifyIcon.Visible = false;
            #endregion
            #region 计划任务
            #endregion
            this.dataGridView_Main.AutoGenerateColumns = false;
            this.dataGridView_Main.AllowUserToAddRows = false;
        }
        /// <summary>
        /// 程序退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing
                && State) {
                e.Cancel = true;
                NormalToMinimized();
            }
            SaveMainFormSize();
        }
        /// <summary>
        /// 保存窗体最后位置大小
        /// </summary>
        private void SaveMainFormSize() {

        }
        #endregion

        #region 站点编辑
        /// <summary>
        /// 网站新建
        /// </summary>
        private void toolStripButton_WebSiteNew_Click(object sender, EventArgs e) {
            WebSite_Add();
        }
        /// <summary>
        /// 网站新建与修改委托方法
        /// </summary>
        private void OOOptionShow(object sender, string msg, Common.Option op) {
            this.Bind_MainDataList(Get_TreeViewClassID());
        }
        /// <summary>
        /// 网站修改
        /// </summary>
        private void toolStripButton_WebSiteEdit_Click(object sender, EventArgs e) {
            string WebSiteID = Get_DataViewID();
            if (!string.IsNullOrEmpty(WebSiteID)) {
                WebSite_Edit(WebSiteID);
            }
            else {
                MessageBox.Show("请选择一个站点在进行编辑!", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        /// <summary>
        /// 站点删除
        /// </summary>
        private void toolStripButton_WebSiteDelete_Click(object sender, EventArgs e) {
            string WebSiteID = Get_DataViewID();
            if (!string.IsNullOrEmpty(WebSiteID)) {
                if (MessageBox.Show("你确定要删除吗?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                    WebSite_Del(WebSiteID);
                    this.Bind_MainDataList(Get_TreeViewClassID());
                }
            }
            else {
                MessageBox.Show("请选择一个站点在进行删除!", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        /// <summary>
        /// 获取选择站点标示
        /// </summary>
        /// <returns></returns>
        private string Get_DataViewID() {
            DataGridViewSelectedRowCollection row = this.dataGridView_Main.SelectedRows;
            if (row.Count > 0) {
                return row[0].Cells[0].Value.ToString();
            }
            return "0";
        }
        #endregion

        #region 站群分类操作
        /// <summary>
        /// 加载站群分类
        /// </summary>
        private void Bind_TreeClassList() {
            TreeNode rootNode = this.treeView_Left.Nodes[0];
            rootNode.Nodes.Clear();
            var list = Common.GetList<ModelTreeClass>(p => p.Uuid != string.Empty);
            foreach (var l in list) {
                rootNode.Nodes.Add(l.Uuid, l.ClassName);
                rootNode.ExpandAll();
            }
        }


        /// <summary>
        /// 单击站群分类操作
        /// </summary>
        private void treeView_Left_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeNode node = e.Node;
            if (node != this.treeView_Left.Nodes[0]) {
                Bind_MainDataList(node.Name);
            }
        }

        /// <summary>
        /// 获取站群分类ID
        /// </summary>
        private string Get_TreeViewClassID() {
            TreeNode node = this.treeView_Left.SelectedNode;
            if (node != this.treeView_Left.Nodes[0]) {
                return node.Name;
            }
            return "0";
        }
        /// <summary>
        /// 新建站群分类
        /// </summary>
        private void toolStripButton_WebSiteClassNew_Click(object sender, EventArgs e) {
            frmWebSiteClass formWebSiteClass = new frmWebSiteClass();
            formWebSiteClass.OO = OOTreeOption;
            formWebSiteClass.ShowDialog(this);
        }
        /// <summary>
        /// 刷新站群分类 委托方法
        /// </summary>
        private void OOTreeOption(object sender, string msg, Common.Option op) {
            this.Bind_TreeClassList();
        }
        /// <summary>
        /// 站群分类修改
        /// </summary>
        private void toolStripButton_WebSiteClassEdit_Click(object sender, EventArgs e) {
            frmWebSiteClass formWebSiteClass = new frmWebSiteClass();
            formWebSiteClass.OO = OOTreeOption;
            formWebSiteClass.OldValue = Get_TreeViewClassID();
            formWebSiteClass.ShowDialog(this);
        }
        /// <summary>
        /// 站群分类删除
        /// </summary>
        private void toolStripButton_WebSiteClassDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("你确定要删除吗?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Common.Delete<ModelTreeClass>(p => p.Uuid == Get_TreeViewClassID());
                this.Bind_TreeClassList();
            }
        }
        /// <summary>
        /// 站群分类添加
        /// </summary>
        private void ToolStripMenuItem_TreeClassAdd_Click(object sender, EventArgs e) {
            frmWebSiteClass formWebSiteClass = new frmWebSiteClass();
            formWebSiteClass.OO = OOTreeOption;
            formWebSiteClass.ShowDialog(this);
        }

        /// <summary>
        /// 站群分类修改
        /// </summary>
        private void ToolStripMenuItem_TreeClassEdit_Click(object sender, EventArgs e) {
            frmWebSiteClass formWebSiteClass = new frmWebSiteClass();
            formWebSiteClass.OO = OOTreeOption;
            formWebSiteClass.OldValue = Get_TreeViewClassID();
            formWebSiteClass.ShowDialog(this);
        }

        /// <summary>
        /// 站群分类删除
        /// </summary>
        private void ToolStripMenuItem_TreeClassDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("你确定要删除吗?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Common.Delete<ModelTreeClass>(p => p.Uuid == Get_TreeViewClassID());
                this.Bind_TreeClassList();
            }
        }
        #endregion

        #region 网站相关操作


        #region 网站管理
        /// <summary>
        /// 网站数据
        /// </summary>
        private void Bind_MainDataList(string ClassID) {
            this.dataGridView_Main.DataSource = null;
            if (string.IsNullOrEmpty(ClassID)) {
                return;
            }
            var list = Common.GetList<WebSiteHelper>(p => p.ClassID == ClassID);
            this.dataGridView_Main.DataSource = list;
        }
        /// <summary>
        /// 网站添加
        /// </summary>
        private void WebSite_Add() {
            frmWebSiteEdit formWebSiteEdit = new frmWebSiteEdit();
            formWebSiteEdit.OO = OOOptionShow;
            formWebSiteEdit.ShowDialog(this);
        }
        /// <summary>
        /// 网站编辑
        /// </summary>
        private void WebSite_Edit(string ID) {
            frmWebSiteEdit formWebSiteEdit = new frmWebSiteEdit();
            formWebSiteEdit.OO = OOOptionShow;
            formWebSiteEdit.OldValue = ID.ToString();
            formWebSiteEdit.ShowDialog(this);
        }
        /// <summary>
        /// 网站删除
        /// </summary>
        private void WebSite_Del(string ID) {
            Common.Delete<WebSiteHelper>(p => p.Uuid == ID);
        }

        /// <summary>
        /// 网站加载数据格式化
        /// </summary>
        private void dataGridView_Main_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
        }
        #endregion

        #region 网站列表右键
        /// <summary>
        /// 网站编辑
        /// </summary>
        private void ToolStripMenuItem_Main_DataGrid_Edit_Click(object sender, EventArgs e) {
            WebSite_Edit(Get_DataViewID());
        }
        /// <summary>
        /// 网站删除
        /// </summary>
        private void ToolStripMenuItem_Main_DataGrid_Delete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("你确定要删除吗?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                WebSite_Del(Get_DataViewID());
                this.Bind_MainDataList(Get_TreeViewClassID());
            }
        }
        /// <summary>
        /// 发布站点数据
        /// </summary>
        private void ToolStripMenuItem_Main_DataGrid_PublishSingleData_Click(object sender, EventArgs e) {
            string WebSiteID = Get_DataViewID();
            if (!string.IsNullOrEmpty(WebSiteID)) {
                frmHandInsert formHandInsert = new frmHandInsert();
                formHandInsert.Show(this);
            }
        }
        /// <summary>
        /// 查询网站发布过的数据
        /// </summary>
        private void ToolStripMenuItem_Main_DataGrid_ViewPublishData_Click(object sender, EventArgs e) {
            string WebSiteID = Get_DataViewID();
            if (!string.IsNullOrEmpty(WebSiteID)) {
                frmWebSiteLogList formWebSiteLogList = new frmWebSiteLogList();
                formWebSiteLogList.ShowDialog(this);
            }
        }
        /// <summary>
        /// 暂停网站
        /// </summary>
        private void ToolStripMenuItem_Main_DataGrid_Pause_Click(object sender, EventArgs e) {
            string WebSiteID = Get_DataViewID();
            if (!string.IsNullOrEmpty(WebSiteID)) {
                var model = Common.GetList<WebSiteHelper>(p => p.Uuid == WebSiteID).SingleOrDefault();
                model.Status = 0;
                Common.Update<WebSiteHelper>(model);
                this.Bind_MainDataList(Get_TreeViewClassID());
            }
        }
        /// <summary>
        /// 开启站点
        /// </summary>
        private void ToolStripMenuItem_Main_DataGrid_Start_Click(object sender, EventArgs e) {
            string WebSiteID = Get_DataViewID();
            if (!string.IsNullOrEmpty(WebSiteID)) {
                var model = Common.GetList<WebSiteHelper>(p => p.Uuid == WebSiteID).SingleOrDefault();
                model.Status = 1;
                Common.Update<WebSiteHelper>(model);
                this.Bind_MainDataList(Get_TreeViewClassID());
            }
        }

        /// <summary>
        /// 登陆后台
        /// </summary>
        private void ToolStripMenuItem_LoginAdmin_Click(object sender, EventArgs e) {
            try {
                string WebSiteID = Get_DataViewID();
            }
            catch (Exception ex) {
                Log4Helper.Write(LogLevel.Error, ex);
                MessageBox.Show("后台登陆失败!" + ex.Message);
            }
        }
        #endregion

        #endregion

        #region 系统菜单
        /// <summary>
        /// 程序配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Application_Option_Click(object sender, EventArgs e) {
            new frmOption().ShowDialog(this);
        }
        /// <summary>
        /// 程序帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Help_AboutUs_Click(object sender, EventArgs e) {
            new frmAboutUs().ShowDialog(this);
        }
        /// <summary>
        /// 软件配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Tool_Option_Click(object sender, EventArgs e) {
            new frmOptionConfig().ShowDialog(this);
        }
        /// <summary>
        /// 软件配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_SystemConfig_Click(object sender, EventArgs e) {
            new frmOptionConfig().ShowDialog(this);
        }
        public Process myProcess;
        /// <summary>
        /// 软件升级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Help_Update_Click(object sender, EventArgs e) {
            myProcess = Process.Start(AppDomain.CurrentDomain.BaseDirectory + "V5.AutoUpdate.exe");
            myProcess.WaitForExit();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Application_Exit_Click(object sender, EventArgs e) {
            System.Environment.Exit(0);
        }
        #endregion

        #region 窗体位置
        private void LoadWinSize(Form form) {
            IniHelper.FilePath = AppDomain.CurrentDomain.BaseDirectory + Common.SettingsFile;
            int iWidth = int.Parse(IniHelper.GetIniKeyValue("Size", "width", "984"));
            int iHeight = int.Parse(IniHelper.GetIniKeyValue("Size", "height", "612"));
            int iLeft = int.Parse(IniHelper.GetIniKeyValue("Size", "left", "0"));
            int iTop = int.Parse(IniHelper.GetIniKeyValue("Size", "top", "0"));

            if (iWidth < 500) {
                iWidth = 900;
            }
            if (iHeight < 100) {
                iHeight = 700;
            }
            if (iLeft < 0) {
                iLeft = 0;
            }
            if (iTop < 0) {
                iTop = 0;
            }
            form.Size = new Size(iWidth, iHeight);
            form.Location = new Point(iLeft, iTop);
        }
        public void SaveWinSize(Form form) {
            IniHelper.FilePath = AppDomain.CurrentDomain.BaseDirectory + Common.SettingsFile;
            int iWidth = form.Size.Width;
            if (iWidth < 100) {
                iWidth = 900;
            }
            int iHeight = form.Size.Height;
            if (iHeight < 100) {
                iHeight = 700;
            }
            int iLeft = form.Location.X;
            if (iLeft < 0) {
                iLeft = 0;
            }
            int iTop = form.Location.Y;
            if (iTop < 0) {
                iTop = 0;
            }
            IniHelper.WriteIniKey("Size", "width", iWidth.ToString());
            IniHelper.WriteIniKey("Size", "height", iHeight.ToString());
            IniHelper.WriteIniKey("Size", "left", iLeft.ToString());
            IniHelper.WriteIniKey("Size", "top", iTop.ToString());
        }
        #endregion

        #region 导入数据
        private void ToolStripMenuItem_Data_Import_Xml_Click(object sender, EventArgs e) {
            new frmImportXml().ShowDialog(this);
        }

        private void ToolStripMenuItem_Data_Import_Text_Click(object sender, EventArgs e) {
            new frmImportText().ShowDialog(this);
        }

        private void ToolStripMenuItem_Data_Import_Http_Click(object sender, EventArgs e) {
            new frmImportHttpWeb().ShowDialog(this);
        }
        #endregion

        #region 主窗体菜单事件

        private void 伪原创ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void ToolStripMenuItem_RestartApplication_Click(object sender, EventArgs e) {
            Application.Restart();
        }


        private void ToolStripMenuItem_ClearPublishData_Click(object sender, EventArgs e) {

        }

        private void 我们的网站ToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("http://www.v5soft.com");
        }

        private void ToolStripMenuItem_RunTask_Click(object sender, EventArgs e) {
            string WebSiteID = Get_DataViewID();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {

        }

        private void toolStripButton4_Click(object sender, EventArgs e) {

        }

        private void 数据来源ToolStripMenuItem_Click(object sender, EventArgs e) {
            Bind_ClassCollection();
        }
        #endregion



    }
}
