using System;

namespace ArrayLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Labs");


            int[] myIntArr = new int[]
                { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Print myIntArr");
            foreach(int i in myIntArr)
                Console.Write($" {i} ");
            Console.WriteLine("\n================= begin labs below ===================");

            Console.WriteLine("1. Write a method that returns an integer array from 1 to 10");
            int[] a1 = Solutions.Lab01();
            foreach(int i in a1)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("2. Write a method that returns an integer array from 10 to 1");
            int[] a2 = Solutions.Lab02();
            foreach(int i in a2)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("3. Write a method that returns an integer array the even " +
                "integers (0, 2, 4, 6, etc.) through 20 given myIntArr");
            int[] a3 = Solutions.Lab03(myIntArr);
            foreach(int i in a3)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("4. Write a method that returns an integer array the odd " +
                "integers (1, 3, 6, 7, etc.) through 20 given myIntArr");
            int[] a4 = Solutions.Lab04(myIntArr);
            foreach (int i in a4)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("5. Write a method that returns an integer array from that repeats " +
                "0, 1, 2 given myIntArr");
            int[] a5 = Solutions.Lab05(myIntArr);
            foreach (int i in a5)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("6. Write a method that returns an integer array from that repeats " +
                "1, 2, 3 given myIntArr");
            int[] a6 = Solutions.Lab06(myIntArr);
            foreach (int i in a6)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("7. Write a method that returns an integer array from that repeats " +
                "3, 2, 1 given myIntArr");
            int[] a7 = Solutions.Lab07(myIntArr);
            foreach (int i in a7)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("8. Given myIntArr, write a method permutes (scrambles, shuffles) the array" +
                " and returns it");
            int[] a8 = Solutions.Lab08(myIntArr);
            foreach (int i in a8)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("09. Given the previous permuted array a8, sort the array into the " +
                "correct order. NOTE: You must sort the shuffled array.");
            int[] a09 = Solutions.Lab09(a8);
            foreach (int i in a09)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("10. Shift myIntArr 5 places to the left, so that it prints 5, 6, 7, etc.");
            int[] a10 = Solutions.Lab10(myIntArr);
            foreach (int i in a10)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("11. Shift myIntArr 3 places to the right, so that it prints " +
                "18, 19, 20, 1, 2, etc.");
            int[] a11 = Solutions.Lab11(myIntArr);
            foreach (int i in a11)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("12. Given myIntArr, 'flip' each element. Output should be " +
                "{1, 0, 3, 2, 5, 4, ... }");
            int[] a12 = Solutions.Lab12(myIntArr);
            foreach (int i in a12)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("13. Create a method that, given myIntArr, returns an array consisting " +
                "of the sum of all prior elements, e.g. {0, 1, 3, 6, 10, ...} ");
            int[] a13 = Solutions.Lab13(myIntArr);
            foreach (int i in a13)
                Console.Write($" {i} ");
            Console.WriteLine();

            Console.WriteLine("14. Given myIntArr, separate the even and odd numbers, placing the even integers " +
                "(0, 2, 4, ...) at the beginning and the odd integers (1, 3, 5, ...) at the end..");
            int[] a14 = Solutions.Lab14(myIntArr);
            foreach (int i in a14)
                Console.Write($" {i} ");
            Console.WriteLine();

        }
    }

   
}

