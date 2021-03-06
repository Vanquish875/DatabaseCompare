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
            var PCCAnalogs = new Dictionary<string, Analog>();
            var TNDAnalogs = new Dictionary<string, Analog>();

            PCCAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + PCC);
            TNDAnalogs = _parseConfiguration.MapAnalogConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesAnalog(PCCAnalogs, TNDAnalogs);
        }

        public Dictionary<Rate, Rate> ComparePCCToTNDRate(string FilePath)
        {
            var PCCRates = new Dictionary<string, Rate>();
            var TNDRates = new Dictionary<string, Rate>();

            PCCRates = _parseConfiguration.MapRateConfiguration(FilePath + PCC);
            TNDRates = _parseConfiguration.MapRateConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesRate(PCCRates, TNDRates);
        }

        public Dictionary<Status, Status> ComparePCCToTNDStatus(string FilePath)
        {
            var PCCStatuses = new Dictionary<string, Status>();
            var TNDStatuses = new Dictionary<string, Status>();

            PCCStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + PCC);
            TNDStatuses = _parseConfiguration.MapStatusConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesStatus(PCCStatuses, TNDStatuses);
        }

        public Dictionary<Remote, Remote> ComparePCCToTNDRemote(string FilePath)
        {
            var PCCRemotes = new Dictionary<string, Remote>();
            var TNDRemotes = new Dictionary<string, Remote>();

            PCCRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + PCC);
            TNDRemotes = _parseConfiguration.MapRemoteConfiguration(FilePath + TND);

            return _checkCompare.CheckIfMatchesRemote(PCCRemotes, TNDRemotes);
        }
    }
}
