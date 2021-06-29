namespace DatabaseCompare.Models.InputModels
{
    public class AnalogADE : Analog
    {
        public string EnableRealarm { get; set; } = "0";
        public string PtStale1 { get; set; } = "";
        public string SetptTolerance { get; set; } = "0";
        public string EnableROCAlarm { get; set; } = "no";
        public string InstrumentFailCheck { get; set; } = "no";
        public string AlarmDeadband { get; set; } = "0";
        public string ROCLimit { get; set; } = "0";
        public string FlatLineTo { get; set; } = "0";
        public string FlatLineDoIt { get; set; } = "no";
        public string CalculateAverages { get; set; } = "no";
        public string CreepDetection { get; set; } = "no";
        public string DeviationAlarmLimit { get; set; } = "0";
        public string InputFormat { get; set; } = "0";
        public string PollGroup { get; set; } = "";
        public string ExceptionDeadband { get; set; } = "0";
        public string OutputFormat { get; set; } = "0";
        public string FilterConstant { get; set; } = "0";
        public string Dataset { get; set; } = "no"; //Add logic for this.
        public string RepDeadband { get; set; } = "0";
        public string ApplyLinearFilter { get; set; } = "no";
        public string HiHi1 { get; set; } = "no";
        public string Hi1 { get; set; } = "no";
        public string Lo2 { get; set; } = "no";
        public string LoLo3 { get; set; } = "no";
        public string AlertGroup { get; set; } = "";
        public string EnalbeAlertAlarm { get; set; } = "no";
        public string EnableSCADAAlarmSubject { get; set; } = "no";
        public string AlternateUnits { get; set; } = "";
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
