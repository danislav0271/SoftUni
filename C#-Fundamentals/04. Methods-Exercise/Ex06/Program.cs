using System;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = GetMiddleCharacters(text);

            Console.WriteLine(result);
        }

        static string GetMiddleCharacters(string text)
        {
            int middle = text.Length / 2;
            string middleChars = string.Empty;

            if (text.Length % 2 == 0)
            {
                middleChars += text[middle - 1];
                middleChars += text[middle];
            }
            else
            {
                middleChars += text[middle];
            }

            return middleChars;
        }
    }
}
