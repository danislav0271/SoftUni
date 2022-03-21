using System;

namespace L10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            GetMultipleOfEvenAndOdds(number);
        }

        static void GetMultipleOfEvenAndOdds(int number)
        {
            int sum = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            Console.WriteLine(sum);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int n = number % 10;
                number /= 10;

                if (n % 2 == 0)
                {
                    sum += n;
                }
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int n = number % 10;
                number /= 10;

                if (n % 2 != 0)
                {
                    sum += n;
                }
            }

            return sum;
        }
    }
}
