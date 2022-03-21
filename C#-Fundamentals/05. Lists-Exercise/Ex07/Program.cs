using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            List<int> listOfNumbers = new List<int>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int[] numbers = array[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                listOfNumbers.AddRange(numbers);
            }

            Console.WriteLine(String.Join(' ', listOfNumbers));
        }
    }
}
