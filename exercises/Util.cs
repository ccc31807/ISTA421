using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progex13
{
    class Util
    {
        internal static string GetPlainText()
        {
            Console.Write("Enter plain text: ");
            string pt = Console.ReadLine();
            return pt;
        }

        internal static string GetMultiKey()
        {
            Console.Write("Enter your multi key as alpha characters: ");
            string mk = Console.ReadLine();
            return mk;
        }

        internal static string GetSingleKey()
        {
            Console.Write("Enter your single key as an alpha character: ");
            string sk = Console.ReadLine();
            return sk.Substring(0, 1);
           
        }

        internal static int[] Clean(string input)
        {
            int[] result = new int[input.Length];
            for (int i = 0, j = -1; i < input.Length; i++)
            {
                int c = (int)input[i];
                if (c > 90) c -= 32;
                if (c < 65 || c > 90)
                    continue;
                result[++j] = c;
                //Console.WriteLine($"{c} == {input[i]} == {(char)c} == {result[j]}");
            }
            return result;
        }

        internal static string ContiEnc(int[] input, int[] key)
        {
            StringBuilder sb = new StringBuilder();
            int keylen = key.Length;
            int[] arrkey = new int[keylen + input.Length];
            //for (int i = 0; i < keylen; i++)
            //    arrkey[i] = key[i];
            for (int i = 0; i < keylen; i++)
                arrkey[i] = key[i];
            for (int i = keylen; i < input.Length; i++)
                arrkey[i] = input[i - keylen] - 64;
            for (int i = 0; i < input.Length; i++)
            {
                int r = input[i] + arrkey[i];
                if (r > 90)
                    r -= 26;
                if (r < 65)
                    continue;
                char s = (char)r;
                sb.Append(s.ToString());
            }
            return sb.ToString();
        }

        internal static string ContiDec(string input, int[] key)
        {
            int len = input.Length;
            int klen = key.Length;
            int[] inputarr = new int[len];
            for (int i = 0; i < len; i++)
                inputarr[i] = (int)input[i];
            for (int i = 0; i < len; i++)
            {
                if (i < klen)
                {
                    int t = (int)input[i] - key[i % klen];
                    if (t < 65) t += 26;
                    inputarr[i] = t;
                }
                else
                {
                    int t = (int)input[i] - inputarr[i - klen] + 64;
                    if (t < 65) t += 26;
                    inputarr[i] = t;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                char c = (char)inputarr[i];
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }

        internal static string MultiDec(string input, int[] key)
        {
            int len = input.Length;
            int klen = key.Length;
            int[] inputarr = new int[len];
            for (int i = 0; i < len; i++)
                inputarr[i] = (int)input[i];
            for (int i = 0; i < len; i++)
            {
                int t = (int)input[i] - key[i % klen];
                if (t < 65) t += 26;
                inputarr[i] = t;
            }
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                char c = (char)inputarr[i];
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }

        internal static string SingleDec(string input, int[] key)
        {
            int len = input.Length;
            int k = key[0] - 64;
            int[] inputarr = new int[len];
            for (int i = 0; i < len; i++)
                inputarr[i] = (int)input[i];
            for (int i = 0; i < len; i++)
            {
                int t = (int)input[i] - k;
                if (t < 65)
                    t += 26;
                inputarr[i] = t;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                char c = (char)inputarr[i];
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }

        internal static string MultiEnc(int[] input, int[] key)
        {
            StringBuilder sb = new StringBuilder();
            int keylen = key.Length; 
            for(int i = 0; i < keylen; i++)
                key[i] -= 64;
            for (int i = 0; i < input.Length; i++)
            {
                int r = input[i] + key[i % keylen];
                if (r > 90)
                    r -= 26;
                if (r < 65)
                    continue;
                char s = (char)r;
                sb.Append(s.ToString());
                //Console.WriteLine($"{input[i]} -- {k} -- {r} -- {s}");
            }
            return sb.ToString();
        }

        internal static string SingleEnc(int[] input, int[] key)
        {
            StringBuilder sb = new StringBuilder();
            int k = key[0] - 64;
            for (int i = 0; i < input.Length; i++)
            {
                int r = input[i] + k;
                if (r > 90)
                    r -= 26;
                if (r < 65)
                    continue;
                char s = (char)r;
                sb.Append(s.ToString());
                //Console.WriteLine($"{input[i]} -- {k} -- {r} -- {s}");
            }
            return sb.ToString();
        }
    }
}
