using System;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            byte count = 0;
            uint totalYield = startingYield;
            uint total = 0;

            while (totalYield >= 100)
            {
                count++;
                uint totalSpices = totalYield - 26;
                total += totalSpices;
                totalYield -= 10;
            }
            if (total >= 26)
            {
                total -= 26;
            }
            Console.WriteLine(count);
            Console.WriteLine(total);
        }
    }
}
