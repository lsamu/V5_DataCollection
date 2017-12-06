using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using V5_DataPlugins.Model;
using V5_WinUtility.Expand;
using V5_Utility.Core;

namespace V5_PublishModule {
    public partial class frmMain : Form {
        public delegate void EditEventHandler(string msg);
        public EditEventHandler EditEH;

        //模块目录
        private string modulePath = AppDomain.CurrentDomain.BaseDirectory + "/Modules/";
        public frmMain() {
            InitializeComponent();
            EditEH = OutModuleDelegate;
        }

        #region 模块操作
        private void OutModuleDelegate(string msg) {
            this.toolStripStatusLabel_Bottom.Text = msg;
        }
        /// <summary>
        /// 模块保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPublishModuleSave_Click(object sender, EventArgs e) {
            string oldFileName = this.txtOldModuleName.Text;
            string ModuleName = this.txtPublishModuleName.Text;
            this.Bind_DataEditSave();
            this.Bind_LoadModuleList();
            if (!string.IsNullOrEmpty(oldFileName)) {
                if (EditEH != null) {
                    EditEH("模块修改成功!");
                }
            }
            else {
                if (EditEH != null) {
                    EditEH("模块添加成功!");
                }
            }
        }
        /// <summary>
        /// 模块编辑
        /// </summary>
        private void Bind_DataEditSave() {
            string oldFileName = this.txtOldModuleName.Text;

            string PublishModuleName = this.txtPublishModuleName.Text;
            string PageEncode = ((ListItem)this.ddlPageEncode.SelectedItem).Value;
            string ModuleReadMe = this.txtModuleReadMe.Text;

            string LoginUrl = this.txtLoginUrl.Text;
            string LoginChkUrl = this.txtLoginChkUrl.Text;
            string LoginRefUrl = this.txtLoginRefUrl.Text;
            string LoginVerCodeUrl = this.txtLoginVerCodeUrl.Text;
            string LoginPostData = this.txtLoginPostData.Text;
            string LoginErrorResult = this.txtLoginErrorResult.Text;
            string LoginSuccessResult = this.txtLoginSuccessResult.Text;

            string ListUrl = this.txtListUrl.Text;
            string ListRefUrl = this.txtListRefUrl.Text;
            string ListStartCut = this.txtListStartCut.Text;
            string ListEndCut = this.txtListEndCut.Text;
            string ListClassIDNameRegex = this.txtListClassIDNameRegex.Text;
            string ListCreateUrl = this.txtListCreateUrl.Text;
            string ListCreateRefUrl = this.txtListCreateRefUrl.Text;
            string ListCreatePostData = this.txtListCreatePostData.Text;
            string ListCreateSuccess = this.txtListCreateSuccess.Text;
            string ListCreateError = this.txtListCreateError.Text;

            string ContentUrl = this.txtContentUrl.Text;
            string ContentRefUrl = this.txtContentRefUrl.Text;
            string ContentPostData = this.txtContentPostData.Text;
            string ContentErrorResult = this.txtContentErrorResult.Text;
            string ContentSuccessResult = this.txtContentSuccessResult.Text;

            string UploadUrl = this.txtUploadUrl.Text;
            string UploadRefUrl = this.txtUploadRefUrl.Text;
            string UploadPostData = this.txtUploadPostData.Text;


            errorProvider.Clear();
            if (string.IsNullOrEmpty(PublishModuleName)) {
                errorProvider.SetError(this.txtPublishModuleName, "模块名称不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(PageEncode)) {
                errorProvider.SetError(this.ddlPageEncode, "网站编码不能为空!");
                return;
            }

            ModelPublishModuleItem model = new ModelPublishModuleItem();
            model.PublishModuleName = PublishModuleName;
            model.PageEncode = PageEncode;
            model.ModuleReadMe = ModuleReadMe;

            model.LoginUrl = LoginUrl;
            model.LoginChkrl = LoginChkUrl;
            model.LoginRefUrl = LoginRefUrl;
            model.LoginVerCodeUrl = LoginVerCodeUrl;
            model.LoginPostData = LoginPostData;
            model.LoginErrorResult = LoginErrorResult;
            model.LoginSuccessResult = LoginSuccessResult;

            model.ListUrl = ListUrl;
            model.ListRefUrl = ListRefUrl;
            model.ListStartCut = ListStartCut;
            model.ListEndCut = ListEndCut;
            model.ListClassIDNameRegex = ListClassIDNameRegex;
            model.ListCreateUrl = ListCreateUrl;
            model.ListCreateRefUrl = ListCreateRefUrl;
            model.ListCreatePostData = ListCreatePostData;
            model.ListCreateSuccess = ListCreateSuccess;
            model.ListCreateError = ListCreateError;

            model.ContentUrl = ContentUrl;
            model.ContentRefUrl = ContentRefUrl;
            model.ContentPostData = ContentPostData;
            model.ContentErrorResult = ContentErrorResult;
            model.ContentSuccessResult = ContentSuccessResult;

            model.UploadUrl = UploadUrl;
            model.UploadRefUrl = UploadRefUrl;
            model.UploadPostData = UploadPostData;

            foreach (ListViewItem item in this.listView_Random.Items) {
                ModelRandom m = new ModelRandom();
                m.LabelName = item.SubItems[0].Text;
                m.RandomUrl = item.SubItems[1].Text;
                m.RandomRefUrl = item.SubItems[2].Text;
                m.RandomPostData = item.SubItems[3].Text;
                m.RandomCutRegex = item.SubItems[4].Text;
                m.RandomLabelType = item.SubItems[5].Text;
                model.ListRandomModel.Add(m);
            }
            foreach (ListViewItem item in this.listView_CreateHtml.Items) {
                ModelCreateHtml m = new ModelCreateHtml();
                m.CreateName = item.SubItems[0].Text;
                m.CreateHtmlUrl = item.SubItems[1].Text;
                m.CreateHtmlRefUrl = item.SubItems[2].Text;
                m.CreateHtmlPostData = item.SubItems[3].Text;
                model.ListCreateHtmlModel.Add(m);
            }
            //修改
            if (!string.IsNullOrEmpty(oldFileName)) {
                if (PublishModuleName != oldFileName) {
                    string modulePathName = modulePath + PublishModuleName + ".pmod";
                    if (File.Exists(modulePathName)) {
                        MessageBox.Show("该模块已经存在!请换个名称试一试!");
                        return;
                    }
                    //删除旧的数据
                    string oldModulePathName = modulePath + oldFileName + ".pmod";
                    if (File.Exists(oldModulePathName))
                        File.Delete(oldModulePathName);
                }
            }
            DoModelToXml(model);
        }
        /// <summary>
        /// 模块编辑
        /// </summary>
        /// <param name="EditItem"></param>
        private void Bind_DataEdit(object EditItem) {
            string Name = (string)EditItem;
            ModelPublishModuleItem model = GetModelXml(Name);

            this.txtOldModuleName.Text = model.PublishModuleName;
            this.txtPublishModuleName.Text = model.PublishModuleName;
            this.ddlPageEncode.SelectedItem = model.PageEncode;
            this.txtModuleReadMe.Text = model.ModuleReadMe;

            this.txtLoginUrl.Text = model.LoginUrl;
            this.txtLoginChkUrl.Text = model.LoginChkrl;
            this.txtLoginRefUrl.Text = model.LoginRefUrl;
            this.txtLoginVerCodeUrl.Text = model.LoginVerCodeUrl;
            this.txtLoginPostData.Text = model.LoginPostData;
            this.txtLoginErrorResult.Text = model.LoginErrorResult;
            this.txtLoginSuccessResult.Text = model.LoginSuccessResult;

            this.txtListUrl.Text = model.ListUrl;
            this.txtListRefUrl.Text = model.ListRefUrl;
            this.txtListStartCut.Text = model.ListStartCut;
            this.txtListEndCut.Text = model.ListEndCut;
            this.txtListClassIDNameRegex.Text = model.ListClassIDNameRegex;
            this.txtListCreateUrl.Text = model.ListCreateUrl;
            this.txtListCreateRefUrl.Text = model.ListCreateRefUrl;
            this.txtListCreatePostData.Text = model.ListCreatePostData;
            this.txtListCreateSuccess.Text = model.ListCreateSuccess;
            this.txtListCreateError.Text = model.ListCreateError;


            this.txtContentUrl.Text = model.ContentUrl;
            this.txtContentRefUrl.Text = model.ContentRefUrl;
            this.txtContentPostData.Text = model.ContentPostData;
            this.txtContentErrorResult.Text = model.ContentErrorResult;
            this.txtContentSuccessResult.Text = model.ContentSuccessResult;


            this.txtUploadUrl.Text = model.UploadUrl;
            this.txtUploadRefUrl.Text = model.UploadRefUrl;
            this.txtUploadPostData.Text = model.UploadPostData;
            foreach (ListViewItem item in this.listView_Random.Items) {
                this.listView_Random.Items.Remove(item);
            }
            foreach (ModelRandom item in model.ListRandomModel) {
                ListViewItem li = new ListViewItem(item.LabelName);
                li.SubItems.Add(item.RandomUrl);
                li.SubItems.Add(item.RandomRefUrl);
                li.SubItems.Add(item.RandomPostData);
                li.SubItems.Add(item.RandomCutRegex);
                li.SubItems.Add(item.RandomLabelType);
                this.listView_Random.Items.Add(li);
            }
            foreach (ListViewItem item in this.listView_CreateHtml.Items) {
                this.listView_CreateHtml.Items.Remove(item);
            }
            foreach (ModelCreateHtml item in model.ListCreateHtmlModel) {
                ListViewItem li = new ListViewItem(item.CreateName);
                li.SubItems.Add(item.CreateHtmlUrl);
                li.SubItems.Add(item.CreateHtmlRefUrl);
                li.SubItems.Add(item.CreateHtmlPostData);
                this.listView_CreateHtml.Items.Add(li);
            }
        }
        /// <summary>
        /// 清楚模块数据
        /// </summary>
        private void Bind_DataEditClear() {
            this.txtPublishModuleName.Text = string.Empty;
            this.txtLoginUrl.Text = string.Empty;
            this.ddlPageEncode.SelectedItem = string.Empty;

            this.txtLoginChkUrl.Text = string.Empty;
            this.txtLoginRefUrl.Text = string.Empty;
            this.txtLoginVerCodeUrl.Text = string.Empty;
            this.txtLoginPostData.Text = string.Empty;
            this.txtLoginErrorResult.Text = string.Empty;
            this.txtLoginSuccessResult.Text = string.Empty;

            this.txtListUrl.Text = string.Empty;
            this.txtListRefUrl.Text = string.Empty;
            this.txtListStartCut.Text = string.Empty;
            this.txtListEndCut.Text = string.Empty;
            this.txtListClassIDNameRegex.Text = string.Empty;
            this.txtListCreateUrl.Clear();
            this.txtListCreateRefUrl.Clear();
            this.txtListCreatePostData.Clear();
            this.txtListCreateError.Clear();
            this.txtListCreateSuccess.Clear();

            this.txtContentUrl.Text = string.Empty;
            this.txtContentRefUrl.Text = string.Empty;
            this.txtContentPostData.Text = string.Empty;
            this.txtContentErrorResult.Text = string.Empty;
            this.txtContentSuccessResult.Text = string.Empty;

            this.listView_Random.Items.Clear();

            this.txtModuleReadMe.Text = string.Empty;

            this.txtOldModuleName.Clear();
        }

        /// <summary>
        /// 处理没有处理完毕的到Xml文件
        /// </summary>
        /// <returns></returns>
        public bool DoModelToXml(ModelPublishModuleItem model) {
            try {
                string fileName = modulePath + model.PublishModuleName + ".pmod";
                ObjFileStoreHelper.Serialize(model, fileName);
                return true;
            }
            catch {
            }
            return false;
        }
        /// <summary>
        /// 获取模型
        /// </summary>
        /// <param name="pathName"></param>
        /// <returns></returns>
        public ModelPublishModuleItem GetModelXml(string pathName) {
            ModelPublishModuleItem model = new ModelPublishModuleItem();
            try {
                string fileName = modulePath + pathName;
                model = (ModelPublishModuleItem)ObjFileStoreHelper.Deserialize(fileName);
            }
            catch {

            }
            return model;
        }

        /// <summary>
        /// 加载模块列表
        /// </summary>
        private void Bind_LoadModuleList() {
            try {
                this.listBoxPublishModule.Items.Clear();
                DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/Modules/");
                FileInfo[] files = di.GetFiles("*.pmod");
                foreach (FileInfo fi in files) {
                    this.listBoxPublishModule.Items.Add(fi.Name);
                }
            }
            catch {
            }
        }
        /// <summary>
        /// 清除模块数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e) {
            Bind_DataEditClear();
        }
        /// <summary>
        /// 删除选中的模块数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e) {
            string seletedValue = (string)this.listBoxPublishModule.SelectedItem;
            string modulePathFile = modulePath + seletedValue;
            if (File.Exists(modulePathFile)) {
                File.Delete(modulePathFile);
            }
            Bind_LoadModuleList();
        }
        /// <summary>
        /// 重新加载模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click_1(object sender, EventArgs e) {
            this.Bind_LoadModuleList();
        }

        /// <summary>
        /// 双击编辑模块数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPublishModule_DoubleClick(object sender, EventArgs e) {
            string EditItemIndex = (string)this.listBoxPublishModule.SelectedItem;
            Bind_DataEdit(EditItemIndex);
        }
        #endregion

        #region 程序
        /// <summary>
        /// 程序退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e) {
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPublishModuleClose_Click(object sender, EventArgs e) {
            this.Bind_DataEditSave();
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPublishModule_Load(object sender, EventArgs e) {
            if (!Directory.Exists(modulePath))
                Directory.CreateDirectory(modulePath);
            this.ddlPageEncode.DataSource = cPageEncode.GetPageEnCode();
            this.ddlPageEncode.DisplayMember = "Text";
            this.ddlPageEncode.ValueMember = "Value";
            this.contextMenuStrip_ListLabelInsert.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip_ListLabelInsert_ItemClicked);
            //;
            Bind_LoginLabelInsert();
            Bind_LoadModuleList();
        }
        #endregion

        #region  公共部分
        /// <summary>
        /// 加载随机值
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="RandomLabelType"></param>
        private void Bind_LoadRandDomList(ContextMenuStrip menu, string RandomLabelType) {
            menu.Items.Add("-");
            foreach (ListViewItem item in this.listView_Random.Items) {
                if (item.SubItems[5].Text == RandomLabelType) {
                    menu.Items.Add(item.Text);
                }
            }
        }
        #endregion

        #region 登陆
        /// <summary>
        /// 加载登陆随机值
        /// </summary>
        private void Bind_LoginRandomList() {
            this.contextMenuStrip_LoginLabelInsert.Items.Clear();
            this.contextMenuStrip_LoginLabelInsert.Items.Add("用户名");
            this.contextMenuStrip_LoginLabelInsert.Items.Add("密码");
            this.contextMenuStrip_LoginLabelInsert.Items.Add("验证码");
            Bind_LoadRandDomList(contextMenuStrip_LoginLabelInsert, "登陆");
        }

        private void Bind_LoginLabelInsert() {
            this.contextMenuStrip_LoginLabelInsert.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip_LoginLabelInsert_ItemClicked);
        }
        /// <summary>
        /// 登陆参数插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip_LoginLabelInsert_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string s = "[" + e.ClickedItem.Text + "]";
            int startPos = this.txtLoginPostData.SelectionStart;
            int l = this.txtLoginPostData.SelectionLength;

            this.txtLoginPostData.Text = this.txtLoginPostData.Text.Substring(0, startPos) + s + this.txtLoginPostData.Text.Substring(startPos + l, this.txtLoginPostData.Text.Length - startPos - l);

            this.txtLoginPostData.SelectionStart = startPos + s.Length;
            this.txtLoginPostData.ScrollToCaret();
        }
        /// <summary>
        /// 登陆标签显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginLabelInsert_Click(object sender, EventArgs e) {
            Bind_LoginRandomList();
            this.contextMenuStrip_LoginLabelInsert.Show(btnLoginLabelInsert, 0, 21);
        }
        #endregion

        #region 分类列表
        private void contextMenuStrip_ListLabelInsert_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string s = "[" + e.ClickedItem.Text + "]";
            int startPos = this.txtListCreatePostData.SelectionStart;
            int l = this.txtListCreatePostData.SelectionLength;

            this.txtListCreatePostData.Text = this.txtListCreatePostData.Text.Substring(0, startPos) + s + this.txtListCreatePostData.Text.Substring(startPos + l, this.txtListCreatePostData.Text.Length - startPos - l);

            this.txtListCreatePostData.SelectionStart = startPos + s.Length;
            this.txtListCreatePostData.ScrollToCaret();
        }
        /// <summary>
        /// 加载列表随机值
        /// </summary>
        private void Bind_ListRandomList() {
            this.contextMenuStrip_ListLabelInsert.Items.Clear();
            this.contextMenuStrip_ListLabelInsert.Items.Add("分类ID");
            this.contextMenuStrip_ListLabelInsert.Items.Add("分类名称");
            Bind_LoadRandDomList(contextMenuStrip_ListLabelInsert, "列表");
        }
        /// <summary>
        /// 分类标签显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListLabelInsert_Click(object sender, EventArgs e) {
            Bind_ListRandomList();
            this.contextMenuStrip_ListLabelInsert.Show(this.btnListLabelInsert, 0, 21);
        }
        #endregion

        #region 发布内容
        /// <summary>
        /// 加载内容随机值
        /// </summary>
        private void Bind_ContentRandomList() {
            this.contextMenuStrip_ViewLabelInsert.Items.Clear();
            this.contextMenuStrip_ViewLabelInsert.Items.Add("标题");
            this.contextMenuStrip_ViewLabelInsert.Items.Add("内容");
            this.contextMenuStrip_ViewLabelInsert.Items.Add("分类ID");
            this.contextMenuStrip_ViewLabelInsert.Items.Add("分类名称");
            Bind_LoadRandDomList(contextMenuStrip_ViewLabelInsert, "内容");
        }
        /// <summary>
        /// 内容标签插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip_ViewLabelInsert_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string s = "[" + e.ClickedItem.Text + "]";
            int startPos = this.txtContentPostData.SelectionStart;
            int l = this.txtContentPostData.SelectionLength;

            this.txtContentPostData.Text = this.txtContentPostData.Text.Substring(0, startPos) + s + this.txtContentPostData.Text.Substring(startPos + l, this.txtContentPostData.Text.Length - startPos - l);

            this.txtContentPostData.SelectionStart = startPos + s.Length;
            this.txtContentPostData.ScrollToCaret();

        }
        /// <summary>
        /// 内容标签显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewLabelInsert_Click(object sender, EventArgs e) {
            Bind_ContentRandomList();
            this.contextMenuStrip_ViewLabelInsert.Show(this.btnViewLabelInsert, 0, 21);
        }
        #endregion

        #region 随机值
        /// <summary>
        /// 添加随机值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewRandom_Click(object sender, EventArgs e) {
            frmRandom formRandom = new frmRandom();
            formRandom.OutRandomDelegate = OutRandomDelegate;
            formRandom.Show(this);
        }
        /// <summary>
        /// 修改随机值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRandom_Click(object sender, EventArgs e) {
            if (this.listView_Random.SelectedItems.Count > 0) {
                frmRandom formRandom = new frmRandom();
                formRandom.EditObject = this.listView_Random.SelectedItems[0];
                formRandom.OutRandomDelegate = OutRandomDelegate;
                formRandom.Show(this);
            }
            else {
                MessageBox.Show("请选择一个在进行编辑!");
            }
        }
        /// <summary>
        /// 删除随机值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRandom_Click(object sender, EventArgs e) {
            if (this.listView_Random.SelectedItems.Count > 0) {
                ListViewItem item = this.listView_Random.SelectedItems[0];
                this.listView_Random.Items.Remove(item);
            }
            else {
                MessageBox.Show("请选择一个在进行删除!");
            }
        }
        /// <summary>
        /// 随机值编辑委托
        /// </summary>
        /// <param name="li"></param>
        /// <param name="EditFlag"></param>
        private void OutRandomDelegate(ListViewItem li, bool EditFlag) {
            if (EditFlag) {
                int index = li.Index;
                this.listView_Random.Items.RemoveAt(index);
                this.listView_Random.Items.Insert(index, li);
            }
            else {
                this.listView_Random.Items.Add(li);
            }
        }
        #endregion

        #region 生成静态
        /// <summary>
        /// 静态规则添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateHtmlAdd_Click(object sender, EventArgs e) {
            frmCreateHtml formCreateHtml = new frmCreateHtml();
            formCreateHtml.OutLVICreateHtml = OutCreateHtmlDelegate;
            formCreateHtml.Show(this);
        }
        /// <summary>
        /// 静态规则编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateHtmlEdit_Click(object sender, EventArgs e) {
            if (this.listView_CreateHtml.SelectedItems.Count > 0) {
                frmCreateHtml formCreateHtml = new frmCreateHtml();
                formCreateHtml.EditObject = this.listView_CreateHtml.SelectedItems[0];
                formCreateHtml.OutLVICreateHtml = OutCreateHtmlDelegate;
                formCreateHtml.Show(this);
            }
            else {
                MessageBox.Show("请选择一个在进行编辑!");
            }
        }
        /// <summary>
        /// 静态规则删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateHtmlDel_Click(object sender, EventArgs e) {
            if (this.listView_CreateHtml.SelectedItems.Count > 0) {
                ListViewItem item = this.listView_CreateHtml.SelectedItems[0];
                this.listView_CreateHtml.Items.Remove(item);
            }
            else {
                MessageBox.Show("请选择一个在进行删除!");
            }
        }
        /// <summary>
        /// 静态规则委托
        /// </summary>
        /// <param name="li"></param>
        /// <param name="EditFlag"></param>
        private void OutCreateHtmlDelegate(ListViewItem li, bool EditFlag) {
            if (EditFlag) {
                int index = li.Index;
                this.listView_CreateHtml.Items.RemoveAt(index);
                this.listView_CreateHtml.Items.Insert(index, li);
            }
            else {
                if (this.listView_CreateHtml.Items.Count > 0) {
                    this.listView_CreateHtml.Items[0].SubItems.Add(li.Text);
                }
                else {
                    this.listView_CreateHtml.Items.Add(li);
                }
            }
        }
        #endregion

        #region 菜单
        /// <summary>
        /// 测试模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_TestModule_Click(object sender, EventArgs e) {
            frmTestModule formTestModule = new frmTestModule();
            formTestModule.Show(this);
        }
        #endregion

        private void 测试模块ToolStripMenuItem_Click(object sender, EventArgs e) {
            object seletedItem = this.listBoxPublishModule.SelectedItem;
            if (seletedItem != null) {
                frmTestModule m_frmTestModule = new frmTestModule();
                m_frmTestModule.ModuleName = seletedItem.ToString();
                m_frmTestModule.ShowDialog(this);
            }
        }
    }
}
