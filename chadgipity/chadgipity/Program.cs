namespace chad
{
    class program
    {
        
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Welcome to the chadgipity program");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Ask me a question");
                Console.WriteLine("H for all possible questions");
                Console.WriteLine("Exit or X to close");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("enter your question: ");
                string userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "exit":
                    case "x":
                    {
                        run = false;
                        break;
                    }
                    case "h":
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("1: how are you doing");
                        Console.WriteLine("2: what time is it");
                        Console.WriteLine("4: give me a random number between 1 and 10");
                        Console.WriteLine("3: give me a random number between 10 and 20");
                        Console.WriteLine("5: give me a random number between 1 and 100");
                        Console.WriteLine("6: what is 1+1");
                        Console.WriteLine("7: what is 2+2");
                        Console.WriteLine("8: what is 3+3");
                        Console.WriteLine("9: what is 4+4");
                        Console.WriteLine("10: what is 5+5");
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "how are you doing":
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("im doing good");
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "what time is it":
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("its" + DateTime.Now.ToLongTimeString());
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "give me a random number between 1 and 10":
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Random rnd = new Random();
                        int number = rnd.Next(1, 10);
                        Console.WriteLine(number);
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "give me a random number between 10 and 20":
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Random rnd = new Random();
                        int number = rnd.Next(10, 20);
                        Console.WriteLine(number);
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "give me a random number between 1 and 100":
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Random rnd = new Random();
                        int number = rnd.Next(1, 100);
                        Console.WriteLine(number);
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "what is 1+1":
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine(1 + 1);
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "what is 2+2":
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(2 + 2);
                        Console.WriteLine("----------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "what is 3+3":
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(3 + 3);
                        Console.WriteLine("----------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "what is 4+4":
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(4 + 4);
                        Console.WriteLine("----------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                    case "what is 5+5":
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(5 + 5);
                        Console.WriteLine("----------------------------------------------");
                        Console.Write("Anny key to continue");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}