using System;
using System.Data;
using System.Windows.Forms;
using V5_DataCollection._Class.DAL;
using V5_DataCollection._Class.Common;
using V5_Model;
namespace V5_DataCollection.Forms.Tools
{
    public partial class frmImportWebCollectionModule : BaseForm {
        public frmImportWebCollectionModule() {
            InitializeComponent();
        }
       public RefreshParentForm RefreshParentForm;
        private void btnSubmit_Click(object sender, EventArgs e) {

            string WebCollectionModule = this.txtWebCollectionModule.Text;
            
            if (string.IsNullOrEmpty(WebCollectionModule)) {
                MessageBox.Show("采集模块不能为空!");
                return;
            }

            var model = SerializeHelper.DeserializeObject<ModelTask>(WebCollectionModule);
            DALTask dal = new DALTask();
            int currentMaxId = dal.GetMaxId();
            model.ID = currentMaxId;
            dal.Add(model);
            foreach (ModelTaskLabel label in model.ListTaskLabel)
            {
                label.TaskID = currentMaxId;
                var d = new DALTaskLabel();
               var m= d.GetMaxID();
                label.ID = m;
                d.Add(label);
            }
            foreach (ModelWebPublishModule label in model.ListModelWebPublishModule)
            {
                label.TaskID = currentMaxId;
                var d = new DALWebPublishModule();               
                label.ID = 0;
                d.Add(label);
            }
            MessageBox.Show("导入成功");
            RefreshParentForm?.Invoke(this,new EventArgs());
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
            openFileDialog1.Filter = "(*.xml)|*.xml";
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                this.txtWebCollectionModule.Text = openFileDialog1.FileName;
            }
        }


    }
}
