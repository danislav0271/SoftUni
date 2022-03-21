using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int a = ch + key;

                word += (char)a;
            }

            Console.WriteLine(word);
        }
    }
}
