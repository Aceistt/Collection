namespace digi_paspoort
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welkom bij het digipaspoort programma vul hier aub je info in");
            Console.WriteLine("========================================================");
            Console.WriteLine("digi paspoort");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("lengte (in cm): ");
            int lengte = int.Parse(Console.ReadLine());
            Console.Write("gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("========================================================");
        }
    }
}

