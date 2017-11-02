using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using V5_Utility.Core;
using V5_Utility;

namespace V5_DataPublish {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            {
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
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    frmSplash fromSplash = new frmSplash();
                    Application.Run(fromSplash);
                    if (fromSplash.IsShow) {
                        Application.Run(new frmMain());
                    }
                }
            }
        }
    }
}
