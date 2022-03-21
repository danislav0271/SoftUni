using System;
using System.Text.RegularExpressions;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s([A-Za-z1-9]+[A-Za-z\.\-\,\\_]+)@([A-Za-z\-]+[\.][A-Za-z\-(\.)?]+[A-Za-z\-]+)";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value.TrimStart());
            }
        }
    }
}
