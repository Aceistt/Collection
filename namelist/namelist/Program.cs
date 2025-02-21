namespace namelist
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the namelist");
            string[] names = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Please enter your name: ");
                names[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("de gekozen namen zijn");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
