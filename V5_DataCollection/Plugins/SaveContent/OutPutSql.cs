using System;
using System.Collections.Generic;
using V5_Model;
using System.Text;
using System.Threading.Tasks;
using V5_DataPlugins;
using System.Data;
using System.IO;
namespace V5_DataCollection.Plugins.SaveContent
{
    public class OutPutSql : IOutPutFormat
    {
        public override string ToString()
        {
            return Format;
        }
        public string Format { get { return ".sql"; } }
        public bool SuportTemplate { get { return false; } }
        public bool SuportSavePath { get { return false; } }
        public Result RunSave(DataTable dt, ModelTask task)
        {
            try
            {
                string strTemplateContent = File.ReadAllText(task.SaveHtmlTemplate2, Encoding.UTF8);
                StringBuilder sbContent = new StringBuilder();
                foreach (DataRow dr in dt.Rows)
                {
                    string sql = strTemplateContent;
                    foreach (ModelTaskLabel mTaskLabel in task.ListTaskLabel)
                    {
                        string content = dr[mTaskLabel.LabelName].ToString().Replace("'", "''");
                        sql = sql.Replace("[" + mTaskLabel.LabelName + "]", content);
                    }
                    sbContent.AppendLine(sql);
                }
                using (StreamWriter sw = new StreamWriter(task.SaveDirectory2 + "\\sql.sql", false, Encoding.UTF8))
                {
                    sw.Write(sbContent.ToString());
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                return new Result() { IsOk=false, Message= "错误!" + ex.Message    };
               // gatherEv.Message = "错误!" + ex.Message;
               // PublishCompalteDelegate?.Invoke(this, gatherEv);
            }
            return new Result() { IsOk = true, Message = "保存成功" };
        }
    }
}
