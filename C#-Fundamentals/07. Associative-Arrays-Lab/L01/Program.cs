using System;
using System.Collections.Generic;
using System.Linq;

namespace L01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            foreach (var item in number)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
