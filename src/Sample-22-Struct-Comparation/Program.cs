using System;

namespace Sample_22_Struct_Comparation
{
    public class Program
    {
        public static void Main(string[] _)
        {
            SDriver1 sDriver1 = new();
            sDriver1.Name = "Antonio Giovinazzi";
            sDriver1.Team = "Alfa Romeo Racing";
            sDriver1.BirthYear = 1993;

            SDriver1 sDriver2 = new();
            sDriver2.Name = "Antonio Giovinazzi";
            sDriver2.Team = "Alfa Romeo Racing";
            sDriver2.BirthYear = 1993;

            SDriver2 sDriver3 = new();
            sDriver2.Name = "Antonio Giovinazzi";
            sDriver2.Team = "Alfa Romeo Racing";
            sDriver2.BirthYear = 1993;

            //Console.WriteLine($"sDriver1 ({sDriver1.GetHashCode()}) == sDriver2 ({sDriver2.GetHashCode()}) : {sDriver1 == sDriver2}"); //Cannot use the operation "=="
            Console.WriteLine($"sDriver1 ({sDriver1.GetHashCode()}) Equals sDriver2 ({sDriver2.GetHashCode()}) : {sDriver1.Equals(sDriver2)}");

            // In this case returned FALSE because although both struct instance have the same value, but the reference is not the same
            Console.WriteLine($"sDriver1 ({sDriver1.GetHashCode()}) Equals sDriver3 ({sDriver3.GetHashCode()}) : {sDriver1.Equals(sDriver3)}");

            Console.WriteLine();
        }
    }
}