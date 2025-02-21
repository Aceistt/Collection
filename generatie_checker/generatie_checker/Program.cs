namespace generatie_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vul je geboorte jaar in");
            int birthyear = int.Parse(Console.ReadLine());

            if (birthyear >= 1941 && birthyear <= 1955)
            {
                Console.WriteLine("U bent een babyboomer");
            }
            else if (birthyear >= 1956 && birthyear <= 1970)
            {
                Console.WriteLine("U bent een gen-x");
            }
            else if (birthyear >= 1971 && birthyear <= 1985)
            {
                Console.WriteLine("U bent een xennial");
            }
            else if (birthyear >= 1986 && birthyear <= 2000)
            {
                Console.WriteLine("U bent een gen-y");
            }
            else if (birthyear >= 2000 && birthyear <= 2015)
            {
                Console.WriteLine("U bent een gen-z");
            }
            else if (birthyear >= 2015 && birthyear <= 2025)
            {
                Console.WriteLine("U bent een gen-alpha");
            }
            else if (birthyear >= 2026)
            {
                Console.WriteLine("U bestaat nog niet");
            }
        }
    }
}