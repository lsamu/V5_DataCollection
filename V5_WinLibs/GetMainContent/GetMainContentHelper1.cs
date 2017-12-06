
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
namespace V5_WinLibs.GetMainContent {
    /// <summary>
    /// 智能获取文章内容
    /// </summary>
    public class GetMainContentHelper1 {
        public static int CompareDinosByChineseLength(string x, string y) {
            if (x == null) {
                if (y == null) {
                    return 0;
                }
                return -1;
            }
            if (y == null) {
                return 1;
            }
            Regex regex = new Regex("[一-龥]");
            float num = ((float)regex.Matches(x).Count) / ((float)x.Length);
            float num2 = ((float)regex.Matches(y).Count) / ((float)y.Length);
            int num3 = num.CompareTo(num2);
            if (num3 != 0) {
                return num3;
            }
            return x.CompareTo(y);
        }
        /// <summary>
        /// 获取数据 自动编码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string getDataFromUrl(string url) {
            string input = string.Empty;
            string requestUriString = url;
            if (!requestUriString.Contains("http://")) {
                requestUriString = "http://" + requestUriString;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.AllowAutoRedirect = true;
            request.AllowWriteStreamBuffering = true;
            request.Referer = "";
            request.Timeout = 0x2710;
            request.UserAgent = "";
            HttpWebResponse response = null;
            try {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK) {
                    Encoding encoding;
                    int num;
                    string characterSet = response.CharacterSet;
                    if (characterSet != "") {
                        if (characterSet == "ISO-8859-1") {
                            characterSet = "gb2312";
                        }
                        encoding = Encoding.GetEncoding(characterSet);
                    }
                    else {
                        encoding = Encoding.Default;
                    }
                    Stream responseStream = response.GetResponseStream();
                    MemoryStream stream = new MemoryStream();
                    byte[] buffer = new byte[0xff];
                    for (num = responseStream.Read(buffer, 0, 0xff); num > 0; num = responseStream.Read(buffer, 0, 0xff)) {
                        stream.Write(buffer, 0, num);
                    }
                    responseStream.Close();
                    stream.Seek(0L, SeekOrigin.Begin);
                    StreamReader reader = new StreamReader(stream, encoding);
                    char[] chArray = new char[0x400];
                    for (num = reader.Read(chArray, 0, 0x400); num > 0; num = reader.Read(chArray, 0, 0x400)) {
                        input = input + new string(chArray, 0, num);
                    }
                    MatchCollection matchs = new Regex("<meta[\\s\\S]+?charset=(.*)\"[\\s\\S]+?>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Matches(input);
                    if (matchs.Count > 0) {
                        string strA = matchs[0].Result("$1");
                        if (string.Compare(strA, characterSet, true) != 0) {
                            encoding = Encoding.GetEncoding(strA);
                            input = string.Empty;
                            stream.Seek(0L, SeekOrigin.Begin);
                            reader = new StreamReader(stream, encoding);
                            chArray = new char[0xff];
                            for (num = reader.Read(chArray, 0, 0xff); num > 0; num = reader.Read(chArray, 0, 0xff)) {
                                input = input + new string(chArray, 0, num);
                            }
                        }
                    }
                    reader.Close();
                    stream.Close();
                }
                return input;
            }
            catch (Exception exception) {
                Trace.TraceError(exception.ToString());
            }
            finally {
                if (response != null) {
                    response.Close();
                }
            }
            return input;
        }
        /// <summary>
        /// 智能获取文章内容
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <param name="Domain">访问域名地址</param>
        /// <param name="tag">标签</param>
        /// <param name="tagurl">标签地址</param>
        /// <param name="inserttag">插入标签</param>
        /// <param name="original">是否伪原创</param>
        /// <param name="keyword">关键词</param>
        /// <param name="isNoHtml">是否过滤html</param>
        /// <returns></returns>
        public static string GetMainContent(string input) {
            try {
                string pattern = "<(p|br)[^<]*>";
                string str2 = "(\\[([^=]*)(=[^\\]]*)?\\][\\s\\S]*?\\[/\\1\\])|(?<lj>(?=[^\\u4E00-\\u9FA5\\uFE30-\\uFFA0,.\");])<a\\s+[^>]*>[^<]{2,}</a>(?=[^\\u4E00-\\u9FA5\\uFE30-\\uFFA0,.\");]))|(?<Style><style[\\s\\S]+?/style>)|(?<select><select[\\s\\S]+?/select>)|(?<Script><script[\\s\\S]*?/script>)|(?<Explein><\\!\\-\\-[\\s\\S]*?\\-\\->)|(?<li><li(\\s+[^>]+)?>[\\s\\S]*?/li>)|(?<Html></?\\s*[^> ]+(\\s*[^=>]+?=['\"]?[^\"']+?['\"]?)*?[^\\[<]*>)|(?<Other>&[a-zA-Z]+;)|(?<Other2>\\#[a-z0-9]{6})|(?<Space>\\s+)|(\\&\\#\\d+\\;)";
                List<string> tags = GetTags(input, "div");
                List<string> list2 = new List<string>();
                foreach (string str3 in tags) {
                    Regex regex = new Regex("[一-龥]");
                    if (regex.Matches(str3).Count < 300) {
                        list2.Add(str3);
                    }
                }
                foreach (string str4 in list2) {
                    tags.Remove(str4);
                }
                List<string> collection = GetTags(input, "td");
                List<string> list4 = new List<string>();
                foreach (string str5 in collection) {
                    Regex regex2 = new Regex("[一-龥]");
                    if (regex2.Matches(str5).Count < 300) {
                        list4.Add(str5);
                    }
                }
                foreach (string str6 in list4) {
                    collection.Remove(str6);
                }
                tags.AddRange(collection);
                tags.Sort(new Comparison<string>(GetMainContentHelper.CompareDinosByChineseLength));
                if (tags.Count < 1) {
                    return "";
                }
                input = tags[tags.Count - 1];
                input = new Regex(pattern, RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "[$1]");
                input = new Regex("<img[\\s\\S]+?src=\"(.+?)\"[\\s\\S]+?>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "[$1]");
                input = new Regex(@"\[p]", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "<br>　　");
                input = new Regex(@"\[br]", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "<br>");
                input = new Regex(@"\[([http|www].+?\.jpg|png|gif|gpeg)\]", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "<br/><img src=\"$1\"/><br/>");
                input = new Regex(@"\[[\s\S]*\]", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(input, "");
                return input;

            }
            catch (Exception ex) {
                return ex.Message + "==" + ex.Source;
            }
        }
        /// <summary>
        /// 获取标签
        /// </summary>
        /// <param name="input"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static List<string> GetTags(string input, string tag) {
            StringReader reader = new StringReader(input);
            int num = 0;
            int startIndex = 0;
            Stack<int> stack = new Stack<int>();
            List<string> list = new List<string>();
            int num3 = 0;
        Label_001B: ;
            try {
                int num4 = reader.Read();
                if (num4 == -1) {
                    return list;
                }
                char ch = Convert.ToChar(num4);
                if ((num > 0) && (ch == '>')) {
                    num--;
                    string str = input.Substring(startIndex, (num3 - startIndex) + 1);
                    if (str.StartsWith(string.Format("<{0}", tag), StringComparison.OrdinalIgnoreCase)) {
                        stack.Push(startIndex);
                    }
                    if (str.StartsWith(string.Format("</{0}", tag), StringComparison.OrdinalIgnoreCase)) {
                        if (stack.Count < 1) {
                            goto Label_001B;
                        }
                        int num5 = stack.Pop();
                        string item = input.Substring(num5, (num3 - num5) + 1);
                        list.Add(item);
                    }
                }
                if (ch == '<') {
                    num++;
                    startIndex = num3;
                }
                goto Label_001B;
            }
            finally {
                num3++;
            }
            return list;
        }
    }
}

