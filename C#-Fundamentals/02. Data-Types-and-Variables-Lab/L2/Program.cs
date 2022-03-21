using System;

namespace L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal result = pound * 1.31m;
            Console.WriteLine($"{result:f3}");
        }
    }
}
