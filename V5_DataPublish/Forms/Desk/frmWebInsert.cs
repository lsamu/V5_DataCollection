using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using V5_DataPublish._Class;
using V5_DAL;
using V5_DataPublish._Class.Publish;
using V5_DataPlugins;
using V5_Utility.Core;
using V5_Utility;
using V5_DataPublish._Class.Model;
using System.Xml.Serialization;
using V5_DataPublish._Class.BLL;
using V5_Utility.Utility;
using System.Web.UI.WebControls;

namespace V5_DataPublish.Forms.Desk {
    public partial class frmWebInsert : Form {

        #region 访问器
        public string Title { get; set; }
        public string Content { get; set; }
        #endregion

        private bool IsHtml = false;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="isHtml"></param>
        public frmWebInsert(bool isHtml) {
            InitializeComponent();
            IsHtml = isHtml;
            if (this.IsHtml) {
                //过滤标签  保留图片标签,视频标签,pdf标签,word标签
            }
        }
        /// <summary>
        /// 发布信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(this.txtTitle.Text)) {
                this.lblResult.Text = "文章标题不能为空!";
                return;
            }
            if (string.IsNullOrEmpty(this.Content)) {
                this.lblResult.Text = "文章内容不能为空!";
                return;
            }
            if (!this.backgroundWorker_Send.IsBusy) {
                this.backgroundWorker_Send.RunWorkerAsync();
            }
        }
        /// <summary>
        /// 发布信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_Send_DoWork(object sender, DoWorkEventArgs e) {
            try {
                this.btnSave.Invoke(new MethodInvoker(delegate() {
                    this.Save_CheckBoxList();
                    int num = 0;
                    for (int i = 0; i < checkedListBox_WebSiteClassList.Items.Count; i++) {
                        if (checkedListBox_WebSiteClassList.GetItemChecked(i)) {
                            num++;
                            ModelWebSiteChecked model = (ModelWebSiteChecked)this.checkedListBox_WebSiteClassList.Items[0];
                            string[] ArrValue = model.Value.Split(new string[] { "→" }, StringSplitOptions.None);
                            WebSiteHelper ModelSite =Common.GetList<WebSiteHelper>(p=>p.Uuid==ArrValue[1]).SingleOrDefault();
                            string[] ArrClassName = model.Name.Split(new string[] { "→" }, StringSplitOptions.None);

                            ListItem LiClassList = new ListItem(ArrValue[2], ArrClassName[2]);
                            PublishTask PublishTask = new PublishTask();
                            PublishTask.PublishOP = PublishOP;
                            PublishTask.CommonSendContent(ModelSite, this.Title, this.Content, LiClassList.Text, LiClassList.Value);
                        }
                    }
                    if (num == 0) {
                        if (MessageBox.Show("你没有选择一个选择保存文章!确定要这样!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK) {
                            this.Close();
                            this.Dispose();
                        }
                    }
                    else {
                        this.Close();
                        this.Dispose();
                    }
                }));
            }
            catch (Exception ex) {
                MessageBox.Show("文章发布出错!" + ex.Message + ex.InnerException + ex.StackTrace + ex.Source,
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log4Helper.Write(LogLevel.Error, ex);
            }
        }
        /// <summary>
        /// 取消发布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWebInsert_Load(object sender, EventArgs e) {
            this.txtTitle.Text = this.Title;
            this.lblResult.Text = string.Empty;
            BLLDeskTopPublish bll = new BLLDeskTopPublish();
            List<ModelWebSiteChecked> list = new List<ModelWebSiteChecked>();
            list = bll.GetXmlConfig();
            Bind_WebSiteList(list);
        }

        /// <summary>
        /// 绑定需要发布的站点分类
        /// </summary>
        /// <param name="list"></param>
        private void Bind_WebSiteList(List<ModelWebSiteChecked> list) {
            foreach (ModelWebSiteChecked model in list) {
                this.checkedListBox_WebSiteClassList.Items.Add(new ModelWebSiteChecked() {
                    Name = model.Name,
                    IsChecked = model.IsChecked,
                    Value = model.Value
                }, model.IsChecked ? true : false
             );
            }
            this.checkedListBox_WebSiteClassList.DisplayMember = "Name";
            this.checkedListBox_WebSiteClassList.ValueMember = "CheckedValue";
        }
        /// <summary>
        /// 编辑内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditContent_Click(object sender, EventArgs e) {
            frmPageContentEdit formContentEdit = new frmPageContentEdit();
            formContentEdit.Title = this.txtTitle.Text;
            formContentEdit.Content = this.Content;
            formContentEdit.rcEH = ReturnContent;
            formContentEdit.ShowDialog(this);
        }
        /// <summary>
        /// 编辑内容委托
        /// </summary>
        /// <param name="strTitle"></param>
        /// <param name="strContent"></param>
        private void ReturnContent(string strTitle, string strContent) {
            this.txtTitle.Text = strTitle;
            this.Title = strTitle;
            this.Content = strContent;
        }
        /// <summary>
        /// 打开站群选择站点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectWebSite_Click(object sender, EventArgs e) {
            frmSelectGroupSite formSelectGroupSite = new frmSelectGroupSite();
            formSelectGroupSite.OutModel = OutModel;
            formSelectGroupSite.Show(this);
        }
        /// <summary>
        /// 打开站群选择站点委托
        /// </summary>
        /// <param name="strMsg"></param>
        private void OutModel(string strMsg, string Text, string Value) {
            List<ModelWebSiteChecked> list = new List<ModelWebSiteChecked>();
            list.Add(new ModelWebSiteChecked() {
                Name = Text,
                IsChecked = true,
                Value = Value
            });
            Bind_WebSiteList(list);
        }
        /// <summary>
        /// 发布站点信息委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="MeOutPut"></param>
        private void PublishOP(object sender, MainEvents.OutPutWindowEventArgs MeOutPut) {
            MessageBox.Show(MeOutPut.Message);
        }



        private void btnDelSelected_Click(object sender, EventArgs e) {
            int chk = this.checkedListBox_WebSiteClassList.SelectedIndex;
            this.checkedListBox_WebSiteClassList.Items.RemoveAt(chk);
        }

        private void Save_CheckBoxList() {
            BLLDeskTopPublish bll = new BLLDeskTopPublish();
            List<ModelWebSiteChecked> list = new List<ModelWebSiteChecked>();
            for (int i = 0; i < checkedListBox_WebSiteClassList.Items.Count; i++) {
                bool IsChecked = false;
                if (checkedListBox_WebSiteClassList.GetItemChecked(i)) {
                    IsChecked = true;
                }
                ModelWebSiteChecked model = (ModelWebSiteChecked)checkedListBox_WebSiteClassList.Items[i];
                list.Add(new ModelWebSiteChecked() {
                    Name = model.Name,
                    IsChecked = IsChecked,
                    Value = model.Value
                });
            }
            bll.SaveXmlConfig(list);
        }

    }
}
