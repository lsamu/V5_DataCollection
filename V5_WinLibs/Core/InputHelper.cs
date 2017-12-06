using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace V5_AllFrameWorkTools._Class
{
    public class InputHelper
    {
        public static string SetString(object o)
        {
            return Convert.ToString("" + o);
        }

        public static int SetNumber(object o)
        {
            return Convert.ToInt32("0" + o);
        }

        /// <summary>           
        /// 得到字符串的长度，一个汉字算3个字符           
        /// </summary>           
        /// <param name="str">字符串</param>           
        /// <returns>返回字符串长度</returns>           
        public static int GetLength(string str)
        {
            if (str.Length == 0) return 0;
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            byte[] s = ascii.GetBytes(str);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 3;
                }
                else
                {
                    tempLen += 1;
                }
            }
            return tempLen;
        }

        /// <summary>
        /// md5加密方式
        /// </summary>
        /// <param name="str">原字符串</param>
        /// <param name="code">16，32 位</param>
        /// <returns>加密后的字符串</returns>
        public static string MD5(string str, int code)
        {
            if (code == 16)
            {
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5").ToLower().Substring(8, 16);
            }
            if (code == 32)
            {
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5").ToUpper();
            }
            return str;
        }

        /// <summary>
        ///SQL注入过滤
        /// </summary>
        /// <param name="InText">要过滤的字符串</param>
        /// <returns>如果参数存在不安全字符，则返回true</returns>
        public static bool SqlFilter(string InText)
        {
            string word = "and|exec|insert|select|delete|update|chr|mid|master|or|truncate|char|declare|join";
            if (InText == null)
                return false;
            foreach (string i in word.Split('|'))
            {
                if ((InText.ToLower().IndexOf(i + " ") > -1) || (InText.ToLower().IndexOf(" " + i) > -1))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// SQL注入过滤
        /// </summary>
        /// <param name="InText"></param>
        /// <returns></returns>
        public static string SqlFilterString(string InText)
        {
            string word = "'|and |exec |insert |select |delete |update |count |% |chr |mid |master |truncate |char |declare ";
            string newWord = "|ａｎｄ　|ｅｘｅｃ　|ｉｎｓｅｒｔ　|ｓｅｌｅｃｔ　|ｄｅｌｅｔｅ　|ｕｐｄａｔｅ　|ｃｏｕｎｔ　|％　|ｃｈｒ　|ｍｉｄ　|ｍａｓｔｅｒ　|ｔｒｕｎｃａｔｅ　|ｃｈａｒ　|ｄｅｃｌａｒｅ　";
            string[] wArr = word.Split('|');
            string[] nArr = newWord.Split('|');
            for (int i = 0; i < wArr.Length; i++)
            {
                InText = Regex.Replace(InText, wArr[i], nArr[i], RegexOptions.IgnoreCase);
            }
            InText = InText.Replace("*", "＊");
            return InText;
        }
    }
}
