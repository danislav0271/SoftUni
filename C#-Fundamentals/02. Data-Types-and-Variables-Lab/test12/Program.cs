using System;

namespace test12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int how = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int n = 1; n <= how; n++)
            {
                int numToWork = n;
                while (numToWork > 0)
                {
                    sum += numToWork % 10;
                    numToWork = numToWork / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", n, isSpecial);
                sum = 0;
            }

        }
    }
}
