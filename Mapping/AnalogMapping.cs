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
                        BaseMessage = data[i + 3],
                        PriorityDisplay = data[i + 4],
                        SafetyRelated = data[i + 5],
                        PointType = data[i + 6],
                        HasInput = data[i + 7],
                        HasOutput = data[i + 8],
                        OutputType = data[i + 9],
                        MinRaw = data[i + 10],
                        MaxRaw = data[i + 11],
                        MinEGU = data[i + 12],
                        MaxEGU = data[i + 13],
                        ConvertRawToEGU = data[i + 14],
                        EngineeringUnits = data[i + 15],
                        LoLimit = data[i + 16],
                        HiLimit = data[i + 17],
                        LoLoLimit = data[i + 18],
                        HiHiLimit = data[i + 19],
                        HasHiLimit = data[i + 20],
                        HasHiHiLimit = data[i + 21],
                        HasLoLimit = data[i + 22],
                        HasLoLoLimit = data[i + 23],
                        InputCoordinates = data[i + 24],
                        InputFormat = data[i + 25],
                        InputType = data[i + 26],
                        OutMinRaw = data[i + 27],
                        OutMaxRaw = data[i + 28],
                        OutMinEGU = data[i + 29],
                        OutMaxEGU = data[i + 30],
                        OutConvertRawToEGU = data[i + 31],
                        OutputCoordinates = data[i + 32],
                        OutputFormat = data[i + 33],
                        CMDTimeout = data[i + 34],
                        LogCmdSuccess = data[i + 35],
                        SetpointLowLimit = data[i + 31],
                        SetpointHiLimit = data[i + 32],
                        Description = data[i + 33]
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
