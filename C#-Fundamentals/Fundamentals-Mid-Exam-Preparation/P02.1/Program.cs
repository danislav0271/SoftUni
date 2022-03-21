using System;
using System.Linq;

namespace P02._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "swap")
                {
                    int firstIndexNum = array[int.Parse(cmdArgs[1])];
                    int secondIndexNum = array[int.Parse(cmdArgs[2])];

                    array[int.Parse(cmdArgs[1])] = secondIndexNum;
                    array[int.Parse(cmdArgs[2])] = firstIndexNum;
                }
                else if (cmdArgs[0] == "multiply")
                {
                    int firstIndexNum = array[int.Parse(cmdArgs[1])];
                    int secondIndexNum = array[int.Parse(cmdArgs[2])];

                    array[int.Parse(cmdArgs[1])] = firstIndexNum * secondIndexNum;
                }
                else if (cmdArgs[0] == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i]--;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }
    }
}
