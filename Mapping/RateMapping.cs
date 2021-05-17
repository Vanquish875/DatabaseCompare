using DatabaseCompare.DotLFields;
using DatabaseCompare.Models;
using System;
using System.Collections.Generic;

namespace DatabaseCompare.Mapping
{
    public class RateMapping
    {
        public Dictionary<string, Rate> MapRate(List<string> data)
        {
            int FieldLength = RateFields.Fields.Length;
            var rates = new Dictionary<string, Rate>();

            try
            {
                for (int i = 0; i < data.Count; i += FieldLength)
                {
                    var rate = new Rate
                    {
                        Name = data[i],
                        RTU = data[i + 1],
                        Group = data[i + 2],
                        Station = data[i + 3],
                        OffNormalAlarm = data[i + 4],
                        NormalAlarm = data[i + 5],
                        OffNormalLog = data[i + 6],
                        NormalLog = data[i + 7],
                        BaseMessage = data[i + 8],
                        PriorityDisplay = data[i + 9],
                        SafetyRelated = data[i + 10],
                        PulseInputCoordinates = data[i + 11],
                        //PulseInputFormat = data[i + 12],
                        PulseInputType = data[i + 12],
                        SourceOfData = data[i + 13],
                        PointType = data[i + 14],
                        LoLimit = data[i + 15],
                        HiLimit = data[i + 16],
                        LoLoLimit = data[i + 17],
                        HiHiLimit = data[i + 18],
                        HasHiAlarm = data[i + 19],
                        HasHiHiAlarm = data[i + 20],
                        HasLoAlarm = data[i + 21],
                        HasLoLoAlarm = data[i + 22],
                        PulseInRollover = data[i + 23],
                        AnalogInputCoordinates = data[i + 24],
                        //AnalogInputFormat = data[i + 26],
                        AnalogInputType = data[i + 25],
                        MinRaw = data[i + 26],
                        MaxRaw = data[i + 27],
                        MinEGU = data[i + 28],
                        MaxEGU = data[i + 29],
                        ConvertRawToEGU = data[i + 30],
                        IntegrationEGUUnits = data[i + 31],
                        RateEGUUnits = data[i + 32],
                        Description = data[i + 33],
                        PointClass = data[i + 34],
                        PointSubClass = data[i + 35],
                        ShortDesc = data[i + 36],
                        DisplayOrder = data[i + 37],
                        WellUnit = data[i + 38]
                    };

                    rates.Add(rate.Name, rate);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return rates;
        }
    }
}
