using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V5_DataCollection.Forms.Task.Tools {
    public partial class frmTaskPlanSet : BaseForm {

        public event MainEventHandler.DataOperationHandler OnDataOperation;
        private MainEvents.DataOperationArgs ee = new MainEvents.DataOperationArgs();

        public frmTaskPlanSet() {
            InitializeComponent();
        }


        private void frmTaskPlanSet_Load(object sender, EventArgs e) {
            this.LoadFormatShow();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            ee.Operation = MainEvents.OperationEnum.Edit;
            ee.Message = "更新触发条件";
            ee.ReturnObj = this.txtDiyTriggerTime.Text;
            if (OnDataOperation != null) {
                OnDataOperation(this, ee);
            }
            this.Hide();
            this.Close();
        }

        private void txtDiyTriggerTime_TextChanged(object sender, EventArgs e) {

            this.LoadFormatShow();
        }


        private void LoadFormatShow() {
            StringBuilder sb = new StringBuilder();

            string s = this.txtDiyTriggerTime.Text;

            string[] arrSplitTime = s.Split(new string[] { " " }, StringSplitOptions.None);

            string strSecond = arrSplitTime[0];
            if (strSecond == "0") {
                sb.Append(" 不限制秒 ");
            }
            else if (strSecond.IndexOf("/") > -1) {
                sb.Append(string.Format(" 每{0}秒执行 ", strSecond.Split(new[] { "/" }, StringSplitOptions.None)[1]));
            }
            else {
                sb.Append(string.Format(" {0}秒后执行一次 ", strSecond));
            }

            string strMinute = arrSplitTime[1];
            if (strMinute == "0" || strMinute == "*") {
                sb.Append(" 不限制分 ");
            }
            else if (strMinute.IndexOf("/") > -1) {
                sb.Append(string.Format(" 每{0}分执行 ", strMinute.Split(new[] { "/" }, StringSplitOptions.None)[1]));
            }
            else {
                sb.Append(string.Format(" {0}分后执行一次 ", strMinute));
            }

            string strHour = arrSplitTime[2];
            if (strHour == "0" || strHour == "*") {
                sb.Append(" 不限制小时 ");
            }
            else if (strHour.IndexOf("/") > -1) {
                sb.Append(string.Format(" 每{0}小时执行 ", strHour.Split(new[] { "/" }, StringSplitOptions.None)[1]));
            }
            else {
                sb.Append(string.Format(" {0}小时后执行一次 ", strHour));
            }

            string strDay = arrSplitTime[3];
            if (strDay == "0" || strDay == "*") {
                sb.Append(" 不限制天 ");
            }
            else if (strDay.IndexOf("/") > -1) {
                sb.Append(string.Format(" 每{0}号执行 ", strDay.Split(new[] { "/" }, StringSplitOptions.None)[1]));
            }
            else {
                sb.Append(string.Format(" {0}号执行一次 ", strDay));
            }

            string strWeek = arrSplitTime[4];
            if (strWeek == "*") {
                sb.Append(" 无周 ");
            }
            else {
                sb.Append(string.Format(" 周{0} ", strWeek));
            }

            string strYear = arrSplitTime[5];
            if (strYear == "?") {
                sb.Append(" 每年 ");
            }
            else {
                sb.Append(string.Format(" {0}年 ", strYear));
            }

        }

        private void Init_Corn() {
            var sec = "0";
            var min = "0/5";
            var hour = "*";
            var day = "*";
            var month = "*";
            var week = "?";

            var startMin = 0.0;
            var startDateTime = DateTime.Now;

            #region min
            if (this.rbtnMinLoop.Checked) {
                startMin = double.Parse(this.num_starttime.Value.ToString());
                startDateTime.AddMinutes(startMin);


                min = this.num_starttime.Value + "/" + this.num_excutetime.Value;
                for (int i = 0; i < this.num_excutetime.Value; i++) {

                }
            }
            else {

                min = this.GetChecked(this.chklistbox_min, ",");

                if (min.Length > 0) {
                    min = min.Remove(min.Length - 1, 1);
                }

                if (string.IsNullOrEmpty(min)) {
                    min = "0";
                }
            }
            #endregion

            #region hour
            if (this.rbtnHourLoop.Checked) {

            }
            else {
                hour = this.GetChecked(this.chklistbox_hour, ",");

                if (hour.Length > 0) {
                    hour = hour.Remove(hour.Length - 1, 1);
                }

                if (string.IsNullOrEmpty(hour)) {
                    hour = "0";
                }
            }
            #endregion

            #region day
            if (this.rbtnDayLoop.Checked) {

            }
            else {
                day = this.GetChecked(this.chklistbox_day, ",");

                if (day.Length > 0) {
                    day = day.Remove(day.Length - 1, 1);
                }

                if (string.IsNullOrEmpty(day)) {
                    day = "0";
                }
            }
            #endregion

            #region month
            if (this.rbtnMonthLoop.Checked) {

            }
            else {
                month = this.GetChecked(this.chklistbox_month, ",");

                if (month.Length > 0) {
                    month = month.Remove(month.Length - 1, 1);
                }

                if (string.IsNullOrEmpty(month)) {
                    month = "0";
                }
            }
            #endregion

            #region week
            if (this.chkUseWeek.Checked) {
                day = "?";

                if (this.rbtnWeekLoop.Checked) {
                    week = "*";
                }
                else {
                    week = this.GetChecked(this.chklistbox_week, ",");

                    if (week.Length > 0) {
                        week = week.Remove(week.Length - 1, 1);
                    }

                    week = week.Replace("日", "1");
                    week = week.Replace("一", "2");
                    week = week.Replace("二", "3");
                    week = week.Replace("三", "4");
                    week = week.Replace("四", "5");
                    week = week.Replace("五", "6");
                    week = week.Replace("六", "7");
                    if (string.IsNullOrEmpty(week)) {
                        week = "*";
                    }
                }
            }
            #endregion

            this.txtDiyTriggerTime.Text = string.Format("{0} {1} {2} {3} {4} {5}", sec, min, hour, day, month, week);

            this.txtStartTime.Text = startDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnExecute_Click(object sender, EventArgs e) {
            Init_Corn();
        }

        #region min
        private void rbtnMinLoop_CheckedChanged(object sender, EventArgs e) {
            this.panel_Loop.Enabled = true;
            this.groupBox_MinDiay.Enabled = false;
        }

        private void rbtnMinDiy_CheckedChanged(object sender, EventArgs e) {
            this.panel_Loop.Enabled = false;
            this.groupBox_MinDiay.Enabled = true;
        }
        #endregion

        #region hour
        private void rbtnHourLoop_CheckedChanged(object sender, EventArgs e) {
            this.groupBox_HourDiy.Enabled = false;
        }

        private void rbtnHourDiy_CheckedChanged(object sender, EventArgs e) {
            this.groupBox_HourDiy.Enabled = true;
        }
        #endregion

        #region day
        private void rbtnDayLoop_CheckedChanged(object sender, EventArgs e) {
            this.groupBox_DayDiy.Enabled = false;
        }

        private void rbtnDayDiy_CheckedChanged(object sender, EventArgs e) {
            this.groupBox_DayDiy.Enabled = true;
        }
        #endregion

        #region month
        private void rbtnMonthLoop_CheckedChanged(object sender, EventArgs e) {
            this.groupBox_MonthDiy.Enabled = false;
        }

        private void rbtnMonthDiy_CheckedChanged(object sender, EventArgs e) {
            this.groupBox_MonthDiy.Enabled = true;
        }
        #endregion

        #region week
        private void chkUseWeek_CheckedChanged(object sender, EventArgs e) {
            if (this.chkUseWeek.Checked) {
                this.groupBox_Week.Enabled = true;
            }
            else {
                this.groupBox_Week.Enabled = false;
            }
        }


        private void rbtnWeekLoop_CheckedChanged(object sender, EventArgs e) {
            this.chklistbox_week.Enabled = false;
        }

        private void rbtnWeekDiy_CheckedChanged(object sender, EventArgs e) {
            this.chklistbox_week.Enabled = true;
        }
        #endregion


        /// <summary>
        /// 初始化CheckedListBox中哪些是选中了的
        /// <param name="checkList">CheckedListBox</param>
        /// <param name="selval">选中了的值串例如："0,1,1,2,1"</param>
        /// <param name="separator">分割符号</param>
        public void SetChecked(CheckedListBox checkList, string selval, string separator) {
            string[] strType = selval.Split(new string[] { separator }, StringSplitOptions.None);
            for (int i = 0; i < checkList.Items.Count; i++) {
                for (int j = 0; j < strType.Length; j++) {
                    if (checkList.Items[i].ToString() == strType[j].ToString()) {
                        checkList.SetItemChecked(i, true);
                    }
                }
            }
        }

        /// <summary>
        /// 得到CheckedListBox中选中了的值
        /// </summary>
        /// <param name="checkList">CheckedListBox</param>
        /// <param name="separator">分割符号</param>
        /// <returns></returns>
        public string GetChecked(CheckedListBox checkList, string separator) {
            string selval = "";

            foreach (var chkItem in checkList.CheckedItems) {
                selval += chkItem + separator;
            }

            return selval;
        }


    }
}
