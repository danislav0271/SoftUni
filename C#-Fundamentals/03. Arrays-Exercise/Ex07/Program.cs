using System;
using System.Linq;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int first = array[0];
            int counter = 1;
            int bestCounter = 0;
            int number = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == first)
                {
                    counter++;
                }
                else
                {
                    first = array[i];
                    counter = 1;
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    number = array[i];
                }
            }

            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
