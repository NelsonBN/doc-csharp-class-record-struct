using System;

namespace Sample_30_Record_With
{
    public static class Program
    {
        public static void Main(string[] _)
        {
            // First instance
            RDriver sDriver1 = new("George Russell", "Williams Racing", 1998);

            RDriver sDriver2 = sDriver1 with { Team = "Mercedes-AMG Petronas F1" }; // Copy the value from sDriver1 to sDriver2 and override the value "Team"

            Console.WriteLine($"rDriver1 : {sDriver1}");
            Console.WriteLine($"rDriver2 : {sDriver2}");
        }
    }
}