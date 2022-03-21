using System;
using System.Linq;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] topIntegers = new int[arr.Length];
            int topIntegersIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentNum <= arr[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex] = currentNum;
                    topIntegersIndex++;
                }
            }

            for (int i = 0; i < topIntegersIndex; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }
        }
    }
}
