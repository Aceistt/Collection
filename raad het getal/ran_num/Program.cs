namespace ran_getal
{
    class program
    {
        static void Main(string[] args)
        {
            int ran_num = 29;
            Console.WriteLine("kies een nummer 1 tm 100: ");
            int chosen_num = int.Parse(Console.ReadLine());
            if (chosen_num == ran_num)
            {
                Console.WriteLine("je hebt het goede nummer");
            }
            else
            {
                Console.WriteLine("je hebt niet het goede nummer");
            }
        }
    }
}