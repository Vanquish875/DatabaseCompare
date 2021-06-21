using DatabaseCompare.Models;
using DatabaseCompare.Parsing;
using System.Collections.Generic;

namespace DatabaseCompare.DBCompare
{
    public class TNDPointConfigurationCompare
    {
        private readonly CheckCompare _checkCompare;
        private readonly ParseConfiguration _parseConfiguration;
        const string TND = @"\tnd\";
        const string PCC = @"\pcc\";

        public TNDPointConfigurationCompare()
        {
            _checkCompare = new CheckCompare();
            _parseConfiguration = new ParseConfiguration();
        }

        public Dictionary<Analog, Analog> CompareTNDToPCCAnalog(string FilePath)
        {
            var TNDAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + TND);
            var PCCAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesAnalog(TNDAnalogs, PCCAnalogs);
        }

        public Dictionary<Rate, Rate> CompareTNDToPCCRate(string FilePath)
        {
            var TNDRates = _parseConfiguration.MapRateConfiguration(FilePath + TND);
            var PCCRates = _parseConfiguration.MapRateConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesRate(TNDRates, PCCRates);
        }

        public Dictionary<Status, Status> CompareTNDToPCCStatus(string FilePath)
        {
            var TNDStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + TND);
            var PCCStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesStatus(TNDStatuses, PCCStatuses);
        }

        public Dictionary<Remote, Remote> CompareTNDToPCCRemote(string FilePath)
        {
            var TNDRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + TND);
            var PCCRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesRemote(TNDRemotes, PCCRemotes);
        }
    }
}
