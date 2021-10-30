using DatabaseCompare.DotLFields;
using DatabaseCompare.Models;
using System;
using System.Collections.Generic;

namespace DatabaseCompare.Mapping
{
    public class AnalogMapping
    {
        public Dictionary<string, Analog> MapAnalog(List<string> data)
        {
            int FieldLength = AnalogFields.Fields.Length;
            var analogs = new Dictionary<string, Analog>();

            try
            {
                for (int i = 0; i < data.Count; i += FieldLength)
                {
                    var analog = new Analog
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
                        PointType = data[i + 11],
                        HasInput = data[i + 12],
                        HasOutput = data[i + 13],
                        OutputType = data[i + 14],
                        MinRaw = data[i + 15],
                        MaxRaw = data[i + 16],
                        MinEGU = data[i + 17],
                        MaxEGU = data[i + 18],
                        ConvertRawToEGU = data[i + 19],
                        EngineeringUnits = data[i + 20],
                        LoLimit = data[i + 21],
                        HiLimit = data[i + 22],
                        LoLoLimit = data[i + 23],
                        HiHiLimit = data[i + 24],
                        HasHiLimit = data[i + 25],
                        HasHiHiLimit = data[i + 26],
                        HasLoLimit = data[i + 27],
                        HasLoLoLimit = data[i + 28],
                        InputCoordinates = data[i + 29],
                        //InputFormat = data[i + 30],
                        InputType = data[i + 30],
                        OutMinRaw = data[i + 31],
                        OutMaxRaw = data[i + 32],
                        OutMinEGU = data[i + 33],
                        OutMaxEGU = data[i + 34],
                        OutConvertRawToEGU = data[i + 35],
                        OutputCoordinates = data[i + 36],
                        //OutputFormat = data[i + 38],
                        CMDTimeout = data[i + 37],
                        LogCmdSuccess = data[i + 38],
                        SetpointLowLimit = data[i + 39],
                        SetpointHiLimit = data[i + 40],
                        Description = data[i + 41],
                        PointClass = data[i + 42],
                        PointSubClass = data[i + 43],
                        ShortDesc = data[i + 44],
                        WellUnit = data[i + 45],
                        DisplayOrder = data[i + 46]
                    };

                    analogs.Add(analog.Name, analog);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return analogs;
        }
    }
}
