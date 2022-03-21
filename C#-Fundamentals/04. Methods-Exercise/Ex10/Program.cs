using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (!IsDivisibleBy8(i) || !IsHoldingOddDigit(i))
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        static bool IsDivisibleBy8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool IsHoldingOddDigit(int number)
        {
            while (number > 0)
            {
                int n = number % 10;
                number /= 10;

                if (n % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
