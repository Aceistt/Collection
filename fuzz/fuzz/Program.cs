using System.Runtime.InteropServices.JavaScript;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hoelang wil je de fizzbuzz reeks maken: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else
                {
                    Console.WriteLine($"{i} :(");
                }
            }
        }
    }
}