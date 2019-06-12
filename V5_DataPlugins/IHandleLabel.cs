using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V5_DataPlugins
{
    public interface IHandleLabel
    {
        string Name { get; }
        string Handle(string remoteViewUrl, string cutContent);
    }

}
