using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using V5_DataCollection._Class.Common;

namespace V5_DataCollection._Class.Gather {
    public class cGatherFunction {

        private static cGatherFunction m_Instance = new cGatherFunction();

        public static cGatherFunction Instance {
            get { return m_Instance; }
        }

        #region
        /// <summary>
        /// 分割采集Url
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public List<string> SplitWebUrl(string Url) {
            List<string> Urls = new List<string>();
            try {
                if (!Regex.IsMatch(Url, "{.*}")) {
                    Urls.Add(Url);
                    return Urls;
                }
                /*
                while (Regex.IsMatch(Url, "{.*}")) {
                    string strMatch = "(?<={)[^}]*(?=})";
                    Match s = Regex.Match(Url, strMatch, RegexOptions.IgnoreCase);
                    string UrlPara = s.Groups[0].Value;
                    List<string> g_Url = getListUrl(UrlPara, Url);
                    foreach (string str in g_Url) {
                        string temp = Url;
                        Urls.Add(temp.Replace("{" + UrlPara + "}", str));
                    }
                    Url = Url.Replace("{" + UrlPara + "}", "");
                }*/
                if (Regex.IsMatch(Url, "{.*}"))
                {
                    var match = Regex.Matches(Url, "{.*}");
                    var count = match.Count;

                    List<string> url1 = new List<string>();
                    url1.Add(Url);
                    // for (int i = 0; i < count; i++)
                    // {                        
                    for (int j = 0; j < url1.Count;)
                    {
                        if (!Regex.IsMatch(url1[j], "{.*}"))
                        {
                            Urls.Add(url1[j]);
                            url1.RemoveAt(j);
                        }
                        else
                        {
                            string strMatch = "(?<={)[^}]*(?=})";
                            Match s = Regex.Match(url1[j], strMatch, RegexOptions.IgnoreCase);
                            string UrlPara = s.Groups[0].Value;
                            List<string> g_Url = getListUrl(UrlPara, url1[j]);
                            foreach (string str in g_Url)
                            {
                                string temp = url1[j];
                                temp = temp.Remove(s.Index - 1, s.Length + 2);
                                url1.Add(temp.Insert(s.Index - 1, str));
                            }
                            j++;
                        }
                    }
                    url1.Clear();
                    // }
                    // Urls.AddRange(url1);
                }
            }
            catch (Exception) {
            }
            return Urls;
        }
        /// <summary>
        /// 获取Url参数
        /// </summary>
        /// <param name="dicPre"></param>
        /// <param name="Url"></param>
        /// <returns></returns>
        private List<string> getListUrl(string dicPre, string Url) {
            List<string> list_Para = new List<string>();
            Regex re;
            MatchCollection aa;
            int step;
            int startI;
            int endI;
            int i = 0;
            try {
                switch (dicPre.Substring(0, dicPre.IndexOf(":"))) {
                    case "Num":
                        re = new Regex("([\\-\\d]+)", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        aa = re.Matches(dicPre);
                        startI = int.Parse(aa[0].Groups[0].Value.ToString());
                        endI = int.Parse(aa[1].Groups[0].Value.ToString());
                        step = int.Parse(aa[2].Groups[0].Value.ToString());
                        if (step > 0) {
                            for (i = startI; i <= endI; i = i + step) {
                                list_Para.Add(i.ToString());
                            }
                        }
                        else {
                            for (i = startI; i >= endI; i = i + step) {
                                list_Para.Add(i.ToString());
                            }
                        }
                        break;

                    case "Letter":
                        startI = getAsc(dicPre.Substring(dicPre.IndexOf(":") + 1, 1));
                        endI = getAsc(dicPre.Substring(dicPre.IndexOf(",") + 1, 1));
                        if (startI > endI) {
                            step = -1;
                        }
                        else {
                            step = 1;
                        }

                        for (i = startI; i <= endI; i = i + step) {
                            char s;
                            s = Convert.ToChar(i);
                            list_Para.Add(s.ToString());
                        }
                        break;
                    case "Date":
                        string[] ary = { "yyyyMMdd", "yyyy-MM-dd" };
                        string lurl = "";
                        if (Array.IndexOf(ary, dicPre.Substring(dicPre.IndexOf(":") + 1)) >= 0) {
                            lurl = DateTime.Now.ToString(dicPre.Substring(dicPre.IndexOf(":") + 1));
                            list_Para.Add(lurl);
                        }
                        break;
                }
            }
            catch (Exception) {
            }
            return list_Para;
        }

        private int getAsc(string s) {
            byte[] array = new byte[1];
            array = System.Text.Encoding.ASCII.GetBytes(s);
            int asciicode = (int)(array[0]);
            return asciicode;
        }
        #endregion
    }
}
