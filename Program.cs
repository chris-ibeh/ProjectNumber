using System;

namespace PrimeOddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb, x, y = 0;
            Console.Write("Enter any Number: ");
            numb = int.Parse(Console.ReadLine());

            for (x = 2; x <= numb / 2; x++)
            {
                if (numb % x == 0)
                {
                    Console.Write("FIZZBUZZ the Number you typed is not a Prime Number");
                    y = 1;
                    break;
                }
            }
            if (y == 0)
            {
                Console.Write("FIZZBUZZ the Number you typed is a Prime Number");
            }
                Console.ReadLine();
            
            if (numb % 2 == 0)
            {
                Console.WriteLine("BUT FIZZ The Number you typed is also Even Number ");
                
            }
            else if (numb % 2 != 0)
            {
                Console.WriteLine("BUT BUZZ The Number you typed is also Odd Number ");
                
            }
        }
    }
}
