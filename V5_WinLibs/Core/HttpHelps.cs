/// <summary>
/// 类说明：HttpHelps类，用来实现Http访问，Post或者Get方式的，直接访问，带Cookie的，带证书的等方式，可以设置代理
/// 编码日期：2011-08-20
/// 编 码 人：  苏飞
/// 联系方式：361983679  Email：sufei.1013@163.com  Blogs:http://sufei.cnblogs.com
/// 修改日期：2011-12-30
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Compression;
namespace V5_WinLibs.Core {
    public class HttpHelps {
        #region 预定义方法或者变更

        public Encoding encoding = Encoding.Default;
        public HttpWebRequest request = null;
        private HttpWebResponse response = null;
        public Boolean isToLower = true;
        private StreamReader reader = null;
        private string returnData = "String Error";

        /// <summary>
        /// 根据相传入的数据，得到相应页面数据
        /// </summary>
        /// <param name="strPostdata">传入的数据Post方式,get方式传NUll或者空字符串都可以</param>
        /// <returns>string类型的响应数据</returns>
        private string GetHttpRequestData(string strPostdata) {
            try {
                request.AllowAutoRedirect = true;

                if (!string.IsNullOrEmpty(strPostdata) && request.Method.Trim().ToLower().Contains("post")) {
                    byte[] buffer = encoding.GetBytes(strPostdata);
                    request.ContentLength = buffer.Length;
                    request.GetRequestStream().Write(buffer, 0, buffer.Length);
                }

                ////最大连接数
                #region 得到请求的response

                using (response = (HttpWebResponse)request.GetResponse()) {
                    if (encoding == null) {
                        MemoryStream _stream = new MemoryStream();
                        if (response.ContentEncoding != null && response.ContentEncoding.Equals("gzip", StringComparison.InvariantCultureIgnoreCase)) {
                            _stream = GetMemoryStream(response.GetResponseStream());
                        }
                        else {
                            _stream = GetMemoryStream(response.GetResponseStream());
                        }
                        byte[] RawResponse = _stream.ToArray();
                        string temp = Encoding.Default.GetString(RawResponse, 0, RawResponse.Length);
                        Match meta = Regex.Match(temp, "<meta([^<]*)charset=([^<]*)[\"']", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        string charter = (meta.Groups.Count > 2) ? meta.Groups[2].Value : string.Empty;
                        charter = charter.Replace("\"", string.Empty).Replace("'", string.Empty).Replace(";", string.Empty);
                        if (charter.Length > 0) {
                            charter = charter.ToLower().Replace("iso-8859-1", "gbk");
                            encoding = Encoding.GetEncoding(charter);
                        }
                        else {
                            if (response.CharacterSet.ToLower().Trim() == "iso-8859-1") {
                                encoding = Encoding.GetEncoding("gbk");
                            }
                            else {
                                if (string.IsNullOrEmpty(response.CharacterSet.Trim())) {
                                    encoding = Encoding.UTF8;
                                }
                                else {
                                    encoding = Encoding.GetEncoding(response.CharacterSet);
                                }
                            }
                        }
                        returnData = encoding.GetString(RawResponse);
                    }
                    else {
                        if (response.ContentEncoding != null && response.ContentEncoding.Equals("gzip", StringComparison.InvariantCultureIgnoreCase)) {
                            using (reader = new StreamReader(new GZipStream(response.GetResponseStream(), CompressionMode.Decompress), encoding)) {
                                returnData = reader.ReadToEnd();
                            }
                        }
                        else {
                            using (reader = new StreamReader(response.GetResponseStream(), encoding)) {
                                returnData = reader.ReadToEnd();
                            }
                        }
                    }
                }

                #endregion
            }
            catch (WebException ex) {
                returnData = "String Error";
                response = (HttpWebResponse)ex.Response;
            }
            if (isToLower) {
                returnData = returnData.ToLower();
            }
            return returnData;
        }

        /// <summary>
        /// 4.0以下.net版本取水运
        /// </summary>
        /// <param name="streamResponse"></param>
        private static MemoryStream GetMemoryStream(Stream streamResponse) {
            MemoryStream _stream = new MemoryStream();
            int Length = 256;
            Byte[] buffer = new Byte[Length];
            int bytesRead = streamResponse.Read(buffer, 0, Length);
            while (bytesRead > 0) {
                _stream.Write(buffer, 0, bytesRead);
                bytesRead = streamResponse.Read(buffer, 0, Length);
            }
            return _stream;
        }

        /// <summary>
        /// 为请求准备参数
        /// </summary>
        /// <param name="_URL">请求的URL地址</param>
        /// <param name="_Method">请求方式Get或者Post</param>
        /// <param name="_Accept">Accept</param>
        /// <param name="_ContentType">ContentType返回类型</param>
        /// <param name="_UserAgent">UserAgent客户端的访问类型，包括浏览器版本和操作系统信息</param>
        /// <param name="_Encoding">读取数据时的编码方式</param>
        private void SetRequest(string _URL, string _Method, string _Accept, string _ContentType, string _UserAgent, Encoding _Encoding) {
            request = (HttpWebRequest)WebRequest.Create(GetUrl(_URL));
            request.Method = _Method;
            request.Accept = _Accept;
            request.ContentType = _ContentType;
            request.UserAgent = _UserAgent;
            encoding = _Encoding;
        }

        /// <summary>
        /// 设置当前访问使用的代理
        /// </summary>
        /// <param name="userName">代理 服务器用户名</param>
        /// <param name="passWord">代理 服务器密码</param>
        /// <param name="ip">代理 服务器地址</param>
        public void SetWebProxy(string userName, string passWord, string ip) {
            WebProxy myProxy = new WebProxy(ip, false);
            myProxy.Credentials = new NetworkCredential(userName, passWord);
            request.Proxy = myProxy;
            request.Credentials = CredentialCache.DefaultNetworkCredentials;
        }

        #endregion

        #region 普通类型
        /// <summary>    
        /// 传入一个正确或不正确的URl，返回正确的URL
        /// </summary>    
        /// <param name="URL">url</param>   
        /// <returns>
        /// </returns>    
        public static string GetUrl(string URL) {
            if (!(URL.Contains("http://") || URL.Contains("https://"))) {
                URL = "http://" + URL;
            }
            return URL;
        }

        /// <summary>
        /// 采用https协议GET|POST方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        /// </summary>
        /// <param name="_URL"></param>
        /// <param name="_Method">请求方式Get或者Post</param>
        /// <param name="_Accept">Accept</param>
        /// <param name="_ContentType">ContentType返回类型</param>
        /// <param name="_UserAgent">UserAgent客户端的访问类型，包括浏览器版本和操作系统信息</param>
        /// <param name="_Encoding">读取数据时的编码方式</param>
        /// <param name="_Postdata">只有_Method为Post方式时才需要传入值</param>
        /// <returns>返回Html源代码</returns>
        public string GetHttpRequestString(string _URL, string _Method, string _Accept, string _ContentType, string _UserAgent, Encoding _Encoding, string _Postdata) {
            SetRequest(_URL, _Method, _Accept, _ContentType, _UserAgent, _Encoding);
            return GetHttpRequestData(_Postdata);
        }

        ///<summary>
        ///采用https协议GET方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        ///</summary>
        ///<param name="URL">url地址</param>
        ///<param name="objencoding">编码方式例如：System.Text.Encoding.UTF8;</param>
        ///<returns>String类型的数据</returns>
        public string GetHttpRequestStringByNUll_Get(string URL, Encoding objencoding) {
            SetRequest(URL, "GET", "text/html, application/xhtml+xml, */*", "text/html", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)", objencoding);
            return GetHttpRequestData("");
        }

        ///<summary>
        ///采用https协议GET方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        ///</summary>
        ///<param name="URL">url地址</param>
        ///<param name="objencoding">编码方式例如：System.Text.Encoding.UTF8;</param>
        ///<param name="stgrcookie">Cookie字符串</param>
        ///<returns>String类型的数据</returns>
        public string GetHttpRequestStringByNUll_GetBycookie(string URL, Encoding objencoding, string stgrcookie) {
            SetRequest(URL, "GET", "text/html, application/xhtml+xml, */*", "text/html", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)", objencoding);
            request.Headers[HttpRequestHeader.Cookie] = stgrcookie;
            return GetHttpRequestData("");
        }

        ///<summary>
        ///采用https协议GET方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        ///</summary>
        ///<param name="URL">url地址</param>
        ///<param name="objencoding">编码方式例如：System.Text.Encoding.UTF8;</param>
        ///<returns>String类型的数据</returns>
        public string GetHttpRequestStringByNUll_Get(string URL, Encoding objencoding, string _Accept, string useragent) {
            SetRequest(URL, "GET", _Accept, "text/html", useragent, objencoding);
            return GetHttpRequestData("");
        }

        ///<summary>
        ///采用https协议Post方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        ///</summary>
        ///<param name="URL">url地址</param>
        ///<param name="strPostdata">Post发送的数据</param>
        ///<param name="objencoding">编码方式例如：System.Text.Encoding.UTF8;</param>
        ///<returns>String类型的数据</returns>
        public string GetHttpRequestStringByNUll_Post(string URL, string strPostdata, Encoding objencoding) {
            SetRequest(URL, "post", "text/html, application/xhtml+xml, */*,zh-CN", "text/html", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)", objencoding);
            return GetHttpRequestData(strPostdata);
        }

        #endregion
    }
}
