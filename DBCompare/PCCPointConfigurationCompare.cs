using DatabaseCompare.Models;
using DatabaseCompare.Parsing;
using System.Collections.Generic;

namespace DatabaseCompare.DBCompare
{
    public class PCCPointConfigurationCompare
    {
        private readonly CheckCompare _checkCompare;
        private readonly ParseConfiguration _parseConfiguration;
        const string TND = @"\tnd\";
        const string PCC = @"\pcc\";

        public PCCPointConfigurationCompare()
        {
            _checkCompare = new CheckCompare();
            _parseConfiguration = new ParseConfiguration();
        }

        public Dictionary<Analog, Analog> ComparePCCToTNDAnalog(string FilePath)
        {
            var PCCAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + PCC);
            var TNDAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesAnalog(PCCAnalogs, TNDAnalogs);
        }

        public Dictionary<Rate, Rate> ComparePCCToTNDRate(string FilePath)
        {
            var PCCRates = _parseConfiguration.MapRateConfiguration(FilePath + PCC);
            var TNDRates = _parseConfiguration.MapRateConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesRate(PCCRates, TNDRates);
        }

        public Dictionary<Status, Status> ComparePCCToTNDStatus(string FilePath)
        {
            var PCCStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + PCC);
            var TNDStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesStatus(PCCStatuses, TNDStatuses);
        }

        public Dictionary<Remote, Remote> ComparePCCToTNDRemote(string FilePath)
        {
            var PCCRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + PCC);
            var TNDRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesRemote(PCCRemotes, TNDRemotes);
        }
    }
}
