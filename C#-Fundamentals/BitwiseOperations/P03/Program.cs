using System;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int bitAtPositionP = n >> p;
            bitAtPositionP = bitAtPositionP & 1;
            Console.WriteLine(bitAtPositionP);
        }
    }
}
