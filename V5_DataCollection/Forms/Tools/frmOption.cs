using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_WinLibs.Core;

namespace V5_DataCollection.Forms.Tools {
    public partial class frmOption : BaseForm {
        public frmOption() {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e) {
            IniHelper.FilePath = System.AppDomain.CurrentDomain.BaseDirectory + "\\V5_DataCollection.ini";
            IniHelper.WriteIniKey("Settings", "TaskMaxCount", this.nudTaskMaxCount.Value.ToString());
            IniHelper.WriteIniKey("Settings", "BossKey", this.txtBossKey.Text);
            IniHelper.WriteIniKey("Settings", "IsAutoSendLog", this.chkIsAutoSendLog.Checked ? "1" : "0");
            //
            IniHelper.WriteIniKey("Task", "CollectionListMin", this.nudCollectionContentMin.Value.ToString());
            IniHelper.WriteIniKey("Task", "CollectionListMax", this.nudCollectionContentMax.Value.ToString());
            IniHelper.WriteIniKey("Task", "CollectionContentThreadCount", this.nudCollectionContentThreadCount.Value.ToString());
            IniHelper.WriteIniKey("Task", "CollectionContentMin", this.nudCollectionContentMin.Value.ToString());
            IniHelper.WriteIniKey("Task", "CollectionContentMax", this.nudCollectionContentMax.Value.ToString());
            IniHelper.WriteIniKey("Task", "PublishContentThreadCount", this.nudPublishContentThreadCount.Value.ToString());
            IniHelper.WriteIniKey("Task", "PublishContentMin", this.nudPublishContentMin.Value.ToString());
            IniHelper.WriteIniKey("Task", "PublishContentMax", this.nudPublishContentMax.Value.ToString());
            this.Hide();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void frmOption_Load(object sender, EventArgs e) {
            IniHelper.FilePath = System.AppDomain.CurrentDomain.BaseDirectory + "\\V5_DataCollection.ini";
            this.nudTaskMaxCount.Value = int.Parse(IniHelper.GetIniKeyValue("Settings", "TaskMaxCount", "1"));
            this.txtBossKey.Text = IniHelper.GetIniKeyValue("Settings", "BossKey", "ALT + F8");
            this.chkIsAutoSendLog.Checked = IniHelper.GetIniKeyValue("Settings", "IsAutoSendLog", "0") == "1" ? true : false;
            //
            this.nudCollectionListMin.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "CollectionListMin", "500"));
            this.nudCollectionListMax.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "CollectionListMax", "10000"));
            this.nudCollectionContentThreadCount.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "CollectionContentThreadCount", "5"));
            this.nudCollectionContentMin.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "CollectionContentMin", "500"));
            this.nudCollectionContentMax.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "CollectionContentMax", "10000"));
            this.nudPublishContentThreadCount.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "PublishContentThreadCount", "5"));
            this.nudPublishContentMin.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "PublishContentMin", "500"));
            this.nudPublishContentMax.Value = int.Parse(IniHelper.GetIniKeyValue("Task", "PublishContentMax", "500"));
        }
    }
}
