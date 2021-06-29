using DatabaseCompare.DBCompare;
using DatabaseCompare.Excel;

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
            var Analogs = _pointConfigurationCompare.CompareTNDToPCCAnalog(FilePath);
            var Rates = _pointConfigurationCompare.CompareTNDToPCCRate(FilePath);
            var Statuses = _pointConfigurationCompare.CompareTNDToPCCStatus(FilePath);
            var Remotes = _pointConfigurationCompare.CompareTNDToPCCRemote(FilePath);

            _excel.TNDTOPCCWriteToExcel(Analogs, Rates, Statuses, Remotes, FilePath);
        }
    }
}
