using DatabaseCompare.DBCompare;
using DatabaseCompare.Excel;
using DatabaseCompare.Models;
using System.Collections.Generic;

namespace DatabaseCompare.Print
{
    public class PrintPCCPointConfigurationCompare
    {
        private readonly ExcelWriteConfigurationMismatch _excel;
        private readonly PCCPointConfigurationCompare _pointConfigurationCompare;

        public PrintPCCPointConfigurationCompare()
        {
            _excel = new ExcelWriteConfigurationMismatch();
            _pointConfigurationCompare = new PCCPointConfigurationCompare();
        }

        public void PrintPCCToTND(string FilePath)
        {
            var Analogs = new Dictionary<Analog, Analog>();
            var Rates = new Dictionary<Rate, Rate>();
            var Statuses = new Dictionary<Status, Status>();
            var Remotes = new Dictionary<Remote, Remote>();

            Analogs = _pointConfigurationCompare.ComparePCCToTNDAnalog(FilePath);
            Rates = _pointConfigurationCompare.ComparePCCToTNDRate(FilePath);
            Statuses = _pointConfigurationCompare.ComparePCCToTNDStatus(FilePath);
            Remotes = _pointConfigurationCompare.ComparePCCToTNDRemote(FilePath);

            _excel.PCCTOTNDWriteToExcel(Analogs, Rates, Statuses, Remotes, FilePath);
        }
    }
}
