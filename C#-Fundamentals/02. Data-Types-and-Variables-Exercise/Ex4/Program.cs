using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int charSum = 0;

            for (int i = 0; i < n; i++)
            {
                char a = char.Parse(Console.ReadLine());
                charSum += (int)a;
            }
            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
