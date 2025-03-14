using System;
using System.Diagnostics.CodeAnalysis;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Receives the 3 arguments from the dotnet run command
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                //phrase we want
                string phrase = args[0];

                //Character we want (convert)
                char c = Convert.ToChar(args[1]);

                //How many times we want (convert)
                int quantity = Convert.ToInt32(args[2]);

                Console.WriteLine(Decor(phrase, c, quantity));
            }

            else
            {
                Console.WriteLine(Decor());
            }

        }

        /// <summary>
        /// Receives a string s , a char dec , and an int q
        /// Show the char q times on the right and left of the string s
        /// </summary>
        /// <param name="s">The string </param>
        /// <param name="dec"> The character to put on the right and left of the string </param>
        /// <param name="q"> The number of times that the char dec will be put on each side of the string </param>
        /// <returns>A string with the specified number q of char dec on each side of the string</returns>
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


        /// <summary>
        /// If the user doesn't specify the arguments
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return Decor($"User did not specify args!", Convert.ToChar("="), 3);
        }
    }
}
