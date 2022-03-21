using System;
using System.Text;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (var item in text)
            {
                int next = (int)item + 3;
                char nextCh = (char)next;
                sb.Append(nextCh);
            }

            Console.WriteLine(sb);
        }
    }
}
