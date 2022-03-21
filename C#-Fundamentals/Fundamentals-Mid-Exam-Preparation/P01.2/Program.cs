using System;

namespace P01._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonCounter = 0;

            string command;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);

                if (distance <= energy)
                {
                    energy -= distance;
                    wonCounter++;
                }
                else if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonCounter} won battles and {energy} energy");
                    break;
                }
                if (wonCounter % 3 == 0)
                {
                    energy += wonCounter;
                }
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonCounter}. Energy left: {energy}");
            }
        }
    }
}
