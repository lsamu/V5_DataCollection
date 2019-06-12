using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_Model {
    public class ModelTaskClass {
        int _ClassID;

        public int ClassID {
            get { return _ClassID; }
            set { _ClassID = value; }
        }
        string _TreeClassName;

        public string TreeClassName {
            get { return _TreeClassName; }
            set { _TreeClassName = value; }
        }
        string _TreeClassReadMe;

        public string TreeClassReadMe {
            get { return _TreeClassReadMe; }
            set { _TreeClassReadMe = value; }
        }
    }
}
