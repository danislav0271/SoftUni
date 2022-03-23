using System;
using System.Linq;

namespace P05.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "TakeOdd")
                {
                    char[] oddChars = password.Where((symbol, index) => index % 2 != 0).ToArray();

                    password = string.Join("", oddChars);
                }
                else if (cmdType == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    password = password.Remove(index, length);
                }
                else if (cmdType == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                }

                Console.WriteLine(password);
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
