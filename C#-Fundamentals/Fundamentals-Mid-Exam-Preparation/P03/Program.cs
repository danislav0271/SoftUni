using System;
using System.Collections.Generic;
using System.Linq;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int movesCounter = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCounter} turns!");
                    break;
                }
                
                movesCounter++;

                int[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (cmdArgs[0] == cmdArgs[1] || cmdArgs[0] < 0 || cmdArgs[0] >= list.Count || cmdArgs[1] < 0 || cmdArgs[1] >= list.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int midIndex = list.Count / 2;
                    list.Insert(midIndex, "-" + movesCounter + "a");
                    list.Insert(midIndex, "-" + movesCounter + "a");
                }
                else if (list[cmdArgs[0]] == list[cmdArgs[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[cmdArgs[0]]}!");
                    if (cmdArgs[0] > cmdArgs[1])
                    {
                        list.RemoveAt(cmdArgs[0]);
                        list.RemoveAt(cmdArgs[1]);
                    }
                    else if (cmdArgs[1] > cmdArgs[0])
                    {
                        list.RemoveAt(cmdArgs[1]);
                        list.RemoveAt(cmdArgs[0]);
                    }
                }
                else if (list[cmdArgs[0]] != list[cmdArgs[1]])
                {
                    Console.WriteLine("Try again!");
                }
            }

            if (command == "end" && list.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", list));
            }
            else if (command == "end")
            {
                Console.WriteLine($"You have won in {movesCounter} turns!");
            }
        }
    }
}
