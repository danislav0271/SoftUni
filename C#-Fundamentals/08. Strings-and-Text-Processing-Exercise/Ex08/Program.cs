using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;

            foreach (var item in words)
            {
                sum += CalculateSingleWordSum(item);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPos = GetAlphabeticalPositionOfCharacter(firstLetter);
            int lastLetterPos = GetAlphabeticalPositionOfCharacter(lastLetter);

            if (char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPos;
            }
            else if (char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPos;
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= (decimal)lastLetterPos;
            }
            else if (char.IsLower(lastLetter))
            {
                sum += (decimal)lastLetterPos;
            }

            return sum;
        }

        static int GetAlphabeticalPositionOfCharacter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }

            char chCI = char.ToLowerInvariant(ch);

            return (int)chCI - 96;
        }
    }
}
