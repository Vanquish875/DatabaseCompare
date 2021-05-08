namespace DatabaseCompare.Models.InputModels
{
    public class AnalogADE
    {
        public string Name { get; set; }
        public string Remote { get; set; }
        public string OffNormalAlarm { get; set; } = "no";
        public string NormalAlarm { get; set; } = "yes";
        public string OffNormalLog { get; set; } = "no";
        public string NormalLog { get; set; } = "no";
        public string BaseMessage { get; set; }
        public string PriorityDisplay { get; set; }
        public string EnableRealarm { get; set; } = "0";
        public string SafetyRelated { get; set; }
        public string PtStale1 { get; set; } = "";
        public string SetptTolerance { get; set; } = "0";
        public string PointType { get; set; }
        public string HasInput { get; set; }
        public string HasOutput { get; set; }
        public string OutputType { get; set; }
        public string MinRaw { get; set; }
        public string MaxRaw { get; set; }
        public string MinEGU { get; set; }
        public string MaxEGU { get; set; }
        public string ConvertRawToEGU { get; set; }
        public string EngineeringUnits { get; set; }
        public string EnableROCAlarm { get; set; } = "no";
        public string InstrumentFailCheck { get; set; } = "no";
        public string AlarmDeadband { get; set; } = "0";
        public string LoLimit { get; set; }
        public string HiLimit { get; set; }
        public string LoLoLimit { get; set; }
        public string HiHiLimit { get; set; }
        public string ROCLimit { get; set; } = "0";
        public string FlatLineTo { get; set; } = "0";
        public string FlatLineDoIt { get; set; } = "no";
        public string HasHiLimit { get; set; }
        public string HasHiHiLimit { get; set; }
        public string HasLoLimit { get; set; }
        public string HasLoLoLimit { get; set; }
        public string CalculateAverages { get; set; } = "no";
        public string CreepDetection { get; set; } = "no";
        public string DeviationAlarmLimit { get; set; } = "0";
        public string Group { get; set; }
        public string InputCoordinates { get; set; }
        public string InputFormat { get; set; }
        public string PollGroup { get; set; } = "";
        public string ExceptionDeadband { get; set; } = "0";
        public string InputType { get; set; }
        public string OutMinRaw { get; set; }
        public string OutMaxRaw { get; set; }
        public string OutMinEGU { get; set; }
        public string OutMaxEGU { get; set; }
        public string OutConvertRawToEGU { get; set; }
        public string OutputCoordinates { get; set; }
        public string OutputFormat { get; set; }
        public string CMDTimeout { get; set; }
        public string LogCmdSuccess { get; set; }
        public string SetpointLowLimit { get; set; }
        public string SetpointHiLimit { get; set; }
        public string Description { get; set; }
        public string FilterConstant { get; set; } = "0";
        public string Dataset { get; set; } = "no"; //Add logic for this.
        public string RepDeadband { get; set; } = "0";
        public string ApplyLinearFilter { get; set; } = "no";
        public string PointClass { get; set; }
        public string PointSubClass { get; set; }
        public string Station { get; set; }
        public string ShortDesc { get; set; }
        public string WellUnit { get; set; }
        public string DisplayOrder { get; set; }
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
