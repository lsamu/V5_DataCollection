using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPlugins {
    public interface IPublishContent {
        void Run(string WebSiteID, string WebSiteName, ref string Title, ref string Content);
    }
}
