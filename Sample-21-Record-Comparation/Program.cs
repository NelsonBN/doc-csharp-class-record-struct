using System;

namespace Sample_21_Record_Comparation
{
    public static class Program
    {
        public static void Main(string[] _)
        {
            // First instance
            RDriver1 rDriver1 = new();
            rDriver1.Name = "Carlos Sainz";
            rDriver1.Team = "Scuderia Ferrari Mission";
            rDriver1.BirthYear = 1994;

            // Second instance
            RDriver1 rDriver2 = new("Carlos Sainz", "Scuderia Ferrari Mission", 1994);

            // Third instance
            RDriver1 rDriver3 = new("Esteban Ocon", "Alpine F1 Team", 1996);

            // Fourth instance
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            RDriver2 rDriver4 = new("Esteban Ocon", "Alpine F1 Team", 1996);
#pragma warning restore IDE0059 // Unnecessary assignment of a value

            Console.WriteLine("***************** COMPARATION EXAMPLE *****************");

            Console.WriteLine($"rDriver1 == rDriver2 : {rDriver1 == rDriver2}");
            Console.WriteLine($"rDriver1 == rDriver3 : {rDriver1 == rDriver3}"); // False because the values are not equals
            //Console.WriteLine($"rDriver3 ({rDriver3.GetHashCode()}) == rDriver4 ({rDriver4.GetHashCode()}) : {rDriver3 == rDriver4}"); // Cannot compare the record rDriver3 with rDriver4 because it is not the same record

            Console.WriteLine($"rDriver1 Equals rDriver2 : {rDriver1.Equals(rDriver2)}");
            Console.WriteLine($"rDriver1 Equals rDriver3 : {rDriver1.Equals(rDriver3)}");

            Console.WriteLine($"rDriver1 ReferenceEquals rDriver2 : {System.Object.ReferenceEquals(rDriver1, rDriver2)}");
            Console.WriteLine($"rDriver1 ReferenceEquals rDriver3 : {System.Object.ReferenceEquals(rDriver1, rDriver3)}");

            Console.WriteLine();

        }
    }
}