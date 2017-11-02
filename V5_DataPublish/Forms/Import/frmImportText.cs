using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace V5_DataPublish.Forms.Import {
    public partial class frmImportText : BaseForm {
        public frmImportText() {
            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            StreamReader fileStream = new StreamReader(this.txtTextFile.Text, Encoding.Default);
            String strContent = fileStream.ReadToEnd();
            fileStream.Close();

            string[] splitStringArr = strContent.Split(new string[] { "标题:" }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            int MaxCount = Math.Min(40000, splitStringArr.Length);
        }

        private void ShowProgressBar(int pValue) {
            this.progressBar.Invoke(new MethodInvoker(delegate() {
                progressBar.Value = pValue;
            }));
            this.labelProgress.Invoke(new MethodInvoker(delegate() {
                labelProgress.Text = progressBar.Value + "%";
            }));
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.btnCancel.Enabled = true;
            this.btnSubmit.Enabled = true;
            MessageBox.Show("导入完毕!");
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            if (this.backgroundWorker.IsBusy) {
                this.backgroundWorker.CancelAsync();
            }
            this.Close();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            this.btnCancel.Enabled = false;
            this.btnSubmit.Enabled = false;
            if (!this.backgroundWorker.IsBusy) {
                this.backgroundWorker.RunWorkerAsync();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                this.txtTextFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnIndexTest_Click(object sender, EventArgs e) {

        }
    }
}
