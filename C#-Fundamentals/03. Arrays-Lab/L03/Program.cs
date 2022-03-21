using System;
using System.Linq;

namespace L03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] rawInput = Console.ReadLine().Split();
            //double[] items = new double[rawInput.Length];

            //for (int i = 0; i < rawInput.Length; i++)
            //{
            //    items[i] = double.Parse(rawInput[i]);
            //}

            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine(value: $"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            //}
            double[] items = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
