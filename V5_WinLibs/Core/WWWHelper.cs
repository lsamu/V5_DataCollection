using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace V5_WinLibs.Core {
    public class WWWHelper {
        public static string GetUrlDomainName(string strHtmlPagePath) {
            string p = @"http://[^\.]*\.(?<domain>[^/]*)";
            Regex reg = new Regex(p, RegexOptions.IgnoreCase);
            Match m = reg.Match(strHtmlPagePath);
            return m.Groups["domain"].Value;
        }
    }
}
