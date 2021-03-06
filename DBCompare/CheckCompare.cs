using DatabaseCompare.Models;
using System.Collections.Generic;

namespace DatabaseCompare.DBCompare
{
    public class CheckCompare
    {
        public Dictionary<Analog, Analog> CheckIfMatchesAnalog(Dictionary<string, Analog> OriginPoints, Dictionary<string, Analog> DestinationPoints)
        {
            var analogs = new Dictionary<Analog, Analog>();

            foreach (var ana in OriginPoints)
            {
                if (DestinationPoints.ContainsKey(ana.Key))
                {
                    if (!ana.Value.Equals(DestinationPoints[ana.Key]))
                    {
                        analogs.Add(ana.Value, DestinationPoints[ana.Key]);
                    }
                }
            }
            return analogs;
        }

        public Dictionary<Rate, Rate> CheckIfMatchesRate(Dictionary<string, Rate> OriginPoints, Dictionary<string, Rate> DestinationPoints)
        {
            var rates = new Dictionary<Rate, Rate>();

            foreach (var rate in OriginPoints)
            {
                if (DestinationPoints.ContainsKey(rate.Key))
                {
                    if (!rate.Value.Equals(DestinationPoints[rate.Key]))
                    {
                        rates.Add(rate.Value, DestinationPoints[rate.Key]);
                    }
                }
            }
            return rates;
        }

        public Dictionary<Status, Status> CheckIfMatchesStatus(Dictionary<string, Status> OriginPoints, Dictionary<string, Status> DestinationPoints)
        {
            var statuses = new Dictionary<Status, Status>();

            foreach (var status in OriginPoints)
            {
                if (DestinationPoints.ContainsKey(status.Key))
                {
                    if (!status.Value.Equals(DestinationPoints[status.Key]))
                    {
                        statuses.Add(status.Value, DestinationPoints[status.Key]);
                    }
                }
            }
            return statuses;
        }

        public Dictionary<Remote, Remote> CheckIfMatchesRemote(Dictionary<string, Remote> OriginPoints, Dictionary<string, Remote> DestinationPoints)
        {
            var remotes = new Dictionary<Remote, Remote>();

            foreach (var remote in OriginPoints)
            {
                if (DestinationPoints.ContainsKey(remote.Key))
                {
                    if (!remote.Value.Equals(DestinationPoints[remote.Key]))
                    {
                        remotes.Add(remote.Value, DestinationPoints[remote.Key]);
                    }
                }
            }
            return remotes;
        }
    }
}
