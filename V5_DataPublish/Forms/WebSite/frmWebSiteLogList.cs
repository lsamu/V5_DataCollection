using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using V5_DataPublish._Class;
using System.IO;
using V5_WinLibs.DBUtility;

namespace V5_DataPublish.Forms.WebSite {
    public partial class frmWebSiteLogList : BaseForm {

        public delegate void OptionOk(object sender, string message, Common.Option o);
        public OptionOk OO;

        WebSiteHelper _modelSite = null;

        public WebSiteHelper ModelSite {
            get { return _modelSite; }
            set { _modelSite = value; }
        }

        public frmWebSiteLogList() {
            InitializeComponent();
        }

        private void frmWebSiteLogList_Load(object sender, EventArgs e) {
            if (this.ModelSite != null) {
                Bind_DataList();
            }
        }

        private void Bind_DataList() {
            int sWebSiteID = ModelSite.ID;
            string baseDir = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Spider\\";
            string SQLiteName = baseDir + sWebSiteID + "\\SpiderResult.db";
            string LocalSQLiteName = "Data\\Spider\\" + sWebSiteID + "\\SpiderResult.db";
            if (File.Exists(SQLiteName)) {
                string SQL = string.Empty; 
                SQL = "Select * from Content Order by ID  Desc";
                DataSet ds = DbHelper.Query(LocalSQLiteName, SQL);
                this.dataGridView_LogList.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
