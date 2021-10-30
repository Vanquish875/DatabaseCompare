using DatabaseCompare.DBCompare;
using DatabaseCompare.Excel;

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
            var Analogs = _pointConfigurationCompare.ComparePCCToTNDAnalog(FilePath);
            var Rates = _pointConfigurationCompare.ComparePCCToTNDRate(FilePath);
            var Statuses = _pointConfigurationCompare.ComparePCCToTNDStatus(FilePath);
            var Remotes = _pointConfigurationCompare.ComparePCCToTNDRemote(FilePath);

            _excel.PCCTOTNDWriteToExcel(Analogs, Rates, Statuses, Remotes, FilePath);
        }
    }
}
