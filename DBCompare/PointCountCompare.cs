using DatabaseCompare.Parsing;
using DatabaseCompare.Excel;
using DatabaseCompare.DBInsert;

namespace DatabaseCompare.DBCompare
{
    public class PointCountCompare
    {
        private readonly ParseName _parser;
        private readonly CheckIfExists _checkIfExists;
        const string PCCANALOG = @"\pcc\analog.l";
        const string PCCRATE = @"\pcc\rate.l";
        const string PCCSTATUS = @"\pcc\status.l";
        const string PCCREMOTE = @"\pcc\remote.l";
        const string PCCACECODE = @"\pcc\acecode.l";
        const string PCCACECONFIG = @"\pcc\aceconfig.l";
        const string PCCCONNECTION = @"\pcc\connection.l";
        const string PCCMULTISTATE = @"\pcc\multistate.l";
        const string TNDANALOG = @"\tnd\analog.l";
        const string TNDRATE = @"\tnd\rate.l";
        const string TNDSTATUS = @"\tnd\status.l";
        const string TNDREMOTE = @"\tnd\remote.l";
        const string TNDACECODE = @"\tnd\acecode.l";
        const string TNDACECONFIG = @"\tnd\aceconfig.l";
        const string TNDCONNECTION = @"\tnd\connection.l";
        const string TNDMULTISTATE = @"\tnd\multistate.l";

        public PointCountCompare()
        {
            _parser = new ParseName();
            _checkIfExists = new CheckIfExists();
        }

        public void ComparePCCToTND(string FilePath, bool IsADEInserts)
        {
            var analogs = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCANALOG), _parser.FindNamesHash(FilePath + TNDANALOG));
            var rates = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCRATE), _parser.FindNamesHash(FilePath + TNDRATE));
            var statuses = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCSTATUS), _parser.FindNamesHash(FilePath + TNDSTATUS));
            var remotes = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCREMOTE), _parser.FindNamesHash(FilePath + TNDREMOTE));
            var aceCodes = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCACECODE), _parser.FindNamesHash(FilePath + TNDACECODE));
            var aceConfigs = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCACECONFIG), _parser.FindNamesHash(FilePath + TNDACECONFIG));
            var connections = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCCONNECTION), _parser.FindNamesHash(FilePath + TNDCONNECTION));
            var multistates = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + PCCMULTISTATE), _parser.FindNamesHash(FilePath + TNDMULTISTATE));


            if (IsADEInserts)
            {
                var manageADE = new ManageADEInsert();

                manageADE.ManageInsertForPCCToTND(FilePath, analogs, rates, statuses);
            }

            if(!IsADEInserts)
            {
                ExcelWriteMissingPoints excel = new ExcelWriteMissingPoints();

                string name = "DBCompare_PCCToTND";

                excel.WriteToExcel(name, analogs, rates, statuses, remotes, aceCodes, aceConfigs, connections, multistates, FilePath);
            }
            
        }

        public void CompareTNDToPCC(string FilePath, bool IsADEInserts)
        {
            var analogs = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDANALOG), _parser.FindNamesHash(FilePath + PCCANALOG));
            var rates = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDRATE), _parser.FindNamesHash(FilePath + PCCRATE));
            var statuses = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDSTATUS), _parser.FindNamesHash(FilePath + PCCSTATUS));
            var remotes = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDREMOTE), _parser.FindNamesHash(FilePath + PCCREMOTE));
            var aceCodes = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDACECODE), _parser.FindNamesHash(FilePath + PCCACECODE));
            var aceConfigs = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDACECONFIG), _parser.FindNamesHash(FilePath + PCCACECONFIG));
            var connections = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDCONNECTION), _parser.FindNamesHash(FilePath + PCCCONNECTION));
            var multistates = _checkIfExists.CheckIfPointExists(_parser.FindNamesList(FilePath + TNDMULTISTATE), _parser.FindNamesHash(FilePath + PCCMULTISTATE));

            if(IsADEInserts)
            {
                var manageADE = new ManageADEInsert();
                manageADE.ManageInsertForTNDToPCC(FilePath, analogs, rates, statuses);
            }

            if(!IsADEInserts)
            {
                ExcelWriteMissingPoints excel = new ExcelWriteMissingPoints();

                string name = "DBCompare_TNDToPCC";

                excel.WriteToExcel(name, analogs, rates, statuses, remotes, aceCodes, aceConfigs, connections, multistates, FilePath);
            }  
        }
    }
}
