using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace csharp_Q23parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# quiz 23 - parallel version");
            Console.Write("Enter the highest number to find primes: ");
            string input = Console.ReadLine();
            long findTo = long.Parse(input);
            List<long> primes = new List<long>();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.For( 1, findTo, x => findPrimes(x, primes));
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            //output
            Console.WriteLine("PRINTING PRIMES");
            //foreach (int element in primes)
            //    Console.Write($" {element} ");
            Console.WriteLine($"\n\nfound primes in time {ts}");
        }

        private static void findPrimes(long i, List<long> primes)
        {
            bool foundP = isPrime(i);
            //Console.WriteLine($"from foundP: i is {i}");
            if (foundP)
                primes.Add(i);
        }

        private static bool isPrime(long n)
        {
            bool isP = true;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    isP = false;
                    break;
                }
            return isP;
        }
    }
}
