namespace Sample_10_Print
{
    public class CDriver
    {
        public string Name { get; set; } 
        public string Team { get; set; }
        public uint BirthYear { get; set; }

        public CDriver() { }

        public CDriver(string name, string team, uint birthYear)
        {
            this.Name = name;
            this.Team = team;
            this.BirthYear = birthYear;
        }

        ~CDriver()
        {
            System.Console.WriteLine("Destroyed the class");
        }
    }
}