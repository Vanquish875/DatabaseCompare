using DatabaseCompare.DBCompare;
using DatabaseCompare.Excel;
using DatabaseCompare.Models;
using System.Collections.Generic;

namespace DatabaseCompare.Print
{
    public class PrintTNDPointConfigurationCompare
    {
        private readonly ExcelWriteConfigurationMismatch _excel;
        private readonly TNDPointConfigurationCompare _pointConfigurationCompare;

        public PrintTNDPointConfigurationCompare()
        {
            _excel = new ExcelWriteConfigurationMismatch();
            _pointConfigurationCompare = new TNDPointConfigurationCompare();
        }

        public void PrintTNDTOPCC(string FilePath)
        {
            var Analogs = new Dictionary<Analog, Analog>();
            var Rates = new Dictionary<Rate, Rate>();
            var Statuses = new Dictionary<Status, Status>();
            var Remotes = new Dictionary<Remote, Remote>();

            Analogs = _pointConfigurationCompare.CompareTNDToPCCAnalog(FilePath);
            Rates = _pointConfigurationCompare.CompareTNDToPCCRate(FilePath);
            Statuses = _pointConfigurationCompare.CompareTNDToPCCStatus(FilePath);
            Remotes = _pointConfigurationCompare.CompareTNDToPCCRemote(FilePath);

            _excel.TNDTOPCCWriteToExcel(Analogs, Rates, Statuses, Remotes, FilePath);
        }
    }
}
