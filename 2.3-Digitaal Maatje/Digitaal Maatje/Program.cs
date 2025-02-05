using System;

class Program
{
    static void Main()
    {
        // Vraag de naam van de gebruiker
        Console.WriteLine("Wat is je naam?");
        string naam = Console.ReadLine();

        // Vraag de leeftijd van de gebruiker
        Console.WriteLine("Hoe oud ben je?");
        string leeftijd = Console.ReadLine();

        // Vraag hoe het gaat met de gebruiker
        Console.WriteLine("Hoe gaat het met je?");
        string humeur = Console.ReadLine();

        // Reageer afhankelijk van het humeur
        if (humeur.ToLower() == "goed")
        {
            Console.WriteLine("Wat fijn dat het goed met je gaat!");
        }
        else if (humeur.ToLower() == "slecht")
        {
            Console.WriteLine("Wat fijn dat het slecht met je gaat!");
        }
        else
        {
            Console.WriteLine("Bedankt voor je antwoord!");
        }

        // Eindbericht
        Console.WriteLine($"Hallo {naam}, je bent {leeftijd} jaar oud.");
    }
}
