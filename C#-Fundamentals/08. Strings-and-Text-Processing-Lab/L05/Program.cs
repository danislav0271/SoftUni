using System;

namespace L05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                }
                else if (char.IsLetter(item))
                {
                    letters += item;
                }
                else
                {
                    other += item;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, digits, letters, other));
        }
    }
}
