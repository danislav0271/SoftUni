using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counter = VowelsCount(text);
            Console.WriteLine(counter);
        }

        static int VowelsCount(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u' || text[i] == 'A' || text[i] == 'E' || text[i] == 'I' || text[i] == 'O' || text[i] == 'U')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
