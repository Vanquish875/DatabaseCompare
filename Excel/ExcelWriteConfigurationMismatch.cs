using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using DatabaseCompare.Models;
using System;

namespace DatabaseCompare.Excel
{
    public class ExcelWriteConfigurationMismatch
    {
        public void PCCTOTNDWriteToExcel(Dictionary<Analog, Analog> analogs, Dictionary<Rate, Rate> rates, Dictionary<Status, Status> status, Dictionary<Remote, Remote> remotes, string FilePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string month = DateTime.Now.ToString("MM");
            string name = "DBCompareConfigurationPCCToTND" + month;

            using ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("Analog_PCC");
            excel.Workbook.Worksheets.Add("Analog_TND");
            excel.Workbook.Worksheets.Add("Rate_PCC");
            excel.Workbook.Worksheets.Add("Rate_TND");
            excel.Workbook.Worksheets.Add("Status_PCC");
            excel.Workbook.Worksheets.Add("Status_TND");
            excel.Workbook.Worksheets.Add("Remote_PCC");
            excel.Workbook.Worksheets.Add("Remote_TND");

            var AnalogPCCWorksheet = excel.Workbook.Worksheets["Analog_PCC"];
            var AnalogTNDWorksheet = excel.Workbook.Worksheets["Analog_TND"];
            var RatePCCWorksheet = excel.Workbook.Worksheets["Rate_PCC"];
            var RateTNDWorksheet = excel.Workbook.Worksheets["Rate_TND"];
            var StatusPCCWorksheet = excel.Workbook.Worksheets["Status_PCC"];
            var StatusTNDWorksheet = excel.Workbook.Worksheets["Status_TND"];
            var RemotePCCWorksheet = excel.Workbook.Worksheets["Remote_PCC"];
            var RemoteTNDWorksheet = excel.Workbook.Worksheets["Remote_TND"];

            AnalogPCCWorksheet.Cells.LoadFromCollection(analogs.Keys, true);
            AnalogTNDWorksheet.Cells.LoadFromCollection(analogs.Values, true);
            RatePCCWorksheet.Cells.LoadFromCollection(rates.Keys, true);
            RateTNDWorksheet.Cells.LoadFromCollection(rates.Values, true);
            StatusPCCWorksheet.Cells.LoadFromCollection(status.Keys, true);
            StatusTNDWorksheet.Cells.LoadFromCollection(status.Values, true);
            RemotePCCWorksheet.Cells.LoadFromCollection(remotes.Keys, true);
            RemoteTNDWorksheet.Cells.LoadFromCollection(remotes.Values, true);

            FileInfo excelFile = new FileInfo(FilePath + @"\" + name + ".xlsx");
            excel.SaveAs(excelFile);
            Console.WriteLine($"Generated file: {FilePath}\\{name}.xlsx");
        }

        public void TNDTOPCCWriteToExcel(Dictionary<Analog, Analog> analogs, Dictionary<Rate, Rate> rates, Dictionary<Status, Status> status, Dictionary<Remote, Remote> remotes, string FilePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string month = DateTime.Now.ToString("MM");
            string name = "DBCompareConfigurationTNDTOPCC" + month;

            using ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("Analog_TND");
            excel.Workbook.Worksheets.Add("Analog_PCC");
            excel.Workbook.Worksheets.Add("Rate_TND");
            excel.Workbook.Worksheets.Add("Rate_PCC");
            excel.Workbook.Worksheets.Add("Status_TND");
            excel.Workbook.Worksheets.Add("Status_PCC");
            excel.Workbook.Worksheets.Add("Remote_TND");
            excel.Workbook.Worksheets.Add("Remote_PCC");

            var AnalogTNDWorksheet = excel.Workbook.Worksheets["Analog_TND"];
            var AnalogPCCWorksheet = excel.Workbook.Worksheets["Analog_PCC"];
            var RateTNDWorksheet = excel.Workbook.Worksheets["Rate_TND"];
            var RatePCCWorksheet = excel.Workbook.Worksheets["Rate_PCC"];
            var StatusTNDWorksheet = excel.Workbook.Worksheets["Status_TND"];
            var StatusPCCWorksheet = excel.Workbook.Worksheets["Status_PCC"];
            var RemoteTNDWorksheet = excel.Workbook.Worksheets["Remote_TND"];
            var RemotePCCWorksheet = excel.Workbook.Worksheets["Remote_PCC"];

            AnalogTNDWorksheet.Cells.LoadFromCollection(analogs.Keys, true);
            AnalogPCCWorksheet.Cells.LoadFromCollection(analogs.Values, true);
            RateTNDWorksheet.Cells.LoadFromCollection(rates.Keys, true);
            RatePCCWorksheet.Cells.LoadFromCollection(rates.Values, true);
            StatusTNDWorksheet.Cells.LoadFromCollection(status.Keys, true);
            StatusPCCWorksheet.Cells.LoadFromCollection(status.Values, true);
            RemoteTNDWorksheet.Cells.LoadFromCollection(remotes.Keys, true);
            RemotePCCWorksheet.Cells.LoadFromCollection(remotes.Values, true);

            FileInfo excelFile = new FileInfo(FilePath + @"\" + name + ".xlsx");
            excel.SaveAs(excelFile);
            Console.WriteLine($"Generated file: {FilePath}\\{name}.xlsx");
        }
    }
}
