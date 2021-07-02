using System.ComponentModel;

namespace DatabaseCompare.Models.InputModels
{
    public class AnalogADE
    {
        public string Name { get; set; }
        public string Remote { get; set; }
        [Description("Off-Norm Alm")]
        public string OffNormalAlarm { get; set; }
        [Description("Norm Alarm")]
        public string NormalAlarm { get; set; }
        [Description("Off-Norm Log")]
        public string OffNormalLog { get; set; }
        [Description("Norm Log")]
        public string NormalLog { get; set; }
        [Description("Base Message")]
        public string BaseMessage { get; set; }
        [Description("Priority Display")]
        public string PriorityDisplay { get; set; }
        [Description("Enable Realarm")]
        public string EnableRealarm { get; set; } = "0";
        [Description("Safety Related")]
        public string SafetyRelated { get; set; }
        [Description("ptStale1")]
        public string PtStale1 { get; set; } = "";
        [Description("Setpt Tolerance")]
        public string SetptTolerance { get; set; } = "0";
        [Description("Point Type")]
        public string PointType { get; set; }
        [Description("Has Input")]
        public string HasInput { get; set; }
        [Description("Has Output")]
        public string HasOutput { get; set; }
        [Description("Output Type")]
        public string OutputType { get; set; }
        [Description("Min (raw)")]
        public string MinRaw { get; set; }
        [Description("Max (raw)")]
        public string MaxRaw { get; set; }
        [Description("Min (EGU)")]
        public string MinEGU { get; set; }
        [Description("Max (EGU)")]
        public string MaxEGU { get; set; }
        public string ConvertRawToEGU { get; set; }
        [Description("Engineering units")]
        public string EngineeringUnits { get; set; }
        [Description("Enable ROC Alarm")]
        public string EnableROCAlarm { get; set; } = "no";
        [Description("Instrument Fail Check")]
        public string InstrumentFailCheck { get; set; } = "no";
        [Description("Alarm Deadband")]
        public string AlarmDeadband { get; set; } = "0";
        [Description("Low Limit")]
        public string LoLimit { get; set; }
        [Description("Hi Limit")]
        public string HiLimit { get; set; }
        [Description("LoLo Limit")]
        public string LoLoLimit { get; set; }
        [Description("HiHi Limit")]
        public string HiHiLimit { get; set; }
        [Description("ROC Limit")]
        public string ROCLimit { get; set; } = "0";
        [Description("Flatline TO(min)")]
        public string FlatLineTo { get; set; } = "0";
        [Description("Flatline Do It")]
        public string FlatLineDoIt { get; set; } = "no";
        [Description("Hi Alarm Check")]
        public string HasHiLimit { get; set; }
        [Description("HiHi Alarm Check")]
        public string HasHiHiLimit { get; set; }
        [Description("Lo Alarm Check")]
        public string HasLoLimit { get; set; }
        [Description("LoLo Alarm Check")]
        public string HasLoLoLimit { get; set; }
        [Description("Calculate Averages")]
        public string CalculateAverages { get; set; } = "no";
        [Description("Creep Detection")]
        public string CreepDetection { get; set; } = "no";
        [Description("Deviation Alarm Limit")]
        public string DeviationAlarmLimit { get; set; } = "0";
        public string Group { get; set; }
        [Description("Input Coordinates")]
        public string InputCoordinates { get; set; }
        [Description("Input Format")]
        public string InputFormat { get; set; } = "0";
        [Description("Poll Group")]
        public string PollGroup { get; set; } = "";
        [Description("Exception Deadband")]
        public string ExceptionDeadband { get; set; } = "0";
        [Description("Input Type")]
        public string InputType { get; set; }
        [Description("Out Min (raw)")]
        public string OutMinRaw { get; set; }
        [Description("Out Max (raw)")]
        public string OutMaxRaw { get; set; }
        [Description("Out Min (EGU)")]
        public string OutMinEGU { get; set; }
        [Description("Out Max (EGU)")]
        public string OutMaxEGU { get; set; }
        [Description("Out Conv raw to EGU")]
        public string OutConvertRawToEGU { get; set; }
        [Description("Output Coordinates")]
        public string OutputCoordinates { get; set; }
        [Description("Output Format")]
        public string OutputFormat { get; set; } = "0";
        [Description("Cmd Timeout")]
        public string CMDTimeout { get; set; }
        [Description("Log Cmd Success")]
        public string LogCmdSuccess { get; set; }
        [Description("Setpt Low Limit")]
        public string SetpointLowLimit { get; set; }
        [Description("Setpt High Limit")]
        public string SetpointHiLimit { get; set; }
        public string Description { get; set; }
        [Description("Filter Constant")]
        public string FilterConstant { get; set; } = "0";
        public string Dataset { get; set; } = "no"; //Add logic for this.
        [Description("Rept. Dband")]
        public string RepDeadband { get; set; } = "0";
        [Description("Apply Linear Filter")]
        public string ApplyLinearFilter { get; set; } = "no";
        [Description("Point Class")]
        public string PointClass { get; set; }
        [Description("Point SubClass")]
        public string PointSubClass { get; set; }
        public string Station { get; set; }
        [Description("shortDesc")]
        public string ShortDesc { get; set; }
        [Description("well unit")]
        public string WellUnit { get; set; }
        [Description("Display Order")]
        public string DisplayOrder { get; set; }
        [Description("HiHi[0]")]
        public string HiHi1 { get; set; } = "no";
        [Description("Hi[1]")]
        public string Hi1 { get; set; } = "no";
        [Description("Lo[2]")]
        public string Lo2 { get; set; } = "no";
        [Description("LoLo[3]")]
        public string LoLo3 { get; set; } = "no";
        [Description("Alert Group")]
        public string AlertGroup { get; set; } = "";
        [Description("Enable Alert Alarm")]
        public string EnalbeAlertAlarm { get; set; } = "no";
        [Description("Enable SCADA alarm subject")]
        public string EnableSCADAAlarmSubject { get; set; } = "no";
        [Description("Alternative Units")]
        public string AlternateUnits { get; set; } = "";
        [Description("Max period of time")]
        public string MaxPeriodOfTime { get; set; } = "0";
        [Description("Warn Mode")]
        public string WarnMode { get; set; } = "no";
        [Description("Analog Interlock Enable")]
        public string AnalogInterlockEnable { get; set; } = "no";
        [Description("Status Interlock Enable")]
        public string StatusInterlockEnable { get; set; } = "no";
        [Description("Multistate Interlock Enable")]
        public string MultistateInterlockEnable { get; set; } = "no";
        [Description("Interlock Analog")]
        public string InterlockAnalog { get; set; } = "";
        [Description("InterlockStatus")]
        public string InterlockStatus { get; set; } = "";
        [Description("Interlock Multistate")]
        public string InterlockMultistate { get; set; } = "";
        [Description("Interlock Analog State String")]
        public string InterlockAnalogStateString { get; set; } = "";
        [Description("Interlock Status State String")]
        public string InterlockStatusStateString { get; set; } = "";
        [Description("Interlock Multistate State String")]
        public string InterlockMultistateString { get; set; } = "";
        [Description("Multi-Control Group")]
        public string MultiControlGroup { get; set; } = "";
        [Description("Control Scan Type")]
        public string ControlScanType { get; set; } = "";
        [Description("Control Scan Frequency")]
        public string ControlScanFrequency { get; set; } = "0";
        [Description("Control Scan Interval (sec)")]
        public string ControlScanInterval { get; set; } = "0";
    }
}
