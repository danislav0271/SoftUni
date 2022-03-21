using System;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Matrix(n);
        }

        static void Matrix(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = n;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Join(' ', array));
            }
        }
    }
}
