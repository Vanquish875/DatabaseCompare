using DatabaseCompare.DotLFields;
using DatabaseCompare.Models;
using System;
using System.Collections.Generic;

namespace DatabaseCompare.Mapping
{
    public class StatusMapping
    {
        public Dictionary<string, Status> MapStatus(List<string> data)
        {
            int FieldLength = StatusFields.Fields.Length;
            var digital = new Dictionary<string, Status>();

            try
            {
                for (int i = 0; i < data.Count; i += FieldLength)
                {
                    var status = new Status
                    {
                        Name = data[i],
                        RTU = data[i + 1],
                        Group = data[i + 2],
                        BaseMessage = data[i + 3],
                        PriorityDisplay = data[i + 4],
                        SafetyRelated = data[i + 5],
                        NumberOfInputBits = data[i + 6],
                        InputOneCoordinates = data[i + 7],
                        InputOneBitNumber = data[i + 8],
                        InputTwoCoordinates = data[i + 9],
                        InputTwoBitNumber = data[i + 10],
                        HasOutput = data[i + 11],
                        HasInput = data[i + 12],
                        CommandCoordinates1 = data[i + 13],
                        CommandType1 = data[i + 14],
                        CommandCoordinates2 = data[i + 15],
                        CommandType2 = data[i + 16],
                        Description = data[i + 17]
                    };

                    digital.Add(status.Name, status);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return digital;
        }
    }
}
