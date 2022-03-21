using System;
using System.Collections.Generic;

namespace L02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Dictionary<string , int> wordsCount = new Dictionary<string , int>();

            foreach (var item in words)
            {
                string lowerCase = item.ToLower();
                if (wordsCount.ContainsKey(lowerCase))
                {
                    wordsCount[lowerCase]++;
                }
                else
                {
                    wordsCount.Add(lowerCase, 1);
                }
            }

            foreach (var item in wordsCount)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
