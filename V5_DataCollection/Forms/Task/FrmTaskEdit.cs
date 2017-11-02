using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using V5_Model;
using System.IO;
using V5_DataCollection._Class.Gather;
using V5_DataCollection.Forms.Publish;
using V5_DataCollection._Class.Common;
using System.Diagnostics;
using V5_DataPlugins;
using V5_DataCollection._Class.PythonExt;
using V5_DataCollection.Forms.Task.Tools;
using V5_DataCollection._Class.DAL;
using V5_DataCollection._Class.Plan;
using V5_DataCollection._Class;
using V5_Utility.Utility;
using V5_WinLibs.Core;
using V5_WinLibs.Utility;
using V5_WinLibs.Expand;
using V5_WinControls;
using V5_WinLibs.DBUtility;
using System.Threading.Tasks;
using V5_DataCollection.Forms.Tools;

namespace V5_DataCollection.Forms.Task {
    public partial class FrmTaskEdit : BaseForm {

        #region 访问器
        private cGatherFunction gatherWork = new cGatherFunction();
        private SpiderHelper Gather = new SpiderHelper();
        public TaskEventHandler.TaskOpHandler TaskOpDelegate;
        private TaskEvents.TaskOpEvents TaskOpEv = new TaskEvents.TaskOpEvents();
        /// <summary>
        /// 任务ID
        /// </summary>
        public int ID { get; set; } = 0;
        /// <summary>
        /// 任务名称
        /// </summary>
        public string OldTaskName { get; set; } = string.Empty;
        /// <summary>
        /// 任务索引
        /// </summary>
        public int TaskIndex { get; set; } = 0;
        protected Panel panel_List2 = new Panel();
        protected TextBox txtSourceText = new TextBox();
        #endregion

        public FrmTaskEdit() {

            InitializeComponent();

            this.txtHiddenPlanFormat.Visible = false;
            this.txtHiddenPlanFormat.TextChanged += (object sender, EventArgs e) => {
                this.txtTaskSetFormat.Text = this.txtHiddenPlanFormat.Text;
            };

            this.cmbStatus.SelectedIndex = 0;

            txtSourceText.Dock = DockStyle.Fill;
            txtSourceText.Multiline = true;
            txtSourceText.ScrollBars = ScrollBars.Both;
            txtSourceText.MaxLength = 0;

            panel_List2.BackColor = Color.Red;
            panel_List2.Location = new Point(this.panel_List1.Location.X - 2, this.panel_List1.Location.Y - 45);
            panel_List2.Size = new Size(this.panel_List1.Size.Width - 5, this.panel_List1.Height);
            panel_List2.SuspendLayout();
            panel_List2.ResumeLayout(false);
            panel_List2.Controls.Add(txtSourceText);
            panel_List2.Visible = false;

            groupBox3.Controls.Add(panel_List2);
        }


        #region 绑定插件
        private void Bind_Plugins() {

            PluginUtility.LoadAllDlls();
            List<IPlugin> Plugins = PluginUtility.ListISpiderUrlPlugin;
            foreach (IPlugin item in Plugins) {
                this.cmbSpiderUrlPlugins.Items.Add(item.PluginName);
            }
            var publishFiles = Directory.GetFiles(PluginUtility.SpiderUrlPluginPath, "*.py");
            foreach (string str2 in publishFiles) {
                var fileInfo = new FileInfo(str2);
                this.cmbSpiderUrlPlugins.Items.Add(fileInfo.Name);
            }

            this.cmbSpiderUrlPlugins.Items.Insert(0, "不使用插件");
            this.cmbSpiderUrlPlugins.SelectedIndex = 0;

            Plugins = PluginUtility.ListISaveContentPlugin;
            foreach (IPlugin item in Plugins) {
                this.cmbSaveConentPlugins.Items.Add(item.PluginName);
            }
            this.cmbSaveConentPlugins.Items.Insert(0, "不使用插件");
            this.cmbSaveConentPlugins.SelectedIndex = 0;
            Plugins = PluginUtility.ListIPublishContentPlugin;
            foreach (IPlugin item in Plugins) {
                this.cmbPublishContentPlugins.Items.Add(item.PluginName);
            }
            this.cmbPublishContentPlugins.Items.Insert(0, "不使用插件");
            this.cmbPublishContentPlugins.SelectedIndex = 0;
        }

        #endregion

        private void FrmTaskEdit_Load(object sender, EventArgs e) {
            Bind_UrlEncode();
            Bind_Plugins();
            Bind_SiteTreeClass();
            if (ID > 0) {
                this.ID = ID;
                this.Bind_DataEdit(ID);
                Bind_TaskLabel(" TaskID=" + ID + " ");
                Bind_WebPublishModule(" TaskID=" + ID + " ");

                Bind_DiyUrlWebList(" And SelfId=" + ID);
            }

            this.contextMenuStrip_Label.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip_Label_ItemClicked);

            this.contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip1_ItemClicked);
        }

        void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string s = "[" + e.ClickedItem.Text + "]";
        }

        void contextMenuStrip_Label_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string s = "[" + e.ClickedItem.Text + "]";
            BindLabel_W(this.txtSaveDataSQL3, s);

        }

        private void BindLabel_W(V5RichTextBox rtb, string s) {
            int startPos = rtb.SelectionStart;
            int l = rtb.SelectionLength;

            rtb.Text = rtb.Text.Substring(0, startPos) + s + rtb.Text.Substring(startPos + l, rtb.Text.Length - startPos - l);

            rtb.SelectionStart = startPos + s.Length;
            rtb.ScrollToCaret();
        }

        #region 初始化
        /// <summary>
        /// 绑定编码
        /// </summary>
        private void Bind_UrlEncode() {
            var data = cPageEncode.GetPageEnCode(); ;
            this.ddlItemEncode.DataSource = data;
            this.ddlItemEncode.DisplayMember = "Text";
            this.ddlItemEncode.ValueMember = "Value";
        }

        private void Bind_SiteTreeClass() {
            DALTaskClass dal = new DALTaskClass();
            DataTable dt = dal.GetList("").Tables[0];
            this.cmbSiteClassID.DataSource = dt;
            this.cmbSiteClassID.DisplayMember = "TreeClassName";
            this.cmbSiteClassID.ValueMember = "ClassID";
        }


        #endregion

        #region LinkUrl
        /// <summary>
        /// 向导添加LinkUrl
        /// </summary>
        private void btnWizardEdit_Click(object sender, EventArgs e) {
            frmTaskUrl FormTaskUrl = new frmTaskUrl();
            FormTaskUrl.AddUrl = AddUrl;
            FormTaskUrl.ShowDialog(this);
        }
        /// <summary>
        /// LinkUrl 委托显示
        /// </summary>
        private void AddUrl(object sender, TaskEvents.AddLinkUrlEvents e) {
            this.listBoxLinkUrl.Items.Clear();
            foreach (string item in e.LinkObject) {
                this.listBoxLinkUrl.Items.Insert(0, item);
            }
        }
        /// <summary>
        /// LinkUrl 删除
        /// </summary>
        private void txtLinkUrlDelete_Click(object sender, EventArgs e) {
            object item = this.listBoxLinkUrl.SelectedItem;
            if (item != null) {
                this.listBoxLinkUrl.Items.Remove(item);
            }
        }
        /// <summary>
        /// LinkUrl 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLinkUrlEdit_Click(object sender, EventArgs e) {
            object item = this.listBoxLinkUrl.SelectedItem;
            if (item != null) {
                frmTaskUrl FormTaskUrl = new frmTaskUrl();
                FormTaskUrl.AddUrl = AddUrl;
                FormTaskUrl.EditUrl = this.listBoxLinkUrl.Items;
                FormTaskUrl.ShowDialog(this);
            }
        }
        #endregion

        #region 测试列表地址采集
        /// <summary>
        /// 测试链接
        /// </summary>
        private void btnLinkUrlTest_Click(object sender, EventArgs e) {
            if (!this.chkIsSource.Checked) {
                object listItem = this.listBoxLinkUrl.SelectedItem;
                if (listItem == null) {
                    MessageBox.Show("选择一个采集连接!");
                    return;
                }
            }

            this.tabControlTaskEdit.SelectTab(4);
            this.treeViewUrlTest.Nodes.Clear();
            object item = this.listBoxLinkUrl.SelectedItem;
            var encode = ((ListItem)this.ddlItemEncode.SelectedItem).Value;
            var includeStr = this.txtLinkUrlMustIncludeStr.Text;
            var NoIncludeStr = this.txtLinkUrlNoMustIncludeStr.Text;
            var LinkUrlAreaStart = this.txtLinkUrlCutAreaStart.Text;
            var LinkUrlAreaEnd = this.txtLinkUrlCutAreaEnd.Text;
            var TestLinkUrl = Convert.ToString(item);

            var IsHandGetUrl = this.chkIsHandGetUrl.Checked ? 1 : 0;
            var HandCollectionUrlRegex = this.txtHandCollectionUrlRegex.Text;

            var model = new ModelTask() {
                PageEncode = encode,
                DemoListUrl = this.txtDemoListUrl.Text,
                LinkUrlMustIncludeStr = includeStr,
                LinkUrlNoMustIncludeStr = NoIncludeStr,
                LinkUrlCutAreaStart = LinkUrlAreaStart,
                LinkUrlCutAreaEnd = LinkUrlAreaEnd,
                IsHandGetUrl = IsHandGetUrl,
                HandCollectionUrlRegex = HandCollectionUrlRegex,
                IsSource = this.chkIsSource.Checked ? 1 : 0,
                SourceText = this.txtSourceText.Text
            };

            if (!this.chkIsSource.Checked) {
                var TestListLinkUrl = gatherWork.SplitWebUrl(TestLinkUrl);
                foreach (string str in TestListLinkUrl) {
                    TreeNode rootNode = new TreeNode();
                    rootNode.Text = str;
                    this.treeViewUrlTest.Nodes.Add(rootNode);
                }
            }
            else {
                TreeNode rootNode = new TreeNode();
                rootNode.Text = "测试源码";
                this.treeViewUrlTest.Nodes.Add(rootNode);
            }


            var task = new TaskFactory().StartNew(() => {
                var spiderListHelper = new SpiderListHelper();
                spiderListHelper.Model = model;
                spiderListHelper.OutMessageHandler += (string msg) => {
                    MessageBox.Show(msg);
                };
                spiderListHelper.OutTreeNodeHandler += (string url, string title, string cover, int nodeIndex) => {
                    this.Invoke(new MethodInvoker(delegate () {
                        if (!this.treeViewUrlTest.Nodes[nodeIndex].Nodes.ContainsKey(url))
                            this.treeViewUrlTest.Nodes[nodeIndex].Nodes.Add(url, url);
                    }));
                };
                spiderListHelper.AnalyzeSingleList(TestLinkUrl);
            });


        }
        #endregion

        #region 测试详细地址采集
        /// <summary>
        /// 测试采集内容
        /// </summary>
        private void btnTestViewUrl_Click(object sender, EventArgs e) {
            this.btnTestViewUrl.Enabled = false;
            this.txtTestViewUrlShow.Clear();
            var Test_ViewUrl = this.txtTextViewUrl.Text;
            var encode = ((ListItem)this.ddlItemEncode.SelectedItem).Value;

            DALTaskLabel dal = new DALTaskLabel();
            List<ModelTaskLabel> Test_LabelList = new List<ModelTaskLabel>();
            ListView.ListViewItemCollection s = this.listViewTaskLabel.Items;
            foreach (ListViewItem ss in s) {
                Test_LabelList.Add(dal.GetModel(ss.SubItems[0].Text, ID));
            }

            var model = new ModelTask() {
                TestViewUrl = Test_ViewUrl,
                PageEncode = encode
            };

            var task = new TaskFactory().StartNew(() => {
                var spiderViewHelper = new SpiderViewHelper();
                spiderViewHelper.Model = model;
                spiderViewHelper.OutViewUrlContentHandler += (string content) => {
                    this.txtTestViewUrlShow.Invoke(new MethodInvoker(delegate () {
                        this.txtTestViewUrlShow.AppendText(content);
                        this.btnTestViewUrl.Enabled = true;
                    }));
                };
                spiderViewHelper.TestAllLabel(Test_ViewUrl, Test_LabelList);
            });
        }
        #endregion

        #region 标签操作
        /// <summary>
        /// 加载任务标签
        /// </summary>
        private void Bind_TaskLabel(string strWhere) {
            this.listViewTaskLabel.Items.Clear();
            DALTaskLabel dal = new DALTaskLabel();
            DataTable dt = dal.GetList(strWhere + " Order by OrderID Asc").Tables[0];
            foreach (DataRow dr in dt.Rows) {
                ListViewItem li = new ListViewItem(dr["LabelName"].ToString());
                li.SubItems.Add(dr["LabelNameCutRegex"].ToString());
                li.Tag = dr["ID"].ToString();
                this.listViewTaskLabel.Items.Add(li);
            }
        }
        /// <summary>
        /// 添加标签
        /// </summary>
        private void btnCutLabelAdd_Click(object sender, EventArgs e) {
            frmTaskSpiderLabel FormTaskSpiderLabel = new frmTaskSpiderLabel();
            FormTaskSpiderLabel.ViewLabel = AddViewLabel;
            FormTaskSpiderLabel.TaskID = ID;
            FormTaskSpiderLabel.TestUrl = this.txtTextViewUrl.Text;
            FormTaskSpiderLabel.PageEncode = ((ListItem)this.ddlItemEncode.SelectedItem).Value;
            FormTaskSpiderLabel.ShowDialog(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddViewLabel(object sender, TaskEvents.AddViewLabelEvents e) {
            Bind_TaskLabel(" TaskID=" + this.ID + " ");
        }
        /// <summary>
        /// 编辑标签
        /// </summary>
        private void btnCutLabelEdit_Click(object sender, EventArgs e) {
            if (this.listViewTaskLabel.SelectedItems.Count > 0) {
                var sel = this.listViewTaskLabel.SelectedItems;
                if (sel != null && sel.Count == 1) {
                    frmTaskSpiderLabel FormTaskSpiderLabel = new frmTaskSpiderLabel();
                    FormTaskSpiderLabel.EditItem = this.listViewTaskLabel.SelectedItems;
                    FormTaskSpiderLabel.ViewLabel = AddViewLabel;
                    FormTaskSpiderLabel.TaskID = ID;
                    FormTaskSpiderLabel.TestUrl = this.txtTextViewUrl.Text;
                    FormTaskSpiderLabel.PageEncode = ((ListItem)this.ddlItemEncode.SelectedItem).Value;
                    FormTaskSpiderLabel.ShowDialog(this);
                }
            }
            else {
                MessageBox.Show("请先选择标签再进行编辑!", "警告!");
            }
        }
        /// <summary>
        /// 删除标签
        /// </summary>
        private void btnCutLabelDel_Click(object sender, EventArgs e) {
            if (this.listViewTaskLabel.SelectedItems.Count > 0) {
                var sel = this.listViewTaskLabel.SelectedItems;
                if (sel != null && sel.Count == 1) {
                    if (MessageBox.Show("你确定要删除吗?删除不可恢复!", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                        ListView.SelectedListViewItemCollection item = this.listViewTaskLabel.SelectedItems;
                        DALTaskLabel dal = new DALTaskLabel();
                        dal.Delete(int.Parse("0" + item[0].Tag));
                        this.Bind_TaskLabel(" TaskID=" + this.ID);
                    }
                }
            }
            else {
                MessageBox.Show("请先选择标签再进行删除!", "警告!");
            }
        }
        /// <summary>
        /// 标签上升
        /// </summary>
        private void btnLabelUp_Click(object sender, EventArgs e) {
            if (this.listViewTaskLabel.SelectedItems.Count > 0) {
                var sel = this.listViewTaskLabel.SelectedItems;
                if (sel != null && sel.Count == 1) {
                    ListView.SelectedListViewItemCollection item = this.listViewTaskLabel.SelectedItems;
                    int iID = int.Parse("0" + item[0].Tag);
                    DALTaskLabel dal = new DALTaskLabel();
                    dal.UpdateOrder(this.ID, iID, -1);
                    this.Bind_TaskLabel(" TaskID=" + this.ID);
                }
            }
            else {
                MessageBox.Show("请先选择标签再进行操作!", "警告!");
            }
        }
        /// <summary>
        /// 标签下降
        /// </summary>
        private void btnLabelDown_Click(object sender, EventArgs e) {
            if (this.listViewTaskLabel.SelectedItems.Count > 0) {
                var sel = this.listViewTaskLabel.SelectedItems;
                if (sel != null && sel.Count == 1) {
                    ListView.SelectedListViewItemCollection item = this.listViewTaskLabel.SelectedItems;
                    int iID = int.Parse("0" + item[0].Tag);
                    DALTaskLabel dal = new DALTaskLabel();
                    dal.UpdateOrder(this.ID, iID, 1);
                    this.Bind_TaskLabel(" TaskID=" + this.ID);
                }
            }
            else {
                MessageBox.Show("请先选择标签再进行操作!", "警告!");
            }
        }
        #endregion

        #region 本地保存

        private OpenFileDialog LocalFileDialog = new OpenFileDialog();
        private FolderBrowserDialog PublishDialog = new FolderBrowserDialog();
        private void btnSaveLocalPath_Click(object sender, EventArgs e) {
            if (PublishDialog.ShowDialog(this) == DialogResult.OK) {
                this.txtSaveDirectory2.Text = PublishDialog.SelectedPath;
            }
        }

        private void btnSaveLocalHtmlTemplatePath_Click(object sender, EventArgs e) {
            if (LocalFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                LocalFileDialog.OpenFile();
                string fileName = this.LocalFileDialog.FileName;
                this.txtSaveHtmlTemplate2.Text = fileName;
            }
        }

        private void ddlSaveLocalFileFormat_SelectedIndexChanged(object sender, EventArgs e) {
            string format = this.ddlSaveFileFormat2.Text;
            if (format == ".Html") {
                txtSaveHtmlTemplate2.Enabled = true;
                btnSaveLocalHtmlTemplatePath.Enabled = true;
            }
            else if (format == ".Sql") {
                txtSaveHtmlTemplate2.Enabled = true;
                this.btnSaveLocalHtmlTemplatePath.Enabled = true;
            }
            else {
                txtSaveHtmlTemplate2.Enabled = false;
                btnSaveLocalHtmlTemplatePath.Enabled = false;
            }
        }
        #endregion

        #region 保存插入SQL语句
        private void btnSaveSqlPath_Click(object sender, EventArgs e) {
            if (PublishDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                string fileName = PublishDialog.SelectedPath;
            }
        }
        #endregion

        #region 发布测试SQL
        private void btnSaveDataBaseConfig_Click(object sender, EventArgs e) {
            btnSaveDataBaseConfig.Enabled = false;
            if (string.IsNullOrEmpty(this.txtSaveDataUrl3.Text)) {
                MessageBox.Show("数据库链接不能为空!", "警告!");
            }
            else {
                var dbType = DataBaseType.SqlServer;

                var dbLink = txtSaveDataUrl3.Text;

                if (this.rbtnAccess.Checked) {
                    dbType = DataBaseType.OleDb;
                }
                else if (this.rbtnMsSql.Checked) {
                    dbType = DataBaseType.SqlServer;
                }
                else if (this.rbtnSqlite.Checked) {
                    dbType = DataBaseType.SQLite;
                }
                else if (this.rbtnMySql.Checked) {
                    dbType = DataBaseType.MySql;
                }
                else if (this.rbtnOracle.Checked) {
                    dbType = DataBaseType.Oracle;
                }
                var task = new TaskFactory().StartNew(() => {
                    using (var conn = DbHelperDapper.GetDbConnection(dbType, dbLink)) {
                        if (conn != null && conn.State == ConnectionState.Open) {
                            MessageBox.Show("数据库连接成功!");
                        }
                        else {
                            MessageBox.Show("数据库连接失败!");
                        }
                    }
                    btnSaveDataBaseConfig.Enabled = true;
                });
            }

        }
        private void OutDbConfigUrl(string strDbUrl) {
            this.txtSaveDataUrl3.Invoke(new MethodInvoker(delegate () {
                this.txtSaveDataUrl3.Text = strDbUrl;
            }));

        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e) {
            this.CloseForm();
        }

        #region 编辑数据
        private void Bind_DataEdit(int ID) {

            this.Text = "编辑任务";

            ModelTask model = new DALTask().GetModel(ID);
            this.txtID.Text = model.ID.ToString();
            this.cmbSiteClassID.SelectedValue = model.TaskClassID;
            this.txtTaskName.Text = model.TaskName;
            this.txtOldTaskName.Text = model.TaskName;
            this.chkIsSpiderUrl.Checked = model.IsSpiderUrl.ToString() == "1" ? true : false;
            this.chkIsSpiderContent.Checked = model.IsSpiderContent.ToString() == "1" ? true : false;
            this.chkIsPublishContent.Checked = model.IsPublishContent.ToString() == "1" ? true : false;
            ListItem item = new ListItem(model.PageEncode, model.PageEncode);
            this.ddlItemEncode.SelectedItem = item;
            if (!string.IsNullOrEmpty(model.CollectionContent)) {
                foreach (string str in model.CollectionContent.Split(new string[] { "$$$$" }, StringSplitOptions.RemoveEmptyEntries)) {
                    this.listBoxLinkUrl.Items.Add(str);
                }
            }
            this.txtLinkUrlMustIncludeStr.Text = model.LinkUrlMustIncludeStr;
            this.txtLinkUrlNoMustIncludeStr.Text = model.LinkUrlNoMustIncludeStr;
            this.txtLinkUrlCutAreaStart.Text = model.LinkUrlCutAreaStart;
            this.txtLinkUrlCutAreaEnd.Text = model.LinkUrlCutAreaEnd;
            this.txtTextViewUrl.Text = model.TestViewUrl;
            this.chkPublish01.Checked = model.IsWebOnlinePublish1.ToString() == "1" ? true : false;
            this.chkPublish02.Checked = model.IsSaveLocal2.ToString() == "1" ? true : false;
            this.ddlSaveFileFormat2.Text = model.SaveFileFormat2;
            this.txtSaveDirectory2.Text = model.SaveDirectory2;
            this.txtSaveHtmlTemplate2.Text = model.SaveHtmlTemplate2;
            this.chkPublish03.Checked = model.IsSaveDataBase3.ToString() == "1" ? true : false;
            string SaveDataType3 = model.SaveDataType3.ToString();
            switch (SaveDataType3) {
                case "1":
                    this.rbtnAccess.Checked = true;
                    break;
                case "2":
                    this.rbtnMsSql.Checked = true;
                    break;
                case "3":
                    this.rbtnSqlite.Checked = true;
                    break;
                case "4":
                    this.rbtnMySql.Checked = true;
                    break;
                case "5":
                    this.rbtnOracle.Checked = true;
                    break;
            }
            this.txtSaveDataUrl3.Text = model.SaveDataUrl3;
            this.txtSaveDataSQL3.Text = model.SaveDataSQL3;
            this.chkPublish04.Checked = model.IsSaveSQL4.ToString() == "1" ? true : false;

            this.cmbSpiderUrlPlugins.Text = model.PluginSpiderUrl;
            this.cmbSaveConentPlugins.Text = model.PluginSaveContent;
            this.cmbPublishContentPlugins.Text = model.PluginPublishContent;

            this.nudCollectionContentThreadCount.Value = model.CollectionContentThreadCount.Value;
            this.nudCollectionContentStepTime.Value = model.CollectionContentStepTime.Value;
            this.nudPublishContentThreadCount.Value = model.PublishContentThreadCount.Value;
            this.nudPublishContentStepTimeMin.Value = model.PublishContentStepTimeMin.Value;
            this.nudPublishContentStepTimeMax.Value = model.PublishContentStepTimeMax.Value;

            this.chkIsHandGetUrl.Checked = model.IsHandGetUrl.Value == 1 ? true : false;
            this.txtHandCollectionUrlRegex.Text = model.HandCollectionUrlRegex;

            this.txtDemoListUrl.Text = model.DemoListUrl;

            this.chkTaskSetStatus.Checked = model.IsPlan == 1 ? true : false;
            this.txtHiddenPlanFormat.Text = model.PlanFormat;

            this.cmbStatus.SelectedIndex = model.Status == 1 ? 0 : 1;

            this.chkIsSource.Checked = model.IsSource == 1 ? true : false;
            this.txtSourceText.Text = model.SourceText;
        }
        #endregion

        #region 创建任务
        private void btnSubmit_Click(object sender, EventArgs e) {
            DALTask dal = new DALTask();
            ModelTask model = new ModelTask();

            errorProvider.Clear();
            if (string.IsNullOrEmpty(this.cmbSiteClassID.Text)) {
                errorProvider.SetError(this.cmbSiteClassID, "所属站点不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtTaskName.Text)) {
                errorProvider.SetError(this.txtTaskName, "任务名称不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDemoListUrl.Text)) {
                errorProvider.SetError(this.txtDemoListUrl, "测试网站列表地址不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(this.ddlItemEncode.Text)) {
                errorProvider.SetError(this.ddlItemEncode, "网页编码不能为空!");
                return;
            }
            int ID = int.Parse(this.txtID.Text);
            int TaskClassID = int.Parse(this.cmbSiteClassID.SelectedValue.ToString());
            string TaskName = this.txtTaskName.Text;
            string OldTaskName = this.txtOldTaskName.Text;
            int IsSpiderUrl = this.chkIsSpiderUrl.Checked ? 1 : 0;
            int IsSpiderContent = this.chkIsSpiderContent.Checked ? 1 : 0;
            int IsPublishContent = this.chkIsPublishContent.Checked ? 1 : 0;
            string PageEncode = ((ListItem)this.ddlItemEncode.SelectedItem).Value;
            string CollectionContent = string.Empty;
            foreach (string str in listBoxLinkUrl.Items) {
                CollectionContent += str + "$$$$";
            }
            string LinkUrlMustIncludeStr = this.txtLinkUrlMustIncludeStr.Text;
            string LinkUrlNoMustIncludeStr = this.txtLinkUrlNoMustIncludeStr.Text;
            string LinkUrlCutAreaStart = this.txtLinkUrlCutAreaStart.Text.Replace("'", "''");
            string LinkUrlCutAreaEnd = this.txtLinkUrlCutAreaEnd.Text.Replace("'", "''");
            string TestViewUrl = this.txtTextViewUrl.Text;
            int IsWebOnlinePublish1 = this.chkPublish01.Checked ? 1 : 0;
            int IsSaveLocal2 = this.chkPublish02.Checked ? 1 : 0;
            string SaveFileFormat2 = this.ddlSaveFileFormat2.Text;
            string SaveDirectory2 = this.txtSaveDirectory2.Text;
            string SaveHtmlTemplate2 = this.txtSaveHtmlTemplate2.Text;
            int IsSaveDataBase3 = this.chkPublish03.Checked ? 1 : 0;
            int SaveDataType3 = 0;
            if (this.rbtnAccess.Checked) {
                SaveDataType3 = 1;
            }
            else if (this.rbtnMsSql.Checked) {
                SaveDataType3 = 2;
            }
            else if (this.rbtnSqlite.Checked) {
                SaveDataType3 = 3;
            }
            else if (this.rbtnMySql.Checked) {
                SaveDataType3 = 4;
            }
            else if (this.rbtnSqlite.Checked) {
                SaveDataType3 = 5;
            }
            string SaveDataUrl3 = this.txtSaveDataUrl3.Text;
            string SaveDataSQL3 = this.txtSaveDataSQL3.Text;
            int IsSaveSQL4 = this.chkPublish04.Checked ? 1 : 0;
            decimal CollectionContentThreadCount = this.nudCollectionContentThreadCount.Value;
            decimal CollectionContentStepTime = this.nudCollectionContentStepTime.Value;
            decimal PublishContentThreadCount = this.nudPublishContentThreadCount.Value;
            decimal PublishContentStepTimeMin = this.nudPublishContentStepTimeMin.Value;
            decimal PublishContentStepTimeMax = this.nudPublishContentStepTimeMax.Value;

            int IsHandGetUrl = this.chkIsHandGetUrl.Checked ? 1 : 0;
            string HandCollectionUrlRegex = this.txtHandCollectionUrlRegex.Text;
            int IsPlan = this.chkTaskSetStatus.Checked ? 1 : 0;
            string PlanFormat = this.txtHiddenPlanFormat.Text;
            model.ID = ID;
            model.TaskClassID = TaskClassID;
            model.TaskName = TaskName;
            model.IsSpiderUrl = IsSpiderUrl;
            model.IsSpiderContent = IsSpiderContent;
            model.IsPublishContent = IsPublishContent;
            model.PageEncode = PageEncode;
            model.CollectionContent = CollectionContent;
            model.LinkUrlMustIncludeStr = LinkUrlMustIncludeStr;
            model.LinkUrlNoMustIncludeStr = LinkUrlNoMustIncludeStr;
            model.LinkUrlCutAreaStart = LinkUrlCutAreaStart;
            model.LinkUrlCutAreaEnd = LinkUrlCutAreaEnd;
            model.TestViewUrl = TestViewUrl;
            model.IsWebOnlinePublish1 = IsWebOnlinePublish1;
            model.IsSaveLocal2 = IsSaveLocal2;
            model.SaveFileFormat2 = SaveFileFormat2;
            model.SaveDirectory2 = SaveDirectory2;
            model.SaveHtmlTemplate2 = SaveHtmlTemplate2;
            model.IsSaveDataBase3 = IsSaveDataBase3;
            model.SaveDataType3 = SaveDataType3;
            model.SaveDataUrl3 = SaveDataUrl3;
            model.SaveDataSQL3 = SaveDataSQL3;
            model.IsSaveSQL4 = IsSaveSQL4;
            model.PluginSpiderUrl = this.cmbSpiderUrlPlugins.Text;
            model.PluginSaveContent = this.cmbSaveConentPlugins.Text;
            model.PluginPublishContent = this.cmbPublishContentPlugins.Text;
            model.CollectionUrlStepTime = int.Parse(nudCollectionUrlStepTime.Value.ToString());
            model.CollectionContentThreadCount = Convert.ToInt32(CollectionContentThreadCount);
            model.CollectionContentStepTime = Convert.ToInt32(CollectionContentStepTime);
            model.PublishContentThreadCount = Convert.ToInt32(PublishContentThreadCount);
            model.PublishContentStepTimeMin = Convert.ToInt32(PublishContentStepTimeMin);
            model.PublishContentStepTimeMax = Convert.ToInt32(PublishContentStepTimeMax);

            model.IsHandGetUrl = IsHandGetUrl;
            model.HandCollectionUrlRegex = HandCollectionUrlRegex;

            model.DemoListUrl = this.txtDemoListUrl.Text;
            model.IsPlan = IsPlan;
            model.PlanFormat = PlanFormat;
            model.Status = this.cmbStatus.SelectedIndex == 0 ? 1 : 0;

            model.IsSource = this.chkIsSource.Checked ? 1 : 0;
            model.SourceText = this.txtSourceText.Text;


            if (ID == 0) {
                string guid = Guid.NewGuid().ToString();
                ID = dal.GetMaxId();
                model.ID = ID;
                model.Guid = guid;
                dal.Add(model);
                DALTaskLabel dalTaskLabel = new DALTaskLabel();
                dalTaskLabel.UpdateTaskLabelByTaskID(ID);
                if (TaskOpDelegate != null) {
                    TaskOpEv.TaskIndex = TaskIndex;
                    TaskOpDelegate(this, TaskOpEv);
                }
            }
            else if (ID > 0) {
                if (TaskName != OldTaskName) {
                    string RootPath = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\";
                    string OldTaskPath = RootPath + OldTaskName;
                    string NewTaskPath = RootPath + TaskName;
                    if (Directory.Exists(NewTaskPath)) {
                        MessageBox.Show("任务名称存在!请换个名称试试!");
                        return;
                    }
                    try {
                        Directory.Move(OldTaskPath, NewTaskPath);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("修改异常!" + ex.Message);
                        return;
                    }
                }
                if (!dal.CheckTaskGuid(ID)) {
                    model.Guid = Guid.NewGuid().ToString();
                }
                dal.Update(model);
                if (TaskOpDelegate != null) {
                    TaskOpEv.TaskIndex = TaskIndex;
                    TaskOpEv.OpType = 1;
                    TaskOpDelegate(this, TaskOpEv);
                }
            }
            CreateDataFile(TaskName, ID);

            #region 更新计划任务
            if (model.IsPlan == 1) {
                PlanTaskHelper.PushJobDetail(ID);
            }
            #endregion

            this.CloseForm();
        }
        #endregion

        #region 创建文件
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
                     [" + dr["LabelName"] + @"] varchar,";
                }
                if (createSQL.Trim() != "") {
                    createSQL = createSQL.Remove(createSQL.Length - 1);
                }
                string ss = string.Empty;
                if (!string.IsNullOrEmpty(createSQL)) {
                    ss = ",";
                }
                SQL = @"
                create table Content(
                    ID integer primary key autoincrement,
                    [HrefSource] varchar,
                    [已采] int,
                    [已发] int" + ss + @"
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
        #endregion

        #region 网站发布模块
        private void btnWebModuleAdd_Click(object sender, EventArgs e) {
            frmPublishEdit PublishEdit = new frmPublishEdit();
            PublishEdit.TaskID = this.ID;
            PublishEdit.ECEH = WebPublishModuleComplate;
            PublishEdit.Show(this);
        }

        private void btnWebModuleEdit_Click(object sender, EventArgs e) {
            frmPublishEdit PublishEdit = new frmPublishEdit();
            PublishEdit.ECEH = WebPublishModuleComplate;
            PublishEdit.TaskID = this.ID;
            PublishEdit.EditItem = this.listViewWebModule.SelectedItems;
            PublishEdit.Show(this);
        }

        private void WebPublishModuleComplate(int id, string msg) {
            Bind_WebPublishModule(" TaskID=" + this.ID + " ");
        }

        private void btnWebModuleDelete_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection item = this.listViewWebModule.SelectedItems;
            DALWebPublishModule dal = new DALWebPublishModule();
            dal.Delete(int.Parse("0" + item[0].Tag));
            Bind_WebPublishModule(" TaskID=" + this.ID + " ");
        }

        private void Bind_WebPublishModule(string strWhere) {
            this.listViewWebModule.Items.Clear();
            DALWebPublishModule dal = new DALWebPublishModule();
            DataTable dt = dal.GetList(strWhere).Tables[0];
            foreach (DataRow dr in dt.Rows) {
                ListViewItem li = new ListViewItem(dr["ModuleName"].ToString());
                li.SubItems.Add(dr["ClassID"].ToString());
                li.SubItems.Add(dr["ClassName"].ToString());
                li.Tag = dr["ID"].ToString();
                this.listViewWebModule.Items.Add(li);
            }
        }
        #endregion

        private void IsHandGetUrl_CheckedChanged(object sender, EventArgs e) {
            if (this.chkIsHandGetUrl.Checked) {
                this.txtHandCollectionUrlRegex.Enabled = true;
            }
            else {
                this.txtHandCollectionUrlRegex.Enabled = false;
            }
        }

        private void btnGetCookies_Click(object sender, EventArgs e) {
            try {
                Process process = new Process();
                process.StartInfo.FileName = AppNameHelper.WebBrowser;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.WaitForExit();
                var result = process.StandardOutput.ReadToEnd();
                this.txtCollectionCookies.Text = result;
                process.Close();
            }
            catch (Exception ex) {
                throw new Exception(AppNameHelper.WebBrowser + "::::" + ex.Message);
            }
        }

        private void btnTaskLabelCopy_Click(object sender, EventArgs e) {
            if (this.listViewTaskLabel.SelectedItems.Count > 0) {
                var sel = this.listViewTaskLabel.SelectedItems;
                if (sel != null && sel.Count > 0) {
                    ListView.SelectedListViewItemCollection item = this.listViewTaskLabel.SelectedItems;
                    int ID = int.Parse("0" + item[0].Tag.ToString());
                    DALTaskLabel dal = new DALTaskLabel();
                    dal.TaskLabelCopy(ID);
                    this.Bind_TaskLabel(" TaskID=" + this.ID);
                }
            }
            else {
                MessageBox.Show("请先选择标签再进行操作!", "警告!");
            }
        }

        private void btnDataBaseLabelTag_Click(object sender, EventArgs e) {
            Bind_contextMenuStrip_Label(contextMenuStrip_Label);
            this.contextMenuStrip_Label.Show(btnDataBaseLabelTag, 0, 21);
        }

        private void Bind_contextMenuStrip_Label(ContextMenuStrip cms) {
            cms.Items.Clear();
            cms.Items.Add("Guid");
            cms.Items.Add("Url");
            DALTaskLabel dal = new DALTaskLabel();
            DataTable dt = dal.GetList(" TaskID=" + this.ID + " Order by OrderID Asc").Tables[0];
            foreach (DataRow dr in dt.Rows) {
                cms.Items.Add(dr["LabelName"].ToString());
            }
        }

        private void btnDataBaseLabelTag4_Click(object sender, EventArgs e) {
            Bind_contextMenuStrip_Label(contextMenuStrip1);
        }

        private void listViewTaskLabel_DoubleClick(object sender, EventArgs e) {
            var sel = this.listViewTaskLabel.SelectedItems;
            if (sel != null && sel.Count == 1) {
                frmTaskSpiderLabel FormTaskSpiderLabel = new frmTaskSpiderLabel();
                FormTaskSpiderLabel.EditItem = this.listViewTaskLabel.SelectedItems;
                FormTaskSpiderLabel.ViewLabel = AddViewLabel;
                FormTaskSpiderLabel.TaskID = ID;
                FormTaskSpiderLabel.TestUrl = this.txtTextViewUrl.Text;
                FormTaskSpiderLabel.PageEncode = ((ListItem)this.ddlItemEncode.SelectedItem).Value;
                FormTaskSpiderLabel.ShowDialog(this);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            tabControlTaskEdit.SelectedTab = tabPage4;
        }

        private void listViewWebModule_DoubleClick(object sender, EventArgs e) {

        }

        #region 4.自定义Web发布地址

        private void btnDiyWebUrlAdd_Click(object sender, EventArgs e) {
            frmTaskDiyWebUrl FormDiyWebUrl = new frmTaskDiyWebUrl();
            FormDiyWebUrl.OnDataOperation += (object sender1, MainEvents.DataOperationArgs e1) => {
                Bind_DiyUrlWebList("And SelfId=" + this.ID);
            };
            FormDiyWebUrl.TaskId = this.ID;
            FormDiyWebUrl.ShowDialog(this);
        }

        private void btnDiyWebUrlEdit_Click(object sender, EventArgs e) {
            if (this.listView_DiyUrlWeb.SelectedItems.Count == 0) {
                return;
            }
            frmTaskDiyWebUrl FormDiyWebUrl = new frmTaskDiyWebUrl();
            FormDiyWebUrl.OnDataOperation += (object sender1, MainEvents.DataOperationArgs e1) => {
                Bind_DiyUrlWebList("And SelfId=" + this.ID);
            };
            FormDiyWebUrl.TaskId = this.ID;
            FormDiyWebUrl.EditItem = this.listView_DiyUrlWeb.SelectedItems[0].Tag;
            FormDiyWebUrl.ShowDialog(this);
        }

        private void btnDiyWebUrlDelete_Click(object sender, EventArgs e) {
            if (this.listView_DiyUrlWeb.SelectedItems.Count == 0) {
                return;
            }
            frmTaskDiyWebUrl FormDiyWebUrl = new frmTaskDiyWebUrl();
            FormDiyWebUrl.OnDataOperation += (object sender1, MainEvents.DataOperationArgs e1) => {
                Bind_DiyUrlWebList("And SelfId=" + this.ID);
            };
            FormDiyWebUrl.EditItem = this.listView_DiyUrlWeb.SelectedItems[0].Tag;
            FormDiyWebUrl.Delete();
        }

        private void Bind_DiyUrlWebList(string p) {
            this.listView_DiyUrlWeb.Items.Clear();
            var list = DALDiyWebUrlHelper.GetList(p, "", 0);
            foreach (var l in list) {
                ListViewItem li = new ListViewItem(l.Name);
                li.SubItems.Add(l.Url);
                li.Tag = l.Id;
                this.listView_DiyUrlWeb.Items.Add(li);
            }
        }
        #endregion

        private void btnTaskSet_Click(object sender, EventArgs e) {
            frmTaskPlanSet FormPlanSet = new frmTaskPlanSet();
            FormPlanSet.OnDataOperation += (object sender1, MainEvents.DataOperationArgs e1) => {
                if (e1.Operation == MainEvents.OperationEnum.Edit) {
                    this.txtHiddenPlanFormat.Text = e1.ReturnObj as string;
                }
            };
            FormPlanSet.ShowDialog(this);
        }

        private void chkIsSource_CheckedChanged(object sender, EventArgs e) {
            if (this.chkIsSource.Checked) {
                this.panel_List1.Visible = false;
                this.panel_List2.Visible = true;
            }
            else {
                this.panel_List1.Visible = true;
                this.panel_List2.Visible = false;
            }
        }

        private void linkSpiderListPlugin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var item = this.cmbSpiderUrlPlugins.SelectedItem as string;

            if (item != "不使用插件") {
                var list = new List<string>();
                list.Add(this.txtDemoListUrl.Text);
                var form = new frmEditor();
                form.PythonFilePath = PluginUtility.SpiderUrlPluginPath + item;
                form.PythonInputParam = list.ToArray();
                form.Show(this);
            }
        }
    }
}
