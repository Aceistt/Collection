namespace pong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welkom bij de oneindige pingpong.");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("PING!");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "pong")
                {
                    Console.WriteLine("PING!");
                }
                else
                {
                    Console.WriteLine("je zei geen pong maar toch krijg je weer een ping.");
                    Console.WriteLine("PING!");
                }
            }
        }
    }
}
