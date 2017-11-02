
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using V5_Utility.Core;
using V5_Utility;
using V5_Utility.Utility;
using V5_WinLibs.GetMainContent;

namespace V5_DataPublish._Class.BaiduHelper {
    /// <summary>
    /// 百度采集文章
    /// </summary>
    public class ThreadGetBaiduResultUtility {
        #region Properties
        public bool IsRunning { get; set; }
        public bool Enabled { get; set; }
        public bool Stopped { get; set; }
        #endregion
        private string _BaseDir = string.Empty;
        /// <summary>
        /// 基本目录
        /// </summary>
        public string BaseDir {
            get {
                if (!Directory.Exists(_BaseDir)) {
                    Directory.CreateDirectory(_BaseDir);
                }
                return _BaseDir;
            }
            set { _BaseDir = value; }
        }
        private string _KeyWord = string.Empty;

        public string KeyWord {
            get { return _KeyWord; }
            set { _KeyWord = value; }
        }
        private Queue<ModelBaiduNewsHelper> QueueUrl = new Queue<ModelBaiduNewsHelper>(100);
        private static Thread th;
        private static Thread[] threads;

        public void Start() {
            if (!this.Stopped) {
                th = new Thread(Run_LinkUrl);
                th.Start();
                th.Join(2000);
                //
                threads = new Thread[2];
                for (int i = 0; i < 2; i++) {
                    threads[i] = new Thread(Run_CollectionUrl);
                    threads[i].Start(i);
                    threads[i].Join(2000);
                }
            }
        }

        public void Stop() {
            this.Stopped = true;
            th.Abort();
            foreach (Thread t1 in threads) {
                t1.Abort();
            }
        }

        private void Run_LinkUrl(object args) {
            GetBaiduContent(this.KeyWord);
        }

        private void Run_CollectionUrl(object args) {
            while (true) {
                if (this.Stopped)
                    break;
                ModelBaiduNewsHelper model = new ModelBaiduNewsHelper();
                lock (QueueUrl) {
                    if (QueueUrl.Count > 0) {
                        model = QueueUrl.Dequeue();
                    }
                }
                if (model != null) {
                    GetBaiduUrlContent(model.Url);
                }
                Thread.Sleep(1000);
            }
        }

        private void GetBaiduContent(string keyword) {
            string lasttime = string.Empty;
            string keywordEncode = HttpUtility.UrlEncode(keyword, Encoding.GetEncoding("gb2312"));
            WebClient client = new WebClient();
            string lastTimeContent = ReadLastTimeFile(this.BaseDir);
            for (int i = 0; i < 100; i += 20) {
                string address = "http://news.baidu.com/ns?bt=0&et=0&si=&rn=20&tn=newsA&ie=gb2312&ct=0&word=" + keywordEncode + "&pn=" + i + "&cl=2";
                client.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)");
                client.Encoding = Encoding.GetEncoding("gb2312");
                string input = client.DownloadString(address);
                string hrefRegex = "<td class=\"text\" colspan=2><a href=\"([\\S\\s]*?)\"  mon=\".+?\" target=_blank><span><b>([\\S\\s]*?)</b></span></a>";
                foreach (Match match3 in Regex.Matches(input, hrefRegex)) {
                    string Url = match3.Groups[1].Value;
                    if (!string.IsNullOrEmpty(Url)) {
                        string lastList = keyword + " " + Url;
                        QueueUrl.Enqueue(new ModelBaiduNewsHelper {
                            Url = Url
                        });
                    }
                }
            }
        }



        private void GetBaiduUrlContent(string Url) {
            try {
                if (string.IsNullOrEmpty(Url)) {
                    return;
                }
                Log4Helper.Write(LogLevel.Debug, Url);
                string EnCodeName = string.Empty;
                string path = this.BaseDir;
                WebClient client = new WebClient {
                    Encoding = Encoding.GetEncoding("gbk")
                };
                client.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)");
                string input = client.DownloadString(Url);
                Match match = Regex.Match(input, "charset=\"?(.+?)\"");
                if (match.Success) {
                    EnCodeName = match.Groups[1].Value;
                }
                if (EnCodeName != "gbk") {
                    WebClient client2 = new WebClient {
                        Encoding = Encoding.GetEncoding(EnCodeName)
                    };
                    client2.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)");
                    string str8 = Url;
                    if (!str8.Contains("http://")) {
                        str8 = "http://" + str8;
                    }
                    input = client2.DownloadString(Url);
                }
                string titlePattern = "<title>(.+?)</title>";
                Match titleMatch = Regex.Match(input, titlePattern, RegexOptions.IgnoreCase);
                string Title = string.Empty;
                if (titleMatch.Success) {
                    Title = titleMatch.Groups[1].Value.Replace('\\', ' ').Replace('/', ' ').Replace(' ', ' ').Split(new char[] { '_' })[0].Split(new char[] { '-' })[0];
                }
                else {
                    return;
                }
                string Content = GetMainContentHelper.GetMainContent(input);
                if (Content.Length < 300) {
                    Log4Helper.Write(LogLevel.Error, "未能提取到正文线程号");
                    return;
                }
                Title = Title.Replace('\\', ' ').Replace('/', ' ').Split(new char[] { '_' })[0].Split(new char[] { '-' })[0];
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                string strHtml = ".html";
                Title = Title.Replace(".", "");
                Title = Title.Replace(",", "");
                Title = Title.Replace("、", "");
                Title = Title.Replace(" ", "");
                Title = Title.Replace("*", "_");
                using (FileStream stream = new FileStream(path + @"\" + Title + strHtml, FileMode.Create)) {
                    StreamWriter writer2 = new StreamWriter(stream, Encoding.GetEncoding("utf-8"));
                    writer2.Write(Content);
                    writer2.Dispose();
                    client.Dispose();
                }
            }
            catch (Exception ex) {
                Log4Helper.Write(LogLevel.Error, ex);
            }
        }

        /// <summary>
        /// 读取最后采集文件记录
        /// </summary>
        private string ReadLastTimeFile(string currentDirectory) {
            string keywordtime = string.Empty;
            lock (this) {
                if (!System.IO.File.Exists(currentDirectory + @"\lasttime.txt")) {
                    System.IO.File.Create(currentDirectory + @"\lasttime.txt").Close();
                }
                FileStream stream = new FileStream(currentDirectory + @"\lasttime.txt", FileMode.Open);
                StreamReader reader = new StreamReader(stream, Encoding.Default);
                keywordtime = reader.ReadToEnd();
                reader.Dispose();
                stream.Dispose();
            }
            return keywordtime;
        }
        /// <summary>
        /// 创建最后采集文件记录
        /// </summary>
        private void CreateLastTimeFile(string currentDirectory, List<string> lasttime) {
            lock (this) {
                if (!System.IO.File.Exists(currentDirectory + @"\lasttime.txt")) {
                    System.IO.File.Create(currentDirectory + @"\lasttime.txt").Close();
                }
                FileStream stream2 = new FileStream(currentDirectory + @"\lasttime.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(stream2, Encoding.Default);
                foreach (string str5 in lasttime) {
                    writer.Write(str5 + "\r\n");
                }
                writer.Dispose();
                stream2.Dispose();
            }
        }

    }
}

