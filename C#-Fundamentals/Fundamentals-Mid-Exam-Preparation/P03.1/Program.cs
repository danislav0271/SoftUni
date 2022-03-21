using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            double average = list.Sum() / list.Count;

            list.RemoveAll(x => x <= average);
            list.Sort();
            list.Reverse();
            if (list.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (list.Count <= 5)
            {
                Console.WriteLine(String.Join(" ", list));
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
    }
}
