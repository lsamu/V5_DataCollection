using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using V5_Utility.Core;

namespace V5_WinLibs.Core {
    public class HtmlHelper {

        private static readonly HtmlHelper m_Instance = new HtmlHelper();
        /// <summary>
        /// 
        /// </summary>
        public static HtmlHelper Instance {
            get { return m_Instance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public HtmlHelper() {

        }

        /// <summary>
        /// 加载用户控件
        /// </summary>
        /// <param name="pathName">控件地址</param>
        /// <param name="isRender">渲染方式  true使用控件渲染 flase为execute读取</param>
        /// <returns></returns>
        public string Include(string pathName, bool isRender) {
            StringBuilder build = new StringBuilder();
            HtmlTextWriter htmlWriter = new HtmlTextWriter(new StringWriter(build));
            UserControl uc = new UserControl();
            Control ctrl = uc.LoadControl(pathName);
            string html = string.Empty;
            Page p = new Page();
            p.Controls.Add(ctrl);
            p.RenderControl(htmlWriter);
            htmlWriter.Flush();
            html = build.ToString();
            return html;
        }
        /// <summary>
        /// 加载用户控件
        /// </summary>
        /// <param name="pathName"></param>
        /// <returns></returns>
        public string Include(string pathName) {
            try {
                System.Web.UI.Page page = new System.Web.UI.Page();
                UserControl ctl = (UserControl)page.LoadControl(pathName);
                page.Controls.Add(ctl);
                StringWriter writer = new StringWriter();
                HttpContext.Current.Server.Execute(page, writer, true);
                return writer.ToString();
            }
            catch (Exception ex) { return pathName + "加载失败!" + ex.Message + ex.InnerException; }
        }

        /// <summary>
        /// 返回指定字符串的值
        /// </summary>
        /// <param name="Tag"></param>
        /// <param name="TagName"></param>
        /// <returns></returns>
        public string TagVal(string Tag, string TagName) {
            string[] strArray = Tag.Split(new string[] { "," }, StringSplitOptions.None);
            for (int i = 0; i < strArray.Length; i++) {
                Regex regex = new Regex(@"(?<Keyword>\w+)\s*=\s*(?<Value>.*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                for (Match match = regex.Match(strArray[i]); match.Success; match = match.NextMatch()) {
                    if (match.Groups["Keyword"].ToString().ToLower().IndexOf(TagName.ToLower()) != -1) {
                        return match.Groups["Value"].ToString().ToLower();
                    }
                }
            }
            return "";
        }

        /// <summary>
        /// Html转换成js
        /// </summary>
        /// <param name="oTxt"></param>
        /// <returns></returns>
        public string HtmlToJS(string oTxt) {
            oTxt = "document.writeln(\"" + oTxt.Replace(@"\", @"\\").Replace("/", @"\/").Replace("'", @"\'").Replace("\"", "\\\"") + "\");";
            return oTxt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oTxt"></param>
        /// <returns></returns>
        public string HtmlToJavaScript(string oTxt) {
            StringBuilder sb = new StringBuilder();
            string[] ArrTxt = oTxt.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (string str in ArrTxt) {
                sb.AppendLine("document.writeln('" + str.Replace(@"\", @"\\").Replace("/", @"\/").Replace("'", @"\'").Replace("\"", "\\\"") + "');");
            }
            return sb.ToString();
        }

        #region UBB代码
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Str"></param>
        /// <returns></returns>
        public static string UBB2HTML(string Str) {
            string OutPut = Str;
            Match match1 = new Regex(@"(\[b\])([ \S\t]*?)(\[\/b\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<B>" + match1.Groups[2].ToString() + "</B>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[i\])([ \S\t]*?)(\[\/i\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<I>" + match1.Groups[2].ToString() + "</I>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[U\])([ \S\t]*?)(\[\/U\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<U>" + match1.Groups[2].ToString() + "</U>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"((\r\n)*\[p\])(.*?)((\r\n)*\[\/p\])", RegexOptions.Singleline | RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<P class=\"pstyle\">" + match1.Groups[3].ToString() + "</P>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[sup\])([ \S\t]*?)(\[\/sup\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<SUP>" + match1.Groups[2].ToString() + "</SUP>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[sub\])([ \S\t]*?)(\[\/sub\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<SUB>" + match1.Groups[2].ToString() + "</SUB>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[url\])([ \S\t]*?)(\[\/url\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<A href=\"" + match1.Groups[2].ToString() + "\" target=\"_blank\">" + match1.Groups[2].ToString() + "</A>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[url=([ \S\t]+)\])([ \S\t]*?)(\[\/url\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<A href=\"" + match1.Groups[2].ToString() + "\" target=\"_blank\">" + match1.Groups[3].ToString() + "</A>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[email\])([ \S\t]*?)(\[\/email\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<A href=\"mailto:" + match1.Groups[2].ToString() + "\" target=\"_blank\">" + match1.Groups[2].ToString() + "</A>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[email=([ \S\t]+)\])([ \S\t]*?)(\[\/email\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<A href=\"mailto:" + match1.Groups[2].ToString() + "\" target=\"_blank\">" + match1.Groups[3].ToString() + "</A>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[size=([1-7])\])([ \S\t]*?)(\[\/size\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<FONT SIZE=" + match1.Groups[2].ToString() + ">" + match1.Groups[3].ToString() + "</FONT>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[color=([\S]+)\])([ \S\t]*?)(\[\/color\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<FONT COLOR=" + match1.Groups[2].ToString() + ">" + match1.Groups[3].ToString() + "</FONT>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[font=([\S]+)\])([ \S\t]*?)(\[\/font\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<FONT FACE=" + match1.Groups[2].ToString() + ">" + match1.Groups[3].ToString() + "</FONT>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"\[picture\](\d+?)\[\/picture\]", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<A href=\"ShowImage.aspx?Type=ALL&Action=forumImage&ImageID=" + match1.Groups[1].ToString() + "\" target=\"_blank\"><IMG border=0 Title=\u70b9\u51fb\u6253\u5f00\u65b0\u7a97\u53e3\u67e5\u770b src=\"ShowImage.aspx?Action=forumImage&ImageID=" + match1.Groups[1].ToString() + "\"></A>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[align=([\S]+)\])([ \S\t]*?)(\[\/align\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<P align=" + match1.Groups[2].ToString() + ">" + match1.Groups[3].ToString() + "</P>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[H=([1-6])\])([ \S\t]*?)(\[\/H\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<H" + match1.Groups[2].ToString() + ">" + match1.Groups[3].ToString() + "</H" + match1.Groups[2].ToString() + ">");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[list(=(A|a|I|i| ))?\]([ \S\t]*)\r\n)((\[\*\]([ \S\t]*\r\n))*?)(\[\/list\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                string text2 = match1.Groups[5].ToString();
                Regex regex2 = new Regex(@"\[\*\]([ \S\t]*\r\n?)", RegexOptions.IgnoreCase);
                for (Match match2 = regex2.Match(text2); match2.Success; match2 = match2.NextMatch()) {
                    text2 = text2.Replace(match2.Groups[0].ToString(), "<LI>" + match2.Groups[1]);
                }
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<UL TYPE=\"" + match1.Groups[3].ToString() + "\"><B>" + match1.Groups[4].ToString() + "</B>" + text2 + "</UL>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"\[shadow=(?<x>[^\]]*),(?<y>[^\]]*),(?<z>[^\]]*)\](?<w>[^\]]*)\[/shadow\]", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), @"<table width=" + match1.Groups[1] + " style=\"filter:shadow(color=" + match1.Groups[2] + ", strength=" + match1.Groups[3] + ")\">" + match1.Groups[4] + "</table>");

                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[glow=)(\d*?),(#*\w*?),(\d*?)\]([\S\t]*?)(\[\/glow\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<TABLE WIDTH=" + match1.Groups[2].ToString() + "  STYLE=FILTER:GLOW(COLOR=" + match1.Groups[3].ToString() + ", STRENGTH=" + match1.Groups[4].ToString() + ")>" + match1.Groups[5].ToString() + "</TABLE>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[center\])([ \S\t]*?)(\[\/center\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<CENTER>" + match1.Groups[2].ToString() + "</CENTER>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[IMG\])(http|https|ftp):\/\/([ \S\t]*?)(\[\/IMG\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<br><a onfocus=this.blur() href=" + match1.Groups[2].ToString() + "://" + match1.Groups[3].ToString() + " target=_blank><IMG SRC=" + match1.Groups[2].ToString() + "://" + match1.Groups[3].ToString() + " border=0 onload=javascript:if(screen.width-333<this.width)this.width=screen.width-333></a>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[em([\S\t]*?)\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<img src=Images/ubb/face/" + match1.Groups[2].ToString() + ".gif border=0 align=middle>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[img\])([ \S\t]*?)(\[\/img\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<a target=_blank href=" + match1.Groups[2].ToString() + "><IMG SRC=" + match1.Groups[2].ToString() + " border=0 onload='javascript:if(screen.width-333<this.width)this.width=screen.width-333'></a>");
                match1 = match1.NextMatch();
            }

            match1 = new Regex(@"(\[flash=)(\d*?),(\d*?)\]([\S\t]*?)(\[\/flash\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<a href=" + match1.Groups[4].ToString() + " TARGET=_blank><IMG SRC=images/swf.gif border=0> [\u5168\u5c4f\u6b23\u8d4f]</a><br><br><OBJECT codeBase=http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,29,0 classid=clsid:D27CDB6E-AE6D-11cf-96B8-444553540000 width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + "><PARAM NAME=movie VALUE=" + match1.Groups[4].ToString() + "><PARAM NAME=quality VALUE=high><param name=menu value=false><embed src=" + match1.Groups[4].ToString() + " quality=high menu=false pluginspage=http://www.macromedia.com/go/getflashplayer type=application/x-shockwave-flash width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + ">" + match1.Groups[4].ToString() + "</embed></OBJECT>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[dir=)(\d*?),(\d*?)\]([\S\t]*?)(\[\/dir\])", RegexOptions.IgnoreCase).Match(Str);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<object classid=clsid:166B1BCA-3F9C-11CF-8075-444553540000 codebase=http://download.macromedia.com/pub/shockwave/cabs/director/sw.cab#version=7,0,2,0 width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + "><param name=src value=" + match1.Groups[4].ToString() + "><embed src=" + match1.Groups[4].ToString() + " pluginspage=http://www.macromedia.com/shockwave/download/ width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + "></embed></object>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[rm=)(\d*?),(\d*?),([\S\t]*?)\]([\S\t]*?)(\[\/rm\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<OBJECT classid=clsid:CFCDAA03-8BE4-11cf-B84B-0020AFBBCCFA class=OBJECT id=RAOCX width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + "><PARAM NAME=SRC VALUE=" + match1.Groups[5].ToString() + "><PARAM NAME=CONSOLE VALUE=Clip1><PARAM NAME=CONTROLS VALUE=imagewindow><PARAM NAME=AUTOSTART VALUE=" + match1.Groups[4].ToString() + "></OBJECT><br><OBJECT classid=CLSID:CFCDAA03-8BE4-11CF-B84B-0020AFBBCCFA height=32 id=video2 width=" + match1.Groups[2].ToString() + "><PARAM NAME=SRC VALUE=" + match1.Groups[5].ToString() + "><PARAM NAME=AUTOSTART VALUE=" + match1.Groups[4].ToString() + "><PARAM NAME=CONTROLS VALUE=controlpanel><PARAM NAME=CONSOLE VALUE=Clip1></OBJECT>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[mp=)(\d*?),(\d*?),([\S\t]*?)\]([\S\t]*?)(\[\/mp\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<object align=middle classid=CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95 class=OBJECT id=MediaPlayer width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + " ><PARAM NAME=AUTOSTART VALUE=" + match1.Groups[4].ToString() + "><param name=Filename value=" + match1.Groups[5].ToString() + "><PARAM NAME=showstatusbar VALUE=1><embed type=application/x-oleobject codebase=http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701 flename=mp src=" + match1.Groups[5].ToString() + "  width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + " showstatusbar=1></embed></object>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[qt=)(\d*?),(\d*?)\]([\S\t]*?)(\[\/qt\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<embed src=" + match1.Groups[4].ToString() + " width=" + match1.Groups[2].ToString() + " height=" + match1.Groups[3].ToString() + " autoplay=true loop=false controller=true playeveryframe=false cache=false scale=TOFIT bgcolor=#000000 kioskmode=false targetcache=false pluginspage=http://www.apple.com/quicktime/>");
                match1 = match1.NextMatch();
            }

            match1 = new Regex(@"(\[QUOTE\])([ \S\t]*?)(\[\/QUOTE\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "以下内容为引用：<table border=0 width=95% cellpadding=10 cellspacing=1 bgcolor=#000000><tr><td bgcolor=#FFFFFF>" + match1.Groups[2].ToString() + "</td></tr></table>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[move\])([ \S\t]*?)(\[\/move\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<MARQUEE scrollamount=3>" + match1.Groups[2].ToString() + "</MARQUEE>");
                match1 = match1.NextMatch();
            }
            match1 = new Regex(@"(\[FLY\])([ \S\t]*?)(\[\/FLY\])", RegexOptions.IgnoreCase).Match(OutPut);
            while (match1.Success) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<MARQUEE width=80% behavior=alternate scrollamount=3>" + match1.Groups[2].ToString() + "</MARQUEE>");
                match1 = match1.NextMatch();
            }
            Regex regex1 = new Regex(@"(\[image\])([ \S\t]*?)(\[\/image\])", RegexOptions.IgnoreCase);
            for (match1 = regex1.Match(OutPut); match1.Success; match1 = match1.NextMatch()) {
                OutPut = OutPut.Replace(match1.Groups[0].ToString(), "<img src=\"" + match1.Groups[2].ToString() + "\" border=0 align=middle><br>");
            }
            return OutPut;
        }
        #endregion

        /// <summary>
        /// 过滤所有Html标签
        /// </summary>
        /// <param name="HTMLStr"></param>
        /// <returns></returns>
        public string ParseTags(string HTMLStr) {
            var s = System.Text.RegularExpressions.Regex.Replace(HTMLStr, "<[^>]*>", "");
            s = s.Replace("\"", "");
            return s;
        }

        #region
        /// <summary>
        /// 获取官方网站内容
        /// </summary>
        /// <returns></returns>
        public string GetLinkHtml() {
            return this.GetLinkHtml(24);
        }
        /// <summary>
        /// 获取官方网站内容
        /// </summary>
        /// <returns></returns>
        public string GetLinkHtml(int hours = 24) {
            string currentWebSite = RequestHelper.Instance.GetCurrentFullHost();
            string pageContent = string.Empty;
            currentWebSite += "-Link";
            if (CacheHelper.Instance.GetCache(currentWebSite) == null) {
                try {
                    pageContent = CollectionHelper.Instance.GetHttpPage("http://www.v5soft.com/includes/plugins/link/link.aspx", 5, "utf-8");
                    if (pageContent == "$UrlIsFalse$" || pageContent == "$GetFalse$") {
                        pageContent = "获取错误!";
                    }
                }
                catch (HttpException ex) {
                    pageContent = "异常!" + ex.Message;
                }
                CacheHelper.Instance.SetCache(currentWebSite, pageContent, new TimeSpan(hours, 0, 0));
            }
            else {
                pageContent = (string)CacheHelper.Instance.GetCache(currentWebSite);
            }
            return pageContent;
        }
        /// <summary>
        /// 获取官方版权内容
        /// </summary>
        /// <returns></returns>
        public string GetVersionHtml() {
            return this.GetVersionHtml(24);
        }
        /// <summary>
        /// 获取官方版权内容
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public string GetVersionHtml(int hours = 24) {
            string currentWebSite = RequestHelper.Instance.GetCurrentFullHost();
            string pageContent = string.Empty;
            currentWebSite += "-CopyRight";
            if (CacheHelper.Instance.GetCache(currentWebSite) == null) {
                try {
                    pageContent = CollectionHelper.Instance.GetHttpPage("http://www.v5soft.com/includes/version.aspx", 5, "utf-8");
                    if (pageContent == "$UrlIsFalse$" || pageContent == "$GetFalse$") {
                        pageContent = "获取错误!";
                    }
                }
                catch (HttpException ex) {
                    pageContent = "异常!" + ex.Message;
                }
                CacheHelper.Instance.SetCache(currentWebSite, pageContent, new TimeSpan(hours, 0, 0));
            }
            else {
                pageContent = (string)CacheHelper.Instance.GetCache(currentWebSite);
            }
            return pageContent;
        }
        #endregion


        /// <summary>
        /// 正则表达式标签替换
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ParseCollectionStrings(string s) {
            string[] chars = "\\,^,$,{,[,.,(,),*,+,?,!,#,|".Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < chars.Length; i++) {
                s = s.Replace(chars[i], "\\" + chars[i]);
            }
            s = Regex.Replace(s, @"\s+", "\\s+");
            return s;
        }
        public string UnParseCollectionStrings(string s) {
            string[] chars = "\\,^,$,{,[,.,(,*,+,?,!,#,|".Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < chars.Length; i++) {
                s = s.Replace("\\" + chars[i], chars[i]);
            }
            s = Regex.Replace(s, "\\s+", @"\s+");
            return s;
        }
        /// <summary>
        /// 获取图片链接地址 必须有Http开头
        /// </summary>
        /// <param name="imgTagStr"></param>
        /// <returns></returns>
        public static string GetImgUrl(string imgTagStr) {
            string str = "";
            Regex reg = new Regex("http://.+.(?:jpg|gif|bmp|png)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match match in reg.Matches(imgTagStr)) {
                str = match.Value;
            }
            return str;
        }
        /// <summary>
        /// 获取图片Src 
        /// </summary>
        /// <param name="imgTagStr"></param>
        /// <returns></returns>
        public static string GetImgUrlSrc(string imgTagStr) {
            string str = "";
            Regex reg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match match in reg.Matches(imgTagStr)) {
                str = match.Groups["imgUrl"].Value;
            }
            return str;
        }
        /// <summary>
        /// 替换Html字符的图片标签到Ubb标签
        /// </summary>
        /// <param name="strHtml"></param>
        /// <param name="url"></param>
        /// <param name="removeWHtml"></param>
        /// <returns></returns>
        public static string ReplaceNormalHtml(string strHtml, string url, bool removeWHtml) {
            Regex reg = new Regex("<img.+?>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match match in reg.Matches(strHtml)) {
                strHtml = strHtml.Replace(match.Value, "[IMG]" + CollectionHelper.Instance.DefiniteUrl(GetImgUrlSrc(match.Value), url) + "[/IMG]");
            }
            if (removeWHtml)
                return NoHTML(strHtml);
            else
                return strHtml;
        }
        /// <summary>
        /// 替换a标签的连接并下载
        /// </summary>
        /// <param name="strHtml">要替换的内容</param>
        /// <param name="url">参考地址</param>
        /// <param name="?">下载文件格式</param>
        /// <returns></returns>
        public static string ReplaceNornalHtmlByHref(string strHtml, string strUrl, string strDownFormat) {
            Regex reg = new Regex("<(?:jpg|gif|bmp|png)>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match match in reg.Matches(strHtml)) {
                strHtml = strHtml.Replace(match.Value, "[A]" + CollectionHelper.Instance.DefiniteUrl(GetImgUrlSrc(match.Value), strUrl) + "[/A]");
            }
            return strHtml;
        }
        /// <summary>
        /// UBB代码处理函数
        /// </summary>
        /// <param name="sDetail">输入字符串</param>
        /// <returns>输出字符串</returns>
        public static string UBBToHTML(string sDetail) {
            Regex r;
            Match m;
            #region 处理空格
            sDetail = sDetail.Replace(" ", "&nbsp;");
            #endregion
            #region html标记符
            sDetail = sDetail.Replace("<", "&lt;");
            sDetail = sDetail.Replace(">", "&gt;");
            #endregion
            #region 处[b][/b]标记
            r = new Regex(@"(\[b\])([ \S\t]*?)(\[\/b\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(), "<B>" + m.Groups[2].ToString() + "</B>");
            }
            #endregion
            #region 处[i][/i]标记
            r = new Regex(@"(\[i\])([ \S\t]*?)(\[\/i\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(), "<I>" + m.Groups[2].ToString() + "</I>");
            }
            #endregion
            #region 处[u][/u]标记
            r = new Regex(@"(\[U\])([ \S\t]*?)(\[\/U\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(), "<U>" + m.Groups[2].ToString() + "</U>");
            }
            #endregion
            #region 处[p][/p]标记
            r = new Regex(@"((\r\n)*\[p\])(.*?)((\r\n)*\[\/p\])", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(), "<P class=\"pstyle\">" + m.Groups[3].ToString() + "</P>");
            }
            #endregion
            #region 处[sup][/sup]标记
            r = new Regex(@"(\[sup\])([ \S\t]*?)(\[\/sup\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(), "<SUP>" + m.Groups[2].ToString() + "</SUP>");
            }
            #endregion
            #region 处[sub][/sub]标记
            r = new Regex(@"(\[sub\])([ \S\t]*?)(\[\/sub\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(), "<SUB>" + m.Groups[2].ToString() + "</SUB>");
            }
            #endregion
            #region 处[img][/img]标记
            r = new Regex(@"(\[img\])([ \S\t]*?)(\[\/img\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<img src=\"" + m.Groups[2].ToString() + "\" />");
            }
            #endregion
            #region 处[url][/url]标记
            r = new Regex(@"(\[url\])([ \S\t]*?)(\[\/url\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<A href=\"" + m.Groups[2].ToString() + "\" target=\"_blank\"><IMG border=0 src=\"images/url.gif\">" +
                    m.Groups[2].ToString() + "</A>");
            }
            #endregion
            #region 处[url=xxx][/url]标记
            r = new Regex(@"(\[url=([ \S\t]+)\])([ \S\t]*?)(\[\/url\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<A href=\"" + m.Groups[2].ToString() + "\" target=\"_blank\"><IMG border=0 src=\"images/url.gif\">" +
                    m.Groups[3].ToString() + "</A>");
            }
            #endregion
            #region 处[email][/email]标记
            r = new Regex(@"(\[email\])([ \S\t]*?)(\[\/email\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<A href=\"mailto:" + m.Groups[2].ToString() + "\" target=\"_blank\"><IMG border=0 src=\"images/email.gif\">" +
                    m.Groups[2].ToString() + "</A>");
            }
            #endregion
            #region 处[email=xxx][/email]标记
            r = new Regex(@"(\[email=([ \S\t]+)\])([ \S\t]*?)(\[\/email\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<A href=\"mailto:" + m.Groups[2].ToString() + "\" target=\"_blank\"><IMG border=0 src=\"images/email.gif\">" +
                    m.Groups[3].ToString() + "</A>");
            }
            #endregion
            #region 处[size=x][/size]标记
            r = new Regex(@"(\[size=([1-7])\])([ \S\t]*?)(\[\/size\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<FONT SIZE=" + m.Groups[2].ToString() + ">" +
                    m.Groups[3].ToString() + "</FONT>");
            }
            #endregion
            #region 处[color=x][/color]标记
            r = new Regex(@"(\[color=([\S]+)\])([ \S\t]*?)(\[\/color\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<FONT COLOR=" + m.Groups[2].ToString() + ">" +
                    m.Groups[3].ToString() + "</FONT>");
            }
            #endregion
            #region 处[font=x][/font]标记
            r = new Regex(@"(\[font=([\S]+)\])([ \S\t]*?)(\[\/font\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<FONT FACE=" + m.Groups[2].ToString() + ">" +
                    m.Groups[3].ToString() + "</FONT>");
            }
            #endregion
            #region 处理图片链接
            r = new Regex("\\[picture\\](\\d+?)\\[\\/picture\\]", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<A href=\"ShowImage.aspx?Type=ALL&Action=forumImage&ImageID=" + m.Groups[1].ToString() +
                    "\" target=\"_blank\"><IMG border=0 Title=\"点击打开新窗口查看\" src=\"ShowImage.aspx?Action=forumImage&ImageID=" + m.Groups[1].ToString() +
                    "\"></A>");
            }
            #endregion
            #region 处理[align=x][/align]
            r = new Regex(@"(\[align=([\S]+)\])([ \S\t]*?)(\[\/align\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<P align=" + m.Groups[2].ToString() + ">" +
                    m.Groups[3].ToString() + "</P>");
            }
            #endregion
            #region 处[H=x][/H]标记
            r = new Regex(@"(\[H=([1-6])\])([ \S\t]*?)(\[\/H\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<H" + m.Groups[2].ToString() + ">" +
                    m.Groups[3].ToString() + "</H" + m.Groups[2].ToString() + ">");
            }
            #endregion
            #region 处理[list=x][*][/list]
            r = new Regex(@"(\[list(=(A|a|I|i| ))?\]([ \S\t]*)\r\n)((\[\*\]([ \S\t]*\r\n))*?)(\[\/list\])", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                string strLI = m.Groups[5].ToString();
                Regex rLI = new Regex(@"\[\*\]([ \S\t]*\r\n?)", RegexOptions.IgnoreCase);
                Match mLI;
                for (mLI = rLI.Match(strLI); mLI.Success; mLI = mLI.NextMatch()) {
                    strLI = strLI.Replace(mLI.Groups[0].ToString(), "<LI>" + mLI.Groups[1]);
                }
                sDetail = sDetail.Replace(m.Groups[0].ToString(),
                    "<UL TYPE=\"" + m.Groups[3].ToString() + "\"><B>" + m.Groups[4].ToString() + "</B>" +
                    strLI + "</UL>");
            }
            #endregion
            #region 处理换行
            r = new Regex(@"(\r\n((&nbsp;)|　)+)(?<正文>\S+)", RegexOptions.IgnoreCase);
            for (m = r.Match(sDetail); m.Success; m = m.NextMatch()) {
                sDetail = sDetail.Replace(m.Groups[0].ToString(), "<BR>　　" + m.Groups["正文"].ToString());
            }
            sDetail = sDetail.Replace("\r\n", "<BR>");
            #endregion
            return sDetail;
        }
        /// <summary>
        /// 去除HTML标记
        /// </summary>
        /// <param name="Htmlstring"></param>
        /// <returns></returns>
        public static string NoHTML(string Htmlstring) {
            if (Htmlstring.Trim() == "")
                return "";
            Htmlstring = Regex.Replace(Htmlstring, @"<br*?>", "$br$", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"\r\n", "$br$", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);

            Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);

            Htmlstring = Htmlstring.Replace("<", "");
            Htmlstring = Htmlstring.Replace(">", "");
            Htmlstring = Htmlstring.Replace("$br$", "<br/>");
            return Htmlstring;
        }
    }
}
