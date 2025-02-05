using System;

class Program
{
    static void Main()
    {
        // Print de vlag
        for (int i = 0; i < 12; i++)
        {
            PrintFlagLine();
        }
    }

    static void PrintFlagLine()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("█████████████");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("█████████████");
        Console.ForegroundColor = ConsoleColor.DarkYellow; // Changed from Orange to DarkYellow
        Console.WriteLine("█████████████");
        Console.ResetColor(); // Reset the console color after printing each line
    }
}
