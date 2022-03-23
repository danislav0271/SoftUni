using System;
using System.Linq;

namespace P01___Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string commandType = cmdArgs[0];

                if (commandType == "InsertSpace")
                {
                    int insertIndex = int.Parse(cmdArgs[1]);
                    message = message.Insert(insertIndex, " ");
                }
                else if (commandType == "Reverse")
                {
                    string substring = cmdArgs[1];

                    if (message.Contains(substring))
                    {
                        int wordIndex = message.IndexOf(substring);
                        message = message.Remove(wordIndex, substring.Length);
                        message += string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (commandType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacementText = cmdArgs[2];

                    message = message.Replace(substring, replacementText);
                }

                Console.WriteLine(message);
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
