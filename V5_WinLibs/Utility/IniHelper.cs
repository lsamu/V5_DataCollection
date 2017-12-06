using System;

namespace V5_WinLibs.Utility {

    /// <summary>
    /// Ini文件操作类
    /// </summary>
    public sealed class IniHelper {
        private static string _filePath = string.Empty;//文件路径

        /// <summary>
        /// 文件路径
        /// </summary>
        public static string FilePath {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        /// Windows API 对INI文件写方法
        /// </summary>
        /// <param name="lpApplicationName">要在其中写入新字串的小节名称。这个字串不区分大小写</param>
        /// <param name="lpKeyName">要设置的项名或条目名。这个字串不区分大小写。用null可删除这个小节的所有设置项</param>
        /// <param name="lpString">指定为这个项写入的字串值。用null表示删除这个项现有的字串</param>
        /// <param name="lpFileName">初始化文件的名字。如果没有指定完整路径名，则windows会在windows目录查找文件。如果文件没有找到，则函数会创建它</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

        /// <summary>
        /// Windows API 对INI文件读方法
        /// </summary>
        /// <param name="lpApplicationName">欲在其中查找条目的小节名称。这个字串不区分大小写。如设为null，就在lpReturnedString缓冲区内装载这个ini文件所有小节的列表</param>
        /// <param name="lpKeyName">欲获取的项名或条目名。这个字串不区分大小写。如设为null，就在lpReturnedString缓冲区内装载指定小节所有项的列表</param>
        /// <param name="lpDefault">指定的条目没有找到时返回的默认值。可设为空（""）</param>
        /// <param name="lpReturnedString">指定一个字串缓冲区，长度至少为nSize</param>
        /// <param name="nSize">指定装载到lpReturnedString缓冲区的最大字符数量</param>
        /// <param name="lpFileName">初始化文件的名字。如没有指定一个完整路径名，windows就在Windows目录中查找文件</param>
        /// 注意：如lpKeyName参数为null，那么lpReturnedString缓冲区会载入指定小节所有设置项的一个列表。
        /// 每个项都用一个NULL字符分隔，最后一个项用两个NULL字符中止。也请参考GetPrivateProfileInt函数的注解
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, System.Text.StringBuilder lpReturnedString, int nSize, string lpFileName);

        /// <summary>
        /// 向Ini文件中写入值
        /// </summary>
        /// <param name="section">小节的名称</param>
        /// <param name="key">键的名称</param>
        /// <param name="value">键的值</param>
        /// <returns>执行成功为True，失败为False。</returns>
        public static long WriteIniKey(string section, string key, string value) {
            if (section.Trim().Length <= 0 || key.Trim().Length <= 0 ||
                value.Trim().Length <= 0) return 0;

            return WritePrivateProfileString(section, key, value, FilePath);
        }

        /// <summary>
        /// 删除指定小节中的键
        /// </summary>
        /// <param name="section">小节的名称</param>
        /// <param name="key">键的名称</param>
        /// <returns>执行成功为True，失败为False。</returns>
        public static long DeleteIniKey(string section, string key) {
            if (section.Trim().Length <= 0 || key.Trim().Length <= 0) return 0;

            return WritePrivateProfileString(section, key, null, FilePath);
        }

        /// <summary>
        /// 删除指定的小节（包括这个小节中所有的键）
        /// </summary>
        /// <param name="section">小节的名称</param>
        /// <returns>执行成功为True，失败为False。</returns>
        public static long DeleteIniSection(string section) {
            if (section.Trim().Length <= 0) return 0;

            return WritePrivateProfileString(section, null, null, FilePath);
        }

        /// <summary>
        /// 获得指定小节中键的值
        /// </summary>
        /// <param name="section">小节的名称</param>
        /// <param name="key">键的名称</param>
        /// <param name="defaultValue">如果键值为空，或没找到，返回指定的默认值。</param>
        /// <param name="capacity">缓冲区初始化大小。</param>
        /// <returns>键的值</returns>
        public static string GetIniKeyValue(string section, string key, string defaultValue, int capacity) {
            if (section.Trim().Length <= 0 || key.Trim().Length <= 0) return defaultValue;

            System.Text.StringBuilder strTemp = new System.Text.StringBuilder(capacity);
            long returnValue = GetPrivateProfileString(section, key, defaultValue, strTemp, capacity, FilePath);

            return strTemp.ToString().Trim();
        }

        /// <summary>
        /// 获得指定小节中键的值
        /// </summary>
        /// <param name="section">小节的名称</param>
        /// <param name="key">键的名称</param>
        /// <param name="defaultValue">如果键值为空，或没找到，返回指定的默认值。</param>
        /// <returns>键的值</returns>
        public static string GetIniKeyValue(string section, string key, string defaultValue) {
            return GetIniKeyValue(section, key, defaultValue, 1024);
        }

        /// <summary>
        /// 获得指定小节中键的值
        /// </summary>
        /// <param name="section">小节的名称</param>
        /// <param name="key">键的名称</param>
        /// <returns>键的值</returns>
        public static string GetIniKeyValue(string section, string key) {
            return GetIniKeyValue(section, key, string.Empty, 1024);
        }
    }
}