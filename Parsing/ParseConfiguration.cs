using System.Collections.Generic;
using DatabaseCompare.Mapping;
using DatabaseCompare.Models;
using DatabaseCompare.DotLFields;

namespace DatabaseCompare.Parsing
{
    public class ParseConfiguration
    {
        private readonly Parser _parser;
        private readonly AnalogMapping _analogMapping;
        private readonly RateMapping _rateMapping;
        private readonly StatusMapping _statusMapping;
        private readonly RemoteMapping _remoteMapping;

        const string ANALOG = @"analog.l";
        const string RATE = @"rate.l";
        const string STATUS = @"status.l";
        const string REMOTE = @"remote.l";

        public ParseConfiguration()
        {
            _parser = new Parser();
            _analogMapping = new AnalogMapping();
            _rateMapping = new RateMapping();
            _statusMapping = new StatusMapping();
            _remoteMapping = new RemoteMapping();
        }

        public Dictionary<string, Analog> MapAnalogConfiguration(string FilePath)
        {
            var Analogs = new List<string>();
            Analogs = _parser.ProcessFileList(FilePath + ANALOG, AnalogFields.Fields);

            return _analogMapping.MapAnalog(Analogs);
        }

        public Dictionary<string, Rate> MapRateConfiguration(string FilePath)
        {
            var Rates = new List<string>();
            Rates = _parser.ProcessFileList(FilePath + RATE, RateFields.Fields);

            return _rateMapping.MapRate(Rates);
        }

        public Dictionary<string, Status> MapStatusConfiguration(string FilePath)
        {
            var Statuses = new List<string>();
            Statuses = _parser.ProcessFileList(FilePath + STATUS, StatusFields.Fields);

            return _statusMapping.MapStatus(Statuses);
        }

        public Dictionary<string, Remote> MapRemoteConfiguration(string FilePath)
        {
            var Remotes = new List<string>();
            Remotes = _parser.ProcessFileList(FilePath + REMOTE, RemoteFields.Fields);

            return _remoteMapping.MapRemote(Remotes);
        }
    }
}
