using System;

namespace L12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int n = 1; n <= num; n++)
            {
                int sum = 0;
                int number = n;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", n, isTrue);
            }
        }
    }
}
