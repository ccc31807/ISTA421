using Microsoft.VisualBasic;
using System;

namespace LINQquizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ quizzes");
            Answer a = new Answer();

            Console.WriteLine("Quiz 1.");
            Console.WriteLine("Using LINQ, print the even numbers from the following integer array");
            int[] intArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a.Quiz01(intArray);
            Console.WriteLine();

            Console.WriteLine("Quiz 2.");
            Console.WriteLine("Using LINQ, print all positive numbers from the following integer array");
            intArray = new int[10] { 0, -1, -2, -3, 4, 5, 6, 7, 8, -9 };
            a.Quiz02(intArray);
            Console.WriteLine();

            Console.WriteLine("Quiz 3.");
            Console.WriteLine("Using LINQ, print the squares of the following integer array");
            intArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            a.Quiz03(intArray);
            Console.WriteLine();

            Console.WriteLine("Quiz 4.");
            Console.Write("Display the number and frequency of each number from given array : \n");
            intArray = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            a.Quiz04(intArray);
            Console.WriteLine();

            Console.WriteLine("Quiz 5.");
            Console.Write("Display the number and frequency of each character from given string : \n");
            string s = "And so, my fellow Americans: " +
                "ask not what your country can do for you — " +
                "ask what you can do for your country.";
            a.Quiz05(s);
            Console.WriteLine();

            Console.WriteLine("Quiz 6.");
            Console.Write("Display the integer and frequency of each number, and the product of the integer and frequency in given array. : \n");
            intArray = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            a.Quiz06(intArray);
            Console.WriteLine();
        }
    }
}

