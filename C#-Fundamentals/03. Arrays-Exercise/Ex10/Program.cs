using System;
using System.Linq;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndex = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                if (initialIndex.Contains(i))
                {
                    field[i] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int startIndex = int.Parse(cmdArgs[0]);
                string position = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (startIndex < 0 || startIndex >= field.Length)
                {
                    continue;
                }
                if (field[startIndex] == 0)
                {
                    continue;
                }

                field[startIndex] = 0;
                int nextIndex = startIndex;

                while (true)
                {
                    if (position == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (position == "left")
                    {
                        nextIndex -= flyLength;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        field[nextIndex] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
