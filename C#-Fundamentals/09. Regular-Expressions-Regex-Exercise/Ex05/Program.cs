using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> demons = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToList();

            for (int i = 0; i < demons.Count; i++)
            {
                string demon = demons[i];

                double health = Health(demon);
                double damage = Damage(demon);

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }

        static double Damage(string demon)
        {
            string pattern = @"(\d+\.\d+)|(-\d+\.\d+)|(\-?\d+)";
            MatchCollection decimals = Regex.Matches(demon, pattern);
            double damage = 0;

            foreach (Match item in decimals)
            {
                damage += double.Parse(item.Value);
            }

            MatchCollection divide = Regex.Matches(demon, @"\/");
            foreach (Match item in divide)
            {
                damage /= 2;
            }

            MatchCollection multiply = Regex.Matches(demon, @"\*");
            foreach (Match item in multiply)
            {
                damage *= 2;
            }

            return damage;
        }

        static double Health(string demon)
        {
            string healthPattern = @"[^\+\-\*\.\/0-9]";
            MatchCollection chars = Regex.Matches(demon, healthPattern);
            double health = 0;

            foreach (Match item in chars)
            {
                char ch = char.Parse(item.Value);
                health += (int)ch;
            }

            return health;
        }
    }
}
