using System;
using System.Text;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            int bombPower = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                char currCh = inputStr[i];

                if (currCh == '>')
                {
                    int currBombPower = GetCharacterIntValue(inputStr[i + 1]);
                    output.Append(currCh);
                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        output.Append(currCh);
                    }
                }
            }

            Console.WriteLine(output);
        }

        static int GetCharacterIntValue(char ch)
        {
            return (int)ch - 48;
        }
    }
}
