namespace DatabaseCompare.Models.InputModels
{
    public class StatusADE : Status
    {
        public string DataSet { get; set; } //Add logic for this.
        public string EnableRealarm { get; set; } = "0";
        public string PtStale1 { get; set; } = "";
        public string PollGroup1 { get; set; } = "";
        public string BitInRTUStatus0 { get; set; } = "no";
        public string PollGroup2 { get; set; } = "";
        public string BitInRTUStatus1 { get; set; } = "no";
        public string CmdFailTimeout { get; set; } = "0";
        public string AccumRuntime { get; set; }
        public string COSFailTimeout { get; set; } = "0";
        public string SOEPoint { get; set; } = "no";
        public string Command1 { get; set; }
        public string Command2 { get; set; }
        public string AlertGroup { get; set; } = "";
        public string EnableEmailAlarm { get; set; } = "no";
        public string AdhocMsgforEmail { get; set; } = "";
        public string EnableCOSAlert { get; set; } = "no";
        public string EnableSCADAAlarmSubject { get; set; } = "no";
        public string PointCndEnable { get; set; } = "no";
        public string MaxPeriodOfTime { get; set; } = "0";
        public string WarnMode { get; set; } = "no";
        public string AnalogInterlockEnable { get; set; } = "no";
        public string StatusInterlockEnable { get; set; } = "no";
        public string MultistateInterlockEnable { get; set; } = "no";
        public string InterlockAnalog { get; set; } = "";
        public string InterlockStatus { get; set; } = "";
        public string InterlockMultistate { get; set; } = "";
        public string InterlockAnalogStateString { get; set; } = "";
        public string InterlockStatusStateString { get; set; } = "";
        public string InterlockMultistateString { get; set; } = "";
        public string MultiControlGroup { get; set; } = "";
        public string ControlScanType { get; set; } = "";
        public string ControlScanFrequency { get; set; } = "0";
        public string ControlScanInterval { get; set; } = "0";
    }
}
