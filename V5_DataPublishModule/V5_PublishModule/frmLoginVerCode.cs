using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_Utility.Core;
using V5_Utility.Utility;

namespace V5_PublishModule {
    public partial class frmLoginVerCode : Form {
        public delegate void OutVerCodeHandler(string VerCode, string userName, string userPwd);
        public OutVerCodeHandler OutVerCode;
        public delegate void OutCookieHandler(string Cookie);
        public OutCookieHandler OutCookie;

        private string _LoginVerCodeUrl = string.Empty;

        public string LoginVerCodeUrl {
            get { return _LoginVerCodeUrl; }
            set { _LoginVerCodeUrl = value; }
        }
        public frmLoginVerCode() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (OutVerCode != null) {
                OutVerCode(this.txtLoginVerCode.Text, this.txtLoginUserName.Text, this.txtLoginPassWord.Text);
            }
            this.Close();
            this.Dispose();
        }
        ThreadMultiHelper th = new ThreadMultiHelper(1);
        private void frmLoginVerCode_Load(object sender, EventArgs e) {
            th.WorkMethod += new ThreadMultiHelper.DelegateWork(work);
            th.Start();
        }

        private void work(int index, int sfsdf) {
            string cookies = string.Empty, cookies1 = string.Empty;
            this.pbVerCode.Image = SimulationHelper.PostImage(LoginVerCodeUrl, ref cookies);
            if (OutCookie != null) {
                OutCookie(cookies);
            }
            th.Stop();
        }
    }
}
