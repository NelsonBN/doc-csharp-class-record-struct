using System;

namespace Sample_20_Class_Comparation
{
    public static class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0090:Use 'new(...)'", Justification = "<Pending>")]
        public static void Main(string[] _)
        {
            // First instance
            CDriver cDriver1 = new CDriver();
            cDriver1.Name = "Daniel Joseph Ricciardo";
            cDriver1.Team = "McLaren F1 Team";
            cDriver1.BirthYear = 1989;

            // Second instance
            CDriver cDriver2 = new CDriver("Daniel Joseph Ricciardo", "McLaren F1 Team", 1989);

            // Third instance
            CDriver cDriver3 = new CDriver();
            cDriver3.Name = "Sebastian Vettel";
            cDriver3.Team = "Aston Martin Cognizant F1 Team";
            cDriver3.BirthYear = 1987;

            // Fourth instance
            CDriver cDriver4 = cDriver3; // Here we are copying the object address in heap memory for a new position in stack memory

            Console.WriteLine("***************** COMPARATION EXAMPLE *****************");

            Console.WriteLine($"cDriver1 ({cDriver1.GetHashCode()}) == cDriver2 ({cDriver2.GetHashCode()}) : {cDriver1 == cDriver2}"); // The result is false because the memory addresses is not the same
            Console.WriteLine($"cDriver3 ({cDriver3.GetHashCode()}) == cDriver4 ({cDriver4.GetHashCode()}) : {cDriver3 == cDriver4}"); // The result is true because the memory addresses is the same
            
            Console.WriteLine();

            Console.WriteLine($"cDriver1 ({cDriver1.GetHashCode()}) Equals cDriver2 ({cDriver2.GetHashCode()}) : {cDriver1.Equals(cDriver2)}");
            Console.WriteLine($"cDriver3 ({cDriver3.GetHashCode()}) Equals cDriver4 ({cDriver4.GetHashCode()}) : {cDriver3.Equals(cDriver4)}");

            Console.WriteLine();

            Console.WriteLine($"cDriver1 ({cDriver1.GetHashCode()}) ReferenceEquals cDriver2 ({cDriver2.GetHashCode()}) : {System.Object.ReferenceEquals(cDriver1, cDriver2)}");
            Console.WriteLine($"cDriver3 ({cDriver3.GetHashCode()}) ReferenceEquals cDriver4 ({cDriver4.GetHashCode()}) : {System.Object.ReferenceEquals(cDriver3, cDriver4)}");
        }
    }
}