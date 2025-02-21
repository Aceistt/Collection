namespace checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kies nummer X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("kies nummer Y: ");
            int y = int.Parse(Console.ReadLine());
            
            if (x == y)
                Console.WriteLine("ze zijn gelijk");
            else if (x > y)
            {
                Console.WriteLine("x is groter");
            }
            else
            {
                Console.WriteLine("y is groter");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine("beide zijn negatief");
            }
            else if (x < 0 || y < 0)
            {
                Console.WriteLine("een is negatief");
            }
            else
            {
                Console.WriteLine("beide zijn positief");
            }

            if (x >= 10 && x <= 20)
            {
                Console.WriteLine("x is in 10 tm 20");
            }
            else
            {
                Console.WriteLine("x is niet in 10 tm 20");
            }

            if (y >= 100)
            {
                Console.WriteLine("y is groter of gelijk aan 100");
            }
            else
            {
                Console.WriteLine("y is niet groter of gelijk aan 100");
            }
        }
    }
}

