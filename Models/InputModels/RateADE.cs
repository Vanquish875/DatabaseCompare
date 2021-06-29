namespace DatabaseCompare.Models.InputModels
{
    public class RateADE : Rate
    {
        public string Dataset { get; set; } //Create logic for this.
        public string EnableReAlarm { get; set; } = "0";
        public string PtStale1 { get; set; } = "";
        public string PulseInTimeBetweenCalcs { get; set; }
        public string PulseInputFormat { get; set; } = "0";
        public string PollGroupPulseInput { get; set; } = "";
        public string ApplyFilter { get; set; } = "no";
        public string ROCAlarm { get; set; } = "no";
        public string InstrumentFailCheck { get; set; } = "no";
        public string AlarmDeadband { get; set; } = "0";
        public string ROCLimit { get; set; } = "1";
        public string FlatLineTo { get; set; } = "0";
        public string FlatlineDoIt { get; set; } = "no";
        public string CreepDetection { get; set; } = "no";
        public string DevAlarmLimit { get; set; } = "0";
        public string PulseInMeterFctr { get; set; } = "1";
        public string AnalogInputFormat { get; set; } = "0";
        public string AnalogPollGroup { get; set; } = "";
        public string ExcpDeadBand { get; set; } = "0";
        public string SubType { get; set; } = "linear";
        public string ScaleFactor { get; set; } = "1";
        public string EnableInt { get; set; } = "no";
        public string IntScaleFactor { get; set; } = "1";
        public string EnableAvg { get; set; } = "no";
        public string Temperature { get; set; } = "";
        public string Pressure { get; set; } = "";
        public string Scale { get; set; } = "0";
        public string ReplicationDeadband { get; set; } = "1";
        public string LFilterConstant { get; set; } = "1";
        public string Consta { get; set; } = "0";
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
