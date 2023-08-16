namespace DatabaseCompare.Models
{
    public record Status
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string Group { get; init; }
        public string InhibitAbnormalAlarm { get; init; }
        public string InhibitNormalAlarm { get; init; }
        public string InhibitAbnormalLog { get; init; }
        public string InhibitNormalLog { get; init; }
        public string BaseMessage { get; init; }
        public string Remote { get; init; }
        public string PriorityDisplay { get; init; }
        public string SafetyRelated { get; init; }
        public string HasInput { get; init; }
        public string InputType { get; init; }
        public string AccumState { get; init; }
        public string NumberOfInputBits { get; init; }
        public string InputOneCoordinates { get; init; }
        public string InputOneBitNumber { get; init; }
        public string InputOneNormallyOpen { get; init; }
        public string InputTwoCoordinates { get; init; }
        public string InputTwoBitNumber { get; init; }
        public string InputTwoNormallyOpen { get; init; }
        public string HasOutput { get; init; }
        public string LogCMDSuccess { get; init; }
        public string CommandOnType1 { get; init; }
        public string CommandOnCmd1 { get; init; }
        public string CommandOnCmdtimeout1 { get; init; }
        public string CommandCoordinates1 { get; init; }
        public string CommandOffType2 { get; init; }
        public string CommandOffCmd2 { get; init; }
        public string CommandOffCmdtimeout2 { get; init; }
        public string CommandCoordinates2 { get; init; }
        public string SustainCOSAlarms { get; init; }
        public string AbnormalState0 { get; init; }
        public string AbnormalState1 { get; init; }
        public string AbnormalState2 { get; init; }
        public string AbnormalState3 { get; init; }
        public string PointClass { get; init; }
        public string PointSubClass { get; init; }
        public string Station { get; init; }
        public string WellUnit { get; init; }
        public string DisplayOrder { get; init; }
        public string ShortDescription { get; init; }
    }
}
