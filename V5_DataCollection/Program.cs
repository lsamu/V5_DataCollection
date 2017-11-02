using System;
using System.Threading;
using System.Windows.Forms;
using V5_DataCollection._Class.Plan;
using V5_WinLibs.DBUtility;

namespace V5_DataCollection {
    static class Program {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            DbHelper.dbType = DataBaseType.SQLite;

            bool isAppRunning = false;
            System.Threading.Mutex mutex = new System.Threading.Mutex(
                true,
                System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                out isAppRunning);
            if (!isAppRunning) {
                MessageBox.Show("本程序已经在运行了，请不要重复运行！");
                Environment.Exit(1);
            }
            else {
                try {
                    Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    frmSplashForm fromSplash = new frmSplashForm();
                    Application.Run(fromSplash);
                    if (fromSplash.IsShow) {

                        #region 执行计划任务
                        PlanTaskHelper.InitScheduler();
                        PlanTaskHelper.LoadAllJobs();
                        #endregion

                        Application.Run(new frmMain());
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message + "::" + ex.InnerException + "::" + ex.StackTrace + "::" + ex.Source + "::" + ex.HelpLink);
                }

            }
        }


        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
            try {
                string errorMsg = "程序运行过程中发生错误,错误信息如下:\n";
                errorMsg += e.Exception.Message;
                errorMsg += "\n发生错误的程序集为:";
                errorMsg += e.Exception.Source;
                errorMsg += "\n发生错误的具体位置为:\n";
                errorMsg += e.Exception.StackTrace;
                errorMsg += "\n\n 请抓取此错误屏幕,并和V5软件联系!";
                MessageBox.Show(errorMsg, "运行时错误--V5软件", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch {
                MessageBox.Show("系统运行时发生致命错误!\n请保存好相关数据,重启系统。", "致命错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
