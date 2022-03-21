using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (!count.ContainsKey(ch) && ch != ' ')
                {
                    count[ch] = 1;
                }
                else if(ch != ' ')
                {
                    count[ch]++;
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
