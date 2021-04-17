namespace Sample_21_Record_Comparation
{
    public record RDriver1
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public uint BirthYear { get; set; }

        public RDriver1() { }

        public RDriver1(string name, string team, uint birthYear)
        {
            this.Name = name;
            this.Team = team;
            this.BirthYear = birthYear;
        }

        ~RDriver1()
        {
            System.Console.WriteLine("Destroyed the record");
        }
    }
}