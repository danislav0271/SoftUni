using System;

namespace P06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 7 << p;
            int result = n ^ mask;
            Console.WriteLine(result);
        }
    }
}
