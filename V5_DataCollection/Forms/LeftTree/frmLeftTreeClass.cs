using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_DataCollection._Class.Common;
using V5_Model;
using V5_DataCollection._Class.DAL;
using V5_WinLibs.Core;

namespace V5_DataCollection.Forms.LeftTree {
    /// <summary>
    /// 任务树分类编辑窗体
    /// </summary>
    public partial class frmLeftTreeClass : BaseForm {

        public delegate void OutOpMessage(string opType, string Message);

        public OutOpMessage OutOpMsg;

        private string _EditValue = string.Empty;
        /// <summary>
        /// 操作结果对象
        /// </summary>
        public string EditValue {
            get { return _EditValue; }
            set { _EditValue = value; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public frmLeftTreeClass() {
            InitializeComponent();
        }

        /// <summary>
        /// 操作点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e) {

            errorProvider.Clear();
            if (string.IsNullOrEmpty(this.txtTreeClassName.Text)) {
                errorProvider.SetError(this.txtTreeClassName, "分类不能为空!");
                return;
            }

            int ClassID = StringHelper.Instance.SetNumber(this.txtEditID.Text);
            string TreeClassName = this.txtTreeClassName.Text;
            string TreeClassReadMe = this.txtTreeClassReadMe.Text;

            string opType = string.Empty;
            string Msg = string.Empty;
            DALTaskClass dal = new DALTaskClass();
            ModelTaskClass model = new ModelTaskClass();
            model.ClassID = ClassID;
            model.TreeClassName = TreeClassName;
            model.TreeClassReadMe = TreeClassReadMe;
            if (ClassID == 0) {
                opType = "add";
                Msg = "分类添加成功!";
                dal.Insert(model);
            }
            else if (ClassID > 0) {
                opType = "edit";
                Msg = "分类编辑成功!";
                dal.Update(model);
            }
            if (OutOpMsg != null) {
                OutOpMsg(opType, Msg);
            }
            this.Hide();
            this.Close();
        }

        /// <summary>
        /// 操作取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        /// <summary>
        /// 分类加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeftTreeClass_Load(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(this.EditValue)) {
                this.Text = "任务分类编辑";
                this.txtEditID.Text = this.EditValue;
                DALTaskClass dal = new DALTaskClass();
                DataTable dt = dal.GetList(" ClassID=" + this.EditValue).Tables[0];
                this.txtTreeClassName.Text = dt.Rows[0]["TreeClassName"].ToString();
                this.txtTreeClassReadMe.Text = dt.Rows[0]["TreeClassReadMe"].ToString();
            }
        }
    }
}
