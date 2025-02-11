using System;

namespace WheresWaldo
{
    class Program
    {
        // Move variables to class level
        static string waldo = "Ik ben hier!";
        static int waldoLocation = 42;

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij 'Where's Waldo'!");

            ZoekWaldo();
            ToonWaldo();
        }

        static void ZoekWaldo()
        {
            // Access class-level variable 'waldoLocation'
            Console.WriteLine($"Waldo bevindt zich op locatie {waldoLocation}!");
        }

        static void ToonWaldo()
        {
            // Access class-level variable 'waldo'
            Console.WriteLine(waldo);
        }
    }
}
