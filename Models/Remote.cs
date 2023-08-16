namespace DatabaseCompare.Models
{
    public record Remote
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public string Group { get; init; }
        public string PriorityDisplay { get; init; }
        public string Protocol { get; init; }
        public string Address { get; init; }
    }
}
