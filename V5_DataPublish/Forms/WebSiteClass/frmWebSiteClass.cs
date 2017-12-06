using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using V5_DataPublish._Class;
using V5_Utility;
using V5_DAL;
using V5_Utility.Core;
using System.Linq;

namespace V5_DataPublish.Forms.WebSiteClass {
    public partial class frmWebSiteClass : BaseForm {

        public delegate void OptionOk(object sender, string message, Common.Option o);
        public OptionOk OO;

        public string OldValue { get; set; }
        public frmWebSiteClass() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            string Uuid = this.txtHideValue.Text;
            string ClassName = this.txtWebSiteClassName.Text;
            string ReadMe = this.txtReadMe.Text;
            if (string.IsNullOrEmpty(Uuid)) {
                var model = new ModelTreeClass() {
                    Uuid = Guid.NewGuid().ToString(),
                    ClassID = 0,
                    ClassName = ClassName,
                    ReadMe = ReadMe,
                    ParentID = 0,
                    AddDateTime = DateTime.Now.ToString(),
                    UpdateTime = DateTime.Now.ToString()
                };
                Common.Update<ModelTreeClass>(model);
                if (OO != null) {
                    OO(this, "添加成功!", Common.Option.add);
                }
            }
            else {
                var model = Common.GetList<ModelTreeClass>(p => p.Uuid == Uuid).SingleOrDefault();
                model.ClassID = 0;
                model.ClassName = ClassName;
                model.ReadMe = ReadMe;
                model.ParentID = 0;
                model.AddDateTime = DateTime.Now.ToString();
                model.UpdateTime = DateTime.Now.ToString();
                Common.Update<ModelTreeClass>(model);
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

        private void frmWebSiteClass_Load(object sender, EventArgs e) {
            this.txtHideValue.Text = this.OldValue;
            if (!string.IsNullOrEmpty(this.OldValue)) {
                var model = Common.GetList<ModelTreeClass>(p => p.Uuid == this.OldValue).SingleOrDefault();
                this.txtWebSiteClassName.Text = model.ClassName;
                this.txtReadMe.Text = model.ReadMe;
            }
        }
    }
}
