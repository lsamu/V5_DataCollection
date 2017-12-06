using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_WinLibs.Core;

namespace V5_DataCollection._Class.Common {
    public class CommonHelper {

        public static frmMain FormMain = null;
        public static string SQLiteConnectionStringPublishLog = "System\\V5_DataPublishLog.db";
        public static string SQLiteConnectionString = "System\\V5.DataCollection.db";
        /// <summary>
        /// 替换标签内容
        /// </summary>
        /// <param name="regexContent"></param>
        public static string ReplaceSystemRegexTag(string regexContent) {
            regexContent = regexContent.Replace("\\(\\*)", ".+?");
            regexContent = regexContent.Replace("\\[参数]", "([\\S\\s]*?)");
            return regexContent;
        }
        /// <summary>
        /// 采集网页
        /// </summary>
        /// <param name="url"></param>
        /// <param name="pageEncode"></param>
        /// <returns></returns>
        public static string getPageContent(string url, string pageEncode) {
            var http = new HttpHelper4();
            var httpItem = new HttpItem() {
                URL = url,
                Method = "GET"
            };
            if (pageEncode != "自动编码") {
                httpItem.Encoding = Encoding.GetEncoding(pageEncode);
            }
            var httpResult = http.GetHtml(httpItem);
            return httpResult.Html == "本次请求并未返回任何数据" ? string.Empty : httpResult.Html;
        }
    }
}
