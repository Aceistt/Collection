namespace cylinder
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("vul de hoogte in in cm: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("vul de straal in in cm: ");
            double depth = double.Parse(Console.ReadLine());

            double volume = Double.Pi * (depth * depth) * height / 1000;
            Console.WriteLine($"de volume van uw cylinder is {volume} liters");
        }
    }
}