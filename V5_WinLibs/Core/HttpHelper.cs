using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
namespace V5_WinLibs.Core {

    public class HttpHelper {
        #region 变量定义
        private static CookieContainer cc = new CookieContainer();
        private static string contentType = "application/x-www-form-urlencoded";
        private static string accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/x-silverlight, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, application/x-silverlight-2-b1, */*";
        private static string userAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
        private static Encoding encoding = Encoding.GetEncoding("utf-8");
        private static int delay = 1000;
        private static int maxTry = 300;
        private static int currentTry = 0;
        #endregion
        #region 变量赋值
        /// <summary> 
        /// Cookie
        /// </summary> 
        public static CookieContainer CookieContainer {
            get {
                return cc;
            }
        }

        /// <summary> 
        /// 语言
        /// </summary> 
        /// <value></value> 
        public static Encoding Encoding {
            get {
                return encoding;
            }
            set {
                encoding = value;
            }
        }

        public static int NetworkDelay {
            get {
                Random r = new Random();
                return (r.Next(delay, delay * 2));
            }
            set {
                delay = value;
            }
        }

        public static int MaxTry {
            get {
                return maxTry;
            }
            set {
                maxTry = value;
            }
        }
        #endregion

        #region 获取HTML
        /// <summary>
        /// 获取HTML
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="postData">post 提交的字符串</param>
        /// <param name="isPost">是否是post</param>
        /// <param name="cookieContainer">CookieContainer</param>
        /// <returns>html </returns>
        public static string GetHtml(string url, string postData, bool isPost, ref CookieContainer cookieContainer) {
            if (string.IsNullOrEmpty(postData)) {
                return GetHtml(url, ref cookieContainer);
            }

            Thread.Sleep(NetworkDelay);

            currentTry++;

            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;
            try {
                byte[] byteRequest = Encoding.Default.GetBytes(postData);

                httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.ServicePoint.ConnectionLimit = maxTry;
                httpWebRequest.Referer = url;
                httpWebRequest.Accept = accept;
                httpWebRequest.UserAgent = userAgent;
                httpWebRequest.Method = isPost ? "POST" : "GET";
                httpWebRequest.ContentLength = byteRequest.Length;

                Stream stream = httpWebRequest.GetRequestStream();
                stream.Write(byteRequest, 0, byteRequest.Length);
                stream.Close();

                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, encoding);
                string html = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();
                currentTry = 0;

                httpWebRequest.Abort();
                httpWebResponse.Close();

                return html;
            }
            catch (Exception e) {
                if (currentTry <= maxTry) {
                    GetHtml(url, postData, isPost, ref cookieContainer);
                }
                currentTry--;

                if (httpWebRequest != null) {
                    httpWebRequest.Abort();
                } if (httpWebResponse != null) {
                    httpWebResponse.Close();
                }
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取HTML
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="cookieContainer">CookieContainer</param>
        /// <returns>HTML</returns>
        public static string GetHtml(string url, ref CookieContainer cookieContainer) {
            Thread.Sleep(NetworkDelay);

            currentTry++;
            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;
            try {

                httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.ServicePoint.ConnectionLimit = maxTry;
                httpWebRequest.Referer = url;
                httpWebRequest.Accept = accept;
                httpWebRequest.UserAgent = userAgent;
                httpWebRequest.Method = "GET";

                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, encoding);
                string html = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();

                currentTry--;

                httpWebRequest.Abort();
                httpWebResponse.Close();

                return html;
            }
            catch (Exception e) {
                if (currentTry <= maxTry) {
                    GetHtml(url, ref cookieContainer);
                }

                currentTry--;

                if (httpWebRequest != null) {
                    httpWebRequest.Abort();
                } if (httpWebResponse != null) {
                    httpWebResponse.Close();
                }
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取HTML
        /// </summary>
        /// <param name="url">地址</param>
        /// <returns>HTML</returns>
        public static string GetHtml(string url) {
            return GetHtml(url, ref cc);
        }
        /// <summary>
        /// 获取HTML
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="postData">提交的字符串</param>
        /// <param name="isPost">是否是POST</param>
        /// <returns>HTML</returns>
        public static string GetHtml(string url, string postData, bool isPost) {
            return GetHtml(url, postData, isPost, ref cc);
        }
        /// <summary>
        /// 获取字符流
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="cookieContainer">cookieContainer</param>
        /// <returns>Stream</returns>
        public static Stream GetStream(string url, CookieContainer cookieContainer) {
            currentTry++;
            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;

            try {

                httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.ServicePoint.ConnectionLimit = maxTry;
                httpWebRequest.Referer = url;
                httpWebRequest.Accept = accept;
                httpWebRequest.UserAgent = userAgent;
                httpWebRequest.Method = "GET";

                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                currentTry--;

                return responseStream;
            }
            catch (Exception e) {
                if (currentTry <= maxTry) {
                    GetHtml(url, ref cookieContainer);
                }

                currentTry--;

                if (httpWebRequest != null) {
                    httpWebRequest.Abort();
                } if (httpWebResponse != null) {
                    httpWebResponse.Close();
                }
                return null;
            }
        }
        #endregion

        #region 上传获取Html
        public static string GetHtml(string url, string postData, bool isPost, bool isUpload, ref CookieContainer cookieContainer) {
            return string.Empty;
        }
        #endregion

    }
}
