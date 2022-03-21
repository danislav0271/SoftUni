﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdArgs[1]));
                }
                else
                {
                    int numberOfPassengers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + numberOfPassengers) <= maxCapacity)
                        {
                            wagons[i] += numberOfPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(' ', wagons));
        }
    }
}
