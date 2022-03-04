using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using System;

namespace DatabaseCompare.Excel
{
    public class ExcelWriteMissingPoints
    {
        public void WriteToExcel(string name, List<string> analogs, List<string> rates, List<string> statuses, List<string> remotes, List<string> aceCodes, 
            List<string> aceConfigs, List<string> connections, List<string> multistates, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("Analog");
            excel.Workbook.Worksheets.Add("Rate");
            excel.Workbook.Worksheets.Add("Status");
            excel.Workbook.Worksheets.Add("Remote");
            excel.Workbook.Worksheets.Add("Connection");
            excel.Workbook.Worksheets.Add("AceCode");
            excel.Workbook.Worksheets.Add("AceConfig");
            excel.Workbook.Worksheets.Add("Multistate");

            var AnalogWorksheet = excel.Workbook.Worksheets["Analog"];
            var RateWorksheet = excel.Workbook.Worksheets["Rate"];
            var DigitalWorksheet = excel.Workbook.Worksheets["Status"];
            var RemoteWorksheet = excel.Workbook.Worksheets["Remote"];
            var ConnectionWorksheet = excel.Workbook.Worksheets["Connection"];
            var AceCodeWorksheet = excel.Workbook.Worksheets["AceCode"];
            var AceConfigWorksheet = excel.Workbook.Worksheets["AceConfig"];
            var MultistateWorksheet = excel.Workbook.Worksheets["Multistate"];

            AnalogWorksheet.Cells.LoadFromCollection(analogs, false);
            RateWorksheet.Cells.LoadFromCollection(rates, false);
            DigitalWorksheet.Cells.LoadFromCollection(statuses, false);
            RemoteWorksheet.Cells.LoadFromCollection(remotes, false);
            ConnectionWorksheet.Cells.LoadFromCollection(connections, false);
            AceCodeWorksheet.Cells.LoadFromCollection(aceCodes, false);
            AceConfigWorksheet.Cells.LoadFromCollection(aceConfigs, false);
            MultistateWorksheet.Cells.LoadFromCollection(multistates, false);

            FileInfo excelFile = new FileInfo(filePath + name + ".xlsx");
            excel.SaveAs(excelFile);
            Console.WriteLine($"Generated file: {filePath}\\{name}.xlsx");
            
        }
    }
}
