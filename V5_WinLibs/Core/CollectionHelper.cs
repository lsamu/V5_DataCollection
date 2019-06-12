using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Collections;
using System.Drawing;

namespace V5_WinLibs.Core {
    /// <summary>
    /// 采集分类
    /// </summary>
    public class CollectionHelper {

        #region
        /// <summary>
        /// 重写WebClient
        /// </summary>
        public class EaspWebClient : WebClient {
            private int _timeOut = 10;
            /// <summary>
            /// 过期时间
            /// </summary>
            public int Timeout {
                get {
                    return _timeOut;
                }
                set {
                    if (value <= 0)
                        _timeOut = 10;
                    _timeOut = value;
                }
            }
            /// <summary>
            /// 重写GetWebRequest,添加WebRequest对象超时时间
            /// </summary>
            /// <param name="address"></param>
            /// <returns></returns>
            protected override WebRequest GetWebRequest(Uri address) {
                HttpWebRequest request = (HttpWebRequest)base.GetWebRequest(address);
                request.Timeout = 1000 * Timeout;
                request.ReadWriteTimeout = 1000 * Timeout;
                return request;
            }
        }
        #endregion

        private static readonly CollectionHelper m_Instance = new CollectionHelper();
        /// <summary>
        /// 
        /// </summary>
        public static CollectionHelper Instance {
            get { return m_Instance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public CollectionHelper() {

        }
        /// <summary>
        /// 得到页面的内容     $UrlIsFalse$    $GetFalse$
        /// </summary>
        /// <param name="url">地址 http://www.qbzw.com</param>
        /// <param name="timeout">返回超时 单位 毫秒</param>
        /// <param name="EnCodeType">编码 gb2312 等</param>
        /// <returns></returns>
        public string GetHttpPage(string url, int timeout, Encoding EnCodeType) {
            string strResult = string.Empty;
            if (url.Length < 10)
                return "$UrlIsFalse$";
            try {
                WebClient wc = new WebClient();
                wc.Credentials = CredentialCache.DefaultCredentials;
                wc.Encoding = EnCodeType;
                wc.Headers.Add("Content-Type", "text/xml");
                strResult = wc.DownloadString(url);
            }
            catch (Exception) {
                strResult = "$GetFalse$";
            }
            return strResult;
        }

        /// <summary>
        /// 自动获取网页内容  $UrlIsFalse$    $GetFalse$
        /// </summary>
        public string GetHttpPage(string url, int timeout) {
            string strResult = string.Empty;
            if (url.Length < 10)
                return "$UrlIsFalse$";
            try {
                WebClient wc = new WebClient();
                wc.Credentials = CredentialCache.DefaultCredentials;
                byte[] myDataBuffer = wc.DownloadData(url);
                string strWebData = Encoding.Default.GetString(myDataBuffer);
                Match charSetMatch = Regex.Match(strWebData, "<meta([^<]*)charset=([^<]*)\"", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                string webCharSet = charSetMatch.Groups[2].Value;
                webCharSet = webCharSet.Replace("\"", "");
                strWebData = Encoding.GetEncoding(webCharSet).GetString(myDataBuffer);
                strResult = strWebData;
            }
            catch (Exception ex) {
                strResult = "$GetFalse$";
            }
            return strResult;
        }

        /// <summary>
        /// 得到页面的内容 url错误$UrlIsFalse$ 获取错误$GetFalse$
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeout"></param>
        /// <param name="EnCodeType"></param>
        /// <returns></returns>
        public string GetHttpPage(string url, int timeout, string EnCodeType) {
            string strResult = string.Empty;
            if (url.Length < 10)
                return "$UrlIsFalse$";
            try {
                EaspWebClient MyWebClient = new EaspWebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;
                MyWebClient.Encoding = Encoding.GetEncoding(EnCodeType);
                MyWebClient.Timeout = timeout;
                strResult = MyWebClient.DownloadString(url);
            }
            catch (Exception ex) {

                strResult = "$GetFalse$_" + ex.Message;
            }
            return strResult;
        }

        /// <summary>
        /// 获取内容
        /// </summary>
        /// <param name="pageStr">截取的字符串</param>
        /// <param name="strStart">开始字符</param>
        /// <param name="strEnd">结束字符</param>
        /// <param name="inStart">是否包含开始字符</param>
        /// <param name="inEnd">是否包含结束字符</param>
        /// <returns>返回匹配的字符串</returns>
        public string GetBody(string pageStr, string strStart, string strEnd, bool inStart, bool inEnd) {
            pageStr = pageStr.Trim();
            int start = pageStr.IndexOf(strStart);
            if (strStart.Length == 0 || start < 0)
                return "$StartFalse$";
            pageStr = pageStr.Substring(start + strStart.Length, pageStr.Length - start - strStart.Length);
            int end = pageStr.IndexOf(strEnd);
            if (strEnd.Length == 0 || end < 0)
                return "$EndFalse$";
            string strResult = pageStr.Substring(0, end);
            if (inStart)
                strResult = strStart + strResult;
            if (inEnd)
                strResult += strEnd;
            return strResult.Trim();
        }

        /// <summary>
        /// 截取字符
        /// </summary>
        /// <param name="sStr">字符</param>
        /// <param name="Patrn">表达式</param>
        /// <returns></returns>
        public string[] CutStr(string sStr, string Patrn) {
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
        /// 格式化地址
        /// </summary>
        /// <param name="BaseUrl"></param>
        /// <param name="theUrl"></param>
        /// <returns></returns>
        public string FormatUrl(string BaseUrl, string theUrl) {
            if (string.IsNullOrEmpty(BaseUrl)) {
                return theUrl;
            }
            int pathLevel = 0;
            string hostName;
            //20190526 如果转小写将导致某些区分大小写的网址无法访问
            //theUrl = theUrl.ToLower();
            hostName = BaseUrl.Substring(0, BaseUrl.IndexOf("/", 8));
            BaseUrl = BaseUrl.Substring(0, BaseUrl.LastIndexOf("/"));
            if (theUrl.StartsWith("./")) {
                theUrl = theUrl.Remove(0, 1);
                theUrl = BaseUrl + theUrl;
            }
            else if (theUrl.StartsWith("/")) {
                theUrl = hostName + theUrl;
            }
            else if (theUrl.StartsWith("../")) {
                while (theUrl.StartsWith("../")) {
                    pathLevel = ++pathLevel;
                    theUrl = theUrl.Remove(0, 3);
                }
                for (int i = 0; i < pathLevel; i++) {
                    BaseUrl = BaseUrl.Substring(0, BaseUrl.LastIndexOf("/", BaseUrl.Length - 2));
                }
                theUrl = BaseUrl + "/" + theUrl;
            }
            //20190526 纠正上述问题
            var lowerUrl = theUrl.ToLower();
           
            if (!lowerUrl.StartsWith("http://") && !lowerUrl.StartsWith("https://")) {
                theUrl = BaseUrl + "/" + theUrl;
            }
            return theUrl;
        }

        /// <summary>
        /// 获取连接
        /// </summary>
        /// <param name="pageStr">截取的字符串</param>
        /// <param name="strStart">开始字符串</param>
        /// <param name="strEnd">结束字符串</param>
        /// <returns>匹配导的所有连接 ArrayList类型</returns>
        public ArrayList GetArray(string pageStr, string strStart, string strEnd) {
            ArrayList linkArray = new ArrayList();
            int start = pageStr.IndexOf(strStart);
            if (strStart.Length == 0 || start < 0) {
                linkArray.Add("$StartFalse$");
                return linkArray;
            }
            int end = pageStr.IndexOf(strEnd);
            if (strEnd.Length == 0 || end < 0) {
                linkArray.Add("$EndFalse$");
                return linkArray;
            }
            Regex myRegex = new Regex(@"(" + strStart + ").+?(" + strEnd + ")", RegexOptions.IgnoreCase);
            MatchCollection matches = myRegex.Matches(pageStr);
            foreach (Match match in matches)
                linkArray.Add(match.ToString());
            if (linkArray.Count == 0) {
                linkArray.Add("$NoneLink$");
                return linkArray;
            }
            string TempStr = string.Empty;
            for (int i = 0; i < linkArray.Count; i++) {
                TempStr = linkArray[i].ToString();
                TempStr = TempStr.Replace(strStart, "");
                TempStr = TempStr.Replace(strEnd, "");
                linkArray[i] = (object)TempStr;
            }
            return linkArray;
        }

        /// <summary>
        /// 替换远程图片路径为本地路径
        /// </summary>
        /// <param name="pageStr"></param>
        /// <param name="SavePath"></param>
        /// <param name="CDir"></param>
        /// <param name="webUrl"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        public ArrayList ReplaceSaveRemoteFile(string pageStr, string SavePath, string CDir, string webUrl, string isSave) {
            ArrayList replaceArray = new ArrayList();
            Regex imgReg = new Regex(@"<img.+?[^\>]>", RegexOptions.IgnoreCase);
            MatchCollection matches = imgReg.Matches(pageStr);
            string TempStr = string.Empty;
            string TitleImg = string.Empty;
            foreach (Match match in matches) {
                if (TempStr != string.Empty)
                    TempStr += "$Array$" + match.ToString();
                else
                    TempStr = match.ToString();
            }
            string[] TempArr = TempStr.Split(new string[] { "$Array$" }, StringSplitOptions.None);
            TempStr = string.Empty;
            imgReg = new Regex(@"src\s*=\s*.+?\.(gif|jpg|bmp|jpeg|psd|png|svg|dxf|wmf|tiff)", RegexOptions.IgnoreCase);
            for (int i = 0; i < TempArr.Length; i++) {
                matches = imgReg.Matches(TempArr[i]);
                foreach (Match match in matches) {
                    if (TempStr != string.Empty)
                        TempStr += "$Array$" + match.ToString();
                    else
                        TempStr = match.ToString();
                }
            }
            if (TempStr.Length > 0) {
                imgReg = new Regex(@"src\s*=\s*", RegexOptions.IgnoreCase);
                TempStr = imgReg.Replace(TempStr, "");
            }
            if (TempStr.Length == 0) {
                replaceArray.Add(pageStr);
                return replaceArray;
            }
            TempStr = TempStr.Replace("\"", "");
            TempStr = TempStr.Replace("'", "");
            TempStr = TempStr.Replace(" ", "");
            if (!System.IO.Directory.Exists(SavePath))
                System.IO.Directory.CreateDirectory(SavePath);
            TempArr = TempStr.Split(new string[] { "$Array$" }, StringSplitOptions.None);
            TempStr = string.Empty;
            for (int i = 0; i < TempArr.Length; i++) {
                if (TempStr.IndexOf(TempArr[i]) == -1)
                    TempStr += "$Array$" + TempArr[i];
            }
            TempStr = TempStr.Substring(7);

            TempArr = TempStr.Split(new string[] { "$Array$" }, StringSplitOptions.None);
            TempStr = string.Empty;
            string ImageArr = string.Empty;
            for (int i = 0; i < TempArr.Length; i++) {
                imgReg = new Regex(TempArr[i]);
                string RemoteFileUrl = DefiniteUrl(TempArr[i], webUrl);
                if (isSave == "1") {
                    string fileType = RemoteFileUrl.Substring(RemoteFileUrl.LastIndexOf('.'));
                    string filename = string.Empty;
                    filename += fileType;
                    if (SaveRemotePhoto(SavePath + "/" + filename, RemoteFileUrl)) {

                    }
                }
                pageStr = imgReg.Replace(pageStr, RemoteFileUrl);
                if (i == 0) {
                    TitleImg = RemoteFileUrl;
                    ImageArr = RemoteFileUrl;
                }
                else
                    ImageArr += "|||" + RemoteFileUrl;
            }
            replaceArray.Add(pageStr);
            replaceArray.Add(TitleImg);
            replaceArray.Add(ImageArr);
            return replaceArray;
        }

        /// <summary>
        /// 替换字符为远程的链接  比如 index.aspx 替换为http://www.v5soft.com/index.aspx
        /// </summary>
        /// <param name="PrimitiveUrl"></param>
        /// <param name="ConsultUrl"></param>
        /// <returns></returns>
        public string DefiniteUrl(string PrimitiveUrl, string ConsultUrl) {
            if (ConsultUrl.Substring(0, 7) != "http://")
                ConsultUrl = "http://" + ConsultUrl;
            ConsultUrl = ConsultUrl.Replace(@"\", "/");
            ConsultUrl = ConsultUrl.Replace("://", @":\\");
            PrimitiveUrl = PrimitiveUrl.Replace(@"\", "/");

            if (ConsultUrl.Substring(ConsultUrl.Length - 1) != "/") {
                if (ConsultUrl.IndexOf('/') > 0) {
                    if (ConsultUrl.Substring(ConsultUrl.LastIndexOf("/"), ConsultUrl.Length - ConsultUrl.LastIndexOf("/")).IndexOf('.') == -1)
                        ConsultUrl += "/";
                }
                else
                    ConsultUrl += "/";
            }
            string[] ConArray = ConsultUrl.Split('/');
            string returnStr = string.Empty;
            string[] PriArray;
            int pi = 0;
            if (PrimitiveUrl.Substring(0, 7) == "http://")
                returnStr = PrimitiveUrl.Replace("://", @":\\");
            else if (PrimitiveUrl.Substring(0, 1) == "/")
                returnStr = ConArray[0] + PrimitiveUrl;
            else if (PrimitiveUrl.Substring(0, 2) == "./") {
                PrimitiveUrl = PrimitiveUrl.Substring(PrimitiveUrl.Length - 2, 2);
                if (ConsultUrl.Substring(ConsultUrl.Length - 1) == "/")
                    returnStr = ConsultUrl + PrimitiveUrl;
                else
                    returnStr = ConsultUrl.Substring(0, ConsultUrl.LastIndexOf('/')) + PrimitiveUrl;
            }
            else if (PrimitiveUrl.Substring(0, 3) == "../") {
                while (PrimitiveUrl.Substring(0, 3) == "../") {
                    PrimitiveUrl = PrimitiveUrl.Substring(3);
                    pi++;
                }
                for (int i = 0; i < ConArray.Length - 1 - pi; i++) {
                    if (returnStr.Length > 0)
                        returnStr = returnStr + ConArray[i];
                    else
                        returnStr = ConArray[i];
                }
                returnStr = returnStr + PrimitiveUrl;
            }
            else {
                if (PrimitiveUrl.IndexOf('/') > -1) {
                    PriArray = PrimitiveUrl.Split('/');
                    if (PriArray[0].IndexOf('.') > -1) {
                        if (PrimitiveUrl.Substring(PrimitiveUrl.Length - 1) == "/")
                            returnStr = "http://" + PrimitiveUrl;
                        {
                            if (PriArray[PriArray.Length - 1].IndexOf('.') > -1)
                                returnStr = "http:\\" + PrimitiveUrl;
                            else
                                returnStr = "http:\\" + PrimitiveUrl + "/";
                        }
                    }
                    else {
                        if (ConsultUrl.Substring(ConsultUrl.Length - 1) == "/")
                            returnStr = ConsultUrl + PrimitiveUrl;
                        else
                            returnStr = ConsultUrl.Substring(0, ConsultUrl.LastIndexOf('/')) + PrimitiveUrl;
                    }
                }
                else {
                    if (PrimitiveUrl.IndexOf('.') > -1) {
                        string lastUrl = ConsultUrl;
                        if (ConsultUrl.Substring(ConsultUrl.Length - 1) == "/") {
                            if (lastUrl == "com" || lastUrl == "cn" || lastUrl == "net" || lastUrl == "org")
                                returnStr = "http:\\" + PrimitiveUrl + "/";
                            else
                                returnStr = ConsultUrl + PrimitiveUrl;
                        }
                        else {
                            if (lastUrl == "com" || lastUrl == "cn" || lastUrl == "net" || lastUrl == "org")
                                returnStr = "http:\\" + PrimitiveUrl + "/";
                            else
                                returnStr = ConsultUrl.Substring(0, ConsultUrl.LastIndexOf('/')) + "/" + PrimitiveUrl;
                        }
                    }
                    else {
                        if (ConsultUrl.Substring(ConsultUrl.Length - 1) == "/")
                            returnStr = ConsultUrl + PrimitiveUrl + "/";
                        else
                            returnStr = ConsultUrl.Substring(0, ConsultUrl.LastIndexOf('/')) + "/" + PrimitiveUrl + "/";
                    }
                }
            }

            if (returnStr.Substring(0, 1) == "/")
                returnStr = returnStr.Substring(1);
            if (returnStr.Length > 0) {
                returnStr = returnStr.Replace("//", "/");
                returnStr = returnStr.Replace(@":\\", "://");
            }
            else
                returnStr = "$False$";
            return returnStr;
        }

        /// <summary>
        /// 保存远程图片
        /// </summary>
        /// <param name="fileName">本地文件名称</param>
        /// <param name="RemoteFileUrl">远程文件地址</param>
        /// <returns></returns>
        public bool SaveRemotePhoto(string fileName, string RemoteFileUrl) {
            try {
                WebRequest request = WebRequest.Create(RemoteFileUrl);
                request.Timeout = 20000;
                Stream stream = request.GetResponse().GetResponseStream();
                Image getImage = Image.FromStream(stream);
                getImage.Save(fileName);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
        /// <summary>
        /// 保存远程图片
        /// </summary>
        /// <param name="fileName">本地文件名称</param>
        /// <param name="RemoteFileUrl">远程文件地址</param>
        /// <param name="RefererUrl">远程Referer</param>
        /// <returns></returns>
        public bool SaveRemotePhoto(string fileName, string RemoteFileUrl, string RefererUrl) {
            try {
                WebClient wc = new WebClient();
                wc.DownloadFile(RemoteFileUrl, fileName);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
        /// <summary>
        /// 移除制定 html标签代码
        /// </summary>
        /// <param name="ConStr"></param>
        /// <param name="TagName"></param>
        /// <param name="FType"></param>
        /// <returns></returns>
        public string ScriptHtml(string ConStr, string TagName, int FType) {
            Regex myReg;
            switch (FType) {
                case 1:
                    myReg = new Regex("<" + TagName + "([^>])*>", RegexOptions.IgnoreCase);
                    ConStr = myReg.Replace(ConStr, "");
                    break;
                case 2:
                    myReg = new Regex("<" + TagName + "([^>])*>.*?</" + TagName + "([^>])*>", RegexOptions.IgnoreCase);
                    ConStr = myReg.Replace(ConStr, "");
                    break;
                case 3:
                    myReg = new Regex("<" + TagName + "([^>])*>", RegexOptions.IgnoreCase);
                    ConStr = myReg.Replace(ConStr, "");
                    myReg = new Regex("</" + TagName + "([^>])*>", RegexOptions.IgnoreCase);
                    ConStr = myReg.Replace(ConStr, "");
                    break;
            }
            return ConStr;
        }
        /// <summary>
        /// 过滤HTML标签内容
        /// </summary>
        /// <param name="ConStr">源字符串</param>
        /// <param name="TagList">标签数组</param>
        /// <returns></returns>
        public static string ScriptHtml(string ConStr, string[] TagList) {
            string conStr = ConStr;
            string pattern = @"(?isx)
                      <({0})\b[^>]*>                  #开始标记“<tag...>”
                          (?>                         #分组构造，用来限定量词“*”修饰范围
                              <\1[^>]*>  (?<Open>)    #命名捕获组，遇到开始标记，入栈，Open计数加1
                          |                           #分支结构
                              </\1>  (?<-Open>)       #狭义平衡组，遇到结束标记，出栈，Open计数减1
                          |                           #分支结构
                              (?:(?!</?\1\b).)*       #右侧不为开始或结束标记的任意字符
                          )*                          #以上子串出现0次或任意多次
                          (?(Open)(?!))               #判断是否还有'OPEN'，有则说明不配对，什么都不匹配
                      </\1>                           #结束标记“</tag>”
                     ";
            string patt = pattern;
            foreach (string tag in TagList) {
                switch (tag) {
                    case "remark":
                        patt = "<!--.+?-->";
                        break;
                    case "div":
                        patt = @"<div\b[^>]*>[\n\r ]*</div>";
                        break;
                    default:
                        patt = pattern;
                        break;
                }
                Regex tmpreg = new Regex(string.Format(patt, Regex.Escape(tag)), RegexOptions.Compiled | RegexOptions.IgnoreCase);
                MatchCollection matchs = tmpreg.Matches(conStr);
                while (matchs.Count > 0) {
                    for (int i = 0; i < matchs.Count; i++) {
                        conStr = conStr.Replace(matchs[i].Value, "");
                    }
                    matchs = tmpreg.Matches(conStr);
                }


            }
            return conStr;
        }

        public static string RemoveHtml(string ConStr, string removeCon) {
            string conStr = ConStr;
            string[] arr = removeCon.Split(new string[] { "@@@@" }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"<([a-z]+)(?:(?!\bid\b)[^<>])*" + arr[0] + @"=([""']?){0}\2[^>]*>(?><\1[^>]*>(?<o>)|</\1>(?<-o>)|(?:(?!</?\1).)*)*(?(o)(?!))</\1>";
            Regex tmpreg = new Regex(string.Format(pattern, Regex.Escape(arr[1])), RegexOptions.Singleline | RegexOptions.IgnoreCase);
            MatchCollection matchs = tmpreg.Matches(conStr);
            while (matchs.Count > 0) {
                for (int i = 0; i < matchs.Count; i++) {
                    conStr = conStr.Replace(matchs[i].Value, "");
                }
                matchs = tmpreg.Matches(conStr);
            }
            return conStr;
        }
        /// <summary>
        /// 移除所有Html标签
        /// </summary>
        /// <param name="ConStr"></param>
        /// <returns></returns>
        public string NoHtml(string ConStr) {
            Regex myReg = new Regex(@"(\<.[^\<]*\>)", RegexOptions.IgnoreCase);
            ConStr = myReg.Replace(ConStr, "");
            myReg = new Regex(@"(\<\/[^\<]*\>)", RegexOptions.IgnoreCase);
            ConStr = myReg.Replace(ConStr, "");
            return ConStr;
        }
        /// <summary>
        /// 截取Html内容
        /// </summary>
        /// <param name="pageStr"></param>
        /// <param name="strStart"></param>
        /// <param name="strEnd"></param>
        /// <returns></returns>
        public string GetPaing(string pageStr, string strStart, string strEnd) {
            int end = pageStr.IndexOf(strEnd);
            if (strEnd.Length == 0 || end < 0)
                return "$EndFalse$";
            pageStr = pageStr.Substring(0, end);
            int start = pageStr.LastIndexOf(strStart);
            if (strStart.Length == 0 || start < 0 || start > end)
                return "$StartFalse$";
            pageStr = pageStr.Substring(start + strStart.Length);
            pageStr = pageStr.Replace("\"", "");
            pageStr = pageStr.Replace("'", "");
            pageStr = pageStr.Replace(" ", "");
            pageStr = pageStr.Trim();
            return pageStr;
        }


        /// <summary>
        /// 自动上传文本中的图片
        /// </summary>
        /// <param name="content">文本内容</param>
        /// <param name="path">保存路径</param>
        /// <returns></returns>
        public string AutoUploadStringPhoto(string content, string path) {
            WebClient client = new WebClient();
            Regex reg = new Regex("IMG[^>]*?src\\s*=\\s*(?:\"(?<1>[^\"]*)\"|'(?<1>[^\']*)')", RegexOptions.IgnoreCase);
            MatchCollection m = reg.Matches(content);
            foreach (Match math in m) {
                string imgUrl = math.Groups[1].Value;
                Regex regName = new Regex(@"\w+.(?:jpg|gif|bmp|png)", RegexOptions.IgnoreCase);
                string strNewImgName = DateTime.Now.ToShortDateString().Replace("-", "") + regName.Match(imgUrl).ToString();
                try {
                    client.DownloadFile(imgUrl, (path + strNewImgName));
                }
                catch {
                }
                finally {
                }
                client.Dispose();
            }
            return "远程图片保存成功，保存路径为" + path;
        }

        #region "远程保存图片到本地"
        /// <summary>
        /// 下载图片到本地
        /// </summary>
        /// <param name="_strHTML"></param>
        /// <param name="_Path"></param>
        /// <returns></returns>
        public string SaveUrlPics(string _strHTML, string _Path) {
            try {
                string[] imgurlAry = GetImgTag(_strHTML);
                string ReFilePath = _Path;
                for (int i = 0; i < imgurlAry.Length; i++) {
                    WebClient wc = new WebClient();
                    wc.DownloadFile(imgurlAry[i], ReFilePath + "/" + imgurlAry[i].Substring(imgurlAry[i].LastIndexOf("/") + 1));
                    _strHTML = _strHTML.Replace(imgurlAry[i], _Path + "/" + imgurlAry[i].Substring(imgurlAry[i].LastIndexOf("/") + 1));
                }
                return _strHTML;
            }
            catch {
                return _strHTML;
            }
        }
        /// <summary>
        /// 获取图片链接标签
        /// </summary>
        /// <param name="_strHTML"></param>
        /// <returns></returns>
        public string[] GetImgTag(string _strHTML) {
            Regex reg = new Regex("<img.+?>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string[] strAry = new string[reg.Matches(_strHTML).Count];
            int i = 0;
            foreach (Match match in reg.Matches(_strHTML)) {
                strAry[i] = GetImgUrl(match.Value);
            }
            return strAry;
        }
        /// <summary>
        /// 获取图片标签
        /// </summary>
        /// <param name="imgTagStr"></param>
        /// <returns></returns>
        private string GetImgUrl(string imgTagStr) {
            string str = "";
            Regex reg = new Regex("http://.+.(?:jpg|gif|bmp|png)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match match in reg.Matches(imgTagStr)) {
                str = match.Value;
            }
            return str;
        }
        #endregion
    }
}