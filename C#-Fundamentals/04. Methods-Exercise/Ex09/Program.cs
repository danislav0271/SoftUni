using System;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            while ((number = Console.ReadLine()) != "END")
            {
                string reversedNum = Palindrome(number);
                if (number == reversedNum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static string Palindrome(string number)
        {
            string reversedNum = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNum += number[i];
            }

            return reversedNum;
        }
    }
}
