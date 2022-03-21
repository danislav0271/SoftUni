using System;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double totalMoney = 0;

            while (coins != "Start")
            {
                double coin = double.Parse(coins);
                if (coin == 0.1)
                {
                    totalMoney += 0.1;
                }
                else if (coin == 0.2)
                {
                    totalMoney += 0.2;
                }
                else if (coin == 0.5)
                {
                    totalMoney += 0.5;
                }
                else if (coin == 1)
                {
                    totalMoney += 1;
                }
                else if (coin == 2)
                {
                    totalMoney += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                coins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "Nuts" & totalMoney >= 2.0)
                {
                    Console.WriteLine("Purchased nuts");
                    totalMoney -= 2.0;
                }
                else if (product == "Water" & totalMoney >= 0.7)
                {
                    Console.WriteLine("Purchased water");
                    totalMoney -= 0.7;
                }
                else if (product == "Crisps" & totalMoney >= 1.5)
                {
                    Console.WriteLine("Purchased crisps");
                    totalMoney -= 1.5;
                }
                else if (product == "Soda" & totalMoney >= 0.8)
                {
                    Console.WriteLine("Purchased soda");
                    totalMoney -= 0.8;
                }
                else if (product == "Coke" & totalMoney >= 1.0)
                {
                    Console.WriteLine("Purchased coke");
                    totalMoney -= 1.0;
                }
                else if (product == "Coke" || product == "Soda" || product == "Crisps" || product == "Water" || product == "Nuts")
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
