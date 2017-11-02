namespace V5_DataCollection.Forms.Tools
{
    partial class frmOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkIsAutoSendLog = new System.Windows.Forms.CheckBox();
            this.txtBossKey = new System.Windows.Forms.TextBox();
            this.nudTaskMaxCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.nudCollectionContentMax = new System.Windows.Forms.NumericUpDown();
            this.nudCollectionListMax = new System.Windows.Forms.NumericUpDown();
            this.nudPublishContentMax = new System.Windows.Forms.NumericUpDown();
            this.nudPublishContentMin = new System.Windows.Forms.NumericUpDown();
            this.nudCollectionListMin = new System.Windows.Forms.NumericUpDown();
            this.nudCollectionContentMin = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.nudPublishContentThreadCount = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.nudCollectionContentThreadCount = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaskMaxCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionListMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionListMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentThreadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentThreadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(476, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(560, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 355);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkIsAutoSendLog);
            this.tabPage1.Controls.Add(this.txtBossKey);
            this.tabPage1.Controls.Add(this.nudTaskMaxCount);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkIsAutoSendLog
            // 
            this.chkIsAutoSendLog.AutoSize = true;
            this.chkIsAutoSendLog.Location = new System.Drawing.Point(150, 82);
            this.chkIsAutoSendLog.Name = "chkIsAutoSendLog";
            this.chkIsAutoSendLog.Size = new System.Drawing.Size(36, 16);
            this.chkIsAutoSendLog.TabIndex = 3;
            this.chkIsAutoSendLog.Text = "是";
            this.chkIsAutoSendLog.UseVisualStyleBackColor = true;
            // 
            // txtBossKey
            // 
            this.txtBossKey.Location = new System.Drawing.Point(150, 50);
            this.txtBossKey.Name = "txtBossKey";
            this.txtBossKey.Size = new System.Drawing.Size(154, 21);
            this.txtBossKey.TabIndex = 2;
            this.txtBossKey.Text = "ALT + F8";
            // 
            // nudTaskMaxCount
            // 
            this.nudTaskMaxCount.Location = new System.Drawing.Point(150, 16);
            this.nudTaskMaxCount.Name = "nudTaskMaxCount";
            this.nudTaskMaxCount.Size = new System.Drawing.Size(61, 21);
            this.nudTaskMaxCount.TabIndex = 1;
            this.nudTaskMaxCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "自动提交软件日志";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "老板键";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "任务最大个数";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "采集任务配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.nudCollectionContentMax);
            this.groupBox10.Controls.Add(this.nudCollectionListMax);
            this.groupBox10.Controls.Add(this.nudPublishContentMax);
            this.groupBox10.Controls.Add(this.nudPublishContentMin);
            this.groupBox10.Controls.Add(this.nudCollectionListMin);
            this.groupBox10.Controls.Add(this.nudCollectionContentMin);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.nudPublishContentThreadCount);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.nudCollectionContentThreadCount);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Location = new System.Drawing.Point(10, 7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(588, 316);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "任务运行设置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "随机值";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "随机值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "毫秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "毫秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "毫秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "毫秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "毫秒";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "毫秒";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(241, 190);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 12);
            this.label34.TabIndex = 2;
            this.label34.Text = "随机值";
            // 
            // nudCollectionContentMax
            // 
            this.nudCollectionContentMax.Location = new System.Drawing.Point(114, 134);
            this.nudCollectionContentMax.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.nudCollectionContentMax.Name = "nudCollectionContentMax";
            this.nudCollectionContentMax.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionContentMax.TabIndex = 1;
            this.nudCollectionContentMax.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudCollectionListMax
            // 
            this.nudCollectionListMax.Location = new System.Drawing.Point(114, 52);
            this.nudCollectionListMax.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.nudCollectionListMax.Name = "nudCollectionListMax";
            this.nudCollectionListMax.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionListMax.TabIndex = 1;
            this.nudCollectionListMax.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudPublishContentMax
            // 
            this.nudPublishContentMax.Location = new System.Drawing.Point(114, 215);
            this.nudPublishContentMax.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.nudPublishContentMax.Name = "nudPublishContentMax";
            this.nudPublishContentMax.Size = new System.Drawing.Size(69, 21);
            this.nudPublishContentMax.TabIndex = 1;
            this.nudPublishContentMax.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudPublishContentMin
            // 
            this.nudPublishContentMin.Location = new System.Drawing.Point(114, 188);
            this.nudPublishContentMin.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudPublishContentMin.Name = "nudPublishContentMin";
            this.nudPublishContentMin.Size = new System.Drawing.Size(69, 21);
            this.nudPublishContentMin.TabIndex = 1;
            this.nudPublishContentMin.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudCollectionListMin
            // 
            this.nudCollectionListMin.Location = new System.Drawing.Point(114, 20);
            this.nudCollectionListMin.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudCollectionListMin.Name = "nudCollectionListMin";
            this.nudCollectionListMin.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionListMin.TabIndex = 1;
            this.nudCollectionListMin.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudCollectionContentMin
            // 
            this.nudCollectionContentMin.Location = new System.Drawing.Point(114, 106);
            this.nudCollectionContentMin.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudCollectionContentMin.Name = "nudCollectionContentMin";
            this.nudCollectionContentMin.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionContentMin.TabIndex = 1;
            this.nudCollectionContentMin.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 190);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(77, 12);
            this.label32.TabIndex = 0;
            this.label32.Text = "发布内容间隔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "采集列表间隔";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(20, 108);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "采集内容间隔";
            // 
            // nudPublishContentThreadCount
            // 
            this.nudPublishContentThreadCount.Location = new System.Drawing.Point(114, 161);
            this.nudPublishContentThreadCount.Name = "nudPublishContentThreadCount";
            this.nudPublishContentThreadCount.Size = new System.Drawing.Size(69, 21);
            this.nudPublishContentThreadCount.TabIndex = 1;
            this.nudPublishContentThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 163);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "发布内容线程";
            // 
            // nudCollectionContentThreadCount
            // 
            this.nudCollectionContentThreadCount.Location = new System.Drawing.Point(114, 79);
            this.nudCollectionContentThreadCount.Name = "nudCollectionContentThreadCount";
            this.nudCollectionContentThreadCount.Size = new System.Drawing.Size(69, 21);
            this.nudCollectionContentThreadCount.TabIndex = 1;
            this.nudCollectionContentThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 81);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "采集内容线程";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 413);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOption";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选项配置";
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaskMaxCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionListMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionListMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishContentThreadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollectionContentThreadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown nudPublishContentMax;
        private System.Windows.Forms.NumericUpDown nudPublishContentMin;
        private System.Windows.Forms.NumericUpDown nudCollectionContentMin;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown nudPublishContentThreadCount;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown nudCollectionContentThreadCount;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown nudCollectionListMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCollectionListMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCollectionContentMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudTaskMaxCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBossKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkIsAutoSendLog;
    }
}