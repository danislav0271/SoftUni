using System;

namespace L5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int numberToProcess = i;
                int sum = 0;
                while (numberToProcess > 0)
                {
                    int currentDigit = numberToProcess % 10;
                    numberToProcess = numberToProcess / 10;
                    sum += currentDigit;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
