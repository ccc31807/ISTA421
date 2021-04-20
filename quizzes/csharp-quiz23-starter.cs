using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace csharp_quiz23para
{
    class Program
    {
        static List<long> primes = new List<long>();
        static void Main(string[] args)
        {
            Console.WriteLine("C# quiz 23 parallel");
            Console.Write("Enter the highest number to find primes: ");
            string input = Console.ReadLine();
            long findTo = long.Parse(input);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (long i = 1; i < findTo; i++)
               isPrime(i) ;
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            //uncomment to see primes
            //Console.WriteLine("PRINTING PRIMES");
            //foreach (int element in primes)
            //    Console.Write($" {element} ");

            Console.WriteLine($"\n\nfound primes in time {ts}");
        }

        private static void isPrime(long n)
        {
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                if (n % i == 0)
                    return;
            primes.Add(n);
        }
    }
}


