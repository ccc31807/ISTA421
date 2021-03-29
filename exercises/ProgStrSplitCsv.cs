using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progex_strsplit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************************
             * read CSV with embedded commas
             * parse CSV into separate fields and
             * ignore commas within quoted string
             * ***********************/
            Console.WriteLine("Reading CSV with embedded commas");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
            myList.Add(input2);
            string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
                "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," +
                "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
            myList.Add(input3);

            foreach (string s in myList)
            {
                Console.WriteLine($"Current input is {s}");
                List<string> output = getCSV(s);
                int len = output.Count;
                Console.WriteLine($"This line has {len} fields. They are:");
                foreach (string s1 in output)
                    Console.WriteLine(s1);
            }
        }

        private static List<string> getCSV(string input)
        {
            //Console.WriteLine($"Inside method getCSV({input})");
            int len = input.Length;
            List<string> rv = new List<string>();
            bool inQuote = false;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                int charcode = (int)input[i];
                //Console.WriteLine($"---{input[i]} {charcode} {inQuote} [{sb.ToString()}]");
                //if out-quote and character is ", change to in-quote
                if (inQuote == false && charcode == 34)
                {
                    inQuote = true;
                }
                //if in-quote and character is ", change to out-quote
                else if (inQuote == true && charcode == 34)
                {
                    inQuote = false;
                }
                //if in-quote, append char to SB
                else if (inQuote == true && charcode != 34)
                {
                    sb.Append(input[i]);
                }
                //if out-quote and comma, add SB to RV and clear SB
                else if (inQuote == false && charcode == 44)
                {
                    rv.Add(sb.ToString());
                    sb.Clear();
                }
                else if (inQuote == false && charcode != 44)
                {
                    sb.Append(input[i]);
                }
                else
                    Console.WriteLine($"WARNING, ERROR, == {input[i]} {charcode} {inQuote} [{sb.ToString()}]");
            }
            rv.Add(sb.ToString());
            return rv;
        }
    }
}
