using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataCollection._Class.Model {

    public class ModelDownLoadImg {

        public int TaskId { get; set; } = 0;

        public string LocalImg { get; set; } = string.Empty;

        public string RemoteImg { get; set; } = string.Empty;

        public int StepTime { get; set; }
    }
}
