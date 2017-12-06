using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace V5_WinLibs.Core {
    public class User32Helper {
        /// <summary>
        /// 获取窗口标题
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpString"></param>
        /// <param name="nMaxCount"></param>
        /// <returns></returns>
        [DllImport("user32", SetLastError = true)]
        public static extern int GetWindowText(
        IntPtr hWnd, 
        StringBuilder lpString, 
        int nMaxCount  
        );
        /// <summary>
        /// 获取类的名字
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpString"></param>
        /// <param name="nMaxCount"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern int GetClassName(
            IntPtr hWnd, 
            StringBuilder lpString, 
            int nMaxCount 
        );
        /// <summary>
        /// 根据坐标获取窗口句柄
        /// </summary>
        /// <param name="Point"></param>
        /// <returns></returns>
        [DllImport("user32")]
        private static extern IntPtr WindowFromPoint(
        Point Point  
        );
        /// <summary>
        /// 获取窗口句柄
        /// </summary>
        /// <param name="lpClassName">类名</param>
        /// <param name="lpWindowName">窗口名称</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        /// <summary>
        /// 获取控件句柄
        /// </summary>
        /// <param name="hwndParent"></param>
        /// <param name="hwndChildAfter"></param>
        /// <param name="lpszClass"></param>
        /// <param name="lpszWindow"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="wMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
    }
}
