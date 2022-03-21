using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            long num = 0;


            for (int i = 0; i < n.Length; i++)
            {
                char carrCh = n[i];
                int currD = (int)carrCh - 48;

                long currDigitFactorial = 1;
                for (int r = currD; r >= 1; r--)
                {
                    currDigitFactorial *= r;
                }
                num += currDigitFactorial;
            }
            if (num == int.Parse(n))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
