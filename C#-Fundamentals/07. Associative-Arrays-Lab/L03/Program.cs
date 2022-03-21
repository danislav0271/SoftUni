using System;
using System.Collections.Generic;

namespace L03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonymList = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymList.ContainsKey(word))
                {
                    synonymList.Add(word, new List<string>());
                }

                synonymList[word].Add(synonym);
            }

            foreach (var item in synonymList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
