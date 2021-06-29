using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using System;

namespace DatabaseCompare.Excel
{
    public class ExcelWriteMissingPoints
    {
        public void WriteToExcel(string name, List<string> analogs, List<string> rates, List<string> statuses, List<string> remotes, string filepath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("Analog");
            excel.Workbook.Worksheets.Add("Rate");
            excel.Workbook.Worksheets.Add("Status");
            excel.Workbook.Worksheets.Add("Remote");

            var AnalogWorksheet = excel.Workbook.Worksheets["Analog"];
            var RateWorksheet = excel.Workbook.Worksheets["Rate"];
            var DigitalWorksheet = excel.Workbook.Worksheets["Status"];
            var RemoteWorksheet = excel.Workbook.Worksheets["Remote"];

            AnalogWorksheet.Cells.LoadFromCollection(analogs, false);
            RateWorksheet.Cells.LoadFromCollection(rates, false);
            DigitalWorksheet.Cells.LoadFromCollection(statuses, false);
            RemoteWorksheet.Cells.LoadFromCollection(remotes, false);

            FileInfo excelFile = new FileInfo(filepath + name + ".xlsx");
            excel.SaveAs(excelFile);
            Console.WriteLine($"Generated file: {filepath}\\{name}.xlsx");
        }
    }
}
