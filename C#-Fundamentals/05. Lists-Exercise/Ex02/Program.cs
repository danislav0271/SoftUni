using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Delete")
                {
                    int numberToRemove = int.Parse(cmdArgs[1]);
                    numbers.RemoveAll(x => x == numberToRemove);
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    numbers.Insert(index, numberToInsert);
                }
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
