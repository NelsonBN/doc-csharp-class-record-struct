namespace Sample_10_Print
{
    public record RDriver
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public uint BirthYear { get; set; }

        public RDriver() { }

        public RDriver(string name, string team, uint birthYear)
        {
            this.Name = name;
            this.Team = team;
            this.BirthYear = birthYear;
        }

        ~RDriver()
        {
            System.Console.WriteLine("Destroyed the record");
        }
    }
}