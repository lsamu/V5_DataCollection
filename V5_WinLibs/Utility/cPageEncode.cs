using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_WinUtility.Expand {
    public class cPageEncode {
        /// <summary>
        /// ÍøÕ¾±àÂë
        /// </summary>
        /// <returns></returns>
        public static List<ListItem> GetPageEnCode() {
            List<ListItem> items = new List<ListItem>();
            items = new List<ListItem>();
            items.Add(new ListItem("×Ô¶¯±àÂë", "×Ô¶¯±àÂë"));
            items.Add(new ListItem("utf-8", "utf-8"));
            items.Add(new ListItem("gb2312", "gb2312"));
            items.Add(new ListItem("gbk", "gbk"));
            return items;
        }
    }
}
