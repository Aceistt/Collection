namespace pyramide
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}