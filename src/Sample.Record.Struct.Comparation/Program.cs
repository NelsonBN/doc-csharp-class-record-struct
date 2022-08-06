var rsDriver1 = new RSDriver1();
rsDriver1.Name = "Antonio Giovinazzi";
rsDriver1.Team = "Alfa Romeo Racing";
rsDriver1.BirthYear = 1993;

var rsDriver2 = new RSDriver1();
rsDriver2.Name = "Antonio Giovinazzi";
rsDriver2.Team = "Alfa Romeo Racing";
rsDriver2.BirthYear = 1993;

var rsDriver3 = new RSDriver2();
rsDriver2.Name = "Antonio Giovinazzi";
rsDriver2.Team = "Alfa Romeo Racing";
rsDriver2.BirthYear = 1993;

//Console.WriteLine($"rsDriver1 ({rsDriver1.GetHashCode()}) == rsDriver2 ({rsDriver2.GetHashCode()}) : {rsDriver1 == rsDriver2}"); //Cannot use the operation "=="
Console.WriteLine($"rsDriver1 ({rsDriver1.GetHashCode()}) Equals rsDriver2 ({rsDriver2.GetHashCode()}) : {rsDriver1.Equals(rsDriver2)}");

// In this case returned FALSE because although both struct instance have the same value, but the reference is not the same
Console.WriteLine($"rsDriver1 ({rsDriver1.GetHashCode()}) Equals rsDriver3 ({rsDriver3.GetHashCode()}) : {rsDriver1.Equals(rsDriver3)}");


public record struct RSDriver1
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public RSDriver1(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }
}


public record struct RSDriver2
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public RSDriver2(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }
}
