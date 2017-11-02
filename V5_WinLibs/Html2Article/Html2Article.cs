using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace V5_WinLibs.Html2Article {
    /// <summary>
    /// 文章正文数据模型
    /// </summary>
    public class Article {
        public string Title { get; set; }
        /// <summary>
        /// 正文文本
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 带标签正文
        /// </summary>
        public string ContentWithTags { get; set; }
        public DateTime PublishDate { get; set; }
    }

    /// <summary>
    /// 解析Html页面的文章正文内容,基于文本密度的HTML正文提取类
    /// Date:   2012/12/30
    /// Update: 
    ///     2013/7/10   优化文章头部分析算法，优化
    ///         
    /// </summary>
    public class Html2Article {
        #region 参数设置

        private static readonly string[][] _filters = new string[][]{
                new string[] { @"(?is)<script.*?>.*?</script>", "" },
                new string[] { @"(?is)<style.*?>.*?</style>", "" },
                new string[] { @"(?is)</a>", "</a>\n"}
            };

        private static bool _appendMode = false;
        /// <summary>
        /// 是否使用追加模式，默认为false
        /// 使用追加模式后，会将符合过滤条件的所有文本提取出来
        /// </summary>
        public static bool AppendMode {
            get { return _appendMode; }
            set { _appendMode = value; }
        }

        private static int _depth = 6;
        /// <summary>
        /// 按行分析的深度，默认为6
        /// </summary>
        public static int Depth {
            get { return _depth; }
            set { _depth = value; }
        }

        private static int _limitCount = 180;
        /// <summary>
        /// 字符限定数，当分析的文本数量达到限定数则认为进入正文内容
        /// 默认180个字符数
        /// </summary>
        public static int LimitCount {
            get { return _limitCount; }
            set { _limitCount = value; }
        }

        private static int _headEmptyLines = 2;
        private static int _endLimitCharCount = 20;

        #endregion

        /// <summary>
        /// 从给定的Html原始文本中获取正文信息
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static Article GetArticle(string html) {
            if (html.Count(c => c == '\n') < 10) {
                html = html.Replace(">", ">\n");
            }

            string body = "";
            string bodyFilter = @"(?is)<body.*?</body>";
            Match m = Regex.Match(html, bodyFilter);
            if (m.Success) {
                body = m.ToString();
            }
            foreach (var filter in Html2Article._filters) {
                body = Regex.Replace(body, filter[0], filter[1]);
            }
            body = Regex.Replace(body, @"(<[^<>]+)\s*\n\s*", FormatTag);

            string content;
            string contentWithTags;
            GetContent(body, out content, out contentWithTags);

            Article article = new Article {
                Title = GetTitle(html),
                PublishDate = GetPublishDate(html),
                Content = content,
                ContentWithTags = contentWithTags
            };

            return article;
        }

        /// <summary>
        /// 格式化标签，剔除匹配标签中的回车符
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        private static string FormatTag(Match match) {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in match.Value) {
                if (ch == '\r' || ch == '\n') {
                    continue;
                }
                sb.Append(ch);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取时间
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        private static string GetTitle(string html) {
            string titleFilter = @"<title>[\s\S]*?</title>";
            string h1Filter = @"<h1.*?>.*?</h1>";
            string clearFilter = @"<.*?>";

            string title = "";
            Match match = Regex.Match(html, titleFilter, RegexOptions.IgnoreCase);
            if (match.Success) {
                title = Regex.Replace(match.Groups[0].Value, clearFilter, "");
            }

            match = Regex.Match(html, h1Filter, RegexOptions.IgnoreCase);
            if (match.Success) {
                string h1 = Regex.Replace(match.Groups[0].Value, clearFilter, "");
                if (!String.IsNullOrEmpty(h1) && title.StartsWith(h1)) {
                    title = h1;
                }
            }
            return title;
        }

        /// <summary>
        /// 获取文章发布日期
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        private static DateTime GetPublishDate(string html) {
            string text = Regex.Replace(html, "(?is)<.*?>", "");
            Match match = Regex.Match(
                text,
                @"((\d{4}|\d{2})(\-|\/)\d{1,2}\3\d{1,2})(\s?\d{2}:\d{2})?|(\d{4}年\d{1,2}月\d{1,2}日)(\s?\d{2}:\d{2})?",
                RegexOptions.IgnoreCase);

            DateTime result = new DateTime(1900, 1, 1);
            if (match.Success) {
                try {
                    string dateStr = "";
                    for (int i = 0; i < match.Groups.Count; i++) {
                        dateStr = match.Groups[i].Value;
                        if (!String.IsNullOrEmpty(dateStr)) {
                            break;
                        }
                    }
                    if (dateStr.Contains("年")) {
                        StringBuilder sb = new StringBuilder();
                        foreach (var ch in dateStr) {
                            if (ch == '年' || ch == '月') {
                                sb.Append("/");
                                continue;
                            }
                            if (ch == '日') {
                                sb.Append(' ');
                                continue;
                            }
                            sb.Append(ch);
                        }
                        dateStr = sb.ToString();
                    }
                    result = Convert.ToDateTime(dateStr);
                }
                catch (Exception) { }
                if (result.Year < 1900) {
                    result = new DateTime(1900, 1, 1);
                }
            }
            return result;
        }

        /// <summary>
        /// 从body标签文本中分析正文内容
        /// </summary>
        /// <param name="bodyText">只过滤了script和style标签的body文本内容</param>
        /// <param name="content">返回文本正文，不包含标签</param>
        /// <param name="contentWithTags">返回文本正文包含标签</param>
        private static void GetContent(string bodyText, out string content, out string contentWithTags) {
            string[] orgLines = null;    
            string[] lines = null;       

            orgLines = bodyText.Split('\n');
            lines = new string[orgLines.Length];
            for (int i = 0; i < orgLines.Length; i++) {
                string lineInfo = orgLines[i];
                lineInfo = Regex.Replace(lineInfo, "(?is)</p>|<br.*?/>", "[crlf]");
                lines[i] = Regex.Replace(lineInfo, "(?is)<.*?>", "").Trim();
            }

            StringBuilder sb = new StringBuilder();
            StringBuilder orgSb = new StringBuilder();

            int preTextLen = 0;          
            int startPos = -1;           
            for (int i = 0; i < lines.Length - _depth; i++) {
                int len = 0;
                for (int j = 0; j < _depth; j++) {
                    len += lines[i + j].Length;
                }

                if (startPos == -1)      
                {
                    if (preTextLen > _limitCount && len > 0)     
                    {
                        int emptyCount = 0;
                        for (int j = i - 1; j > 0; j--) {
                            if (String.IsNullOrEmpty(lines[j])) {
                                emptyCount++;
                            }
                            else {
                                emptyCount = 0;
                            }
                            if (emptyCount == _headEmptyLines) {
                                startPos = j + _headEmptyLines;
                                break;
                            }
                        }
                        if (startPos == -1) {
                            startPos = i;
                        }
                        for (int j = startPos; j <= i; j++) {
                            sb.Append(lines[j]);
                            orgSb.Append(orgLines[j]);
                        }
                    }
                }
                else {
                    if (len <= _endLimitCharCount && preTextLen < _endLimitCharCount)     
                    {
                        if (!_appendMode) {
                            break;
                        }
                        startPos = -1;
                    }
                    sb.Append(lines[i]);
                    orgSb.Append(orgLines[i]);
                }
                preTextLen = len;
            }

            string result = sb.ToString();
            content = result.Replace("[crlf]", Environment.NewLine);
            content = System.Web.HttpUtility.HtmlDecode(content);
            contentWithTags = orgSb.ToString();
        }
    }
}
