using System;
using System.Linq;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int[] uniquePair = new int[2];

                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] + array[j] == sum)
                    {
                        uniquePair[0] = array[i];
                        uniquePair[1] = array[j];

                        Console.WriteLine(String.Join(' ', uniquePair));
                    }
                }
            }
        }
    }
}
