namespace Sample_22_Struct_Comparation
{
    public struct SDriver1
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public uint BirthYear { get; set; }

        public SDriver1(string name, string team, uint birthYear)
        {
            this.Name = name;
            this.Team = team;
            this.BirthYear = birthYear;
        }
    }
}