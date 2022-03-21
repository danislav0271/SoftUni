using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int div = 2; div < i; div++)
                {
                    if (i % div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string isTrue = isPrime.ToString();
                Console.WriteLine("{0} -> {1}", i, isTrue.ToLower());
            }
        }
    }
}
