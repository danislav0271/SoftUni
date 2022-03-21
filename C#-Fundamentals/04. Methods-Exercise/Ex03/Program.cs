using System;
using System.Text;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            CharactersInRange(first, second);
        }

        static void CharactersInRange(char first, char second)
        {
            int start = (int)first;
            int end = (int)second;

            if (start < end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    char character = (char)i;
                    Console.Write($"{character} ");
                }
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    char character = (char)i;
                    Console.Write($"{character} ");
                }
            }
        }
    }
}
