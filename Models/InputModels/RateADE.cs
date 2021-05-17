namespace DatabaseCompare.Models.InputModels
{
    public class RateADE
    {
        public string Name { get; set; }
        public string RTU { get; set; }
        public string Group { get; set; }
        public string Dataset { get; set; } //Create logic for this.
        public string OffNormalAlarm { get; set; }
        public string NormalAlarm { get; set; }
        public string OffNormalLog { get; set; }
        public string NormalLog { get; set; }
        public string BaseMessage { get; set; }
        public string PriorityDisplay { get; set; }
        public string EnableReAlarm { get; set; } = "0";
        public string SafetyRelated { get; set; }
        public string PtStale1 { get; set; } = "";
        public string PulseInTimeBetweenCalcs { get; set; }
        public string PulseInputCoordinates { get; set; }
        public string PulseInputFormat { get; set; } = "0";
        public string PollGroupPulseInput { get; set; } = "";
        public string PulseInputType { get; set; }
        public string SourceOfData { get; set; }
        public string EnableAccum { get; set; }
        public string PointType { get; set; }
        public string ApplyFilter { get; set; } = "no";
        public string ROCAlarm { get; set; } = "no";
        public string InstrumentFailCheck { get; set; } = "no";
        public string AlarmDeadband { get; set; } = "0";
        public string LoLimit { get; set; }
        public string HiLimit { get; set; }
        public string LoLoLimit { get; set; }
        public string HiHiLimit { get; set; }
        public string ROCLimit { get; set; } = "1";
        public string FlatLineTo { get; set; } = "0";
        public string FlatlineDoIt { get; set; } = "no";
        public string HasHiAlarm { get; set; }
        public string HasHiHiAlarm { get; set; }
        public string HasLoAlarm { get; set; }
        public string HasLoLoAlarm { get; set; }
        public string CreepDetection { get; set; } = "no";
        public string DevAlarmLimit { get; set; } = "0";
        public string PulseInRollover { get; set; }
        public string PulseInMeterFctr { get; set; } = "1";
        public string AnalogInputCoordinates { get; set; }
        public string AnalogInputFormat { get; set; } = "0";
        public string AnalogPollGroup { get; set; } = "";
        public string ExcpDeadBand { get; set; } = "0";
        public string AnalogInputType { get; set; }
        public string MinRaw { get; set; }
        public string MaxRaw { get; set; }
        public string MinEGU { get; set; }
        public string MaxEGU { get; set; }
        public string ConvertRawToEGU { get; set; }
        public string SubType { get; set; } = "linear";
        public string ScaleFactor { get; set; } = "1";
        public string EnableInt { get; set; } = "no";
        public string IntScaleFactor { get; set; } = "1";
        public string EnableAvg { get; set; } = "no";
        public string IntegrationEGUUnits { get; set; }
        public string RateEGUUnits { get; set; }
        public string Description { get; set; }
        public string Temperature { get; set; } = "";
        public string Pressure { get; set; } = "";
        public string Scale { get; set; } = "0";
        public string ReplicationDeadband { get; set; } = "1";
        public string LFilterConstant { get; set; } = "1";
        public string Consta { get; set; } = "0";
        public string PointClass { get; set; }
        public string PointSubClass { get; set; }
        public string Station { get; set; }
        public string ShortDesc { get; set; }
        public string DisplayOrder { get; set; }
        public string WellUnit { get; set; }
        public string HIHI0 { get; set; } = "no";
        public string Hi1 { get; set; } = "no";
        public string Lo2 { get; set; } = "no";
        public string LoLo3 { get; set; } = "no";
        public string AlertGroup { get; set; } = "";
        public string EnableAlertAlarm { get; set; } = "no";
        public string EnableSCADAAlarmSub { get; set; } = "no";
        public string AlternateUnits { get; set; } = "";
        public string AlternateAccumUnits { get; set; } = "";
        public string MaxPeriodofTime { get; set; } = "0";
    }
}
