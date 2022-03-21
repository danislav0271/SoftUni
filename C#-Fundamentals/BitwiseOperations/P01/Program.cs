using System;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            int counter = 0;

            string binary = Convert.ToString(n, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == b)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
