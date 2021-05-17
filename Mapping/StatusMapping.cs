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
                        InhibitAbnormalAlarm = data[i + 4],
                        InhibitNormalAlarm = data[i + 5],
                        InhibitAbnormalLog = data[i + 6],
                        InhibitNormalLog = data[i + 7],
                        BaseMessage = data[i + 8],
                        PriorityDisplay = data[i + 9],
                        SafetyRelated = data[i + 10],
                        NumberOfInputBits = data[i + 11],
                        InputOneCoordinates = data[i + 12],
                        InputOneBitNumber = data[i + 13],
                        InputOneNormallyOpen = data[i + 14],
                        InputTwoCoordinates = data[i + 15],
                        InputTwoBitNumber = data[i + 16],
                        InputTwoNormallyOpen = data[i + 17],
                        HasOutput = data[i + 18],
                        LogCMDSuccess = data[i + 19],
                        HasInput = data[i + 20],
                        InputType = data[i + 21],
                        CommandCoordinates1 = data[i + 22],
                        CommandOnType1 = data[i + 23],
                        CommandOnCmd1 = data[i + 24],
                        CommandOnCmdtimeout1 = data[i + 25],
                        CommandCoordinates2 = data[i + 26],
                        CommandOffType2 = data[i + 27],
                        CommandOffCmd2 = data[i + 28],
                        CommandOffCmdtimeout2 = data[i + 29],
                        Description = data[i + 30],
                        SustainCOSAlarms = data[i + 31],
                        AbnormalState0 = data[i + 32],
                        AbnormalState1 = data[i + 33],
                        AbnormalState2 = data[i + 34],
                        AbnormalState3 = data[i + 35],
                        PointClass = data[i + 36],
                        PointSubClass = data[i + 37],
                        WellUnit = data[i + 38],
                        DisplayOrder = data[i + 39],
                        ShortDescription = data[i + 40]
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
