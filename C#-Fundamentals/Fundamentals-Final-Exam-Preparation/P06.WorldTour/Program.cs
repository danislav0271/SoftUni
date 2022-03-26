using System;

namespace P06.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, cmdArgs[2]);
                    }
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length)
                    {
                        int count = endIndex - startIndex + 1;
                        stops = stops.Remove(startIndex, count);
                    }
                }
                else if (cmdType == "Switch")
                {
                    string oldString = cmdArgs[1];
                    string newString = cmdArgs[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
