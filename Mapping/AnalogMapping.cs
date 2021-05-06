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
                        RTU = data[i + 1],
                        Group = data[i + 2],
                        Station = data[i + 3],
                        BaseMessage = data[i + 4],
                        PriorityDisplay = data[i + 5],
                        SafetyRelated = data[i + 6],
                        PointType = data[i + 7],
                        HasInput = data[i + 8],
                        HasOutput = data[i + 9],
                        OutputType = data[i + 10],
                        MinRaw = data[i + 11],
                        MaxRaw = data[i + 12],
                        MinEGU = data[i + 13],
                        MaxEGU = data[i + 14],
                        ConvertRawToEGU = data[i + 15],
                        EngineeringUnits = data[i + 16],
                        LoLimit = data[i + 17],
                        HiLimit = data[i + 18],
                        LoLoLimit = data[i + 19],
                        HiHiLimit = data[i + 20],
                        HasHiLimit = data[i + 21],
                        HasHiHiLimit = data[i + 22],
                        HasLoLimit = data[i + 23],
                        HasLoLoLimit = data[i + 24],
                        InputCoordinates = data[i + 25],
                        InputFormat = data[i + 26],
                        InputType = data[i + 27],
                        OutMinRaw = data[i + 28],
                        OutMaxRaw = data[i + 29],
                        OutMinEGU = data[i + 30],
                        OutMaxEGU = data[i + 31],
                        OutConvertRawToEGU = data[i + 32],
                        OutputCoordinates = data[i + 33],
                        OutputFormat = data[i + 34],
                        CMDTimeout = data[i + 35],
                        LogCmdSuccess = data[i + 36],
                        SetpointLowLimit = data[i + 37],
                        SetpointHiLimit = data[i + 38],
                        Description = data[i + 39],
                        PointClass = data[i + 40],
                        PointSubClass = data[i + 41],
                        ShortDesc = data[i + 42],
                        WellUnit = data[i + 43],
                        DisplayOrder = data[i + 44]
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
