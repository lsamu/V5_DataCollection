using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace V5_WinLibs.Utility {
    public class OriginalUtility {
        public string ContentOriginal(string content, string tag, string tagurl, bool inserttag, bool original, string keyword) {
            if (original) {
                string k = "";// parm.k;
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add(keyword, tag);
                string[] strArray = k.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < strArray.Length; j++) {
                    string key = Regex.Match(strArray[j], "(.+)¡ú(.+)").Groups[1].Value;
                    string str3 = Regex.Match(strArray[j], "(.+)¡ú(.+)").Groups[2].Value;
                    if (!dictionary.ContainsKey(key)) {
                        dictionary.Add(key, str3);
                    }
                }
                foreach (string str4 in dictionary.Keys) {
                    content = Regex.Replace(content, str4, dictionary[str4]);
                }
            }
            if (inserttag) {
                int startIndex = new Random().Next(1, content.Length - 20);
                //if (parm.ubb)
                //{
                //    content = content.Insert(startIndex, "[url=http://" + tagurl + "]" + tag + "[/url]");
                //}
                //else
                {
                    content = content.Insert(startIndex, "<a href=http://" + tagurl + ">" + tag + "</a>");
                }
            }
            string myk = "";// parm.myk;
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
            string[] strArray2 = myk.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strArray2.Length; i++) {
                string str6 = Regex.Match(strArray2[i], "(.+)¡ú(.+)¡ú(.+)").Groups[1].Value;
                string str7 = Regex.Match(strArray2[i], "(.+)¡ú((.+)¡ú(.+))").Groups[2].Value;
                if (!dictionary2.ContainsKey(str6)) {
                    dictionary2.Add(str6, str7);
                }
            }
            foreach (string str8 in dictionary2.Keys) {
                Regex regex = new Regex(str8);
                string str9 = Regex.Match(dictionary2[str8], "(.+)¡ú(.+)").Groups[1].Value;
                string str10 = Regex.Match(dictionary2[str8], "(.+)¡ú(.+)").Groups[2].Value;
                //if (parm.ubb) {
                //    content = regex.Replace(content, "[url=" + str10 + "]" + str9 + "[/url]", 1);
                //}
                //else 

                {
                    content = regex.Replace(content, "<a href=http://" + str10 + ">" + str9 + "</a>", 1);
                }
            }
            return content;
        }

        public string TitleOriginal(string content) {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] strArray = "".Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strArray.Length; i++) {
                string key = Regex.Match(strArray[i], "(.+)¡ú(.+)").Groups[1].Value;
                string str3 = Regex.Match(strArray[i], "(.+)¡ú(.+)").Groups[2].Value;
                if (!dictionary.ContainsKey(key)) {
                    dictionary.Add(key, str3);
                }
            }
            foreach (string str4 in dictionary.Keys) {
                content = Regex.Replace(content, str4, dictionary[str4]);
            }
            return content;
        }
    }
}
