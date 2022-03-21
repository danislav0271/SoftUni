using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)\b";
            List<string> names = new List<string>();
            decimal total = 0;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    total += decimal.Parse(match.Groups["price"].Value) * decimal.Parse(match.Groups["quantity"].Value);
                    names.Add(match.Groups["name"].Value);
                }
            }

            Console.WriteLine("Bought furniture:");
            if (names.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, names));
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}