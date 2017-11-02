using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_DataCollection._Class.DAL;

namespace V5_DataCollection.Forms.Tools {
    public partial class frmImportWebCollectionModule : BaseForm {
        public frmImportWebCollectionModule() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {

            string WebCollectionModule = this.txtWebCollectionModule.Text;
            if (string.IsNullOrEmpty(WebCollectionModule)) {
                MessageBox.Show("采集模块不能为空!");
                return;
            }
            this.Hide();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void frmImportWebCollectionModule_Load(object sender, EventArgs e) {
            DALTaskClass dal = new DALTaskClass();
            DataTable dt = dal.GetList(string.Empty).Tables[0];
            this.cmbSiteClass.Items.Clear();
            foreach (DataRow dr in dt.Rows) {
                this.cmbSiteClass.Items.Add(dr["TreeClassName"].ToString() + "||" + dr["ClassId"].ToString());
            }
            this.cmbSiteClass.SelectedIndex = 0;
        }

        private void btnBroswer_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                this.txtWebCollectionModule.Text = openFileDialog1.FileName;
            }
        }


    }
}
