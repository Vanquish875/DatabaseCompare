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
                        BaseMessage = data[i + 4],
                        PriorityDisplay = data[i + 5],
                        SafetyRelated = data[i + 6],
                        PulseInputCoordinates = data[i + 7],
                        PulseInputFormat = data[i + 8],
                        PulseInputType = data[i + 9],
                        SourceOfData = data[i + 10],
                        PointType = data[i + 11],
                        LoLimit = data[i + 12],
                        HiLimit = data[i + 13],
                        LoLoLimit = data[i + 14],
                        HiHiLimit = data[i + 15],
                        HasHiAlarm = data[i + 16],
                        HasHiHiAlarm = data[i + 17],
                        HasLoAlarm = data[i + 18],
                        HasLoLoAlarm = data[i + 19],
                        PulseInRollover = data[i + 20],
                        AnalogInputCoordinates = data[i + 21],
                        AnalogInputFormat = data[i + 22],
                        AnalogInputType = data[i + 23],
                        MinRaw = data[i + 24],
                        MaxRaw = data[i + 25],
                        MinEGU = data[i + 26],
                        MaxEGU = data[i + 27],
                        ConvertRawToEGU = data[i + 28],
                        IntegrationEGUUnits = data[i + 29],
                        RateEGUUnits = data[i + 30],
                        Description = data[i + 31],
                        PointClass = data[i + 32],
                        PointSubClass = data[i + 33],
                        ShortDesc = data[i + 34],
                        DisplayOrder = data[i + 35],
                        WellUnit = data[i + 36]
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
