using System;
using System.Text;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char ch = input[0];
            sb.Append(ch);
            for (int i = 0; i < input.Length; i++)
            {
                if (ch != input[i])
                {
                    ch = input[i];
                    sb.Append(ch);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
