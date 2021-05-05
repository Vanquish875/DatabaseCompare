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
                        InputOneNormallyOpen = data[i + 9],
                        InputTwoCoordinates = data[i + 10],
                        InputTwoBitNumber = data[i + 11],
                        InputTwoNormallyOpen = data[i + 12],
                        HasOutput = data[i + 13],
                        LogCMDSuccess = data[i + 14],
                        HasInput = data[i + 15],
                        InputType = data[i + 16],
                        CommandCoordinates1 = data[i + 17],
                        CommandOnType1 = data[i + 18],
                        CommandOnCmd1 = data[i + 19],
                        CommandOnCmdtimeout1 = data[i + 20],
                        CommandCoordinates2 = data[i + 21],
                        CommandOffType2 = data[i + 22],
                        CommandOffCmd2 = data[i + 23],
                        CommandOffCmdtimeout2 = data[i + 24],
                        Description = data[i + 25],
                        SustainCOSAlarms = data[i + 26],
                        AbnormalState0 = data[i + 27],
                        AbnormalState1 = data[i + 28],
                        AbnormalState2 = data[i + 29],
                        AbnormalState3 = data[i + 30]
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
