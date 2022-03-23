using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(@|#)([A-Za-z]{3,})(\1)(\1)([A-Za-z]{3,})(\1)");
            List<string[]> results = new List<string[]>();

            string message = Console.ReadLine();

            MatchCollection matches = pattern.Matches(message);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match item in matches)
            {
                string firstWord = item.Groups[2].Value;
                string secondWord = item.Groups[5].Value;

                string reversedSecondWord = string.Join("", secondWord.Reverse());

                if (firstWord == reversedSecondWord)
                {
                    results.Add(new string[] {firstWord, secondWord});
                }
            }

            if (results.Count == 0 )
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                string[] messages = results.Select(word => $"{word[0]} <=> {word[1]}").ToArray();
                Console.WriteLine("The mirror words are: ");
                Console.WriteLine(string.Join(", ", messages));
            }
        }
    }
}
