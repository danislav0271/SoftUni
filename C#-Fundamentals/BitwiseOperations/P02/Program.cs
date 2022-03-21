using System;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bitAtPosition1 = n >> 1;
            bitAtPosition1 = bitAtPosition1 & 1;
            Console.WriteLine(bitAtPosition1);
        }
    }
}
