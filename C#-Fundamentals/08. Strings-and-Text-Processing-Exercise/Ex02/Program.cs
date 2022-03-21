using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string str1 = arr[0];
            string str2 = arr[1];
            double result = 0;
            int n = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < n; i++)
            {
                int first = 0;
                int second = 0;
                if (i < str1.Length)
                {
                    first = (int)str1[i];
                }
                if (i < str2.Length)
                {
                    second = (int)str2[i];
                }

                if (first == 0 || second == 0)
                {
                    result += first + second;
                }
                else
                {
                    result += first * second;
                }
            }

            Console.WriteLine(result);
        }
    }
}
