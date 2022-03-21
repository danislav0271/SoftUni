using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    guestList.Add(name);
                }

                else if (cmdArgs.Length == 4)
                {
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                    guestList.Remove(name);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, guestList));
        }
    }
}
