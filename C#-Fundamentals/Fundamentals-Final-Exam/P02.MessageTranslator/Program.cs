using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.MessageTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Regex regex = new Regex(@"(!)([A-Z][a-z]{2,})(\1):(\[)([A-Za-z]{8,})(\])");

                if (regex.IsMatch(text))
                {
                    string command = regex.Match(text).Groups[2].Value;
                    string chars = regex.Match(text).Groups[5].Value;

                    List<int> listChars = new List<int>();

                    foreach (var item in chars)
                    {
                        int ch = (char)item;
                        listChars.Add(ch);
                    }

                    Console.WriteLine($"{command}: {string.Join(" ", listChars)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
