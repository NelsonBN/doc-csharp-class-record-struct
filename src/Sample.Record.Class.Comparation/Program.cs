// First instance
var rcDriver1 = new RCDriver();
rcDriver1.Name = "Daniel Joseph Ricciardo";
rcDriver1.Team = "McLaren F1 Team";
rcDriver1.BirthYear = 1989;

// Second instance
var rcDriver2 = new RCDriver("Daniel Joseph Ricciardo", "McLaren F1 Team", 1989);

// Third instance
var rcDriver3 = new RCDriver();
rcDriver3.Name = "Sebastian Vettel";
rcDriver3.Team = "Aston Martin Cognizant F1 Team";
rcDriver3.BirthYear = 1987;

// Fourth instance
var rcDriver4 = rcDriver3; // Here we are copying the object address in heap memory for a new position in stack memory


Console.WriteLine("***************** COMPARATION EXAMPLE *****************");

Console.WriteLine($"rcDriver1 ({rcDriver1.GetHashCode()})\t==\t\trcDriver2 ({rcDriver2.GetHashCode()})\t: {rcDriver1 == rcDriver2}"); // The result is false because the memory addresses is not the same
Console.WriteLine($"rcDriver3 ({rcDriver3.GetHashCode()})\t==\t\trcDriver4 ({rcDriver4.GetHashCode()})\t: {rcDriver3 == rcDriver4}"); // The result is true because the memory addresses is the same

Console.WriteLine();

Console.WriteLine($"rcDriver1 ({rcDriver1.GetHashCode()})\tEquals\t\trcDriver2 ({rcDriver2.GetHashCode()})\t: {rcDriver1.Equals(rcDriver2)}");
Console.WriteLine($"rcDriver3 ({rcDriver3.GetHashCode()})\tEquals\t\trcDriver4 ({rcDriver4.GetHashCode()})\t: {rcDriver3.Equals(rcDriver4)}");

Console.WriteLine();

Console.WriteLine($"rcDriver1 ({rcDriver1.GetHashCode()})\tReferenceEquals\trcDriver2 ({rcDriver2.GetHashCode()})\t: {ReferenceEquals(rcDriver1, rcDriver2)}");
Console.WriteLine($"rcDriver3 ({rcDriver3.GetHashCode()})\tReferenceEquals\trcDriver4 ({rcDriver4.GetHashCode()})\t: {ReferenceEquals(rcDriver3, rcDriver4)}");


public record class RCDriver
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public RCDriver() { }

    public RCDriver(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }
}
