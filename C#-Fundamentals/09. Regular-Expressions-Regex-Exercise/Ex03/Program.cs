using System;
using System.Text.RegularExpressions;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalIncome = 0m;
            string pattern = @"\%(?<client>[A-Z][a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string client = match.Groups["client"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{client}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
