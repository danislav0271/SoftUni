using System;
using System.Linq;

namespace Ex02._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = VowelsCount(text);

            Console.WriteLine(count);
        }

        static int VowelsCount(string text)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;

            foreach (char ch in text.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
