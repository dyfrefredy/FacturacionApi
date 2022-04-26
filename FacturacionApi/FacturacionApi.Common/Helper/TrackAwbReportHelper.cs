using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FacturacionApi.Common.Helper
{
    public class TrackAwbReportHelper
    {
        public byte[] CreateExcel()
        {
            var memoryStream = new MemoryStream();
            using (var excel = SpreadsheetDocument.Create(memoryStream, SpreadsheetDocumentType.Workbook, true))
            {
                CreateParts(excel);
            }

            return memoryStream.ToArray();
        }

        public void CreateParts(SpreadsheetDocument excel)
        {
            //workbook area
            var workbookPart = excel.AddWorkbookPart();
            //workbook content
            CreateWorkbookPartContent(workbookPart);

            //worksheet area
            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetContent(worksheetPart);
        }

        private static void CreateWorkbookPartContent(WorkbookPart workbookPart)
        {
            var workbook = new Workbook();

            //Workbook sheets
            var sheets = new Sheets();
            var sheet = new Sheet { Name = "ReturnGisSheet", SheetId = 1, Id = "rId1" };

            sheets.Append(sheet);
            workbook.Append(sheets);

            workbookPart.Workbook = workbook;
        }

        private static void GenerateWorksheetContent(WorksheetPart worksheetPart)
        {
            var worksheet = new Worksheet();

            var sheetData = new SheetData();

            worksheet.Append(sheetData);

            worksheetPart.Worksheet = worksheet;
        }

        public void GetTrackAwbReport()
        {

            SpreadsheetDocument doc = SpreadsheetDocument.Create("", SpreadsheetDocumentType.Workbook);

            //create the object for workbook part  
            WorkbookPart workbookPart = doc.WorkbookPart;
            Sheets thesheetcollection = workbookPart.Workbook.GetFirstChild<Sheets>();
            StringBuilder excelResult = new StringBuilder();
            //using for each loop to get the sheet from the sheetcollection  
            foreach (Sheet thesheet in thesheetcollection)
            {
                excelResult.AppendLine("Excel Sheet Name : " + thesheet.Name);
                excelResult.AppendLine("----------------------------------------------- ");
                //statement to get the worksheet object by using the sheet id  
                Worksheet theWorksheet = ((WorksheetPart)workbookPart.GetPartById(thesheet.Id)).Worksheet;

                SheetData thesheetdata = (SheetData)theWorksheet.GetFirstChild<SheetData>();
                foreach (Row thecurrentrow in thesheetdata)
                {
                    foreach (Cell thecurrentcell in thecurrentrow)
                    {
                        if (thecurrentcell.DataType != null)
                        {
                            if (thecurrentcell.DataType == CellValues.SharedString)
                            {
                                if (Int32.TryParse(thecurrentcell.InnerText, out int id))
                                {
                                    SharedStringItem item = workbookPart.SharedStringTablePart.SharedStringTable.Elements<SharedStringItem>().ElementAt(id);
                                    //statement to take the integer value
                                    if (item.Text != null)
                                    {
                                        //code to take the string value  
                                        excelResult.Append(item.Text.Text + " ");
                                    }
                                    else if (item.InnerText != null)
                                    {
                                       
                                    }
                                    else if (item.InnerXml != null)
                                    {
                                       
                                    }
                                }
                            }
                        }
                        else
                        {
                            excelResult.Append(Convert.ToInt16(thecurrentcell.InnerText) + " ");
                        }
                    }
                    excelResult.AppendLine();
                }
                excelResult.Append("");
                Console.WriteLine(excelResult.ToString());
                Console.ReadLine();
            }
        }
    }
}
