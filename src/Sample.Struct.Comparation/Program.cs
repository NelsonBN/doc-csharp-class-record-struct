var sDriver1 = new SDriver1();
sDriver1.Name = "Antonio Giovinazzi";
sDriver1.Team = "Alfa Romeo Racing";
sDriver1.BirthYear = 1993;

var sDriver2 = new SDriver1();
sDriver2.Name = "Antonio Giovinazzi";
sDriver2.Team = "Alfa Romeo Racing";
sDriver2.BirthYear = 1993;

var sDriver3 = new SDriver2();
sDriver2.Name = "Antonio Giovinazzi";
sDriver2.Team = "Alfa Romeo Racing";
sDriver2.BirthYear = 1993;

//Console.WriteLine($"sDriver1 ({sDriver1.GetHashCode()}) == sDriver2 ({sDriver2.GetHashCode()}) : {sDriver1 == sDriver2}"); //Cannot use the operation "=="
Console.WriteLine($"sDriver1 ({sDriver1.GetHashCode()}) Equals sDriver2 ({sDriver2.GetHashCode()}) : {sDriver1.Equals(sDriver2)}");

// In this case returned FALSE because although both struct instance have the same value, but the reference is not the same
Console.WriteLine($"sDriver1 ({sDriver1.GetHashCode()}) Equals sDriver3 ({sDriver3.GetHashCode()}) : {sDriver1.Equals(sDriver3)}");


public struct SDriver1
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public SDriver1(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }
}


public struct SDriver2
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public SDriver2(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }
}
