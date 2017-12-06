using Microsoft.ConsultingServices.HtmlEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_WinControls.Pager;
using V5_DataCollection._Class.DAL;

namespace V5_DataCollection.Forms.Task.TaskData {
    public partial class frmTaskDataList : BaseForm {
        #region 访问器
        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }
        #endregion


        public frmTaskDataList() {
            InitializeComponent();
        }

        private void frmTaskDataList_Load(object sender, EventArgs e) {


            this.Pager.PageCurrent = 1;
            this.Pager.Bind();

            this.Bind_DataList();
        }


        private int Bind_DataList() {

            if (!string.IsNullOrEmpty(this.TaskName)) {

                int oCount = 0;
                int startIndex = (this.Pager.PageCurrent - 1) * this.Pager.PageSize;
                int pageSize = this.Pager.PageSize;

                DataTable dt = DALContentHelper.GetContentList(this.TaskName, startIndex, pageSize, ref oCount);

                this.Pager.bindingSource.DataSource = dt;
                this.Pager.bindingNavigator.BindingSource = Pager.bindingSource;

                this.dataGridView_DataList.DataSource = this.Pager.bindingSource;

                return oCount;
            }
            return 0;
        }

        private int Pager_EventPaging(EventPagingArg e) {
            return this.Bind_DataList();
        }

        private void dataGridView_DataList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var id = dataGridView_DataList.Rows[e.RowIndex].Cells[0];
            var cell = dataGridView_DataList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var headerName = cell.OwningColumn.HeaderText;
            frmTaskDataEdit FormTaskDataEdit = new frmTaskDataEdit();
            FormTaskDataEdit.TaskName = this.TaskName;
            FormTaskDataEdit.HeaderText = headerName;
            FormTaskDataEdit.Id = id.Value.ToString();
            FormTaskDataEdit.Cell = cell;
            FormTaskDataEdit.OutEdit = EditContentReturn;
            FormTaskDataEdit.ShowDialog(this);
        }


        private void EditContentReturn(DataGridViewCell cell, string result) {
            cell.Value = result;
        }


    }
}
