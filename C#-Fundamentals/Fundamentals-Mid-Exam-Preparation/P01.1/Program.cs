using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            int hoursCounter = 0;

            while (students > 0)
            {
                hoursCounter++;
                students -= sum;
                if (hoursCounter % 4 == 0)
                {
                    hoursCounter++;
                }
            }
            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
