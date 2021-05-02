using System;

namespace Sample_10_Print
{
    public static class Program
    {
        public static void Main(string[] _)
        {
            // DECLARATION OF CLASSES
            CDriver cDriver = new();
            cDriver.Name = "Daniel Joseph Ricciardo";
            cDriver.Team = "McLaren F1 Team";
            cDriver.BirthYear = 1989;

            // DECLARATION OF RECORDS
            RDriver rDriver = new();
            rDriver.Name = "Carlos Sainz";
            rDriver.Team = "Scuderia Ferrari Mission";
            rDriver.BirthYear = 1994;

            // DECLARATION OF STRUCTS
            SDriver sDriver = new();
            sDriver.Name = "George Russell";
            sDriver.Team = "Williams Racing";
            sDriver.BirthYear = 1998;

            Console.WriteLine("***************** PRINT EXAMPLE *****************");

            Console.WriteLine($"Class > cDriver : {cDriver}");
            Console.WriteLine($"Record > rDriver : {rDriver}"); // The records is printed like a json object
            Console.WriteLine($"Struct > sDriver : {sDriver}");

            Console.WriteLine();

            Console.WriteLine($"Class > cDriver > HashCode : {cDriver.GetHashCode()}");
            Console.WriteLine($"Record > rDriver > HashCode : {rDriver.GetHashCode()}");
            Console.WriteLine($"Struct > sDriver > HashCode : {sDriver.GetHashCode()}");
        }
    }
}