// First instance
var rDriver1 = new RDriver("George Russell", "Williams Racing", 1998);

var rDriver2 = rDriver1 with { Team = "Mercedes-AMG Petronas F1" }; // Copy the value from sDriver1 to sDriver2 and override the value "Team"

Console.WriteLine($"rDriver1 : {rDriver1}");
Console.WriteLine($"rDriver2 : {rDriver2}");
Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()}) == rDriver2 ({rDriver2.GetHashCode()}): {rDriver1 == rDriver2}");


public record RDriver
{
    public string Name { get; init; }
    public string Team { get; init; }
    public uint BirthYear { get; init; }

    public RDriver(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }
}
