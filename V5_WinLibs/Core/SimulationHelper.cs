using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace V5_WinLibs.Core {
    public class SimulationHelper {
        private static string cookieHeader = "";
        /// <summary>
        /// Cookies值
        /// </summary>
        public static string CookieHeader {
            get { return cookieHeader; }
            set { cookieHeader = value; }
        }
        /// <summary>
        /// Get获取页面的值
        /// </summary>
        /// <param name="strURL">访问地址</param>
        /// <param name="strReferer">来源网站或者地址</param>
        /// <param name="strPageCode">网站编码</param>
        /// <returns></returns>
        public static string GetPageContent(
            string strURL,
            string strReferer,
            string strPageCode,
            ref string cookieHeader) {
            string strResult = "";
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(strURL);
            Request.ContentType = "text/html";
            Request.Method = "GET";
            Request.Referer = strReferer;
            Request.Headers.Add("cookie:" + cookieHeader);
            HttpWebResponse Response = null;
            System.IO.StreamReader sr = null;
            Response = (HttpWebResponse)Request.GetResponse();
            Encoding defaultEncoding;
            if (strPageCode.Trim() == "")
                defaultEncoding = Encoding.Default;
            else
                defaultEncoding = Encoding.GetEncoding(strPageCode);
            sr = new System.IO.StreamReader(Response.GetResponseStream(), defaultEncoding);
            strResult = sr.ReadToEnd();

            Request.Abort();
            Response.Close();
            return strResult;
        }
        /// <summary>
        /// 获取页面
        /// </summary>
        /// <param name="strURL">页面地址</param>
        /// <param name="strReferer">引用地址</param>
        /// <param name="pageCode">编码</param>
        /// <returns></returns>
        public static string GetPage(
            string strURL,
            string strReferer,
            string strPageCode,
            ref string cookieHeader) {
            string strResult = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            request.ContentType = "text/html";
            request.Method = "GET";
            request.Referer = strReferer;
            if (string.IsNullOrEmpty(cookieHeader)) {
                request.Headers.Add("cookie:" + cookieHeader);
            }
            HttpWebResponse response = null;
            System.IO.StreamReader sr = null;
            response = (HttpWebResponse)request.GetResponse();
            sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.GetEncoding(strPageCode));
            strResult = sr.ReadToEnd();
            return strResult;
        }
        /// <summary>
        /// Post获取数据
        /// </summary>
        /// <param name="strURL"></param>
        /// <param name="strArgs"></param>
        /// <param name="strReferer"></param>
        /// <param name="strPageCode"></param>
        /// <returns></returns>
        public static string PostPage(
            string strURL,
            string strArgs,
            string strReferer,
            string strPageCode,
            ref string cookieHeader) {
            string strResult = "";

            Encoding enPageCode = Encoding.GetEncoding(strPageCode);
            byte[] paramByte = enPageCode.GetBytes(strArgs);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            request.AllowAutoRedirect = true;
            request.KeepAlive = true;
            request.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-silverlight, */*";
            request.Referer = strReferer;

            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; CIBA)";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            if (!string.IsNullOrEmpty(cookieHeader)) {
                request.Headers.Add("cookie:" + cookieHeader);
            }
            Stream MyRequestStrearm = request.GetRequestStream();
            MyRequestStrearm.Write(paramByte, 0, paramByte.Length);    
            MyRequestStrearm.Close();

            HttpWebResponse response = null;
            System.IO.StreamReader sr = null;
            response = (HttpWebResponse)request.GetResponse();
            sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.GetEncoding(strPageCode));
            strResult = sr.ReadToEnd();
            return strResult;
        }
        /// <summary>
        /// Post登陆 并记录Cookies
        /// </summary>
        /// <param name="strURL">地址</param>
        /// <param name="strArgs">参数</param>
        /// <param name="strReferer">引用地址</param>
        /// <param name="strPageCode">页面编码</param>
        /// <returns></returns>
        public static string PostLogin(string strURL,
            string strArgs,
            string strReferer,
            string strPageCode,
            ref string cookieHeader) {
            try {
                string strResult = "";

                Encoding enPageCode = Encoding.GetEncoding(strPageCode);
                byte[] paramByte = enPageCode.GetBytes(strArgs);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                request.AllowAutoRedirect = true;
                request.KeepAlive = true;
                request.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/msword, application/x-shockwave-flash, */*";
                request.Referer = strReferer;

                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 2.0.50727)";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "POST";

                #region
                CookieCollection myCookies = null;
                CookieContainer myCookieContainer = new CookieContainer();
                request.CookieContainer = myCookieContainer;
                #endregion

                Stream MyRequestStrearm = request.GetRequestStream();
                MyRequestStrearm.Write(paramByte, 0, paramByte.Length);    
                MyRequestStrearm.Close();

                HttpWebResponse response = null;
                System.IO.StreamReader sr = null;
                response = (HttpWebResponse)request.GetResponse();
                cookieHeader = request.CookieContainer.GetCookieHeader(new Uri(strURL));
                myCookies = response.Cookies;
                sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.GetEncoding(strPageCode));
                strResult = sr.ReadToEnd();
                return strResult;
            }
            catch (Exception) {
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取远程验证码 并记录Cookies
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Image PostImage(
            string url,
            ref string cookieHeader) {
            try {
                Uri myUri = new Uri(url);
                WebRequest webRequest = WebRequest.Create(myUri);
                WebResponse webResponse = webRequest.GetResponse();
                cookieHeader = webResponse.Headers["Set-Cookie"];

                Bitmap myImage = new Bitmap(webResponse.GetResponseStream());
                return (Image)myImage;
            }
            catch (Exception) {
            }
            return null;
        }



        /// <summary>
        /// 上传模拟发送数据
        /// </summary>
        /// <param name="strURL"></param>
        /// <param name="strArgs"></param>
        /// <param name="strReferer"></param>
        /// <param name="strPageCode"></param>
        /// <returns></returns>
        public static string Post_FormData(
            string strURL,
            string strArgs,
            string strReferer,
            string strPageCode) {
            string boundary = DateTime.Now.Ticks.ToString("x"); 
            WebRequest request = WebRequest.Create(strURL);
            request.Method = "POST";
            request.ContentType = "multipart/form-data; boundary=---------------------------" + boundary;
            if (CookieHeader.Trim() != "") {
                request.Headers.Add("cookie:" + CookieHeader);
            }

            if (string.IsNullOrEmpty(strPageCode))
                strPageCode = Encoding.Default.EncodingName;
            strArgs = strArgs.Replace("${boundary}", boundary);
            byte[] postFormData = Encoding.GetEncoding(strPageCode).GetBytes(strArgs);
            long length = postFormData.Length;
            request.ContentLength = length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postFormData, 0, postFormData.Length);
            requestStream.Close();
            ////文件内容 
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(strPageCode));
            string html = sr.ReadToEnd().Trim();
            sr.Close();
            if (response != null) {
                response.Close();
                response = null;
            }
            if (request != null) {
                request = null;
            }
            return html;
        }

        public static string Post_FormData(
          string strURL,
          string strArgs,
          string strReferer,
          string strPageCode,
            string boundaryType,
            string boundary) {
            WebRequest request = WebRequest.Create(strURL);
            request.Method = "POST";
            request.ContentType = "multipart/form-data; boundary=" + boundaryType;
            if (CookieHeader.Trim() != "") {
                request.Headers.Add("cookie:" + CookieHeader);
            }

            if (string.IsNullOrEmpty(strPageCode))
                strPageCode = Encoding.Default.EncodingName;
            strArgs = strArgs.Replace("${boundary}", boundary);
            byte[] postFormData = Encoding.GetEncoding(strPageCode).GetBytes(strArgs);
            long length = postFormData.Length;
            request.ContentLength = length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postFormData, 0, postFormData.Length);
            requestStream.Close();
            ////文件内容 
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(strPageCode));
            string html = sr.ReadToEnd().Trim();
            sr.Close();
            if (response != null) {
                response.Close();
                response = null;
            }
            if (request != null) {
                request = null;
            }
            return html;
        }
        /// <summary>
        /// 上传模拟登录
        /// </summary>
        /// <param name="strURL"></param>
        /// <param name="strArgs"></param>
        /// <param name="strReferer"></param>
        /// <param name="strPageCode"></param>
        /// <returns></returns>
        public static string Post_FormDataLogin(
            string strURL,
            string strArgs,
            string strReferer,
            string strPageCode) {
            string boundary = DateTime.Now.Ticks.ToString("x");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "POST";
            request.ContentType = "multipart/form-data; boundary=---------------------------" + boundary;

            CookieContainer myCookieContainer = new CookieContainer();
            request.CookieContainer = myCookieContainer;

            if (string.IsNullOrEmpty(strPageCode))
                strPageCode = Encoding.Default.EncodingName;
            strArgs = strArgs.Replace("${boundary}", boundary);
            byte[] postFormData = Encoding.GetEncoding(strPageCode).GetBytes(strArgs);
            long length = postFormData.Length;
            request.ContentLength = length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postFormData, 0, postFormData.Length);
            requestStream.Close();
            ////文件内容 
            WebResponse response = request.GetResponse();
            if (CookieHeader.Trim() == "") {
                CookieHeader = request.CookieContainer.GetCookieHeader(new Uri(strURL));
            }
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string html = sr.ReadToEnd().Trim();
            sr.Close();
            if (response != null) {
                response.Close();
                response = null;
            }
            if (request != null) {
                request = null;
            }
            return html;
        }


        /// <summary>
        /// 截取字符
        /// </summary>
        /// <param name="sStr">字符</param>
        /// <param name="Patrn">表达式</param>
        /// <returns></returns>
        public static string[] CutStr(string sStr, string Patrn) {
            string[] RsltAry;
            Regex tmpreg = new Regex(Patrn, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection sMC = tmpreg.Matches(sStr);
            if (sMC.Count != 0) {
                RsltAry = new string[sMC.Count];
                for (int i = 0; i < sMC.Count; i++) {
                    RsltAry[i] = sMC[i].Groups[1].Value;
                }
            }
            else {
                RsltAry = new string[1];
                RsltAry[0] = "";
            }
            return RsltAry;
        }

        /// <summary>
        /// 根据cookie字符串获取cookie对象
        /// </summary>
        /// <param name="cookies"></param>
        /// <returns></returns>
        public CookieContainer GetCookieContainer(string url, string cookies) {
            CookieContainer cc = new CookieContainer();
            string cookieStr = cookies;
            string[] cookstr = cookieStr.Split(';');
            foreach (string str in cookstr) {
                string[] cookieNameValue = str.Split('=');
                Cookie ck = new Cookie(cookieNameValue[0].Trim().ToString(), cookieNameValue[1].Trim().ToString());
                ck.Domain = url;
                cc.Add(ck);
            }
            return cc;
        }
    }
}
