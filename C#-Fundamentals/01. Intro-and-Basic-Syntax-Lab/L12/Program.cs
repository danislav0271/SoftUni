using System;

namespace L12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isTrue = true;

            while (isTrue)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    isTrue = false;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    n = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
