using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_DataPublish._Class;
using V5_Utility.Core;
using V5_DataPublish.Forms.Desk;
using System.Web.UI.WebControls;
using V5_Utility.Utility;
using V5_WinLibs.Utility;
using V5_WinLibs.Core;

namespace V5_DataPublish.Forms.DiyWeb {
    public partial class frmHandWebInsert : Form {

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        string _Content = string.Empty;
        /// <summary>
        /// 内容
        /// </summary>
        public string Content {
            get { return _Content; }
            set { _Content = value; }
        }



        public frmHandWebInsert() {
            InitializeComponent();

            this.fckHtmlEditorControl1.OnEditorInitialized += fckHtmlEditorControl1_OnEditorInitialized;
        }

        void fckHtmlEditorControl1_OnEditorInitialized(object sender, EventArgs e) {
            this.fckHtmlEditorControl1.InnerHtml = this.Content;
        }

        /// <summary>
        /// 加载站点信息
        /// </summary>
        private void Bind_LoadSiteInfo() {
            List<ModelSiteInfo> listSiteInfo = new List<ModelSiteInfo>();
            var path = AppDomain.CurrentDomain.BaseDirectory + "\\Config";
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
                return;
            }
            path += "\\SiteInfo.json";

            var f = File.OpenText(path);
            var content = f.ReadToEnd();
            var json = JObject.Parse(content);
            var list = json["list"].ToArray();
            foreach (var site in list) {
                ModelSiteInfo model = new ModelSiteInfo() {
                    UserName = site["username"].Value<string>(),
                    UserPwd = site["userpwd"].Value<string>(),
                    Title = site["title"].Value<string>(),
                    Url = site["url"].Value<string>(),
                    Encode = site["encode"].Value<string>(),
                    Plugin = site["plugin"].Value<string>()
                };
                listSiteInfo.Add(model);
            }
            this.cmbWebSite.Items.Add(new ListItem2(null, "请选择一个站点"));
            foreach (var l in listSiteInfo) {
                this.cmbWebSite.Items.Add(new ListItem2(l, l.Title));
            }
            this.cmbWebSite.SelectedIndex = 0;
        }

        /// <summary>
        /// 窗体加载时
        /// </summary>
        private void frmHandWebInsert_Load(object sender, EventArgs e) {
            this.txtTitle.Text = this.Title;
            this.fckHtmlEditorControl1.InnerHtml = this.Content;
            Bind_LoadSiteInfo();
        }

        /// <summary>
        /// 确定发布数据
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e) {
            var model = (ModelSiteInfo)((ListItem2)this.cmbWebSite.SelectedItem).Value;
            if (model == null) {
                MessageBox.Show("请选择一个网站!");
                this.cmbWebSite.Focus();
                return;
            }

            if (this.cmbClassList.Text == string.Empty) {
                MessageBox.Show("请选择一个分类!");
                this.cmbClassList.Focus();
                return;
            }

            var title = this.txtTitle.Text;
            var content = this.fckHtmlEditorControl1.InnerHtml;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content)) {
                MessageBox.Show("标题或者内容为空!");
                this.txtTitle.Focus();
                return;
            }

            var selectedItem = (ListItem)this.cmbClassList.SelectedItem;
            var classid = selectedItem.Value;
            var classname = selectedItem.Text;
            if (classid == string.Empty || classid == "0") {
                MessageBox.Show("请选择一个分类!");
                this.cmbClassList.Focus();
                return;
            }
            var th = new ThreadMultiHelper(1);
            th.WorkMethod += new ThreadMultiHelper.DelegateWork(delegate(int taskindex, int threadindex) {
                string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string baseData = "cmd=sendcontent"
                    + "&username=" + model.UserName
                    + "&userpwd=" + model.UserPwd
                    + "&title=" + StringHelper.Instance.UrlEncode(title, model.Encode)
                    + "&content=" + StringHelper.Instance.UrlEncode(content, model.Encode)
                    + "&classid=" + classid
                    + "&classtitle=" + StringHelper.Instance.UrlEncode(classname, model.Encode)
                    + "&author=" + string.Empty
                    + "&time=" + nowTime;
                string md5key = "&md5key=" + StringHelper.Instance.MD5(baseData, 32).ToLower();
                string sendUrl = model.Url;
                string sendData = baseData + md5key;
                HttpHelper4 http = new HttpHelper4();
                var result = http.GetHtml(new HttpItem() {
                    URL = sendUrl,
                    Method = "post",
                    Postdata = sendData,
                    ContentType = "application/x-www-form-urlencoded",
                    Encoding = Encoding.GetEncoding(model.Encode)
                });
                var html = result.Html;
                this.lblResult.Text = "操作结果成功!结果为:" + html;

                try {
                    var json = JObject.Parse(html);
                    var code = json["code"].Value<string>();
                    this.lblResult.Text = "操作结果成功!结果为:" + code;
                }
                catch (Exception ex) {
                }

            });
            th.CompleteEvent += new ThreadMultiHelper.DelegateComplete(delegate() {
                var r = MessageBox.Show(this, "发布内容成功!", "提示信息!", MessageBoxButtons.OKCancel);
                if (r == System.Windows.Forms.DialogResult.OK) {
                    this.Close();
                    this.Dispose();
                }
            });
            th.Start();
        }

        public delegate void OutCmbMsg(List<ModelClassList> list);

        public OutCmbMsg OutMsg;

        public class ModelClassList {
            public string ClassId { get; set; }
            public string ClassName { get; set; }
            public string CreateTime { get; set; }
        }

        /// <summary>
        /// 获取站点信息
        /// </summary>
        private void cmbWebSite_SelectedIndexChanged(object sender, EventArgs e) {

            var model = (ModelSiteInfo)((ListItem2)this.cmbWebSite.SelectedItem).Value;
            if (model == null) {
                return;
            }
            this.btnSubmit.Enabled = false;

            this.cmbClassList.Text = string.Empty;
            this.cmbClassList.Items.Clear();

            var th = new ThreadMultiHelper(1);
            th.WorkMethod += new ThreadMultiHelper.DelegateWork(delegate(int taskindex, int threadindex) {
                string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string baseData = "cmd=getclasslist"
                    + "&username=" + model.UserName
                    + "&userpwd=" + model.UserPwd
                    + "&time=" + nowTime;
                string md5key = "&md5key=" + StringHelper.Instance.MD5(baseData, 32).ToLower();
                string senUrl = model.Url;
                string sendData = baseData + md5key;
                HttpHelper4 http = new HttpHelper4();
                var result = http.GetHtml(new HttpItem() {
                    URL = senUrl + "?" + sendData
                });
                var html = result.Html;
                try {
                    var json = JObject.Parse(html);
                    var code = json["code"].Value<string>();
                    var list = json["list"].ToArray();

                    this.lblResult.Text = "操作结果成功!结果为:" + code;

                    List<ModelClassList> listClassList = new List<ModelClassList>();
                    this.cmbClassList.Items.Clear();
                    foreach (var l in list) {
                        listClassList.Add(
                             new ModelClassList() {
                                 ClassId = l["classid"].Value<string>(),
                                 ClassName = l["classname"].Value<string>(),
                                 CreateTime = ""
                             }
                            );
                    }
                    OutMsg = new OutCmbMsg(OutClassListMsg);
                    OutMsg(listClassList);
                }
                catch (Exception ex) {
                }
            });
            th.CompleteEvent += new ThreadMultiHelper.DelegateComplete(delegate() {
                this.btnSubmit.Enabled = true;
            });
            th.Start();
        }

        private void OutClassListMsg(List<ModelClassList> list) {
            if (this.cmbClassList.InvokeRequired) {
                this.cmbClassList.Invoke(new MethodInvoker(() => {
                    foreach (var l in list) {
                        this.cmbClassList.Items.Add(new ListItem(
                            l.ClassId,
                            l.ClassName
                            ));
                    }
                    this.cmbClassList.SelectedIndex = 0;
                }));
            }
            else {
                foreach (var l in list) {
                    this.cmbClassList.Items.Add(new ListItem(
                        l.ClassId,
                        l.ClassName
                        ));
                }
                this.cmbClassList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 自定义发布数据
        /// </summary>
        private void btnAutoCreateArticle_Click(object sender, EventArgs e) {
            frmAutoCreateArticle FormAutoCreateArticle = new frmAutoCreateArticle();
            FormAutoCreateArticle.ShowDialog(this);
        }
    }
}
