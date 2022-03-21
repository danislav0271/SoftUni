using System;

namespace L08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = MathPower(@base, power);
            Console.WriteLine(result);
        }

        static double MathPower(double @base, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= @base;
            }
            return result;
        }
    }
}
