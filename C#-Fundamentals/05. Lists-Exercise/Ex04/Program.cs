using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split();
                string operation = cmdArgs[0];

                if (operation == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (operation == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, numberToInsert);
                }
                else if (operation == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (operation == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static void ShiftLeft(List<int> numbers, int count)
        {
            int realCount = count % numbers.Count;

            for (int i = 0; i < realCount; i++)
            {
                numbers.Add(numbers.First());
                numbers.RemoveAt(0);
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            int realCount = count % numbers.Count;

            for (int i = 0; i < realCount; i++)
            {
                int lastNumber = numbers.Last();
                numbers.Insert(0, lastNumber);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}
