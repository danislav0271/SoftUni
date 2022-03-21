using System;
using System.Linq;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] dna = new int[length];
            double counter = 1;
            double index = 2;
            int[] bestDna = new int[length];
            double bestDnaCounter = 0;
            double bestIndex = 0;

            double sample = 0;
            double loopCount = 0;

            double bestSequenceSum = 0;

            string command;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                dna = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                loopCount++;

                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == dna[i+1] && dna[i] == 1)
                    {
                        counter++;
                        index = i;
                    }
                    else
                    {
                        counter = 1;

                    }

                    if (counter > bestDnaCounter)
                    {
                        bestDnaCounter = counter;
                        sample = loopCount;
                        bestIndex = index;

                        bestDna = dna;
                    }

                    else if (counter == bestDnaCounter)
                    {
                        if (index == bestIndex)
                        {
                            if (dna.Sum() > bestDna.Sum())
                            {
                                bestDnaCounter = counter;
                                sample = loopCount;
                                bestIndex = index;

                                bestDna = dna;
                            }
                        }
                        
                        else if (index < bestIndex)
                        {
                            bestDnaCounter = counter;
                            sample = loopCount;
                            bestIndex = index;

                            bestDna = dna;
                        }
                    }
                }
            }

            bestSequenceSum = bestDna.Sum();
            Console.WriteLine($"Best DNA sample {sample} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(' ', bestDna));
        }
    }
}
