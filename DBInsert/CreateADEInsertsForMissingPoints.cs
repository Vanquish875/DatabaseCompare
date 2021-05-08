using DatabaseCompare.Excel;
using DatabaseCompare.Models.InputModels;
using System.Collections.Generic;

namespace DatabaseCompare.DBInsert
{
    public class CreateADEInsertsForMissingPoints
    {
        private readonly ExcelCreateADEInserts _excelCreateADE;

        const string TNDTOPCCNAME = "TNDToPCCADEInsert";
        const string PCCTOTNDNAME = "PCCToTNDADEInsert";

        public CreateADEInsertsForMissingPoints()
        {
            _excelCreateADE = new ExcelCreateADEInserts();
        }

        public void CreateInsertForTNDToPCC(string filePath, List<AnalogADE> analogs, List<RateADE> rates, List<StatusADE> statuses)
        {
            _excelCreateADE.WriteAnalogToExcel(filePath, TNDTOPCCNAME + "Analog", analogs);
            _excelCreateADE.WriteRateToExcel(filePath, TNDTOPCCNAME + "Rate", rates);
            _excelCreateADE.WriteStatusToExcel(filePath, TNDTOPCCNAME + "Status", statuses);
        }

        public void CreateInsertForPCCToTND(string filePath, List<AnalogADE> analogs, List<RateADE> rates, List<StatusADE> statuses)
        {
            _excelCreateADE.WriteAnalogToExcel(filePath, PCCTOTNDNAME + "Analog", analogs);
            _excelCreateADE.WriteRateToExcel(filePath, PCCTOTNDNAME + "Rate", rates);
            _excelCreateADE.WriteStatusToExcel(filePath, PCCTOTNDNAME + "Status", statuses);
        }
    }
}
