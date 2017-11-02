using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace V5_WinLibs.Core {
    /// <summary>
    /// 伪原创Helper
    /// </summary>
    public class cFalseOriginalHelper {
        /// <summary>
        /// 加载伪原创词
        /// </summary>
        /// <returns></returns>
        public static IDictionary<string, string> FalseOriginalWords() {
            return FalseOriginalWords("\\System\\ReplaceWords.txt");
        }
        /// <summary>
        /// 加载伪原创词
        /// </summary>
        public static IDictionary<string, string> FalseOriginalWords(string filePath) {
            Dictionary<string, string> ret = new Dictionary<string, string>();
            string rootPath = AppDomain.CurrentDomain.BaseDirectory + "";
            using (StreamReader sr =
                new StreamReader(rootPath + filePath, Encoding.Default)) {
                string temp;
                string[] ltemparr;
                while ((temp = sr.ReadLine()) != null) {
                    ltemparr = temp.Split(new string[] { "→" }, StringSplitOptions.None);
                    if (!ret.ContainsKey(ltemparr[0])) {
                        ret.Add(ltemparr[0], ltemparr[1]);
                    }
                }
            }
            return ret;
        }
        /// <summary>
        /// 内容伪原创
        /// </summary>
        /// <param name="strContent">内容</param>
        /// <param name="strOldStr">待替换的词</param>
        /// <param name="strNewStr">替换为的词</param>
        /// <param name="iReplaceNum">要替换的次数</param>
        /// <returns></returns>
        public static string FalseOriginalData(string strContent, string strOldStr, string strNewStr, int iReplaceNum) {
            string temp = "";
            if (iReplaceNum > FalseOriginalSearchNum(strContent, strOldStr)) {
                return strContent;
            }
            string[] sArray = Regex.Split(strContent, strOldStr, RegexOptions.IgnoreCase);
            for (int tt = 0; tt < sArray.Length; tt++) {
                if (tt == sArray.Length - 1)
                { temp += sArray[tt]; }
                else { temp += sArray[tt] + "|" + (tt + 1).ToString() + "||"; }
            }
            string lyg = "";
            for (int i = 0; i < iReplaceNum; i++) 
            {
                Random r = new Random();
                int j = r.Next(1, sArray.Length - 1);
                if (lyg.Contains("-" + j.ToString() + "+")) { i--; }
                else {
                    lyg += "-" + j.ToString() + "+"; 
                    temp = temp.Replace("|" + (j).ToString() + "||", strNewStr);
                }
            }
            for (int j = 0; j < sArray.Length; j++)
            { temp = temp.Replace("|" + (j + 1).ToString() + "||", strOldStr); }
            return temp;
        }
        /// <summary>
        /// 查找需要替换的个数
        /// </summary>
        private static int FalseOriginalSearchNum(string strContent, string strReplace) {
            int indexNum = 0;
            int replaceNum = 0;
            while (strContent.IndexOf(strReplace, indexNum) != -1) {
                indexNum = strContent.IndexOf(strReplace, indexNum) + strReplace.Length;
                replaceNum++;
            }
            return replaceNum;
        }
    }
}
