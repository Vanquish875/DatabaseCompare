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
                        Station = data[i + 3],
                        BaseMessage = data[i + 4],
                        PriorityDisplay = data[i + 5],
                        SafetyRelated = data[i + 6],
                        NumberOfInputBits = data[i + 7],
                        InputOneCoordinates = data[i + 8],
                        InputOneBitNumber = data[i + 9],
                        InputOneNormallyOpen = data[i + 10],
                        InputTwoCoordinates = data[i + 11],
                        InputTwoBitNumber = data[i + 12],
                        InputTwoNormallyOpen = data[i + 13],
                        HasOutput = data[i + 14],
                        LogCMDSuccess = data[i + 15],
                        HasInput = data[i + 16],
                        InputType = data[i + 17],
                        CommandCoordinates1 = data[i + 18],
                        CommandOnType1 = data[i + 19],
                        CommandOnCmd1 = data[i + 20],
                        CommandOnCmdtimeout1 = data[i + 21],
                        CommandCoordinates2 = data[i + 22],
                        CommandOffType2 = data[i + 23],
                        CommandOffCmd2 = data[i + 24],
                        CommandOffCmdtimeout2 = data[i + 25],
                        Description = data[i + 26],
                        SustainCOSAlarms = data[i + 27],
                        AbnormalState0 = data[i + 28],
                        AbnormalState1 = data[i + 29],
                        AbnormalState2 = data[i + 30],
                        AbnormalState3 = data[i + 31],
                        PointClass = data[i + 32],
                        PointSubClass = data[i + 33],
                        WellUnit = data[i + 34],
                        DisplayOrder = data[i + 35],
                        ShortDescription = data[i + 36]
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
