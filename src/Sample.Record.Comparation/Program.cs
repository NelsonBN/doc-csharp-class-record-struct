// First instance
var rDriver1 = new RDriver1();
rDriver1.Name = "Carlos Sainz";
rDriver1.Team = "Scuderia Ferrari Mission";
rDriver1.BirthYear = 1994;

// Second instance
RDriver1 rDriver2 = new("Carlos Sainz", "Scuderia Ferrari Mission", 1994);

// Third instance
RDriver1 rDriver3 = new("Esteban Ocon", "Alpine F1 Team", 1996);

// Fourth instance
RDriver2 rDriver4 = new("Esteban Ocon", "Alpine F1 Team", 1996);

var rFerrariDriver = new RFerrariDriver();
rFerrariDriver.Name = "Carlos Sainz";
rFerrariDriver.Team = "Scuderia Ferrari Mission";
rFerrariDriver.BirthYear = 1994;



Console.WriteLine("***************** COMPARATION EXAMPLE *****************");

Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()})\t\t==\t\trDriver2 ({rDriver2.GetHashCode()})\t: {rDriver1 == rDriver2}");
Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()})\t\t==\t\trDriver3 ({rDriver3.GetHashCode()})\t: {rDriver1 == rDriver3}"); // False because the values are not equals
                                                                                                                                  //Console.WriteLine($"rDriver3 ({rDriver3.GetHashCode()}) == rDriver4 ({rDriver4.GetHashCode()}) : {rDriver3 == rDriver4}"); // Cannot compare the record rDriver3 with rDriver4 because it is not the same record

Console.WriteLine();

Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()})\t\tEquals\t\trDriver2 ({rDriver2.GetHashCode()})\t: {rDriver1.Equals(rDriver2)}");
Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()})\t\tEquals\t\trDriver3 ({rDriver3.GetHashCode()})\t: {rDriver1.Equals(rDriver3)}");

Console.WriteLine();

Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()})\t\tReferenceEquals\trDriver2 ({rDriver2.GetHashCode()})\t: {ReferenceEquals(rDriver1, rDriver2)}");
Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()})\t\tReferenceEquals\trDriver3 ({rDriver3.GetHashCode()})\t: {ReferenceEquals(rDriver1, rDriver3)}");

// In this case returned FALSE because although both record instance have the same value, but the reference is not the same
Console.WriteLine($"rDriver3 ({rDriver3.GetHashCode()})\t\tReferenceEquals\trDriver4 ({rDriver4.GetHashCode()})\t: {ReferenceEquals(rDriver3, rDriver4)}");

Console.WriteLine();

// In this case returned FALSE because although both record instance have the same value, but the record type is not the same. Despite RFerrariDriver inheriting from RDriver1
Console.WriteLine($"rFerrariDriver ({rFerrariDriver.GetHashCode()})\t==\t\trDriver2 ({rDriver2.GetHashCode()})\t: {rFerrariDriver == rDriver2}");
Console.WriteLine($"rFerrariDriver ({rFerrariDriver.GetHashCode()})\tEquals\t\trDriver2 ({rDriver2.GetHashCode()})\t: {rFerrariDriver.Equals(rDriver2)}");
Console.WriteLine($"rFerrariDriver ({rFerrariDriver.GetHashCode()})\tReferenceEquals rDriver2 ({rDriver2.GetHashCode()})\t: {ReferenceEquals(rFerrariDriver, rDriver2)}");

Console.WriteLine();


public record RDriver1
{
    public string Name { get; set; }
    public string Team { get; set; }
    public uint BirthYear { get; set; }

    public RDriver1() { }

    public RDriver1(string name, string team, uint birthYear)
    {
        Name = name;
        Team = team;
        BirthYear = birthYear;
    }

    ~RDriver1()
    {
        Console.WriteLine("Destroyed the record");
    }
}

public record RFerrariDriver : RDriver1 { }

public record RDriver2(string Name, string Team, uint BirthYear);
