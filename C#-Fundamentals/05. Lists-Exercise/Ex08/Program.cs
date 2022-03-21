using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    Merge(words, startIndex, endIndex);
                }
                else if (cmdArgs[0] == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);

                    Divide(words, index, partitions);
                }
            }

            Console.WriteLine(String.Join(' ', words));
        }

        static bool isIndexValid(List<string> words, int index)
        {
            return index >= 0 && index < words.Count;
        }

        static void Merge(List<string> words, int startIndex, int endIndex)
        {
            if (!isIndexValid(words, startIndex))
            {
                startIndex = 0;
            }
            if (!isIndexValid(words, endIndex))
            {
                endIndex = words.Count - 1;
            }

            StringBuilder merged = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                merged.Append(words[startIndex]);
                words.RemoveAt(startIndex);
            }

            words.Insert(startIndex, merged.ToString());
        }

        static void Divide(List<string> words, int index, int partitions)
        {
            string word = words[index];

            if (partitions > word.Length)
            {
                return;
            }

            int partitionsLength = word.Length / partitions;
            int partitionsReminder = word.Length % partitions;
            int lastPartitionLength = partitionsReminder + partitionsLength;

            List<string> partitionsList = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                char[] currentPartition;
                if (i == partitions - 1)
                {
                    currentPartition = word.Skip(i * partitionsLength).Take(lastPartitionLength).ToArray();
                }
                else
                {
                    currentPartition = word.Skip(i * partitionsLength).Take(partitionsLength).ToArray();
                }

                partitionsList.Add(new string(currentPartition));
            }

            words.RemoveAt(index);
            words.InsertRange(index, partitionsList);
        }
    }
}
