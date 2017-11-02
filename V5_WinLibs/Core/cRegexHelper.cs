using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace V5_WinLibs.Core {
    /// <summary>
    /// 
    /// </summary>
    public class cRegexHelper {
        /// <summary>
        /// href链接
        /// </summary>
        public static string RegexATag = @"<a[^<>]*?hrefs*=s*[,""s]([^"",]*)[,""][^<>]*?>(.*?)</a>";
        /// <summary>
        /// 匹配移动手机号
        /// </summary>
        public const string PATTERN_CMCMOBILENUM = @" ^ 1(3[4-9]|5[012789]|8[78])\d{8}$";
        /// <summary>
        /// 匹配电信手机号
        /// </summary>
        public const string PATTERN_CTCMOBILENUM = @"^18[09]\d{8}$";
        /// <summary>
        /// 匹配联通手机号
        /// </summary>
        public const string PATTERN_CUTMOBILENUM = @"^1(3[0-2]|5[56]|8[56])\d{8}$";
        /// <summary>
        /// 是否为手机号
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsMobile(string val) {
            return Regex.IsMatch(val, @"^1[358]\d{9}$", RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// 判断手机类型 0未知1移动2联通3电信
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int CheckMobileType(string val) {
            int type = 0;
            if (Regex.IsMatch(val, PATTERN_CMCMOBILENUM, RegexOptions.IgnoreCase))
                return 1;
            if (Regex.IsMatch(val, PATTERN_CUTMOBILENUM, RegexOptions.IgnoreCase))
                return 2;
            if (Regex.IsMatch(val, PATTERN_CTCMOBILENUM, RegexOptions.IgnoreCase))
                return 3;
            return type;
        }



        public static string ParseTags(string HTMLStr) {
            return Regex.Replace(HTMLStr, "<[^>]*>", "");
        }
    }
}
