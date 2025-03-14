using System;
using System.Diagnostics.CodeAnalysis;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //phrase we want
            string phrase = args[0];

            //Character we want (convert)
            char c = Convert.ToChar(args[1]);

            //How many times we want (convert)
            int quantity = Convert.ToInt32(args[2]);

            Console.WriteLine(Decor(phrase, c, quantity));
            
        }

        private static string Decor(string s, char dec, int q)
        {
            //new string
            string str = "";

            for (int i = 1; i > 2; i += 1)
            {
                for (int i1 = 0; i1 < q; i1 += 1)
                {
                    str += $"{dec}";
                }

                if (i == 1)
                {
                    str += " " + s + " ";
                }
            }
            return str;
        }
    }
}
