namespace Sample_30_Record_With
{
    public record RDriver
    {
        public string Name { get; init; }
        public string Team { get; init; }
        public uint BirthYear { get; init; }

        public RDriver(string name, string team, uint birthYear)
        {
            this.Name = name;
            this.Team = team;
            this.BirthYear = birthYear;
        }
    }
}