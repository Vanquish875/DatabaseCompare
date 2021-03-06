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
                        HasInput = data[i + 6],
                        HasOutput = data[i + 7],
                        OutputType = data[i + 8],
                        MinRaw = data[i + 9],
                        MaxRaw = data[i + 10],
                        MinEGU = data[i + 11],
                        MaxEGU = data[i + 12],
                        ConvertRawToEGU = data[i + 13],
                        EngineeringUnits = data[i + 14],
                        LoLimit = data[i + 15],
                        HiLimit = data[i + 16],
                        LoLoLimit = data[i + 17],
                        HiHiLimit = data[i + 18],
                        HasHiLimit = data[i + 19],
                        HasHiHiLimit = data[i + 20],
                        HasLoLimit = data[i + 21],
                        HasLoLoLimit = data[i + 22],
                        InputCoordinates = data[i + 23],
                        InputType = data[i + 24],
                        OutMinRaw = data[i + 25],
                        OutMaxRaw = data[i + 26],
                        OutMinEGU = data[i + 27],
                        OutMaxEGU = data[i + 28],
                        OutConvertRawToEGU = data[i + 29],
                        OutputCoordinates = data[i + 30],
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
