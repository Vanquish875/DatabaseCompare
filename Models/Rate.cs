namespace DatabaseCompare.Models
{
    public record Rate
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string Group { get; init; }
        public string Remote { get; init; }
        public string OffNormalAlarm { get; init; }
        public string NormalAlarm { get; init; }
        public string OffNormalLog { get; init; }
        public string NormalLog { get; init; }
        public string BaseMessage { get; init; }
        public string MinEGU { get; init; }
        public string MaxEGU { get; init; }
        public string SourceOfData { get; init; }
        public string EnableAccum { get; init; }
        public string PointType { get; init; }
        public string PriorityDisplay { get; init; }
        public string SafetyRelated { get; init; }
        public string PulseInputCoordinates { get; init; }
        public string PulseInputType { get; init; }
        public string PulseInRollover { get; init; }
        public string AnalogInputType { get; init; }
        public string AnalogInputCoordinates { get; init; }
        public string ConvertRawToEGU { get; init; }
        public string MinRaw { get; init; }
        public string MaxRaw { get; init; }
        public string IntegrationEGUUnits { get; init; }
        public string RateEGUUnits { get; init; }
        public string HasHiHiAlarm { get; init; }
        public string HasHiAlarm { get; init; }
        public string HasLoAlarm { get; init; }
        public string HasLoLoAlarm { get; init; }
        public string HiHiLimit { get; init; }
        public string HiLimit { get; init; }
        public string LoLimit { get; init; }
        public string LoLoLimit { get; init; }
        public string PointClass { get; init; }
        public string PointSubClass { get; init; }
        public string Station { get; init; }
        public string ShortDesc { get; init; }
        public string DisplayOrder { get; init; }
        public string WellUnit { get; init; }
    }
}
