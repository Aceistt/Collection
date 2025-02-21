namespace bakinhoud
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("vul de lengte van de bak in in cm: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("vul de hoogte van de bak in in cm: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("vul de diepte van de bak in in cm: ");
            double depth = double.Parse(Console.ReadLine());
            
            double liters = len * height * depth / 100 / 10;
            Console.WriteLine($"uw object bevat een inhoud van ongeveer {liters} liter");
        }
    }
}