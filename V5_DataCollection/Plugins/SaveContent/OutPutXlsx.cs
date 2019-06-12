using System;
using System.Collections.Generic;
using V5_Model;
using System.Text;
using System.Threading.Tasks;
using V5_DataPlugins;
using System.Data;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using System.Linq;
namespace V5_DataCollection.Plugins.SaveContent
{
    public class OutPutXlsx : IOutPutFormat
    {
        public override string ToString()
        {
            return Format;
        }
        public string Format { get { return ".xlsx"; } }
        public bool SuportTemplate { get { return false; } }
        public bool SuportSavePath { get { return true; } }
        public Result RunSave(DataTable dt, ModelTask task)
        {
            try
            {
                CreateExcel(task.SaveDirectory2 + $"\\{task.TaskName}导出结果{DateTime.Now.ToString("-yyyy-MM-dd")}.xlsx", dt);
            }
            catch (Exception ex)
            {
                return new Result() { IsOk=false, Message= "错误!" + ex.Message    };
            }
            return new Result() { IsOk = true, Message = "保存成功" };
        }
        #region CreateExcel Interop 2007
        //20190526增加导出excel功能
        /// <summary>
        /// 创建excel,并且把dataTable导入到excel中
        /// </summary>       
        /// <param name="filePath">保存路径</param>
        /// <param name="table">数据源</param>       
        public void CreateExcel(string filePath, DataTable table)
        {
            using (var workbook = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = workbook.AddWorkbookPart();
                workbook.WorkbookPart.Workbook = new Workbook
                {
                    Sheets = new Sheets()
                };

                uint sheetId = 1;
                bool isAddStyle = false;

                var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                sheetPart.Worksheet = new Worksheet();
                if (!isAddStyle)
                {
                    var stylesPart = workbook.WorkbookPart.AddNewPart<WorkbookStylesPart>();
                    Stylesheet styles = new Stylesheet();
                    styles.Save(stylesPart);
                    isAddStyle = true;
                }

                Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<Sheets>();
                string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                if (sheets.Elements<Sheet>().Count() > 0)
                {
                    sheetId =
                        sheets.Elements<Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                }
                string sheetName = table.TableName;


                Sheet sheet = new Sheet() { Id = relationshipId, SheetId = sheetId, Name = sheetName };
                sheets.Append(sheet);
                sheetPart.Worksheet.Append(CreateSheetData(table));

                workbook.Close();
            }
        }



        private SheetData CreateSheetData(DataTable table)
        {
            var sheetData = new SheetData();
            Row headerRow = new Row();

            List<String> columns = new List<string>();
            foreach (DataColumn column in table.Columns)
            {
                columns.Add(column.ColumnName);

                Cell cell = new Cell();
                cell.StyleIndex = 11;
                cell.DataType = CellValues.String;
                cell.CellValue = new CellValue(column.ColumnName);
                headerRow.Append(cell);
            }

            sheetData.Append(headerRow);

            foreach (DataRow dsrow in table.Rows)
            {
                Row newRow = new Row();
                foreach (String col in columns)
                {
                    Cell cell = new Cell();
                    cell.StyleIndex = 10;
                    cell.DataType = CellValues.String;
                    cell.CellValue = new CellValue(dsrow[col].ToString()); //
                    newRow.Append(cell);
                }

                sheetData.Append(newRow);
            }

            return sheetData;
        }
        #endregion
    }
}
