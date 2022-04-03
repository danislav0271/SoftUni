using System;

namespace P01.DectyptingCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "Replace")
                {
                    string oldChar = cmdArgs[1];
                    string newChar = cmdArgs[2];
                    text = text.Replace(oldChar, newChar);
                }
                else if (cmdType == "Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (IsIndexValid(startIndex, text) && IsIndexValid(endIndex, text))
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }
                }
                else if (cmdType == "Make")
                {
                    string cmd = cmdArgs[1];

                    if (cmd == "Upper")
                    {
                        text = text.ToUpper();
                    }
                    else if (cmd == "Lower")
                    {
                        text = text.ToLower();
                    }
                }
                else if (cmdType == "Check")
                {
                    string checkString = cmdArgs[1];

                    if (text.Contains(checkString))
                    {
                        Console.WriteLine($"Message contains {checkString}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {checkString}");
                        continue;
                    }
                }
                else if (cmdType == "Sum")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (IsIndexValid(startIndex, text) && IsIndexValid(endIndex, text))
                    {
                        string sumString = text.Substring(startIndex, endIndex - startIndex + 1);

                        int sum = 0;

                        foreach (var item in sumString)
                        {
                            sum += (char)item;
                        }

                        Console.WriteLine(sum);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }
                }

                Console.WriteLine(text);
            }
        }

        static bool IsIndexValid(int index, string text)
        {
            if (index < text.Length && index >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
