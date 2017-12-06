using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Data ;

///功能：自定义datagridview控件
namespace V5_WinControls.DataGrid
{
    public partial class cMyDataGridView : DataGridView 
    {
        private string m_FileName;

        public cMyDataGridView()
        {
            InitializeComponent();
            m_gData = new DataTable();
            base.ReadOnly = false;
            base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            base.MultiSelect = true;
            base.DataSource = m_gData;
            m_gData.AcceptChanges();

            base.AllowUserToAddRows = false;
            base.AllowUserToDeleteRows = true ;
        }

        public cMyDataGridView(string FileName)
        {
            InitializeComponent();
            m_gData = new DataTable();
            base.ReadOnly = false;
            base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            base.DataSource = m_gData;
            m_gData.AcceptChanges();

            base.AllowUserToAddRows = false;
            base.AllowUserToDeleteRows = false;

            m_FileName = FileName;

        }

        public void Clear()
        {
            m_gData = null;
            m_gData = new DataTable();
            base.DataSource = m_gData;
        }

        public cMyDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private string m_TaskName;
        public string TaskName
        {
            get { return m_TaskName; }
            set { m_TaskName = value; }
        }

        private Int64 m_TaskRunID;
        public Int64 TaskRunID
        {
            get { return m_TaskRunID; }
            set { m_TaskRunID = value; }
        }

        private DataTable m_gData;
        public DataTable gData
        {
            get { return this.m_gData; }
            set 
            {
                DataTable tmp = new DataTable();
                tmp=value;
                try
                {
                    if (tmp != null)
                    {
                        m_gData.Merge(tmp);
                        m_gData.AcceptChanges();

                        base.FirstDisplayedScrollingRowIndex = base.Rows.Count - 1;

                    }
                }
                catch (System.Exception)
                {
                }
            }
        }

        private string FileName
        {
            get
            {
                string FileName = "";           
                return FileName;
            }

        }
    }
}
