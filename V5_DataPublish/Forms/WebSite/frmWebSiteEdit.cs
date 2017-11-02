using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using V5_DataPublish._Class;
using V5_DAL;
using V5_Utility;
using System.IO;
using V5_DataPublish._Class.Publish;
using System.Threading;
using V5_DataPlugins;
using V5_Utility.Core;
using System.Linq;
using V5_Utility.Utility;
using System.Web.UI.WebControls;
using V5_WinLibs.Core;

namespace V5_DataPublish.Forms.WebSite {
    public partial class frmWebSiteEdit : BaseForm {


        public delegate void OptionOk(object sender, string message, Common.Option o);
        public OptionOk OO;

        /// <summary>
        /// 需要编辑的值
        /// </summary>
        public string OldValue { get; set; }

        public frmWebSiteEdit() {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体事件加载
        /// </summary>
        private void frmWebSiteEdit_Load(object sender, EventArgs e) {
            bwLogin.DoWork += new DoWorkEventHandler(bwLogin_DoWork);
            Bind_LoadPublishModules();
            Bind_LoadGropWebSiteClass();
            Bind_LoadSendContentPlugins();
            if (!string.IsNullOrEmpty(this.OldValue)) {
                Bind_DataEdit(this.OldValue);
            }
            this.Bind_ClassList();
        }
        /// <summary>
        /// 取消窗体
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        #region 网站操作
        /// <summary>
        /// 发布模块
        /// </summary>
        private void Bind_LoadPublishModules() {
            List<IPublish> listIPublish = _Class.Utility.ListIPublish;
            try {
                DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/Modules/");
                FileInfo[] files = di.GetFiles("*.pmod");
                foreach (FileInfo fi in files) {
                    this.cmbPublishName.Items.Add(fi.Name);
                }
            }
            catch {
            }

            foreach (IPublish item in listIPublish) {
                this.cmbPublishName.Items.Add(item.Publish_Name);
            }
        }
        /// <summary>
        /// 绑定发布文章内容插件
        /// </summary>
        private void Bind_LoadSendContentPlugins() {
            try {
                string[] publiscContentDirs = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\V5.DataPublish.PublishContent\\");
                foreach (string dir in publiscContentDirs) {
                    try {
                        string file = Directory.GetFiles(dir, "*PublishContent.dll")[0];
                        FileInfo fiName = new FileInfo(file);
                        ListViewItem lvItem = new ListViewItem(fiName.Name);
                        this.listView_PublishContentPlugins.Items.Add(lvItem);
                    }
                    catch (Exception ex) {
                        Log4Helper.Write(LogLevel.Error, ex);
                        continue;
                    }
                }
            }
            catch (Exception) {
                return;
            }
        }
        /// <summary>
        /// 站群分类
        /// </summary>
        private void Bind_LoadGropWebSiteClass() {
            var list = Common.GetList<ModelTreeClass>(p => p.Uuid != string.Empty);
            this.cmbClassID.DataSource = list;
            this.cmbClassID.DisplayMember = "ClassName";
            this.cmbClassID.ValueMember = "UUId";
        }
        /// <summary>
        /// 网站编辑加载
        /// </summary>
        private void Bind_DataEdit(string UUId) {
            WebSiteHelper model = Common.GetList<WebSiteHelper>(p => p.Uuid == UUId).SingleOrDefault();
            this.txtID.Text = model.Uuid.ToString();
            this.cmbClassID.SelectedValue = model.ClassID.ToString();
            this.txtWebSiteName.Text = model.WebSiteName;
            this.txtWebSiteUrl.Text = model.WebSiteUrl;
            this.txtWebSiteLoginUrl.Text = model.WebSiteLoginUrl;
            this.txtLoginUserName.Text = model.LoginUserName;
            this.txtLoginUserPwd.Text = model.LoginUserPwd;
            this.cmbPublishName.Text = model.PublishName;
            this.chkIsLinkPic.Checked = model.IsLinkPic.ToString() == "1" ? true : false;
            this.chkIsLinkWord.Checked = model.IsLinkWord.ToString() == "1" ? true : false;
            this.chkIsLinkPdf.Checked = model.IsLinkPdf.ToString() == "1" ? true : false;
            this.chkIsLinkVideo.Checked = model.IsLinkVideo.ToString() == "1" ? true : false;
            this.chkIsTitleFalse.Checked = model.IsTitleFalse.ToString() == "1" ? true : false;
            this.chkIsContentFalse.Checked = model.IsContentFalse.ToString() == "1" ? true : false;
            this.chkIsAddTask.Checked = model.IsAddTask.ToString() == "1" ? true : false;
            int DataSourceType = model.DataSourceType.Value;
            if (DataSourceType == 1) {
                this.rbtnDataSourceType1.Checked = true;
            }
            if (DataSourceType == 2) {
                this.rbtnDataSourceType2.Checked = true;
            }
            if (DataSourceType == 3) {
                this.rbtnDataSourceType3.Checked = true;
            }
            if (DataSourceType == 4) {
                this.rbtnDataSourceType4.Checked = true;
            }
            this.cmbDataType.Text = model.DataType;
            this.txtDataLinkUrl.Text = model.DataLinkUrl;
            this.txtDataQuerySQL.Text = model.DataQuerySQL;
            this.txtFileSourcePath.Text = model.FileSourcePath;


            this.chkStatus.Checked = model.Status == 1 ? true : false;
        }
        /// <summary>
        /// 绑定数据源分类
        /// </summary>
        private void Bind_FileSourceClassList() {
            this.cmbFileSourceClassIDList.Items.Clear();
            this.cmbFileSourceClassIDList.Items.Add(new ListItem("0", "请选择"));
            DALWebSiteClassList dalWebSiteClassList = new DALWebSiteClassList();
            DataSet ds = dalWebSiteClassList.GetClassList(this.txtID.Text);
            foreach (DataRow dr in ds.Tables[0].Rows) {
                this.cmbFileSourceClassIDList.Items.Add(new ListItem(dr["ClassID"].ToString(), dr["ClassName"].ToString()));
            }
            this.cmbFileSourceClassIDList.SelectedIndex = 0;
        }

        /// <summary>
        /// 提交窗体
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e) {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(this.cmbClassID.Text)) {
                errorProvider.SetError(this.cmbClassID, "站群分类不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtWebSiteName.Text)) {
                errorProvider.SetError(this.txtWebSiteName, "网站名称不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtWebSiteUrl.Text)) {
                errorProvider.SetError(this.txtWebSiteUrl, "网站地址不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtWebSiteLoginUrl.Text)) {
                errorProvider.SetError(this.txtWebSiteLoginUrl, "网站后台目录不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.cmbPublishName.Text)) {
                errorProvider.SetError(this.cmbPublishName, "网站发布模块需要选择!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtLoginUserName.Text)) {
                errorProvider.SetError(this.txtLoginUserName, "网站登录用户名不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtLoginUserPwd.Text)) {
                errorProvider.SetError(this.txtLoginUserPwd, "网站登录密码不能为空!");
                return;
            }

            WebSiteHelper model = new WebSiteHelper();
            string UUID = this.txtID.Text;
            if (!string.IsNullOrEmpty(UUID)) {
                model = Common.GetList<WebSiteHelper>(p => p.Uuid == this.txtID.Text).SingleOrDefault();
            }
            model.ID = 0;
            model.ClassID = this.cmbClassID.SelectedValue.ToString();
            model.WebSiteName = this.txtWebSiteName.Text;
            model.WebSiteUrl = this.txtWebSiteUrl.Text;
            model.WebSiteLoginUrl = this.txtWebSiteLoginUrl.Text;
            model.PublishName = this.cmbPublishName.Text;
            model.LoginUserName = this.txtLoginUserName.Text;
            model.LoginUserPwd = this.txtLoginUserPwd.Text;
            model.IsLinkPic = this.chkIsLinkPic.Checked ? 1 : 0;
            model.IsLinkWord = this.chkIsLinkWord.Checked ? 1 : 0;
            model.IsLinkPdf = this.chkIsLinkPdf.Checked ? 1 : 0;
            model.IsLinkVideo = this.chkIsLinkVideo.Checked ? 1 : 0;
            model.IsTitleFalse = this.chkIsTitleFalse.Checked ? 1 : 0;
            model.IsContentFalse = this.chkIsContentFalse.Checked ? 1 : 0;
            model.IsAddTask = this.chkIsAddTask.Checked ? 1 : 0;
            model.AddDateTime = DateTime.Now.ToString();

            #region 2011  2 22
            int DataSourceType = 0;
            if (this.rbtnDataSourceType1.Checked) {
                DataSourceType = 1;
            }
            if (this.rbtnDataSourceType2.Checked) {
                DataSourceType = 2;
            }
            if (this.rbtnDataSourceType3.Checked) {
                DataSourceType = 3;
            }
            if (this.rbtnDataSourceType4.Checked) {
                DataSourceType = 4;
            }
            model.DataSourceType = DataSourceType;
            model.DataType = this.cmbDataType.Text;
            model.DataLinkUrl = this.txtDataLinkUrl.Text;
            model.DataQuerySQL = this.txtDataQuerySQL.Text;
            model.FileSourcePath = this.txtFileSourcePath.Text;
            #endregion

            model.Status = this.chkStatus.Checked ? 1 : 0;
            if (string.IsNullOrEmpty(UUID)) {
                model.IsCookie = 0;
                model.Status = 1;
                Common.Update<WebSiteHelper>(model);
                if (OO != null) {
                    OO(this, "添加成功!", Common.Option.add);
                }
            }
            else {
                Common.Update<WebSiteHelper>(model);
                if (OO != null) {
                    OO(this, "修改成功!", Common.Option.edit);
                }
            }
            this.Close();
            this.Dispose();
        }
        #endregion

        #region 测试网站是否登录成功
        private BackgroundWorker bwLogin = new BackgroundWorker();

        private void btnTestStatus_Click(object sender, EventArgs e) {

            bwLogin.WorkerReportsProgress = true;
            bwLogin.WorkerSupportsCancellation = true;
            this.btnTestStatus.Enabled = false;
            if (!bwLogin.IsBusy) {
                bwLogin.RunWorkerAsync();
            }
        }
        IPublish iPublish;
        void bwLogin_DoWork(object sender, DoWorkEventArgs e) {
            this.btnTestStatus.Invoke(new MethodInvoker(delegate() {
                iPublish = _Class.Utility.GetIPublishByName(this.cmbPublishName.Text);
                iPublish.Publish_OutResult = OPR_SendData;
                iPublish.Publish_Type = PublishType.Login;
                iPublish.Publish_Init(this.txtWebSiteUrl.Text,
                    this.txtWebSiteLoginUrl.Text,
                    this.txtLoginUserName.Text,
                    this.txtLoginUserPwd.Text,
                    0,
                    string.Empty);
                iPublish.Publish_Login();
                this.btnTestStatus.Enabled = true;
            }));
        }

        private void OPR_SendData(object sender, PublishType pt, bool isLogin, string Msg, object oResult) {
            if (pt == PublishType.Login) {
                MessageBox.Show(Msg.ToString());
            }
            else if (pt == PublishType.LoginOver) {
                MessageBox.Show(Msg.ToString());
            }
            else if (pt == PublishType.GetClassListOver) {
                List<ModelClassItem> ListModelClassItem = (List<ModelClassItem>)oResult;
                int WebSiteID = StringHelper.Instance.SetNumber(this.txtID.Text);
                DALWebSiteClassList dal = new DALWebSiteClassList();
                foreach (ModelClassItem item in ListModelClassItem) {
                    dal.InsertClassList(WebSiteID.ToString(),
                        item.ClassID, item.ClassName,
                        string.Empty);
                }
                this.Bind_ClassList();
            }
        }
        #endregion

        #region 分类操作
        /// <summary>
        /// 创建分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateClass_Click(object sender, EventArgs e) {
        }
        /// <summary>
        /// 加载分类
        /// </summary>
        private void Bind_ClassList() {
            DALWebSiteClassList dal = new DALWebSiteClassList();
            int WebSiteID = StringHelper.Instance.SetNumber(this.txtID.Text);
            DataSet ds = dal.GetClassList(WebSiteID.ToString());
            if (ds != null && ds.Tables[0].Rows.Count > 0) {
                DataTable dt = ds.Tables[0];
                this.dataGridView_ClassList.AutoGenerateColumns = false;
                this.dataGridView_ClassList.AllowUserToAddRows = false;
                this.dataGridView_ClassList.DataSource = dt.DefaultView;
            }
        }
        /// <summary>
        /// 获取分类
        /// </summary>
        private void btnGetClassList_Click(object sender, EventArgs e) {
            Application.DoEvents();
            IPublish iPublish = _Class.Utility.GetIPublishByName(this.cmbPublishName.Text);
            iPublish.Publish_OutResult = OPR_SendData;
            iPublish.Publish_Type = PublishType.GetClassList;
            iPublish.Publish_Init(this.txtWebSiteUrl.Text,
                    this.txtWebSiteLoginUrl.Text,
                    this.txtLoginUserName.Text,
                    this.txtLoginUserPwd.Text,
                    0,
                    string.Empty);
            iPublish.Publish_GetClassList();
        }

        /// <summary>
        /// 编辑分类
        /// </summary>
        private void ToolStripMenuItem_WebSiteClassEdit_Click(object sender, EventArgs e) {
            int ClassID = Get_DataViewID();
            if (ClassID == 0) {
                return;
            }
            frmWebSiteClassEdit formWebSiteClassEdit = new frmWebSiteClassEdit();
            formWebSiteClassEdit.OldValue = ClassID.ToString();
            formWebSiteClassEdit.OO = OOTreeOption;
            formWebSiteClassEdit.ShowDialog(this);
        }
        /// <summary>
        /// 获取分类Id
        /// </summary>
        private int Get_DataViewID() {
            DataGridViewSelectedRowCollection row = this.dataGridView_ClassList.SelectedRows;
            if (row.Count > 0) {
                return StringHelper.Instance.SetNumber(row[0].Cells[0].Value.ToString());
            }
            return 0;
        }
        /// <summary>
        /// 重新加载分类
        /// </summary>
        private void OOTreeOption(object sender, string msg, Common.Option op) {
            this.Bind_ClassList();
        }
        /// <summary>
        /// 分类删除
        /// </summary>
        private void ToolStripMenuItem_WebSiteClassDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("你确定要删除吗?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                int ID = Get_DataViewID();
                DALWebSiteClassList dal = new DALWebSiteClassList();
                dal.Delete(ID);
                this.Bind_ClassList();
            }
        }
        #endregion

        #region 数据源操作
        /// <summary>
        /// 文本数据源
        /// </summary>
        private void btnFileSourcePathBower_Click(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK) {
                this.txtFileSourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }
        #endregion

        #region 插件加载顺序

        /// <summary>
        /// 插件向上
        /// </summary>
        private void btnUp_Click(object sender, EventArgs e) {
            for (int i = 0; i < this.listView_PublishContentPlugins.CheckedItems.Count; i++) {
                if (listView_PublishContentPlugins.CheckedItems[i].Index != 0) {
                    ListViewItem item = listView_PublishContentPlugins.CheckedItems[i];
                    int index = item.Index;
                    listView_PublishContentPlugins.Items.Remove(item);
                    listView_PublishContentPlugins.Items.Insert(index - 1, item);
                }
            }
        }
        /// <summary>
        /// 插件向下
        /// </summary>
        private void btnDown_Click(object sender, EventArgs e) {
            for (int i = listView_PublishContentPlugins.CheckedItems.Count; i > 0; i--) {
                if (listView_PublishContentPlugins.CheckedItems[i - 1].Index != listView_PublishContentPlugins.Items.Count - 1) {
                    ListViewItem item = listView_PublishContentPlugins.CheckedItems[i - 1];
                    int index = item.Index;
                    listView_PublishContentPlugins.Items.Remove(item);
                    listView_PublishContentPlugins.Items.Insert(index + 1, item);
                }
            }
        }
        #endregion

        #region 模块导入
        /// <summary>
        /// 模块导入
        /// </summary>
        private void lbtnImportModules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string MuBiaoPath = AppDomain.CurrentDomain.BaseDirectory + "Modules\\";
            this.openFileDialogModules.Filter = "dll files(*.dll)|*.dll|pmod files(*.pmod)|*.pmod|All files (*.*)|*.*";
            if (this.openFileDialogModules.ShowDialog() == DialogResult.OK) {
                string fileOld = this.openFileDialogModules.FileName;
                FileInfo fileI = new FileInfo(fileOld);
                string fileNewName = fileI.Name;
                string fileNew = MuBiaoPath + fileNewName;
                if (File.Exists(fileNew)) {
                    if (MessageBox.Show("目标文件存在!你确定要覆盖吗?", "警告", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                        File.Delete(fileNew);
                        File.Copy(fileOld, MuBiaoPath + fileNewName);
                    }
                }
                else {
                    File.Copy(fileOld, MuBiaoPath + fileNewName);
                }
            }
        }
        #endregion

        #region 数据源操作选项切换

        private void rbtnDataSourceType1_CheckedChanged(object sender, EventArgs e) {
            if (this.rbtnDataSourceType1.Checked) {
                this.tabControl_DataSourceList.SelectedIndex = 0;
            }
        }

        private void rbtnDataSourceType2_CheckedChanged(object sender, EventArgs e) {
            if (this.rbtnDataSourceType2.Checked) {
                this.tabControl_DataSourceList.SelectedIndex = 1;
            }
        }

        private void rbtnDataSourceType3_CheckedChanged(object sender, EventArgs e) {
            if (this.rbtnDataSourceType3.Checked) {
                this.tabControl_DataSourceList.SelectedIndex = 2;
            }
        }

        private void rbtnDataSourceType4_CheckedChanged(object sender, EventArgs e) {
            if (this.rbtnDataSourceType4.Checked) {
                this.tabControl_DataSourceList.SelectedIndex = 3;
            }
        }

        private void rbtnDataSourceType5_CheckedChanged(object sender, EventArgs e) {
            if (this.rbtnDataSourceType5.Checked) {
                this.tabControl_DataSourceList.SelectedIndex = 4;
            }
        }

        private void tabControl_DataSourceList_SelectedIndexChanged(object sender, EventArgs e) {
            int tabIndex = tabControl_DataSourceList.SelectedIndex;
            switch (tabIndex) {
                case 0:
                    rbtnDataSourceType1.Checked = true;
                    break;
                case 1:
                    rbtnDataSourceType2.Checked = true;
                    break;
                case 2:
                    rbtnDataSourceType3.Checked = true;
                    break;
                case 3:
                    rbtnDataSourceType4.Checked = true;
                    break;
                case 4:
                    rbtnDataSourceType5.Checked = true;
                    break;
            }
        }
        #endregion
    }
}
