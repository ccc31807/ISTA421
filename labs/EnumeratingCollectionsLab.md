# Enumerating Collections Lab
## Charles Carter
### March 22, 2020

1. Open Visual Studio and create a new .NET Core 2 console application. Name the project *EnumeratingCollectiionsLab* and place it in hour appropriate lab folder.

1. Edit the *Main()* method as follows:

        static void Main(string[] args)
        {
            Console.WriteLine("Enumerating Collections Lab");
        }

1. Add the following as *Example 1*:

            Console.WriteLine("Example 1");
            int[] myArray = new int[] { 1, 3, 2, 5, 3, 7, 5, 99 };
            foreach (int i in myArray)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.ReadKey();

1. Add the following as *Example 2*:

            Console.WriteLine("Example 2");
            var enumer = myArray.GetEnumerator();
            while (enumer.MoveNext())
                Console.WriteLine(enumer.Current);
            Console.WriteLine();
            Console.ReadKey();

1. Create class *President* in the namespace as follows:

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

1. Create class *Presidents* in the namespace as follows:

        public class Presidents
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
        }

1. In the *Program* class, add a *Presidents* instance and attempt to iterate through the collection using a foreach loop, as follows:

            Console.WriteLine("Example 3");
            Presidents pres = new Presidents();
            foreach (President p in pres)
                Console.WriteLine($"{p.FirstName} {p.LastName} was elected in {p.Year}");
            Console.WriteLine();
            Console.ReadKey();

1. What went wrong? Why?  The error message is "foreach statement cannot operate on variables of type 'Presidents' because 'Presidents' does not contain a public instance definition for 'GetEnumerator'"

1. Implement *IEnumerable* in the *Presidents* class, as follows:

        public class Presidents : IEnumerable

1. Add a using directive to import the *System.Collectons* namespace.

        using System.Collections;

1. Implement the interface. It adds the *GetEnumerator()* method. Comment out the *throw* statement and add the return statement as follows:

            public IEnumerator GetEnumerator()
            {
                //throw new NotImplementedException();
                return presidentArray.GetEnumerator();
            }
`
1. An Enumerable object does not have to have a stated length, but can be infinate. To illustrate, create a new class named *myInfinity* that implements *IEnumerable*.

        public class MyInfinity : IEnumerable
        {

        }

1. Implement the interface. The method *GetEnumerator()* simply returns a new enumerator object.

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

1. Add a class to implement the *IEnumerator* interface.


        public class MyEnumerator : IEnumerator
        {

        }

1. Implement the *IEnumerator* interface as shown.

        public class MyInfiniteEnumerator : IEnumerator<int>
        {
            public int Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

1. Add a *using* directive importing the generic collections namespace.

        using System.Collections.Generic;


1. Implement the *Current* property and set it to 0.

            public object Current { get; private set; } = 0;

1. Have the *IEnuerator.Current* property return *Current*.

            object IEnumerator.Current => Current;

1. Delete the body of the *Dispose()* nethod.

            public void Dispose()
            {
            }

1. Revise the *MoveNext()* method to increment *Currebt* and return *true*, as shown:

            public bool MoveNext()
            {
                Current++;
                return true;
            }

1. Revise the *Reset()* method to set *Current* to 0:

            public void Reset()
            {
                Current = 0;
            }

1. Add Example 4 to the *Main()* mmethod as show:

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

1. Build and run.
