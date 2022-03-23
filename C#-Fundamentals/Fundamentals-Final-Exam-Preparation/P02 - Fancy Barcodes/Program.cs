using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02___Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    //char[] digits = input.Where(x => char.IsDigit(x)).ToArray();

                    //if (digits.Length == 0)
                    //{
                    //    Console.WriteLine("Product group: 00");
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"Product group: {string.Join("", digits)}");
                    //}

                    string productGroup = ProductGroup(input);
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }

        static string ProductGroup(string input)
        {
            MatchCollection matches = Regex.Matches(input, "[0-9]");
            StringBuilder result = new StringBuilder();

            if (Regex.IsMatch(input, "[0-9]"))
            {
                foreach (Match item in matches)
                {
                    result.Append(item.Value);
                }
            }
            else
            {
                result.Append("00");
            }

            return result.ToString();
        }
    }
}
