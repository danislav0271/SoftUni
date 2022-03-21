using System;
using System.Drawing;
using System.Linq;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int targetsCount = 0;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if (index < 0 || index >= array.Length)
                {
                    continue;
                }

                if (array[index] != -1)
                {
                    int num = array[index];
                    array[index] = -1;
                    targetsCount++;

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (index == i)
                        {
                            continue;
                        }
                        else if (array[i] > num && array[i] != -1)
                        {
                            array[i] -= num;
                        }
                        else if (array[i] <= num && array[i] != -1)
                        {
                            array[i] += num;
                        }
                    }
}
}

            Console.Write($"Shot targets: {targetsCount} -> ");
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
