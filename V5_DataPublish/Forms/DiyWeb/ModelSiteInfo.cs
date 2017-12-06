using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataPublish.Forms.DiyWeb {
    public class ModelSiteInfo {
        string _userName = string.Empty;

        public string UserName {
            get { return _userName; }
            set { _userName = value; }
        }
        string _userPwd = string.Empty;

        public string UserPwd {
            get { return _userPwd; }
            set { _userPwd = value; }
        }
        string _title = string.Empty;

        public string Title {
            get { return _title; }
            set { _title = value; }
        }

        string _url = string.Empty;

        public string Url {
            get { return _url; }
            set { _url = value; }
        }

        string _encode = string.Empty;

        public string Encode {
            get { return _encode; }
            set { _encode = value; }
        }

        string _plugin = string.Empty;

        public string Plugin {
            get { return _plugin; }
            set { _plugin = value; }
        }
    }
}
