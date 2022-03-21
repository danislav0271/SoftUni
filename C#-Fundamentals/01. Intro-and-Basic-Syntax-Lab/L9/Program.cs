using System;

namespace L9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentOddNumber = 1 + (2 * i);
                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
