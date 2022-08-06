// DECLARATION OF CLASSES
var cDriver = new CDriver()
{
    Name = "Daniel Joseph Ricciardo",
    Team = "McLaren F1 Team",
    BirthYear = 1989
};


// DECLARATION OF RECORDS
var rDriver = new RDriver()
{
    Name = "Carlos Sainz",
    Team = "Scuderia Ferrari Mission",
    BirthYear = 1994
};


// DECLARATION OF STRUCTS
var sDriver = new SDriver()
{
    Name = "George Russell",
    Team = "Williams Racing",
    BirthYear = 1998
};


// DECLARATION OF RECORD STRUCT
var rsDriver = new RSDriver()
{
    Name = "Sebastian Vettel",
    Team = "Aston Martin Cognizant F1 Team",
    BirthYear = 1987
};


// DECLARATION OF RECORD CLASS
var rcDriver = new RCDriver()
{
    Name = "Antonio Giovinazzi",
    Team = "Alfa Romeo Racing",
    BirthYear = 1993
};


Console.WriteLine("***************** PRINT EXAMPLE *****************");

Console.WriteLine($"Class: {cDriver}");
Console.WriteLine($"Record: {rDriver}"); // The records is printed like a json object
Console.WriteLine($"Struct: {sDriver}");
Console.WriteLine($"Record Struct: {rsDriver}"); // The record struct is printed like a json object
Console.WriteLine($"Record Class: {rcDriver}"); // The record struct is printed like a json object

Console.WriteLine();

Console.WriteLine($"Class > HashCode: {cDriver.GetHashCode()}");
Console.WriteLine($"Record > HashCode: {rDriver.GetHashCode()}");
Console.WriteLine($"Struct > HashCode: {sDriver.GetHashCode()}");
Console.WriteLine($"Record Struct > HashCode: {rsDriver.GetHashCode()}");
Console.WriteLine($"Record Class > HashCode: {rcDriver.GetHashCode()}");



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

    ~CDriver()
    {
        Console.WriteLine("Destroyed the class");
    }
}
public record RDriver
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public RDriver() { }

    public RDriver(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }

    ~RDriver()
    {
        Console.WriteLine("Destroyed the record");
    }
}
public struct SDriver
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    // public SDriver() { } // This is not allowed

    public SDriver(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }

    // This is not allowed
    //~SDriver()
    //{
    //    Console.WriteLine("Destroyed the struct");
    //}
}

public record struct RSDriver
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    // public RSDriver() { }  // This is not allowed

    public RSDriver(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }

    // This is not allowed
    //~RSDriver()
    //{
    //    Console.WriteLine("Destroyed the record struct");
    //}
}

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

    ~RCDriver()
    {
        Console.WriteLine("destroyed the record class");
    }
}
