using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openCounter = 0;
            int closeCounter = 0;
            bool isBalanced = false;

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                if (text == "(")
                {
                    openCounter++;
                }            
                if (text == ")" && openCounter >= 1)
                {
                    closeCounter++;
                    isBalanced = true;
                }
                if (openCounter == 1 && closeCounter == 1)
                {
                    isBalanced = true;
                    openCounter = 0;
                    closeCounter = 0;
                }
                else if (openCounter > 1 || closeCounter > 1)
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
