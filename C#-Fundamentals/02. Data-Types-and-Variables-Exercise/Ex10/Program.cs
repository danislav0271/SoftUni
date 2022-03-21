using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            decimal nPercent50 = n * 0.5m;
            int leftN = (int)n;
            int count = 0;

            while (leftN >= m)
            {
                leftN -= m;
                count++;
                if (leftN == nPercent50 && y > 0)
                {
                    leftN = leftN / y;
                }
            }
            Console.WriteLine(leftN);
            Console.WriteLine(count);
        }
    }
}
