using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPlugins {
    public interface IKeyWord {
        List<string> GetKeywordList(string keyword);
    }
}
