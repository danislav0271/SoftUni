using System;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int f = 1; f <= i; f++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
