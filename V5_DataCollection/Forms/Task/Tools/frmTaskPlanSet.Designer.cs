namespace V5_DataCollection.Forms.Task.Tools {
    partial class frmTaskPlanSet {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiyTriggerTime = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Loop = new System.Windows.Forms.Panel();
            this.num_starttime = new System.Windows.Forms.NumericUpDown();
            this.num_excutetime = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_MinDiay = new System.Windows.Forms.GroupBox();
            this.chklistbox_min = new System.Windows.Forms.CheckedListBox();
            this.rbtnMinDiy = new System.Windows.Forms.RadioButton();
            this.rbtnMinLoop = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_HourDiy = new System.Windows.Forms.GroupBox();
            this.chklistbox_hour = new System.Windows.Forms.CheckedListBox();
            this.rbtnHourDiy = new System.Windows.Forms.RadioButton();
            this.rbtnHourLoop = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox_DayDiy = new System.Windows.Forms.GroupBox();
            this.chklistbox_day = new System.Windows.Forms.CheckedListBox();
            this.rbtnDayDiy = new System.Windows.Forms.RadioButton();
            this.rbtnDayLoop = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox_MonthDiy = new System.Windows.Forms.GroupBox();
            this.chklistbox_month = new System.Windows.Forms.CheckedListBox();
            this.rbtnMonthDiy = new System.Windows.Forms.RadioButton();
            this.rbtnMonthLoop = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox_Week = new System.Windows.Forms.GroupBox();
            this.chklistbox_week = new System.Windows.Forms.CheckedListBox();
            this.rbtnWeekDiy = new System.Windows.Forms.RadioButton();
            this.rbtnWeekLoop = new System.Windows.Forms.RadioButton();
            this.chkUseWeek = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtExeuteTimeList = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_Loop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_starttime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_excutetime)).BeginInit();
            this.groupBox_MinDiay.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_HourDiy.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox_DayDiy.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox_MonthDiy.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox_Week.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "自定义";
            // 
            // txtDiyTriggerTime
            // 
            this.txtDiyTriggerTime.Location = new System.Drawing.Point(77, 445);
            this.txtDiyTriggerTime.Name = "txtDiyTriggerTime";
            this.txtDiyTriggerTime.Size = new System.Drawing.Size(351, 21);
            this.txtDiyTriggerTime.TabIndex = 1;
            this.txtDiyTriggerTime.Text = "0 0 0/4 * * ?";
            this.txtDiyTriggerTime.TextChanged += new System.EventHandler(this.txtDiyTriggerTime_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(514, 448);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(604, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tab1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日期,时间";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Controls.Add(this.tabPage4);
            this.tab1.Controls.Add(this.tabPage5);
            this.tab1.Location = new System.Drawing.Point(6, 20);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(647, 212);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_Loop);
            this.tabPage1.Controls.Add(this.groupBox_MinDiay);
            this.tabPage1.Controls.Add(this.rbtnMinDiy);
            this.tabPage1.Controls.Add(this.rbtnMinLoop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 186);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "分钟";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_Loop
            // 
            this.panel_Loop.Controls.Add(this.num_starttime);
            this.panel_Loop.Controls.Add(this.num_excutetime);
            this.panel_Loop.Controls.Add(this.label10);
            this.panel_Loop.Controls.Add(this.label8);
            this.panel_Loop.Controls.Add(this.label11);
            this.panel_Loop.Controls.Add(this.label9);
            this.panel_Loop.Location = new System.Drawing.Point(70, 9);
            this.panel_Loop.Name = "panel_Loop";
            this.panel_Loop.Size = new System.Drawing.Size(521, 35);
            this.panel_Loop.TabIndex = 5;
            // 
            // num_starttime
            // 
            this.num_starttime.Location = new System.Drawing.Point(59, 10);
            this.num_starttime.Name = "num_starttime";
            this.num_starttime.Size = new System.Drawing.Size(69, 21);
            this.num_starttime.TabIndex = 1;
            // 
            // num_excutetime
            // 
            this.num_excutetime.Location = new System.Drawing.Point(285, 10);
            this.num_excutetime.Name = "num_excutetime";
            this.num_excutetime.Size = new System.Drawing.Size(69, 21);
            this.num_excutetime.TabIndex = 1;
            this.num_excutetime.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "每";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "从";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "执行";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "分钟开始";
            // 
            // groupBox_MinDiay
            // 
            this.groupBox_MinDiay.Controls.Add(this.chklistbox_min);
            this.groupBox_MinDiay.Enabled = false;
            this.groupBox_MinDiay.Location = new System.Drawing.Point(70, 44);
            this.groupBox_MinDiay.Name = "groupBox_MinDiay";
            this.groupBox_MinDiay.Size = new System.Drawing.Size(512, 119);
            this.groupBox_MinDiay.TabIndex = 4;
            this.groupBox_MinDiay.TabStop = false;
            // 
            // chklistbox_min
            // 
            this.chklistbox_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklistbox_min.CheckOnClick = true;
            this.chklistbox_min.ColumnWidth = 40;
            this.chklistbox_min.FormattingEnabled = true;
            this.chklistbox_min.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.chklistbox_min.Location = new System.Drawing.Point(16, 20);
            this.chklistbox_min.MultiColumn = true;
            this.chklistbox_min.Name = "chklistbox_min";
            this.chklistbox_min.Size = new System.Drawing.Size(490, 80);
            this.chklistbox_min.TabIndex = 0;
            // 
            // rbtnMinDiy
            // 
            this.rbtnMinDiy.AutoSize = true;
            this.rbtnMinDiy.Location = new System.Drawing.Point(17, 44);
            this.rbtnMinDiy.Name = "rbtnMinDiy";
            this.rbtnMinDiy.Size = new System.Drawing.Size(47, 16);
            this.rbtnMinDiy.TabIndex = 0;
            this.rbtnMinDiy.TabStop = true;
            this.rbtnMinDiy.Text = "指定";
            this.rbtnMinDiy.UseVisualStyleBackColor = true;
            this.rbtnMinDiy.CheckedChanged += new System.EventHandler(this.rbtnMinDiy_CheckedChanged);
            // 
            // rbtnMinLoop
            // 
            this.rbtnMinLoop.AutoSize = true;
            this.rbtnMinLoop.Checked = true;
            this.rbtnMinLoop.Location = new System.Drawing.Point(17, 19);
            this.rbtnMinLoop.Name = "rbtnMinLoop";
            this.rbtnMinLoop.Size = new System.Drawing.Size(47, 16);
            this.rbtnMinLoop.TabIndex = 0;
            this.rbtnMinLoop.TabStop = true;
            this.rbtnMinLoop.Text = "循环";
            this.rbtnMinLoop.UseVisualStyleBackColor = true;
            this.rbtnMinLoop.CheckedChanged += new System.EventHandler(this.rbtnMinLoop_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_HourDiy);
            this.tabPage2.Controls.Add(this.rbtnHourDiy);
            this.tabPage2.Controls.Add(this.rbtnHourLoop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 186);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "小时";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_HourDiy
            // 
            this.groupBox_HourDiy.Controls.Add(this.chklistbox_hour);
            this.groupBox_HourDiy.Enabled = false;
            this.groupBox_HourDiy.Location = new System.Drawing.Point(69, 38);
            this.groupBox_HourDiy.Name = "groupBox_HourDiy";
            this.groupBox_HourDiy.Size = new System.Drawing.Size(509, 88);
            this.groupBox_HourDiy.TabIndex = 1;
            this.groupBox_HourDiy.TabStop = false;
            // 
            // chklistbox_hour
            // 
            this.chklistbox_hour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklistbox_hour.CheckOnClick = true;
            this.chklistbox_hour.ColumnWidth = 40;
            this.chklistbox_hour.FormattingEnabled = true;
            this.chklistbox_hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.chklistbox_hour.Location = new System.Drawing.Point(17, 20);
            this.chklistbox_hour.MultiColumn = true;
            this.chklistbox_hour.Name = "chklistbox_hour";
            this.chklistbox_hour.Size = new System.Drawing.Size(338, 48);
            this.chklistbox_hour.TabIndex = 0;
            // 
            // rbtnHourDiy
            // 
            this.rbtnHourDiy.AutoSize = true;
            this.rbtnHourDiy.Location = new System.Drawing.Point(16, 38);
            this.rbtnHourDiy.Name = "rbtnHourDiy";
            this.rbtnHourDiy.Size = new System.Drawing.Size(47, 16);
            this.rbtnHourDiy.TabIndex = 0;
            this.rbtnHourDiy.TabStop = true;
            this.rbtnHourDiy.Text = "指定";
            this.rbtnHourDiy.UseVisualStyleBackColor = true;
            this.rbtnHourDiy.CheckedChanged += new System.EventHandler(this.rbtnHourDiy_CheckedChanged);
            // 
            // rbtnHourLoop
            // 
            this.rbtnHourLoop.AutoSize = true;
            this.rbtnHourLoop.Checked = true;
            this.rbtnHourLoop.Location = new System.Drawing.Point(16, 16);
            this.rbtnHourLoop.Name = "rbtnHourLoop";
            this.rbtnHourLoop.Size = new System.Drawing.Size(59, 16);
            this.rbtnHourLoop.TabIndex = 0;
            this.rbtnHourLoop.TabStop = true;
            this.rbtnHourLoop.Text = "每小时";
            this.rbtnHourLoop.UseVisualStyleBackColor = true;
            this.rbtnHourLoop.CheckedChanged += new System.EventHandler(this.rbtnHourLoop_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox_DayDiy);
            this.tabPage3.Controls.Add(this.rbtnDayDiy);
            this.tabPage3.Controls.Add(this.rbtnDayLoop);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(639, 186);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "天";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox_DayDiy
            // 
            this.groupBox_DayDiy.Controls.Add(this.chklistbox_day);
            this.groupBox_DayDiy.Enabled = false;
            this.groupBox_DayDiy.Location = new System.Drawing.Point(69, 39);
            this.groupBox_DayDiy.Name = "groupBox_DayDiy";
            this.groupBox_DayDiy.Size = new System.Drawing.Size(553, 87);
            this.groupBox_DayDiy.TabIndex = 1;
            this.groupBox_DayDiy.TabStop = false;
            // 
            // chklistbox_day
            // 
            this.chklistbox_day.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklistbox_day.CheckOnClick = true;
            this.chklistbox_day.ColumnWidth = 40;
            this.chklistbox_day.FormattingEnabled = true;
            this.chklistbox_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.chklistbox_day.Location = new System.Drawing.Point(16, 20);
            this.chklistbox_day.MultiColumn = true;
            this.chklistbox_day.Name = "chklistbox_day";
            this.chklistbox_day.Size = new System.Drawing.Size(510, 48);
            this.chklistbox_day.TabIndex = 0;
            // 
            // rbtnDayDiy
            // 
            this.rbtnDayDiy.AutoSize = true;
            this.rbtnDayDiy.Location = new System.Drawing.Point(16, 39);
            this.rbtnDayDiy.Name = "rbtnDayDiy";
            this.rbtnDayDiy.Size = new System.Drawing.Size(47, 16);
            this.rbtnDayDiy.TabIndex = 0;
            this.rbtnDayDiy.Text = "指定";
            this.rbtnDayDiy.UseVisualStyleBackColor = true;
            this.rbtnDayDiy.CheckedChanged += new System.EventHandler(this.rbtnDayDiy_CheckedChanged);
            // 
            // rbtnDayLoop
            // 
            this.rbtnDayLoop.AutoSize = true;
            this.rbtnDayLoop.Checked = true;
            this.rbtnDayLoop.Location = new System.Drawing.Point(16, 17);
            this.rbtnDayLoop.Name = "rbtnDayLoop";
            this.rbtnDayLoop.Size = new System.Drawing.Size(47, 16);
            this.rbtnDayLoop.TabIndex = 0;
            this.rbtnDayLoop.TabStop = true;
            this.rbtnDayLoop.Text = "每天";
            this.rbtnDayLoop.UseVisualStyleBackColor = true;
            this.rbtnDayLoop.CheckedChanged += new System.EventHandler(this.rbtnDayLoop_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox_MonthDiy);
            this.tabPage4.Controls.Add(this.rbtnMonthDiy);
            this.tabPage4.Controls.Add(this.rbtnMonthLoop);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(639, 186);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "月";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox_MonthDiy
            // 
            this.groupBox_MonthDiy.Controls.Add(this.chklistbox_month);
            this.groupBox_MonthDiy.Enabled = false;
            this.groupBox_MonthDiy.Location = new System.Drawing.Point(83, 53);
            this.groupBox_MonthDiy.Name = "groupBox_MonthDiy";
            this.groupBox_MonthDiy.Size = new System.Drawing.Size(449, 76);
            this.groupBox_MonthDiy.TabIndex = 3;
            this.groupBox_MonthDiy.TabStop = false;
            // 
            // chklistbox_month
            // 
            this.chklistbox_month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklistbox_month.CheckOnClick = true;
            this.chklistbox_month.ColumnWidth = 40;
            this.chklistbox_month.FormattingEnabled = true;
            this.chklistbox_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.chklistbox_month.Location = new System.Drawing.Point(27, 20);
            this.chklistbox_month.MultiColumn = true;
            this.chklistbox_month.Name = "chklistbox_month";
            this.chklistbox_month.Size = new System.Drawing.Size(405, 32);
            this.chklistbox_month.TabIndex = 0;
            // 
            // rbtnMonthDiy
            // 
            this.rbtnMonthDiy.AutoSize = true;
            this.rbtnMonthDiy.Location = new System.Drawing.Point(21, 53);
            this.rbtnMonthDiy.Name = "rbtnMonthDiy";
            this.rbtnMonthDiy.Size = new System.Drawing.Size(47, 16);
            this.rbtnMonthDiy.TabIndex = 2;
            this.rbtnMonthDiy.Text = "指定";
            this.rbtnMonthDiy.UseVisualStyleBackColor = true;
            this.rbtnMonthDiy.CheckedChanged += new System.EventHandler(this.rbtnMonthDiy_CheckedChanged);
            // 
            // rbtnMonthLoop
            // 
            this.rbtnMonthLoop.AutoSize = true;
            this.rbtnMonthLoop.Checked = true;
            this.rbtnMonthLoop.Location = new System.Drawing.Point(21, 22);
            this.rbtnMonthLoop.Name = "rbtnMonthLoop";
            this.rbtnMonthLoop.Size = new System.Drawing.Size(47, 16);
            this.rbtnMonthLoop.TabIndex = 1;
            this.rbtnMonthLoop.TabStop = true;
            this.rbtnMonthLoop.Text = "每月";
            this.rbtnMonthLoop.UseVisualStyleBackColor = true;
            this.rbtnMonthLoop.CheckedChanged += new System.EventHandler(this.rbtnMonthLoop_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox_Week);
            this.tabPage5.Controls.Add(this.chkUseWeek);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(639, 186);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "周";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox_Week
            // 
            this.groupBox_Week.Controls.Add(this.chklistbox_week);
            this.groupBox_Week.Controls.Add(this.rbtnWeekDiy);
            this.groupBox_Week.Controls.Add(this.rbtnWeekLoop);
            this.groupBox_Week.Enabled = false;
            this.groupBox_Week.Location = new System.Drawing.Point(19, 36);
            this.groupBox_Week.Name = "groupBox_Week";
            this.groupBox_Week.Size = new System.Drawing.Size(603, 88);
            this.groupBox_Week.TabIndex = 1;
            this.groupBox_Week.TabStop = false;
            // 
            // chklistbox_week
            // 
            this.chklistbox_week.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklistbox_week.CheckOnClick = true;
            this.chklistbox_week.ColumnWidth = 40;
            this.chklistbox_week.Enabled = false;
            this.chklistbox_week.FormattingEnabled = true;
            this.chklistbox_week.Items.AddRange(new object[] {
            "日",
            "一",
            "二",
            "三",
            "四",
            "五",
            "六"});
            this.chklistbox_week.Location = new System.Drawing.Point(66, 46);
            this.chklistbox_week.MultiColumn = true;
            this.chklistbox_week.Name = "chklistbox_week";
            this.chklistbox_week.Size = new System.Drawing.Size(401, 16);
            this.chklistbox_week.TabIndex = 5;
            // 
            // rbtnWeekDiy
            // 
            this.rbtnWeekDiy.AutoSize = true;
            this.rbtnWeekDiy.Location = new System.Drawing.Point(13, 44);
            this.rbtnWeekDiy.Name = "rbtnWeekDiy";
            this.rbtnWeekDiy.Size = new System.Drawing.Size(47, 16);
            this.rbtnWeekDiy.TabIndex = 4;
            this.rbtnWeekDiy.Text = "指定";
            this.rbtnWeekDiy.UseVisualStyleBackColor = true;
            this.rbtnWeekDiy.CheckedChanged += new System.EventHandler(this.rbtnWeekDiy_CheckedChanged);
            // 
            // rbtnWeekLoop
            // 
            this.rbtnWeekLoop.AutoSize = true;
            this.rbtnWeekLoop.Checked = true;
            this.rbtnWeekLoop.Location = new System.Drawing.Point(13, 20);
            this.rbtnWeekLoop.Name = "rbtnWeekLoop";
            this.rbtnWeekLoop.Size = new System.Drawing.Size(47, 16);
            this.rbtnWeekLoop.TabIndex = 2;
            this.rbtnWeekLoop.TabStop = true;
            this.rbtnWeekLoop.Text = "每周";
            this.rbtnWeekLoop.UseVisualStyleBackColor = true;
            this.rbtnWeekLoop.CheckedChanged += new System.EventHandler(this.rbtnWeekLoop_CheckedChanged);
            // 
            // chkUseWeek
            // 
            this.chkUseWeek.AutoSize = true;
            this.chkUseWeek.Location = new System.Drawing.Point(19, 14);
            this.chkUseWeek.Name = "chkUseWeek";
            this.chkUseWeek.Size = new System.Drawing.Size(60, 16);
            this.chkUseWeek.TabIndex = 0;
            this.chkUseWeek.Text = "使用周";
            this.chkUseWeek.UseVisualStyleBackColor = true;
            this.chkUseWeek.CheckedChanged += new System.EventHandler(this.chkUseWeek_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnExecute);
            this.groupBox7.Controls.Add(this.txtExeuteTimeList);
            this.groupBox7.Controls.Add(this.txtStartTime);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(12, 264);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(667, 175);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "执行计划时间";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(574, 18);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "执行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtExeuteTimeList
            // 
            this.txtExeuteTimeList.Location = new System.Drawing.Point(95, 51);
            this.txtExeuteTimeList.Multiline = true;
            this.txtExeuteTimeList.Name = "txtExeuteTimeList";
            this.txtExeuteTimeList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExeuteTimeList.Size = new System.Drawing.Size(554, 106);
            this.txtExeuteTimeList.TabIndex = 1;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(95, 20);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(230, 21);
            this.txtStartTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "执行时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始时间:";
            // 
            // frmTaskPlanSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 479);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDiyTriggerTime);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskPlanSet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计划任务设置";
            this.Load += new System.EventHandler(this.frmTaskPlanSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel_Loop.ResumeLayout(false);
            this.panel_Loop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_starttime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_excutetime)).EndInit();
            this.groupBox_MinDiay.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox_HourDiy.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox_DayDiy.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox_MonthDiy.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox_Week.ResumeLayout(false);
            this.groupBox_Week.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiyTriggerTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RadioButton rbtnMinLoop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_starttime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_excutetime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox_MinDiay;
        private System.Windows.Forms.RadioButton rbtnMinDiy;
        private System.Windows.Forms.RadioButton rbtnHourLoop;
        private System.Windows.Forms.RadioButton rbtnHourDiy;
        private System.Windows.Forms.GroupBox groupBox_HourDiy;
        private System.Windows.Forms.RadioButton rbtnDayLoop;
        private System.Windows.Forms.RadioButton rbtnDayDiy;
        private System.Windows.Forms.GroupBox groupBox_DayDiy;
        private System.Windows.Forms.GroupBox groupBox_MonthDiy;
        private System.Windows.Forms.RadioButton rbtnMonthDiy;
        private System.Windows.Forms.RadioButton rbtnMonthLoop;
        private System.Windows.Forms.CheckBox chkUseWeek;
        private System.Windows.Forms.GroupBox groupBox_Week;
        private System.Windows.Forms.RadioButton rbtnWeekLoop;
        private System.Windows.Forms.RadioButton rbtnWeekDiy;
        private System.Windows.Forms.CheckedListBox chklistbox_min;
        private System.Windows.Forms.CheckedListBox chklistbox_hour;
        private System.Windows.Forms.CheckedListBox chklistbox_day;
        private System.Windows.Forms.CheckedListBox chklistbox_month;
        private System.Windows.Forms.CheckedListBox chklistbox_week;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExeuteTimeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Panel panel_Loop;
    }
}