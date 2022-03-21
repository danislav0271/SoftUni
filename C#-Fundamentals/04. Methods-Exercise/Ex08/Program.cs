using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double sum = Factorial(first) / Factorial(second);

            Console.WriteLine($"{sum:F2}");
        }

        static double Factorial(int n)
        {
            double sum = n;

            for (int i = 1; i < n; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
