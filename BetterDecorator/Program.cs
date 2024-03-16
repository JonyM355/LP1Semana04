using System;

namespace BetterDecorator
/// <summary>
/// This program receives 3 values, 1 string and 1 int
/// </summary>
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {

            }
            else
            {
                char a = char.Parse(args[1]);
                int n = int.Parse(args[2]);
                Console.WriteLine(Decor(args[0], a, n));
            }
        }
        private static void CountError()
        {
            Console.WriteLine(Decor("Not args enough!", '&', 3))
        }

        private static string Decor(string s, char dec, int num)
        {
            string q = "";
            string e = "";
            for (int w = 0; a < num; w++)
            {
                q = q + dec;
            }
            return $"{q} {s} {q}";
        }
    }
}
