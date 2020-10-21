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
    /***************************************************
    * solutions 7 through 12 omitted
    ****************************************************/
    }
}

