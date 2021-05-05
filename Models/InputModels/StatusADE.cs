namespace DatabaseCompare.Models.InputModels
{
    public class StatusADE
    {
        public string Name { get; set; }
        public string RTU { get; set; }
        public string DataSet { get; set; } //Add logic for this.
        public string InhibitAbnormalAlarm { get; set; } = "no";
        public string InhibitNormalAlarm { get; set; } = "yes";
        public string InhibitAbnormalLog { get; set; } = "no";
        public string InhibitNormalLog { get; set; } = "no";
        public string BaseMessage { get; set; }
        public string PriorityDisplay { get; set; }
        public string EnableRealarm { get; set; } = "0";
        public string SafetyRelated { get; set; }
        public string PtStale1 { get; set; } = "";
        public string NumberOfInputBits { get; set; }
        public string InputOneCoordinates { get; set; }
        public string PollGroup1 { get; set; } = "";
        public string InputOneBitNumber { get; set; }
        public string InputOneNormallyOpen { get; set; }
        public string BitInRTUStatus0 { get; set; } = "no";
        public string InputTwoCoordinates { get; set; }
        public string PollGroup2 { get; set; } = "";
        public string InputTwoBitNumber { get; set; }
        public string InputTwoNormallyOpen { get; set; }
        public string BitInRTUStatus1 { get; set; } = "no";
        public string HasOutput { get; set; }
        public string LogCMDSuccess { get; set; }
        public string HasInput { get; set; }
        public string Group { get; set; }
        public string InputType { get; set; }
        public string CmdFailTimeout { get; set; } = "0";
        public string AccumState { get; set; } //Need to map this.
        public string AccumRuntime { get; set; } //Need to map this.
        public string CommandCoordinates1 { get; set; }
        public string CommandOnType1 { get; set; }
        public string CommandOnCmd1 { get; set; }
        public string CommandOnCmdtimeout1 { get; set; }
        public string CommandCoordinates2 { get; set; }
        public string CommandOffType2 { get; set; }
        public string CommandOffCmd2 { get; set; }
        public string CommandOffCmdtimeout2 { get; set; }
        public string Description { get; set; }
        public string SustainCOSAlarms { get; set; }
        public string COSFailTimeout { get; set; } = "0";
        public string AbnormalState0 { get; set; }
        public string AbnormalState1 { get; set; }
        public string AbnormalState2 { get; set; }
        public string AbnormalState3 { get; set; }
        public string SOEPoint { get; set; } = "no";
    }
}
