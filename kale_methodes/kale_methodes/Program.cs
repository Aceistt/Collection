namespace methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("maak een keuze voor wat je wil 1 tm 10 h voor hulp: ");
                string keuze = Console.ReadLine();
                switch (keuze)
                {
                    case "1":
                        Console.Write("kies nr1: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("kies nr2: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Write($"de som van de nummers is: {num1 + num2}");
                        break;
                    case "2":
                        Console.WriteLine("geef mij een zin die wel of niet coke bevat");
                        Console.Write("vul in: ");
                        string zin = Console.ReadLine();
                        if (zin.ToLower().Contains("coke"))
                        {
                            Console.WriteLine("uw zin bevat het woord coke");
                        }
                        else
                        {
                            Console.WriteLine("uw zin bevat het woord coke niet");
                        }
                        break;
                    case "3":
                        Console.Write("geef mij een graden celcius: ");
                        double tempC = double.Parse(Console.ReadLine());
                        Console.WriteLine($"dat is {tempC * 1.8 + 32} graden farenheit");
                        break;
                    case "4":
                        Console.WriteLine($"de huidige datum en tijd is {DateTime.Now}");
                        break;
                    case "5":
                        int wordcount = 0;
                        Console.Write("geef mij een niet te lange text aub: ");
                        string words = Console.ReadLine();
                        foreach (string word in words.Split(" "))
                        {
                            foreach (string av in words.Split(" "))
                            {
                                if (av == "")
                                {
                                    wordcount++;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}