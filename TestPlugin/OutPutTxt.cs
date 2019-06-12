using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V5_DataPlugins;
using V5_Model;
using System.IO;
using System.Data;
namespace TestPlugin
{
    public class OutPutTxt:IOutPutFormat
    {
        public override string ToString()
        {
            return Format;
        }
        public string Format { get { return ".txt"; } }
        public bool SuportTemplate { get { return false; } }
        public bool SuportSavePath { get { return true; } }
        public Result RunSave(DataTable dt, ModelTask task)
        {
            try
            {
                StringBuilder str = new StringBuilder();
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (ModelTaskLabel mTaskLabel in task.ListTaskLabel)
                    {
                        str.Append(mTaskLabel.LabelName + ":" + dr[mTaskLabel.LabelName] + "\r\n");
                    }
                    str.Append("\r\n\r\n");
                }
                using (StreamWriter sw = new StreamWriter(task.SaveDirectory2 + $"\\{task.TaskName}保存文本采集结果.txt", false, Encoding.UTF8))
                {
                    sw.Write(str.ToString());
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                return new Result() { IsOk = false, Message = "错误!" + ex.Message };
            }
            return new Result() { IsOk = true, Message = "保存成功" };
        }
    }
}
