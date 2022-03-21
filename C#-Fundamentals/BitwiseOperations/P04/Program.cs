using System;

namespace P04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = ~(1 << p);
            int newNumber = n & mask;

            Console.WriteLine(newNumber);
        }
    }
}
