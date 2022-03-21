using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);
                if (indexOfBomb == -1)
                {
                    break;
                }

                DetonateBomb(numbers, indexOfBomb, bombPower);
            }

            Console.WriteLine(numbers.Sum());
        }

        static void DetonateBomb(List<int> numbers, int indexOfBomb, int bombPower)
        {
            int rightIndex = indexOfBomb + bombPower;

            for (int i = indexOfBomb; i <= rightIndex; i++)
            {
                if (indexOfBomb >= numbers.Count)
                {
                    break;
                }

                numbers.RemoveAt(indexOfBomb);
            }

            int leftIndex = indexOfBomb - bombPower;

            if (leftIndex < 0)
            {
                leftIndex = 0;
            }
            for (int i = leftIndex; i < indexOfBomb; i++)
            {
                numbers.RemoveAt(leftIndex);
            }
        }
    }
}
