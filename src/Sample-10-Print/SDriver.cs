namespace Sample_10_Print
{
    public struct SDriver
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public uint BirthYear { get; set; }

        public SDriver(string name, string team, uint birthYear)
        {
            this.Name = name;
            this.Team = team;
            this.BirthYear = birthYear;
        }
    }
}