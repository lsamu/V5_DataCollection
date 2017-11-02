using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace V5_DataPublish.Forms.Import {
    public partial class frmImportXml : V5_DataPublish.BaseForm {
        public frmImportXml() {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                this.txtXmlFile.Text = openFileDialog1.FileName;
            }
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

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            MessageBox.Show("µº»ÎÕÍ±œ!");
        }

        private void frmImportXml_FormClosing(object sender, FormClosingEventArgs e) {
            if (this.backgroundWorker.IsBusy) {
                return;
            }
        }
    }
}
