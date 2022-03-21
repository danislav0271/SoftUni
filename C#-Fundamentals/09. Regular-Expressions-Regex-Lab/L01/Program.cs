using System;
using System.Text.RegularExpressions;

namespace L01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<name>[A-Z][a-z]{1,} [A-Z][a-z]{1,})\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match item in matches)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
