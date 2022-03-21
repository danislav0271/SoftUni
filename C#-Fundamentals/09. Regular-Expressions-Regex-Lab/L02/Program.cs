using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace L02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> results = Regex.Matches(input, pattern).Select(x => x.Value).ToList();

            Console.WriteLine(string.Join(", ", results));


            //Console.WriteLine(String.Join(", ", Regex.Matches(Console.ReadLine(), @"\+359(\s|-)2\1\d{3}\1\d{4}\b").Select(x => x.Value)));
        }
    }
}
