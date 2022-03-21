using System;
using System.Linq;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }
            Console.WriteLine(String.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
