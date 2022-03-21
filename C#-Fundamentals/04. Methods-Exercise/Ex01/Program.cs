using System;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            SmallestNumber(first, second, third);
        }

        static void SmallestNumber(int first, int second, int third)
        {
            if (first < second && first < third)
            {
                Console.WriteLine(first);
            }
            else if (second < first && second < third)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(third);
            }
        }
    }
}
