using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                BigInteger[] array = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
                BigInteger greaterNum = 0;

                if (array[0] > array[1])
                {
                    greaterNum = array[0];
                }
                else
                {
                    greaterNum = array[1];
                }
                
                BigInteger sum = 0;
                while (greaterNum != 0)
                {
                    sum += greaterNum % 10;
                    greaterNum /= 10;
                }
                
                Console.WriteLine(sum);
            }
        }
    }
}
