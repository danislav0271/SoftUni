using System;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(">>", StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string[] arrArgs = array[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int years = int.Parse(arrArgs[1]);
                int totalMileage = int.Parse(arrArgs[2]);

                if (arrArgs[0] == "family")
                {
                    double tax = 0;
                    if (totalMileage >= 3000)
                    {
                        tax += totalMileage / 3000 * 12 + (50 - years * 5);
                    }
                    else
                    {
                        tax += 50 - years * 5;
                    }
                    totalSum += tax;
                    Console.WriteLine($"A {arrArgs[0]} car will pay {tax:f2} euros in taxes.");
                }
                else if (arrArgs[0] == "heavyDuty")
                {
                    double tax = 0;
                    if (totalMileage >= 9000)
                    {
                        tax += totalMileage / 9000 * 14 + (80 - years * 8);
                    }
                    else
                    {
                        tax += 80 - years * 8;
                    }
                    totalSum += tax;
                    Console.WriteLine($"A {arrArgs[0]} car will pay {tax:f2} euros in taxes.");
                }
                else if (arrArgs[0] == "sports")
                {
                    double tax = 0;
                    if (totalMileage >= 2000)
                    {
                        tax += totalMileage / 2000 * 18 + (100 - years * 9);
                    }
                    else
                    {
                        tax += (100 - years * 9);
                    }
                    totalSum += tax;
                    Console.WriteLine($"A {arrArgs[0]} car will pay {tax:f2} euros in taxes.");
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalSum:f2} euros in taxes.");
        }
    }
}
