using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataPublish.Forms.Desk {
    public partial class frmPageContentEdit : Form {
        /// <summary>
        /// 内容编辑委托
        /// </summary>
        /// <param name="strTitle"></param>
        /// <param name="strContent"></param>
        public delegate void ReturnContentEventHandler(string strTitle, string strContent);
        public ReturnContentEventHandler rcEH;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        public frmPageContentEdit() {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(this.txtTitle.Text)) {
                MessageBox.Show("文章标题不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// 窗体初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPageContentEdit_Load(object sender, EventArgs e) {
            this.txtTitle.Text = this.Title;
        }
        /// <summary>
        /// 编辑器初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtFckEditorContent_OnEditorInitialized(object sender, EventArgs e) {
            
        }

    }
}
