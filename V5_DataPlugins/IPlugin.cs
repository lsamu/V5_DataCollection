using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataPlugins;
using System.Collections;

namespace V5_DataPlugins {
    public enum PageType {
        
    }
    public interface IPlugin {
        string PluginName { get; }
        Hashtable Run(PageType pagetype,Hashtable ht, string pageurl, Encoding encoding, System.Net.CookieCollection cookies);
    }
}
