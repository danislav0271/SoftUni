using System;
using System.Linq;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            bool isEqual = false;

            if (array.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                double leftSum = 0;
                double rightSum = 0;

                for (int k = 0; k < i; k++)
                {
                    leftSum += array[k];
                }

                for (int j = array.Length - 1; j > i; j--)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }

            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
