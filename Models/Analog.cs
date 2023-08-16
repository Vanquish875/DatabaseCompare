namespace DatabaseCompare.Models
{
    public record Analog
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string SafetyRelated { get; init; }
        public string Group { get; init; }
        public string Remote { get; init; }
        public string OffNormalAlarm { get; init; }
        public string NormalAlarm { get; init; }
        public string OffNormalLog { get; init; }
        public string NormalLog { get; init; }
        public string BaseMessage { get; init; }
        public string EngineeringUnits { get; init; }
        public string PriorityDisplay { get; init; }
        public string PointType { get; init; }
        public string HasInput { get; init; }
        public string InputType { get; init; }
        public string InputCoordinates { get; init; }
        public string ConvertRawToEGU { get; init; }
        public string MinRaw { get; init; }
        public string MaxRaw { get; init; }
        public string MinEGU { get; init; }
        public string MaxEGU { get; init; }
        public string HasOutput { get; init; }
        public string OutputType { get; init; }
        public string OutputCoordinates { get; init; }
        public string CMDTimeout { get; init; }
        public string LogCmdSuccess { get; init; }
        public string OutConvertRawToEGU { get; init; }
        public string OutMinRaw { get; init; }
        public string OutMaxRaw { get; init; }
        public string OutMinEGU { get; init; }
        public string OutMaxEGU { get; init; }
        public string SetpointLowLimit { get; init; }
        public string SetpointHiLimit { get; init; }
        public string HasHiHiLimit { get; init; }
        public string HasHiLimit { get; init; }
        public string HasLoLimit { get; init; }
        public string HasLoLoLimit { get; init; }
        public string HiHiLimit { get; init; }
        public string HiLimit { get; init; }
        public string LoLimit { get; init; }
        public string LoLoLimit { get; init; }
        public string PointClass { get; init; }
        public string PointSubClass { get; init; }
        public string Station { get; init; }
        public string ShortDesc { get; init; }
        public string WellUnit { get; init; }
        public string DisplayOrder { get; init; }
     }
}
