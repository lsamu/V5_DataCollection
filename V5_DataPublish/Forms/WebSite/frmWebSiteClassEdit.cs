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
using V5_Utility.Core;
using V5_WinLibs.Core;

namespace V5_DataPublish.Forms.WebSite {
    public partial class frmWebSiteClassEdit : V5_DataPublish.BaseForm {

        public delegate void OptionOk(object sender, string message, Common.Option o);
        public OptionOk OO;

        public string OldValue { get; set; }

        public frmWebSiteClassEdit() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(this.txtKeywordList.Text)) {
                MessageBox.Show("关键词列表不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DALWebSiteClassList model = new DALWebSiteClassList();
            int ID = StringHelper.Instance.SetNumber(this.txtID.Text);
            string KeywordList = this.txtKeywordList.Text;

            model.ID = ID;
            model.KeywordList = KeywordList;
            if (ID == 0) {
                model.Add();
                if (OO != null) {
                    OO(this, "添加成功!", Common.Option.add);
                }
            }
            else if (ID > 0) {
                model.Update();
                if (OO != null) {
                    OO(this, "修改成功!", Common.Option.edit);
                }
            }
            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        private void frmWebSiteClassEdit_Load(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(this.OldValue)
                && this.OldValue != "0") {
                DALWebSiteClassList model = new DALWebSiteClassList().GetModel(StringHelper.Instance.SetNumber(
                    this.OldValue
                    ));
                if (model != null) {
                    this.txtID.Text = model.ID.ToString();
                    this.txtClassName.Text = model.ClassName;
                    this.txtKeywordList.Text = model.KeywordList;
                }
            }
        }


    }
}
