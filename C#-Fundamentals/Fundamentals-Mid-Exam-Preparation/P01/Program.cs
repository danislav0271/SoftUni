using System;
using System.Diagnostics;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PriceWithoutTaxes = 0.0;
            double taxes = 0.0;

            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "special")
                {
                    break;
                }
                else if (command == "regular")
                {
                    break;
                }
                if (double.Parse(command) < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                PriceWithoutTaxes += double.Parse(command);
            }

            taxes += PriceWithoutTaxes * 0.2;

            if (command == "regular")
            {
                if (PriceWithoutTaxes <= 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {PriceWithoutTaxes:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {PriceWithoutTaxes + taxes:F2}$");
                }
            }
            else if (command == "special")
            {
                if (PriceWithoutTaxes <= 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    double priceWithDiscount = (PriceWithoutTaxes + taxes) * 0.9;
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {PriceWithoutTaxes:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {priceWithDiscount:F2}$");
                }
            }
        }
    }
}
