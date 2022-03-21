using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string line;
            while ((line = Console.ReadLine()) != "end of race")
            {
                MatchCollection match = Regex.Matches(line, @"[A-Za-z]+");
                string participan = string.Empty;
                foreach (Match item in match)
                {
                    participan += item.Value;
                }
                if (participants.Contains(participan))
                {
                    MatchCollection match1 = Regex.Matches(line, @"\d");
                    int sum = 0;
                    foreach (Match item in match1)
                    {
                        sum += int.Parse(item.Value);
                    }
                    if (!dictionary.ContainsKey(participan))
                    {
                        dictionary.Add(participan, 0);
                    }
                    dictionary[participan] += sum;
                }
            }

            dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"1st place: {dictionary.Keys.First()}");
            Console.WriteLine($"2nd place: {dictionary.Keys.ToList()[1]}");
            Console.WriteLine($"3rd place: {dictionary.Keys.ToList()[2]}");
        }
    }
}
