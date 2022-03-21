using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal aa = Math.Round(a, 6);
            decimal bb = Math.Round(b, 6);

            if (Math.Abs(aa - bb) <= (decimal)0.000001 || Math.Abs(bb - aa) <= (decimal)0.000001)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
