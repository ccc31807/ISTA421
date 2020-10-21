using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLabs
{
    class Solutions
    {
        internal static int[] Lab01()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = i + 1;
            return arr;
        }
        internal static int[] Lab02()
        {
            int[] arr = new int[10];
            for (int i = 0, j = 10; i < 10; i++, j--)
                arr[i] = j;
            return arr;
        }

        internal static int[] Lab03(int[] myIntArr)
        {
            int[] arr = new int[11];
            for(int i = 0, j = 0; i < myIntArr.Length; i += 2, j++)
                arr[j] = myIntArr[i];
            return arr;
        }

        internal static int[] Lab04(int[] myIntArr)
        {
            int[] arr = new int[10];
            for(int i = 0, j = 0; i < myIntArr.Length-1; i += 2, j++)
                arr[j] = myIntArr[i+1];
            return arr;
        }

        internal static int[] Lab05(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for(int i = 0; i < myIntArr.Length; i++)
                arr[i] = myIntArr[i%3];
            return arr;
        }

        internal static int[] Lab06(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for (int i = 0; i < myIntArr.Length; i++)
                arr[i] = myIntArr[(i % 3) + 1];
            return arr;
        }

        internal static int[] Lab07(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for (int i = 0; i < myIntArr.Length; i++)
                arr[i] = myIntArr[Math.Abs((i % 3) - 3)];
            return arr;
        }

        internal static int[] Lab08(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            Array.Copy(myIntArr, arr, myIntArr.Length);
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int place = r.Next(arr.Length);
                //Console.WriteLine($"{i}. random place is {place}, swapping {arr[i]} with {arr[place]}");
                int temp = arr[i];
                arr[i] = arr[place];
                arr[place] = temp;
            }
            return arr;
        }

        internal static int[] Lab09(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for (int i = 0; i < myIntArr.Length; i++)
                arr[myIntArr[i]] = myIntArr[i];
            return arr;
        }

        internal static int[] Lab10(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for (int i = 0; i < myIntArr.Length; i++)
                arr[i] = (i + 5) % myIntArr.Length;
            return arr;
        }

        internal static int[] Lab11(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for (int i = 0; i < myIntArr.Length; i++)
                arr[i] = (myIntArr.Length - 3 + i) %  myIntArr.Length;
            return arr;
        }

        internal static int[] Lab12(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length - 1];
            for (int i = 1; i < myIntArr.Length; i += 2)
            {
                int temp = myIntArr[i-1];
                arr[i - 1] = myIntArr[i];
                arr[i] = temp;
            }
            return arr;
        }

        internal static int[] Lab13(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for (int i = 1; i < arr.Length; i++)
                arr[i] = myIntArr[i] + arr[i - 1];
            return arr;
        }

        internal static int[] Lab14(int[] myIntArr)
        {
            int[] arr = new int[myIntArr.Length];
            for (int i = 1; i < arr.Length; i++)
                arr[i] = ((i % 11) * 2) + (i / 11);
            return arr;
        }
    }
}

