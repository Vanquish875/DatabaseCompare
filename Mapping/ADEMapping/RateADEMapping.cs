using DatabaseCompare.DotLFields;
using DatabaseCompare.Models.InputModels;
using System;
using System.Collections.Generic;

namespace DatabaseCompare.Mapping.ADEMapping
{
    public class RateADEMapping
    {
        public List<RateADE> MapRate(IList<string> data, IList<string> names)
        {
            int FieldLength = RateFields.Fields.Length;
            var rates = new List<RateADE>();

            try
            {
                for (int i = 0; i < data.Count; i += FieldLength)
                {
                    if(names.Contains(data[i]))
                    {
                        var rate = new RateADE
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
                            EnableAccum = data[i + 11],
                            PointType = data[i + 12],
                            LoLimit = data[i + 13],
                            HiLimit = data[i + 14],
                            LoLoLimit = data[i + 15],
                            HiHiLimit = data[i + 16],
                            HasHiAlarm = data[i + 17],
                            HasHiHiAlarm = data[i + 18],
                            HasLoAlarm = data[i + 19],
                            HasLoLoAlarm = data[i + 20],
                            PulseInRollover = data[i + 21],
                            AnalogInputCoordinates = data[i + 22],
                            AnalogInputFormat = data[i + 23],
                            AnalogInputType = data[i + 24],
                            MinRaw = data[i + 25],
                            MaxRaw = data[i + 26],
                            MinEGU = data[i + 27],
                            MaxEGU = data[i + 28],
                            ConvertRawToEGU = data[i + 29],
                            IntegrationEGUUnits = data[i + 30],
                            RateEGUUnits = data[i + 31],
                            Description = data[i + 32],
                            PointClass = data[i + 33],
                            PointSubClass = data[i + 34],
                            ShortDesc = data[i + 35],
                            DisplayOrder = data[i + 36],
                            WellUnit = data[i + 37]
                        };

                        rates.Add(rate);
                    }    
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
