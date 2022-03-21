using System;
using System.Text;

namespace L07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());
            string result = RepeatString(text, repeatTimes);
            Console.WriteLine(result);
        }
        static string RepeatString(string text, int repeatTimes)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < repeatTimes; i++)
            {
                stringBuilder.Append(text);
            }
            return stringBuilder.ToString();
        }
    }
}
