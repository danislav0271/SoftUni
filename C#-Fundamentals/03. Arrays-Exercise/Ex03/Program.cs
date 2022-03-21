using System;
using System.Linq;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstNum = array[0];
                int secondNum = array[1];
                if (row % 2 != 0)
                {
                    first[row - 1] = firstNum;
                    second[row - 1] = secondNum;
                }
                else
                {
                    first[row - 1] = secondNum;
                    second[row - 1] = firstNum;
                }
            }
            Console.WriteLine($"{string.Join(" ", first)}\n{string.Join(" ", second)}");
        }
    }
}
