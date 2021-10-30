using System.ComponentModel;

namespace DatabaseCompare.Models.InputModels
{
    public class StatusADE
    {
        public string Name { get; set; }
        public string Remote { get; set; }
        public string Dataset { get; set; } //Add logic for this.
        [Description("Inhibit Abnormal Alarm")]
        public string InhibitAbnormalAlarm { get; set; }
        [Description("Inhibit Normal Alarm")]
        public string InhibitNormalAlarm { get; set; }
        [Description("Inhibit Abnormal Log")]
        public string InhibitAbnormalLog { get; set; }
        [Description("Inhibit Normal Log")]
        public string InhibitNormalLog { get; set; }
        [Description("Base Message")]
        public string BaseMessage { get; set; }
        [Description("Priority Display")]
        public string PriorityDisplay { get; set; }
        [Description("Enable Realarm")]
        public string EnableRealarm { get; set; } = "0";
        [Description("Saftety Related")]
        public string SafetyRelated { get; set; }
        [Description("ptStale1")]
        public string PtStale1 { get; set; } = "";
        [Description("Num In Bits")]
        public string NumberOfInputBits { get; set; }
        [Description("Bit 1 Coord[0]")]
        public string InputOneCoordinates { get; set; }
        [Description("Poll Group (Input #1)[0]")]
        public string PollGroup1 { get; set; } = "";
        [Description("Bit 1 Bit Num[0]")]
        public string InputOneBitNumber { get; set; }
        [Description("Bit 1 Norm Open[0]")]
        public string InputOneNormallyOpen { get; set; }
        [Description("Bit in RTU Status[0]")]
        public string BitInRTUStatus0 { get; set; } = "no";
        [Description("Bit 2 Coord[1]")]
        public string InputTwoCoordinates { get; set; }
        [Description("Poll Group (Input #2)[1]")]
        public string PollGroup2 { get; set; } = "";
        [Description("Bit 2 Bit Num[1]")]
        public string InputTwoBitNumber { get; set; }
        [Description("Bit 2 Norm Open[1]")]
        public string InputTwoNormallyOpen { get; set; }
        [Description("Bit 2 in RTU Status[1]")]
        public string BitInRTUStatus1 { get; set; } = "no";
        [Description("Has Output")]
        public string HasOutput { get; set; }
        [Description("Log Cmd Success")]
        public string LogCMDSuccess { get; set; }
        [Description("Has Input")]
        public string HasInput { get; set; }
        public string Group { get; set; }
        [Description("Input Type")]
        public string InputType { get; set; }
        [Description("Cmd Fail Timeout")]
        public string CmdFailTimeout { get; set; } = "0";
        [Description("Accum State")]
        public string AccumState { get; set; } //Need to map this.
        [Description("Accum Runtime")]
        public string AccumRuntime { get; set; } //Need to map this.
        [Description("Out On Coord[1]")]
        public string CommandCoordinates1 { get; set; }
        [Description("Out On Type[1]")]
        public string CommandOnType1 { get; set; }
        [Description("Out On Cmd[1]")]
        public string CommandOnCmd1 { get; set; }
        [Description("Out On Timeout (msec)[1]")]
        public string CommandOnCmdtimeout1 { get; set; }
        [Description("Out Off Coord[2]")]
        public string CommandCoordinates2 { get; set; }
        [Description("Out Off Output Type[2]")]
        public string CommandOffType2 { get; set; }
        [Description("Out Off Cmd[2]")]
        public string CommandOffCmd2 { get; set; }
        [Description("Out Off Timeout (msec)[2]")]
        public string CommandOffCmdtimeout2 { get; set; }
        public string Description { get; set; }
        [Description("Sustain COS Alarms")]
        public string SustainCOSAlarms { get; set; }
        [Description("COS Fail Timeout")]
        public string COSFailTimeout { get; set; } = "0";
        [Description("Abnml State+0[0]")]
        public string AbnormalState0 { get; set; }
        [Description("Abnml State+1[1]")]
        public string AbnormalState1 { get; set; }
        [Description("Abnml State+2[2]")]
        public string AbnormalState2 { get; set; }
        [Description("Abnml State+3[3]")]
        public string AbnormalState3 { get; set; }
        [Description("SOE Point")]
        public string SOEPoint { get; set; } = "no";
        [Description("Command #1")]
        public string Command1 { get; set; } //Need to map this point.
        [Description("Command #2")]
        public string Command2 { get; set; } //Need to map this point.
        [Description("Point Class")]
        public string PointClass { get; set; }
        [Description("Point SubClass")]
        public string PointSubClass { get; set; }
        public string Station { get; set; }
        [Description("well unit")]
        public string WellUnit { get; set; }
        [Description("Display Order")]
        public string DisplayOrder { get; set; }
        [Description("shortDesc")]
        public string ShortDescription { get; set; }
        [Description("Alert Group")]
        public string AlertGroup { get; set; } = "";
        [Description("Enable Email Alarm")]
        public string EnableEmailAlarm { get; set; } = "no";
        [Description("Adhoc Msg for Email Alm")]
        public string AdhocMsgforEmail { get; set; } = "";
        [Description("Enable COS Alert")]
        public string EnableCOSAlert { get; set; } = "no";
        [Description("Enable SCADA alarm subject")]
        public string EnableSCADAAlarmSubject { get; set; } = "no";
        [Description("Pntcnd Enable")]
        public string PointCndEnable { get; set; } = "no";
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
