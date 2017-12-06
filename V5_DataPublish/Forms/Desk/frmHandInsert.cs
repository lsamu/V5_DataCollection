using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using V5_DAL;
using V5_DataPlugins;
using V5_Utility;
using V5_DataPublish._Class;
using V5_Utility.Utility;
using V5_DataPublish._Class.BLL;
using V5_DataPublish._Class.Model;

namespace V5_DataPublish.Forms.Desk {
    public partial class frmHandInsert : Form {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        public frmHandInsert() {
            InitializeComponent();
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e) {
            this.Invoke(new MethodInvoker(delegate() {
                this.lblProcess.Text = "请稍后...文章正在发布中...";

                this.Save_CheckBoxList();

                if (string.IsNullOrEmpty(this.txtTitle.Text)) {
                    MessageBox.Show(this, "文章标题不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!this.backgroundWorker.IsBusy) {
                    this.backgroundWorker.RunWorkerAsync();
                }

            }));
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            this.Invoke(new MethodInvoker(delegate() {
                try {
                    Title = this.txtTitle.Text;
                    ModelGatherItem m_GatherItem = new ModelGatherItem();
                    m_GatherItem.Title = Title;
                    m_GatherItem.Content = Content;
                    m_GatherItem.CreateTime = DateTime.Now.ToString();
                }
                catch (Exception ex) {
                    MessageBox.Show(this, "文章发布出错!" + ex.Message + ex.InnerException + ex.StackTrace + ex.Source,
                        "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Log4Helper.Write(LogLevel.Error, ex);
                }
            }));
        }
        /// <summary>
        /// 发送完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.lblProcess.Text = "发布完成!";
        }
        /// <summary>
        /// 窗体加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHandInsert_Load(object sender, EventArgs e) {

            this.txtTitle.Text = this.Title;
            BLLDeskTopPublish bll = new BLLDeskTopPublish();
            List<ModelWebSiteChecked> list = new List<ModelWebSiteChecked>();
            list = bll.GetXmlConfig();
            Bind_WebSiteList(list);
        }
        /// <summary>
        /// 取消窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// 自动生成文章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoCreateArticle_Click(object sender, EventArgs e) {
            frmAutoCreateArticle FormAutoCreateArticle = new frmAutoCreateArticle();
            FormAutoCreateArticle.ShowDialog(this);
        }
        /// <summary>
        /// 选择一个站点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectWebSite_Click(object sender, EventArgs e) {
            frmSelectGroupSite formSelectGroupSite = new frmSelectGroupSite();
            formSelectGroupSite.OutModel = OutModel;
            formSelectGroupSite.Show(this);
        }
        /// <summary>
        /// 选择站点输出委托
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
        /// 发布操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="MeOutPut"></param>
        private void PublishOP(object sender, MainEvents.OutPutWindowEventArgs MeOutPut) {
            MessageBox.Show(MeOutPut.Message);
        }

        /// <summary>
        /// 绑定需要发布的站点分类
        /// </summary>
        /// <param name="list"></param>
        private void Bind_WebSiteList(List<ModelWebSiteChecked> list) {

        }

        private void Save_CheckBoxList() {

        }
    }
}
