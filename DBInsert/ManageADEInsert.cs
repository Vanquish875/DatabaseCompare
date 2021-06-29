using DatabaseCompare.DotLFields;
using DatabaseCompare.Mapping.ADEMapping;
using DatabaseCompare.Parsing;
using System.Collections.Generic;

namespace DatabaseCompare.DBInsert
{
    public class ManageADEInsert
    {
        private readonly Parser _parser;
        private readonly AnalogADEMapping _analogMapping;
        private readonly RateADEMapping _rateMapping;
        private readonly StatusADEMapping _statusMapping;
        private readonly CreateADEInsertsForMissingPoints _createADEInserts;

        const string PCCANALOG = @"\pcc\analog.l";
        const string PCCRATE = @"\pcc\rate.l";
        const string PCCSTATUS = @"\pcc\status.l";
        //const string PCCREMOTE = @"\pcc\remote.l";
        const string TNDANALOG = @"\tnd\analog.l";
        const string TNDRATE = @"\tnd\rate.l";
        const string TNDSTATUS = @"\tnd\status.l";
        //const string TNDREMOTE = @"\tnd\remote.l";

        public ManageADEInsert()
        {
            _parser = new Parser();
            _analogMapping = new AnalogADEMapping();
            _rateMapping = new RateADEMapping();
            _statusMapping = new StatusADEMapping();
            _createADEInserts = new CreateADEInsertsForMissingPoints();
        }

        public void ManageInsertForTNDToPCC(string filePath, List<string> analogs, List<string> rates, List<string> statuses)
        {
            var AnalogList = _analogMapping.MapAnalog(_parser.ProcessFileList(filePath + TNDANALOG, AnalogFields.Fields), analogs);
            var RateList = _rateMapping.MapRate(_parser.ProcessFileList(filePath + TNDRATE, RateFields.Fields), rates);
            var StatusList = _statusMapping.MapStatus(_parser.ProcessFileList(filePath + TNDSTATUS, StatusFields.Fields), statuses);

            _createADEInserts.CreateInsertForTNDToPCC(filePath, AnalogList, RateList, StatusList);
        }

        public void ManageInsertForPCCToTND(string filePath, List<string> analogs, List<string> rates, List<string> statuses)
        {
            var AnalogList = _analogMapping.MapAnalog(_parser.ProcessFileList(filePath + PCCANALOG, AnalogFields.Fields), analogs);
            var RateList = _rateMapping.MapRate(_parser.ProcessFileList(filePath + PCCRATE, RateFields.Fields), rates);
            var StatusList = _statusMapping.MapStatus(_parser.ProcessFileList(filePath + PCCSTATUS, StatusFields.Fields), statuses);

            _createADEInserts.CreateInsertForPCCToTND(filePath, AnalogList, RateList, StatusList);
        }
    }
}
