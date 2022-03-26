using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P07.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(\=|\/)([A-Z][A-Za-z]{2,})(\1)");

            MatchCollection matches = regex.Matches(input);
            List<string> output = new List<string>();

            int travelPoints = 0;

            foreach (Match item in matches)
            {
                string currDestination = item.Groups[2].Value;
                travelPoints += currDestination.Length;
                output.Add(currDestination);
            }

            Console.WriteLine($"Destinations: {String.Join(", ", output)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
