using System.Collections.Generic;

namespace DatabaseCompare.DBCompare
{
    public class CheckIfExists
    {
        public List<string> CheckIfPointExists(List<string> OriginPoints, HashSet<string> DestinationPoints)
        {
            var FoundPoints = new List<string>();

            foreach(var tnd in OriginPoints)
            {
                if(!DestinationPoints.Contains(tnd))
                {
                    FoundPoints.Add(tnd);
                }
            }

            return FoundPoints;
        }
    }
}
