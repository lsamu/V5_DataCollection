using System.Data;
using V5_Model;
namespace V5_DataPlugins
{
    public interface IOutPutFormat
    {
        string Format { get; }
        bool SuportTemplate { get; }
        bool SuportSavePath { get; }
        Result RunSave(DataTable dt,ModelTask task);
    }
    public struct Result
    {
        public bool IsOk { get; set; }
        public string Message { get; set; }
    }
}
