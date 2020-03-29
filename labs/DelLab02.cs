using System;

namespace DelLab02
{
    class Program
    {
        delegate int IntDel(int a, int b);

        static int Add(int a, int b) => a + b;
        static int Sub(int a, int b) => a - b;
        static int Prod(int a, int b) => a * b;
        static int Mod(int a, int b) => a % b;
        static int Pow(int a, int b) => (int) Math.Pow(a, b);
        
        private static (int a, int b) GetInput()
        {
            Console.WriteLine("Enter an integer for the left hand side");
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter an integer for the right hand side");
            int.TryParse(Console.ReadLine(), out b);
            return (a, b);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello Del20200327c!");
            (int a, int b) = GetInput();

            Console.WriteLine("=======using a method call=========");
            int result = Add(a, b);
            Console.WriteLine(result);
            result = Sub(a, b);
            Console.WriteLine(result);
            result = Prod(a, b);
            Console.WriteLine(result);
            result = Mod(a, b);
            Console.WriteLine(result);
            result = Pow(a, b);
            Console.WriteLine(result);

            Console.WriteLine("=======using a delegate=========");
            IntDel idel = new IntDel(Add);
            Console.WriteLine(idel(a, b));
            idel = Sub;
            Console.WriteLine(idel(a, b));
            idel = Prod;
            Console.WriteLine(idel(a, b));
            idel = Mod;
            Console.WriteLine(idel(a, b));
            idel = Pow;
            Console.WriteLine(idel(a, b));
        }
    }
}
