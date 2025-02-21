namespace gamelib;

class program
{
    static void Main(string[] args)
    {
        Console.Write("input player name: ");
        string playerName = Console.ReadLine();
        Console.Write("input class: ");
        string player_class = Console.ReadLine();
        
        Console.WriteLine(playerName + " is de " + player_class + " class");
    }
}
