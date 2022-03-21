using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = IntegersSubtracts(first, second, third);
            Console.WriteLine(sum);
        }

        static int IntegersAdd(int first, int second)
        {
            return first + second;
        }
        static int IntegersSubtracts(int first, int second, int third)
        {
            return IntegersAdd(first, second) - third;
        }
    }
}
