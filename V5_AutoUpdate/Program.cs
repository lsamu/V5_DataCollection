using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace V5.AutoUpdate {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            //// 合并命令行参数
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmUpdate());
        }
    }
}
