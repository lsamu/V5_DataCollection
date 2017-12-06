using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace V5_WinLibs.Utility {
    /// <summary>
    /// 日志帮助类
    /// </summary>
    public class LogHelper {
        private bool m_isWriteLog = true;  //是否写日志
        private String m_logFilePath = String.Empty;  //日志路径
        private String m_time;  //时间字符串
        /// <summary>
        /// 初始化日志文件名
        /// </summary>
        /// <param name="layerIndex"></param>
        /// <param name="logPath"></param>
        public void InitLog(String layerIndex, String logPath) {
            //日志写入路径
            if (!String.IsNullOrEmpty(logPath)) {
                //赋值时间字串
                m_time = GetTimeStr();
                if (!String.IsNullOrEmpty(logPath)) {
                    //路径不存在则创建一个
                    if (!Directory.Exists(logPath)) {
                        Directory.CreateDirectory(logPath);
                    }
                    //名字用实时的还是历史的
                    String logName = "_log_";

                    //这样组成一个文件路径
                    String filePath = logPath + "\\" + layerIndex + logName + m_time + ".txt";
                    //文件路径的地址
                    m_logFilePath = filePath;

                }
            }
        }
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="msg"></param>
        public void WriteLog(String msg) {
            try {
                lock (this) {
                    if (m_isWriteLog) {
                        if (!File.Exists(m_logFilePath)) {
                            using (FileStream fs = File.Create(m_logFilePath)) {
                                fs.Close();
                                fs.Dispose();
                            }
                        }
                        using (StreamWriter sw = File.AppendText(m_logFilePath)) {
                            sw.WriteLine("【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "】 " + msg);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// 获取时间格式
        /// </summary>
        /// <returns></returns>
        private String GetTimeStr() {
            return DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
        }

        static LogHelper log = new LogHelper();
        /// <summary>
        /// 输出日志文件
        /// </summary>
        /// <param name="logPath"></param>
        /// <param name="logContent"></param>
        public static void LogWrite(string logPath, string flag, string logContent) {
            log.InitLog(flag, logPath);
            log.WriteLog(logContent);
        }

        public static void LogWrite(string flag, string logContent) {
            string logPath = AppDomain.CurrentDomain.BaseDirectory + "logs";
            LogWrite(logPath, flag, logContent);
        }

        public static void LogWrite2(string logPath, string flag, string logContent) {
            string logPath2 = AppDomain.CurrentDomain.BaseDirectory + logPath;
            LogWrite(logPath2, flag, logContent);
        }
    }
}
