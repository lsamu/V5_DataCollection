using System;
using V5_Model;
using System.Text;
using V5_DataPlugins;
using System.Data;
using System.IO;
namespace V5_DataCollection.Plugins.SaveContent
{
    public class OutPutHtml : IOutPutFormat
    {
        public override string ToString()
        {
            return Format;
        }
        public string Format { get { return ".html"; } }
        public bool SuportTemplate { get { return false; } }
        public bool SuportSavePath { get { return true; } }
        public Result RunSave(DataTable dt, ModelTask task)
        {
            try
            {
                StringBuilder str = new StringBuilder();
                foreach (DataRow dr in dt.Rows)
                {
                    
                    //str.Append( dr["内容"].ToString());
                    try
                    {
                        string fileName = "";
                        if (dt.Columns.Contains("标题"))
                        {
                            fileName = dr["标题"].ToString();
                            fileName = fileName.Replace(".", "");
                            fileName = fileName.Replace(",", "");
                            fileName = fileName.Replace("、", "");
                            fileName = fileName.Replace(" ", "");
                            fileName = fileName.Replace("*", "_");
                            fileName = fileName.Replace("?", "_");
                            fileName = fileName.Replace("/", "_");
                            fileName = fileName.Replace("\\", "_");
                            fileName = fileName.Replace(":", "_");
                            fileName = fileName.Replace("|", "_");
                            fileName += ".html";
                        }
                        else
                        {
                            fileName = dr["ID"].ToString() + ".html";
                        }
                        foreach (ModelTaskLabel mTaskLabel in task.ListTaskLabel)
                        {
                            str.Append( dr[mTaskLabel.LabelName]);
                        }
                        using (StreamWriter sw = new StreamWriter(task.SaveDirectory2 + "\\" + fileName, false, Encoding.UTF8))
                        {
                            sw.Write(str);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    catch
                    {
                        continue;
                    }
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
