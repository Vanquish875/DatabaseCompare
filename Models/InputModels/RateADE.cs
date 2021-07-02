using System.ComponentModel;

namespace DatabaseCompare.Models.InputModels
{
    public class RateADE
    {
        public string Name { get; set; }
        public string Remote { get; set; }
        public string Group { get; set; }
        public string Dataset { get; set; } //Create logic for this.
        [Description("Off-Norm Alm")]
        public string OffNormalAlarm { get; set; }
        [Description("Norm Alm")]
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
        public string EnableReAlarm { get; set; } = "0";
        [Description("Safety Related")]
        public string SafetyRelated { get; set; }
        [Description("ptStale1")]
        public string PtStale1 { get; set; } = "";
        [Description("Pulse In time between calcs (secs)")]
        public string PulseInTimeBetweenCalcs { get; set; }
        [Description("Pulse Input Coord.")]
        public string PulseInputCoordinates { get; set; }
        [Description("Pulse Input Format")]
        public string PulseInputFormat { get; set; } = "0";
        [Description("Poll Group (Pulse Input)")]
        public string PollGroupPulseInput { get; set; } = "";
        [Description("Pulse Input Type")]
        public string PulseInputType { get; set; }
        public string Source { get; set; }
        [Description("Enable Accum")]
        public string EnableAccum { get; set; }
        [Description("Point Type")]
        public string PointType { get; set; }
        [Description("Apply LFilter")]
        public string ApplyFilter { get; set; } = "no";
        [Description("ROC Alarm")]
        public string ROCAlarm { get; set; } = "no";
        [Description("Instrument Fail Check")]
        public string InstrumentFailCheck { get; set; } = "no";
        [Description("Alarm Deadband")]
        public string AlarmDeadband { get; set; } = "0";
        [Description("Lo Limit")]
        public string LoLimit { get; set; }
        [Description("Hi Limit")]
        public string HiLimit { get; set; }
        [Description("LoLo Alm Lim")]
        public string LoLoLimit { get; set; }
        [Description("HiHi Alm Lim")]
        public string HiHiLimit { get; set; }
        [Description("ROC Limit")]
        public string ROCLimit { get; set; } = "1";
        [Description("Flatline TO(min)")]
        public string FlatLineTo { get; set; } = "0";
        [Description("Flatline Do It")]
        public string FlatlineDoIt { get; set; } = "no";
        [Description("Hi Alarm Check")]
        public string HasHiAlarm { get; set; }
        [Description("HiHi Alarm Check")]
        public string HasHiHiAlarm { get; set; }
        [Description("Lo Alarm Check")]
        public string HasLoAlarm { get; set; }
        [Description("LoLo Alarm Check")]
        public string HasLoLoAlarm { get; set; }
        [Description("Creep Detection")]
        public string CreepDetection { get; set; } = "no";
        [Description("Dev Alm Lim")]
        public string DevAlarmLimit { get; set; } = "0";
        [Description("Pulse In Rollover")]
        public string PulseInRollover { get; set; }
        [Description("Pulse In Meter Fctr")]
        public string PulseInMeterFctr { get; set; } = "1";
        [Description("Input Coord.")]
        public string AnalogInputCoordinates { get; set; }
        [Description("Input Format")]
        public string AnalogInputFormat { get; set; } = "0";
        [Description("Poll Group (Analog Input)")]
        public string AnalogPollGroup { get; set; } = "";
        [Description("Excp DeadB")]
        public string ExcpDeadBand { get; set; } = "0";
        [Description("Input Type")]
        public string AnalogInputType { get; set; }
        [Description("Min raw")]
        public string MinRaw { get; set; }
        [Description("Max raw")]
        public string MaxRaw { get; set; }
        [Description("Min (EGU)")]
        public string MinEGU { get; set; }
        [Description("Max (EGU)")]
        public string MaxEGU { get; set; }
        [Description("Raw to EGU")]
        public string ConvertRawToEGU { get; set; }
        [Description("Subtype")]
        public string SubType { get; set; } = "linear";
        [Description("Scale Factor")]
        public string ScaleFactor { get; set; } = "1";
        [Description("Enable Int.")]
        public string EnableInt { get; set; } = "no";
        [Description("Int. Scale Factor")]
        public string IntScaleFactor { get; set; } = "1";
        [Description("Enable Avg.")]
        public string EnableAvg { get; set; } = "no";
        [Description("Int EGU Units")]
        public string IntegrationEGUUnits { get; set; }
        [Description("Rate EGU Units")]
        public string RateEGUUnits { get; set; }
        public string Description { get; set; }
        public string Temperature { get; set; } = "";
        public string Pressure { get; set; } = "";
        public string Scale { get; set; } = "0";
        [Description("Repl. Dead.")]
        public string ReplicationDeadband { get; set; } = "1";
        [Description("LFilter Constant")]
        public string LFilterConstant { get; set; } = "1";
        public string Constant { get; set; } = "0";
        [Description("Point Class")]
        public string PointClass { get; set; }
        [Description("Point SubClass")]
        public string PointSubClass { get; set; }
        public string Station { get; set; }
        [Description("shortDesc")]
        public string ShortDesc { get; set; }
        [Description("Display Order")]
        public string DisplayOrder { get; set; }
        [Description("well unit")]
        public string WellUnit { get; set; }
        [Description("HiHi[0]")]
        public string HIHI0 { get; set; } = "no";
        [Description("Hi[1]")]
        public string Hi1 { get; set; } = "no";
        [Description("Lo[2]")]
        public string Lo2 { get; set; } = "no";
        [Description("LoLo[3]")]
        public string LoLo3 { get; set; } = "no";
        [Description("Alert Group")]
        public string AlertGroup { get; set; } = "";
        [Description("Enable Alert Alarm")]
        public string EnableAlertAlarm { get; set; } = "no";
        [Description("Enable SCADA alarm subject")]
        public string EnableSCADAAlarmSub { get; set; } = "no";
        [Description("Alternate Units")]
        public string AlternateUnits { get; set; } = "";
        [Description("Alternate Accum Units")]
        public string AlternateAccumUnits { get; set; } = "";
        [Description("Max period of time")]
        public string MaxPeriodofTime { get; set; } = "0";
    }
}
