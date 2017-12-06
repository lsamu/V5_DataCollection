using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace V5_Utility.Utility {
    /// <summary>
    /// 
    /// </summary>
    public enum LogLevel {
        Debug,
        Info,
        Warning,
        Error,
        Fatal
    }
    /// <summary>
    /// 
    /// </summary>
    public class Log4Helper {
        private static readonly ILog log;//= LogManager.GetLogger("V5.WinLibs");

        static Log4Helper() {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"Config/lognet4.config"));
            log = log4net.LogManager.GetLogger(System.Reflection.Assembly.GetExecutingAssembly(), "Application");
        }

        public static void Write(LogLevel level, string message) {
            Write(level, message, null, null);
        }

        public static void Write(LogLevel level, Exception e) {
            Write(level, null, null, e);
        }

        public static void Write(LogLevel level, string message, Exception e) {
            Write(level, message, null, e);
        }

        public static void Write(LogLevel level, string message, IDictionary<string, string> additionalInfo) {
            Write(level, message, additionalInfo);
        }

        public static void Write(LogLevel level, string message, IDictionary<string, string> additionalInfo, Exception e) {
            string formattedMessage;
            switch (level) {
                case LogLevel.Debug:
                    if (log.IsDebugEnabled) {
                        formattedMessage = FormatOutputMessage(message, additionalInfo);
                        log.Debug(formattedMessage, e);
                    }
                    break;
                case LogLevel.Info:
                    if (log.IsInfoEnabled) {
                        formattedMessage = FormatOutputMessage(message, additionalInfo);
                        log.Info(formattedMessage, e);
                    }
                    break;
                case LogLevel.Warning:
                    if (log.IsWarnEnabled) {
                        formattedMessage = FormatOutputMessage(message, additionalInfo);
                        log.Warn(formattedMessage, e);
                    }
                    break;
                case LogLevel.Error:
                    if (log.IsErrorEnabled) {
                        formattedMessage = FormatOutputMessage(message, additionalInfo);
                        log.Error(formattedMessage, e);
                    }
                    break;
                case LogLevel.Fatal:
                    if (log.IsFatalEnabled) {
                        formattedMessage = FormatOutputMessage(message, additionalInfo);
                        log.Fatal(formattedMessage, e);
                    }
                    break;
                default:
                    throw new ArgumentException(string.Format("type '{0}' not add to Write method", level));
            }
        }

        private static string FormatOutputMessage(string message, IDictionary<string, string> additionalInfo) {
            if (additionalInfo == null || additionalInfo.Count == 0)
                return message;

            System.Text.StringBuilder buffer = new System.Text.StringBuilder();
            if (!string.IsNullOrEmpty(message))
                buffer.AppendLine(message);
            foreach (KeyValuePair<string, string> kvp in additionalInfo)
                buffer.AppendLine(kvp.Key + " = " + kvp.Value);

            return buffer.ToString();
        }
    }
}
