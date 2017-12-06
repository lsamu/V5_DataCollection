using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace V5_WinLibs.Core {
    /// <summary>  
    /// 图片下载  
    /// </summary>  
    public class ImageDownHelper {
        public ImageDownHelper() { }

        public void Test() {
            var CutContent = $@"
                <a href='http://www.baidu.com/logo.gif'>title</a>sdf
                <img src='http://www.baidu.com/img.gif'/>
                <img src='img/xxx.jpg'/>
            ";
            var DownResourceExts = ".gif";
            string[] imgExtArr = DownResourceExts.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var imgTag = ImageDownHelper.GetImgTag(CutContent);
            var downImgPath = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\Test\\Images\\";
            foreach (var img in imgTag) {
                var newImg = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                if (!string.IsNullOrEmpty(DownResourceExts)) {
                    var imgExt = img.Substring(img.LastIndexOf("."));
                    if (imgExtArr.SingleOrDefault(x => x.ToLower() == imgExt.ToLower()) != imgExt.ToLower()) {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// 获取html的所有img标签
        /// </summary>
        /// <param name="_strHTML"></param>
        /// <returns></returns>
        public static string[] GetImgTag(string _strHTML) {
            Regex reg = new Regex("IMG[^>]*?src\\s*=\\s*(?:\"(?<1>[^\"]*)\"|'(?<1>[^\']*)')", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string[] strAry = new string[reg.Matches(_strHTML).Count];
            int i = 0;
            foreach (Match match in reg.Matches(_strHTML)) {
                strAry[i] = match.Groups[1].Value;
                i++;
            }
            return strAry;
        }
        /// <summary>
        /// 获取图片中的连接
        /// </summary>
        /// <param name="imgTagStr"></param>
        /// <returns></returns>
        private static string GetImgUrl(string imgTagStr) {
            string str = "";
            Regex reg = new Regex("(http|https)(://.+.)(?:jpg|gif|bmp|png|jpeg)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match match in reg.Matches(imgTagStr)) {
                str = match.Value;
            }
            return str;
        }

        /// <summary>  
        /// 下载图片到本地  
        /// </summary>  
        /// <param name="strHTML">HTML</param>  
        /// <param name="path">路径</param>  
        /// <param name="nowyymm">年月</param>  
        /// <param name="nowdd">日</param>  
        public static string SaveUrlPics(string strHTML, string path) {
            string nowym = DateTime.Now.ToString("yyyy-MM");    
            string nowdd = DateTime.Now.ToString("dd");         
            path = path + nowym + "/" + nowdd;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] imgurlAry = GetImgTag(strHTML);
            try {
                for (int i = 0; i < imgurlAry.Length; i++) {
                    string preStr = System.DateTime.Now.ToString() + "_";
                    preStr = preStr.Replace("-", "");
                    preStr = preStr.Replace(":", "");
                    preStr = preStr.Replace(" ", "");
                    WebClient wc = new WebClient();
                    wc.DownloadFile(imgurlAry[i], path + "/" + preStr + imgurlAry[i].Substring(imgurlAry[i].LastIndexOf("/") + 1));
                }
            }
            catch (Exception ex) {
                return ex.Message;
            }
            return strHTML;
        }

        /// <summary>
        /// 下载图片到本地
        /// </summary>
        /// <param name="imgUrl">图片远程路径</param>
        /// <param name="path">本地图片主目录</param>
        /// <returns></returns>
        public static string DownUrlPics(string imgUrl, string path)
        {
            string nowym = DateTime.Now.ToString("yyyy-MM");    
            string nowdd = DateTime.Now.ToString("dd");         
            path = path + nowym + "/" + nowdd;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string preStr = System.DateTime.Now.ToString() + "_";
            preStr = preStr.Replace("-", "");
            preStr = preStr.Replace(":", "");
            preStr = preStr.Replace(" ", "");
            string newFileName = "/" + preStr + imgUrl.Substring(imgUrl.LastIndexOf("/") + 1);

            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(imgUrl, path + newFileName);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return newFileName;
        }
    }
}