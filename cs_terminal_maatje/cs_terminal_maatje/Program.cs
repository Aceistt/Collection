using System;

namespace maatje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("wat is je naam? ");
            string? naam = Console.ReadLine();
            Console.WriteLine(naam + ": wat een mooie naam.");
            Console.Write("hou oud ben jij. ");
            int? age = int.Parse(Console.ReadLine());
            Console.WriteLine(age + ": zo wat ben je nog jong.");
            Console.Write("hoe gaat het met je. ");
            string? mood = Console.ReadLine();
            if (mood != null)
                if (mood.ToLower() == "good")
                    Console.WriteLine(mood + ": fijn om te horen.");
                else if (mood.ToLower() == "bad")
                {
                    Console.WriteLine(mood + ": het komt nog wel goed.");
                }
                else
                {
                    
                }
        }
    }
}

