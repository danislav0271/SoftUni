using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string digit1 = Console.ReadLine();
                int mainDigit = int.Parse(digit1);
                mainDigit = mainDigit % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                if (mainDigit == 0)
                {
                    char space = (char)32;
                    text += space;
                    continue;
                }
                int letterIndex = (offset + digit1.Length - 1);
                char c = (char)(letterIndex + 97);
                text += c;
            }
            Console.WriteLine(text);
        }
    }
}
