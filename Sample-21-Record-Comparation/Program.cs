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
            RDriver2 rDriver4 = new("Esteban Ocon", "Alpine F1 Team", 1996);

            RFerrariDriver rFerrariDriver = new();
            rFerrariDriver.Name = "Carlos Sainz";
            rFerrariDriver.Team = "Scuderia Ferrari Mission";
            rFerrariDriver.BirthYear = 1994;

            Console.WriteLine("***************** COMPARATION EXAMPLE *****************");

            Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()}) == rDriver2 ({rDriver2.GetHashCode()}) : {rDriver1 == rDriver2}");
            Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()}) == rDriver3 ({rDriver3.GetHashCode()}) : {rDriver1 == rDriver3}"); // False because the values are not equals
            //Console.WriteLine($"rDriver3 ({rDriver3.GetHashCode()}) == rDriver4 ({rDriver4.GetHashCode()}) : {rDriver3 == rDriver4}"); // Cannot compare the record rDriver3 with rDriver4 because it is not the same record

            Console.WriteLine();

            Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()}) Equals rDriver2 ({rDriver2.GetHashCode()}) : {rDriver1.Equals(rDriver2)}");
            Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()}) Equals rDriver3 ({rDriver3.GetHashCode()}) : {rDriver1.Equals(rDriver3)}");

            Console.WriteLine();
           
            Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()}) ReferenceEquals rDriver2 ({rDriver2.GetHashCode()}) : {System.Object.ReferenceEquals(rDriver1, rDriver2)}");
            Console.WriteLine($"rDriver1 ({rDriver1.GetHashCode()}) ReferenceEquals rDriver3 ({rDriver3.GetHashCode()}) : {System.Object.ReferenceEquals(rDriver1, rDriver3)}");

            // In this case returned FALSE because although both record instance have the same value, but the reference is not the same
            Console.WriteLine($"rDriver3 ({rDriver3.GetHashCode()}) ReferenceEquals rDriver4 ({rDriver4.GetHashCode()}) : {System.Object.ReferenceEquals(rDriver3, rDriver4)}");

            Console.WriteLine();

            // In this case returned FALSE because although both record instance have the same value, but the record type is not the same. Despite RFerrariDriver inheriting from RDriver1
            Console.WriteLine($"rFerrariDriver ({rFerrariDriver.GetHashCode()}) == rDriver2 ({rDriver2.GetHashCode()}) : {rFerrariDriver == rDriver2}");
            Console.WriteLine($"rFerrariDriver ({rFerrariDriver.GetHashCode()}) == Equals ({rDriver2.GetHashCode()}) : {rFerrariDriver.Equals(rDriver2)}");
            Console.WriteLine($"rFerrariDriver ({rFerrariDriver.GetHashCode()}) ReferenceEquals rDriver2 ({rDriver2.GetHashCode()}) : {System.Object.ReferenceEquals(rFerrariDriver, rDriver2)}");

            Console.WriteLine();
        }
    }
}