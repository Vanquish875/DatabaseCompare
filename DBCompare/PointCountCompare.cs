using DatabaseCompare.Parsing;
using DatabaseCompare.Excel;

namespace DatabaseCompare.DBCompare
{
    public class PointCountCompare
    {
        private readonly ParseName _parser;
        private readonly CheckIfExists _checkIfExists;
        const string PCCANALOG = @"pcc\analog.l";
        const string PCCRATE = @"pcc\rate.l";
        const string PCCSTATUS = @"pcc\status.l";
        const string PCCREMOTE = @"pcc\remote.l";
        const string TNDANALOG = @"tnd\analog.l";
        const string TNDRATE = @"tnd\rate.l";
        const string TNDSTATUS = @"tnd\status.l";
        const string TNDREMOTE = @"tnd\remote.l";


        public PointCountCompare()
        {
            _parser = new ParseName();
            _checkIfExists = new CheckIfExists();
        }

        public void ComparePCCToTND(string FilePath)
        {
            var analogs = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCANALOG), _parser.FindNamesHash(FilePath + TNDANALOG));
            var rates = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCRATE), _parser.FindNamesHash(FilePath + TNDRATE));
            var statuses = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCSTATUS), _parser.FindNamesHash(FilePath + TNDSTATUS));
            var remotes = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCREMOTE), _parser.FindNamesHash(FilePath + TNDREMOTE));

            
            ExcelWriteMissingPoints excel = new ExcelWriteMissingPoints();

            string name = "DBCompare_PCCToTND";

            excel.WriteToExcel(name, analogs, rates, statuses, remotes);
        }

        public void CompareTNDToPCC(string FilePath)
        {
            var analogs = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDANALOG), _parser.FindNamesHash(FilePath + PCCANALOG));
            var rates = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDRATE), _parser.FindNamesHash(FilePath + PCCRATE));
            var statuses = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDSTATUS), _parser.FindNamesHash(FilePath + PCCSTATUS));
            var remotes = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDREMOTE), _parser.FindNamesHash(FilePath + PCCREMOTE));


            ExcelWriteMissingPoints excel = new ExcelWriteMissingPoints();

            string name = "DBCompare_TNDToPCC";

            excel.WriteToExcel(name, analogs, rates, statuses, remotes);
        }
    }
}
