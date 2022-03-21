using System;
using System.Text;

namespace L02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result.Append(item);
                }
            }

            Console.WriteLine(result);
        }
    }
}
