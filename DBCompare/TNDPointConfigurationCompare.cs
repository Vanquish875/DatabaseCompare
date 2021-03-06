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
            var TNDAnalogs = new Dictionary<string, Analog>();
            var PCCAnalogs = new Dictionary<string, Analog>();

            TNDAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + TND);
            PCCAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesAnalog(TNDAnalogs, PCCAnalogs);
        }

        public Dictionary<Rate, Rate> CompareTNDToPCCRate(string FilePath)
        {
            var TNDRates = new Dictionary<string, Rate>();
            var PCCRates = new Dictionary<string, Rate>();

            TNDRates = _parseConfiguration.MapRateConfiguration(FilePath + TND);
            PCCRates = _parseConfiguration.MapRateConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesRate(TNDRates, PCCRates);
        }

        public Dictionary<Status, Status> CompareTNDToPCCStatus(string FilePath)
        {
            var TNDStatuses = new Dictionary<string, Status>();
            var PCCStatuses = new Dictionary<string, Status>();

            TNDStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + TND);
            PCCStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesStatus(TNDStatuses, PCCStatuses);
        }

        public Dictionary<Remote, Remote> CompareTNDToPCCRemote(string FilePath)
        {
            var TNDRemotes = new Dictionary<string, Remote>();
            var PCCRemotes = new Dictionary<string, Remote>();

            TNDRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + TND);
            PCCRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + PCC);

            return _checkCompare.CheckIfMatchesRemote(TNDRemotes, PCCRemotes);
        }
    }
}
