using System;

namespace L04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Array.Reverse(input);
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
