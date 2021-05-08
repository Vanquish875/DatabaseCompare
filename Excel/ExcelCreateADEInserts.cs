using DatabaseCompare.Models.InputModels;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace DatabaseCompare.Excel
{
    public class ExcelCreateADEInserts
    {
        public void WriteAnalogToExcel(string filePath, string name, List<AnalogADE> analogs)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("analog");

                var AnalogWorksheet = excel.Workbook.Worksheets["analog"];

                AnalogWorksheet.Cells.LoadFromCollection(analogs, true);

                FileInfo excelFile = new FileInfo(filePath + @"\" + name + ".xlsx");
                excel.SaveAs(excelFile);
            }
        }

        public void WriteRateToExcel(string filePath, string name, List<RateADE> rates)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("rate");

                var RateWorksheet = excel.Workbook.Worksheets["rate"];

                RateWorksheet.Cells.LoadFromCollection(rates, true);

                FileInfo excelFile = new FileInfo(filePath + @"\" + name + ".xlsx");
                excel.SaveAs(excelFile);
            }
        }

        public void WriteStatusToExcel(string filePath, string name, List<StatusADE> statuses)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("status");

                var DigitalWorksheet = excel.Workbook.Worksheets["status"];

                DigitalWorksheet.Cells.LoadFromCollection(statuses, true);

                FileInfo excelFile = new FileInfo(filePath + @"\" + name + ".xlsx");
                excel.SaveAs(excelFile);
            }
        }
    }
}
