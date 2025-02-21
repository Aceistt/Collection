namespace rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kies je eerste nummer: ");
            double nr1 = double.Parse(Console.ReadLine());
            
            Console.Write("kies + (plus) - (min) of * (keer): ");
            string choise = Console.ReadLine();
            
            Console.Write("kies nr 2: ");
            double nr2 = double.Parse(Console.ReadLine());

            if (choise == "+")
            {
                double nr3 = nr1 + nr2;
                Console.Write(nr3);
            }
            else if (choise == "-")
            {
                double nr3 = nr1 - nr2;
                Console.Write(nr3);
            }
            else if (choise == "*")
            {
                double nr3 = nr1 * nr2;
                Console.Write(nr3);
            }
            
        }
    }
}

