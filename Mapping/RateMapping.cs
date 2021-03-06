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
                        BaseMessage = data[i + 3],
                        PriorityDisplay = data[i + 4],
                        SafetyRelated = data[i + 5],
                        PulseInputCoordinates = data[i + 6],
                        PulseInputType = data[i + 7],
                        SourceOfData = data[i + 8],
                        LoLimit = data[i + 9],
                        HiLimit = data[i + 10],
                        LoLoLimit = data[i + 11],
                        HiHiLimit = data[i + 12],
                        HasHiAlarm = data[i + 13],
                        HasHiHiAlarm = data[i + 14],
                        HasLoAlarm = data[i + 15],
                        HasLoLoAlarm = data[i + 16],
                        AnalogInputCoordinates = data[i + 17],
                        AnalogInputType = data[i + 18],
                        MinRaw = data[i + 19],
                        MaxRaw = data[i + 20],
                        MinEGU = data[i + 21],
                        MaxEGU = data[i + 22],
                        ConvertRawToEGU = data[i + 23],
                        IntegrationEGUUnits = data[i + 24],
                        RateEGUUnits = data[i + 25],
                        Description = data[i + 26]
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
