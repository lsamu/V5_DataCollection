using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using V5_Model;
using System.Xml.Serialization;
using V5_DataCollection.Forms.Tools;
using V5_DataCollection._Class.DAL;
using V5_WinLibs.Core;
using System.Diagnostics;
using V5_DataCollection._Class.Common;

namespace V5_DataCollection.Forms.Publish {
    public partial class frmPublishEdit : BaseForm {

        public delegate void EditComplateEventHandler(int ipID, string msg);
        public EditComplateEventHandler ECEH;
        string modulePath = AppDomain.CurrentDomain.BaseDirectory + "/Modules/";
        private object _EditItem = null;

        public object EditItem {
            get { return _EditItem; }
            set { _EditItem = value; }
        }

        private int _TaskID = 0;
        /// <summary>
        /// 任务ID
        /// </summary>
        public int TaskID {
            get { return _TaskID; }
            set { _TaskID = value; }
        }

        public frmPublishEdit() {
            InitializeComponent();
        }

        private void Bind_ModuleList() {
            try {
                this.listBoxPublishModule.Items.Clear();
                DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/Modules/");
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo fi in files) {
                    this.listBoxPublishModule.Items.Add(fi.Name);
                }
            }
            catch {
            }
        }

        private void frmPublishEdit_Load(object sender, EventArgs e) {
            Bind_ModuleList();
            if (EditItem != null) {
                this.Bind_DataEdit();
            }
        }

        private void Bind_DataEdit() {
            ListView.SelectedListViewItemCollection item = (ListView.SelectedListViewItemCollection)EditItem;
            DALWebPublishModule dal = new DALWebPublishModule();
            int ID = Int32.Parse("0" + item[0].Tag);
            ModelWebPublishModule model = dal.GetModel(ID);
            this.txtID.Text = model.ID.ToString();
            this.TaskID = int.Parse("0" + model.TaskID.ToString());
            this.txtWebPublishName.Text = model.ModuleName;
            this.txtWebPublishUrl.Text = model.SiteUrl;
            this.chkCookies.Checked = model.IsCookiesLogin.ToString() == "1" ? true : false;
            this.txtWebPublishCookies.Text = model.CookiesValue;
            this.txtClassID.Text = model.ClassID.ToString();
            this.txtClassName.Text = model.ClassName;
            this.txtWebPublishUserName.Text = model.LoginUserName;
            this.txtWebPublishPassWord.Text = model.LoginUserPwd;
            this.listBoxPublishModule.SelectedItem = model.ModuleNameFile;
        }

        private void btnGetClass_Click(object sender, EventArgs e) {
            SiteUrl = this.txtWebPublishUrl.Text;
            object item = this.listBoxPublishModule.SelectedItem;
            modelLogin = GetModelXml((string)item);

            if (this.chkCookies.Checked) {
                LoginedCookies = this.txtWebPublishCookies.Text;
                GetClassList();
            }
            else {
                if (!string.IsNullOrEmpty(modelLogin.LoginVerCodeUrl)) {
                    //打开登录窗口登录
                    //frmLoginVerCode LoginVerCode = new frmLoginVerCode();
                    //LoginVerCode.LoginVerCodeUrl = SiteUrl + modelLogin.LoginVerCodeUrl;
                    //LoginVerCode.OutVerCode = OutVerCode;
                    //LoginVerCode.OutCookie = OutCookie;
                    //LoginVerCode.Show(this);
                }
            }
        }
        private string LoginedCookies = string.Empty, LoginPostData = string.Empty;//
        cPublishModuleItem modelLogin;
        private string SiteUrl = string.Empty;
        private void combClassList_SelectedIndexChanged(object sender, EventArgs e) {
            string item = (string)this.combClassList.SelectedItem;
            this.txtClassID.Text = item;
        }

        private void OutCookie(string cookie) {
            LoginedCookies = cookie;
        }

        private void OutVerCode(string verCode, string username, string userpwd) {
            LoginPostData = modelLogin.LoginPostData;
            LoginPostData = LoginPostData.Replace("【验证码】", verCode);
            LoginPostData = LoginPostData.Replace("【用户名】", username);
            LoginPostData = LoginPostData.Replace("【密码】", userpwd);
            LoginCMS();
        }

        private void LoginCMS() {
            try {
                string result = SimulationHelper.PostLogin(SiteUrl + modelLogin.LoginUrl,
                    LoginPostData,
                    SiteUrl + modelLogin.LoginRefUrl,
                    modelLogin.PageEncode,
                    ref LoginedCookies);
                foreach (string str in modelLogin.LoginErrorResult.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)) {
                    if (result.IndexOf(str) > -1) {
                        this.txtLogView.Clear();
                        this.txtLogView.AppendText("登录失败!值为:" + str);
                        return;
                    }
                }
                if (modelLogin.LoginSuccessResult.Trim() != "") {
                    if (result.IndexOf(modelLogin.LoginSuccessResult) > -1) {
                        GetClassList();
                    }
                    else {
                        this.txtLogView.Clear();
                        this.txtLogView.AppendText("登录失败!没找到成功的值为:" + modelLogin.LoginSuccessResult);
                    }
                }
                else {
                    GetClassList();
                }
            }
            catch (Exception ex) {
                this.txtLogView.Clear();
                this.txtLogView.AppendText(ex.Message);
            }
        }

        private void GetClassList() {

            LoginPostData = "";
            string result = SimulationHelper.PostPage(SiteUrl + modelLogin.ListUrl,
                "",
                SiteUrl + modelLogin.ListRefUrl,
                modelLogin.PageEncode,
                ref LoginedCookies);
            string ClassListRegex = modelLogin.ListClassIDRegex.Replace("[参数1]", "(.*?)");
            string[] aa = CollectionHelper.Instance.CutStr(result, ClassListRegex);
            this.txtLogView.Clear();
            foreach (string str in aa) {
                this.combClassList.Items.Add(str);
            }
        }

        public cPublishModuleItem GetModelXml(string pathName) {
            cPublishModuleItem model = new cPublishModuleItem();
            XmlSerializer serializer = new XmlSerializer(typeof(cPublishModuleItem));
            try {
                string fileName = modulePath + pathName;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                model = (cPublishModuleItem)serializer.Deserialize(fs);
                fs.Close();
            }
            catch {

            }
            return model;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            int ID = Int32.Parse("0" + this.txtID.Text);
            int TaskID = this.TaskID;
            string ModuleName = this.txtWebPublishName.Text;
            string SiteUrl = this.txtWebPublishUrl.Text;
            int IsCookiesLogin = this.chkCookies.Checked ? 1 : 0;
            string CookiesValue = this.txtWebPublishCookies.Text;
            int ClassID = int.Parse(this.txtClassID.Text);
            string ClassName = this.txtClassName.Text;
            string LoginUserName = this.txtWebPublishUserName.Text;
            string LoginUserPwd = this.txtWebPublishPassWord.Text;
            string ModuleNameFile = (string)this.listBoxPublishModule.SelectedItem;
            string CreateTime = DateTime.Now.ToString();
            DALWebPublishModule dal = new DALWebPublishModule();
            ModelWebPublishModule model = new ModelWebPublishModule();
            model.ID = ID;
            model.TaskID = TaskID;
            model.ModuleName = ModuleName;
            model.SiteUrl = SiteUrl;
            model.IsCookiesLogin = IsCookiesLogin;
            model.CookiesValue = CookiesValue;
            model.ClassID = ClassID;
            model.ClassName = ClassName;
            model.LoginUserName = LoginUserName;
            model.LoginUserPwd = LoginUserPwd;
            model.ModuleNameFile = ModuleNameFile;
            model.CreateTime = CreateTime;

            if (ID == 0) {
                ID = dal.Add(model);
            }
            else if (ID > 0) {
                dal.Update(model);
            }
            if (ECEH != null) {
                ECEH(ID, "操作成功!");
            }
            this.Hide();
            this.Close();
        }

        private void EditEH(string msg) {
            Bind_ModuleList();
        }

        private void btnTestWebPublish_Click(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void GetCookies(string val) {
            this.txtWebPublishCookies.Text = val;
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
                this.txtWebPublishCookies.Text = result;
                process.Close();
            }
            catch (Exception ex) {
                throw new Exception(AppNameHelper.WebBrowser + "::::" + ex.Message);
            }
        }

        private void btnModuleDelete_Click(object sender, EventArgs e) {

        }
    }
}
