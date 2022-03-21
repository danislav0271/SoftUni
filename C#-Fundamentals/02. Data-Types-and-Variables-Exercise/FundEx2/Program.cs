using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            long productOne = (long)a + b;
            long productTwo = productOne / c;
            long product = productTwo * d;
            Console.WriteLine(product);
        }
    }
}
