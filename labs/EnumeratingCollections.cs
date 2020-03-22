using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumeratingCollectionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumerating Collections Lab");

            Console.WriteLine("Example 1");
            int[] myArray = new int[] { 1, 3, 2, 5, 3, 7, 5, 99 };
            foreach (int i in myArray)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Example 2");
            var enumer = myArray.GetEnumerator();
            while (enumer.MoveNext())
                Console.WriteLine(enumer.Current);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Example 3");
            Presidents pres = new Presidents();
            foreach (President p in pres)
                Console.WriteLine($"{p.FirstName} {p.LastName} was elected in {p.Year}");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Example 4 - infinite enumeration");
            var myInfinity = new MyInfinity();
            foreach (int i in myInfinity)
            {
                Console.WriteLine(i);
                if (i > 500)
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class MyInfinity : IEnumerable<int>
    {
        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return new MyInfiniteEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            //throw new NotImplementedException();
            return new MyInfiniteEnumerator();
        }
    }

    public class MyInfiniteEnumerator : IEnumerator<int>
    {
        public int Current { get; private set; } = 0;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            Current++;
            return true;
        }

        public void Reset()
        {
            Current = 0;
        }
    }

    public class President
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public President(string f, string l, int y)
        {
            FirstName = f;
            LastName = l;
            Year = y;
        }
    }

    public class Presidents : IEnumerable
    {
        private President[] presidentArray = new President[5];

        public Presidents()
        {
            presidentArray[0] = new President("George", "Washington", 1788);
            presidentArray[1] = new President("John", "Adams", 1796);
            presidentArray[2] = new President("Thomas", "Jeffersion", 1800);
            presidentArray[3] = new President("James", "Madison", 1808);
            presidentArray[4] = new President("James", "Monroe", 1816);
        }

        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return presidentArray.GetEnumerator();
        }
    }
}
