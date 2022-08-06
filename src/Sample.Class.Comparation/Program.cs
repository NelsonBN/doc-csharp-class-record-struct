// First instance
var cDriver1 = new CDriver();
cDriver1.Name = "Daniel Joseph Ricciardo";
cDriver1.Team = "McLaren F1 Team";
cDriver1.BirthYear = 1989;

// Second instance
var cDriver2 = new CDriver("Daniel Joseph Ricciardo", "McLaren F1 Team", 1989);

// Third instance
var cDriver3 = new CDriver();
cDriver3.Name = "Sebastian Vettel";
cDriver3.Team = "Aston Martin Cognizant F1 Team";
cDriver3.BirthYear = 1987;

// Fourth instance
var cDriver4 = cDriver3; // Here we are copying the object address in heap memory for a new position in stack memory

Console.WriteLine("***************** COMPARATION EXAMPLE *****************");

Console.WriteLine($"cDriver1 ({cDriver1.GetHashCode()})\t==\t\tcDriver2 ({cDriver2.GetHashCode()})\t: {cDriver1 == cDriver2}"); // The result is false because the memory addresses is not the same
Console.WriteLine($"cDriver3 ({cDriver3.GetHashCode()})\t==\t\tcDriver4 ({cDriver4.GetHashCode()})\t: {cDriver3 == cDriver4}"); // The result is true because the memory addresses is the same

Console.WriteLine();

Console.WriteLine($"cDriver1 ({cDriver1.GetHashCode()})\tEquals\t\tcDriver2 ({cDriver2.GetHashCode()})\t: {cDriver1.Equals(cDriver2)}");
Console.WriteLine($"cDriver3 ({cDriver3.GetHashCode()})\tEquals\t\tcDriver4 ({cDriver4.GetHashCode()})\t: {cDriver3.Equals(cDriver4)}");

Console.WriteLine();

Console.WriteLine($"cDriver1 ({cDriver1.GetHashCode()})\tReferenceEquals\tcDriver2 ({cDriver2.GetHashCode()})\t: {ReferenceEquals(cDriver1, cDriver2)}");
Console.WriteLine($"cDriver3 ({cDriver3.GetHashCode()})\tReferenceEquals\tcDriver4 ({cDriver4.GetHashCode()})\t: {ReferenceEquals(cDriver3, cDriver4)}");



public class CDriver
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public CDriver() { }

    public CDriver(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }
}
