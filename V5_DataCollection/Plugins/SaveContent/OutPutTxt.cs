using System;
using V5_Model;
using System.Text;
using V5_DataPlugins;
using System.Data;
using System.IO;
namespace V5_DataCollection.Plugins.SaveContent
{
    public class OutPutTxt : IOutPutFormat
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
                    str.Append( "\r\n\r\n");
                }
                using (StreamWriter sw = new StreamWriter(task.SaveDirectory2 + $"\\{task.TaskName}采集结果文本保存.txt", false, Encoding.UTF8))
                {
                    sw.Write(str.ToString());
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                return new Result() { IsOk=false, Message= "错误!" + ex.Message    };
            }
            return new Result() { IsOk = true, Message = "保存成功" };
        }
    }
}
