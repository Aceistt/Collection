namespace height_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            double minheight = 1.2;
            Console.Write("Enter height (in meters): ");
            double height = double.Parse(Console.ReadLine());

            if (height >= minheight)
            {
                Console.WriteLine("jij mag in de python");
            }
            else if (height < minheight)
            {
                Console.WriteLine("jij mag niet in de python");
            }
        }
    }
}