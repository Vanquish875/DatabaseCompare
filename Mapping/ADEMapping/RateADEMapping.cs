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
                            Remote = data[i + 1],
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
                            Source = data[i + 13],
                            EnableAccum = data[i + 14],
                            PointType = data[i + 15],
                            LoLimit = data[i + 16],
                            HiLimit = data[i + 17],
                            LoLoLimit = data[i + 18],
                            HiHiLimit = data[i + 19],
                            HasHiAlarm = data[i + 20],
                            HasHiHiAlarm = data[i + 21],
                            HasLoAlarm = data[i + 22],
                            HasLoLoAlarm = data[i + 23],
                            PulseInRollover = data[i + 24],
                            AnalogInputCoordinates = data[i + 25],
                            //AnalogInputFormat = data[i + 27],
                            AnalogInputType = data[i + 26],
                            MinRaw = data[i + 27],
                            MaxRaw = data[i + 28],
                            MinEGU = data[i + 29],
                            MaxEGU = data[i + 30],
                            ConvertRawToEGU = data[i + 31],
                            IntegrationEGUUnits = data[i + 32],
                            RateEGUUnits = data[i + 33],
                            Description = data[i + 34],
                            PointClass = data[i + 35],
                            PointSubClass = data[i + 36],
                            ShortDesc = data[i + 37],
                            DisplayOrder = data[i + 38],
                            WellUnit = data[i + 39]
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
