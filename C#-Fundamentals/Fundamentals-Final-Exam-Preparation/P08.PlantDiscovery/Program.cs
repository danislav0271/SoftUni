using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] plantArgs = Console.ReadLine().Split("<->");
                string plantName = plantArgs[0];
                int rarity = int.Parse(plantArgs[1]);

                if (plants.ContainsKey(plantName))
                {
                    plants[plantName].Rarity = rarity;
                }
                else
                {
                    Plant plant = new Plant() { Name = plantName, Rarity = rarity , Rating = new List<double>()};
                    plants.Add(plantName, plant);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = command.Split(new char[] {'-',':' ,' '}, StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string plantName = cmdArgs[1];

                if (!plants.ContainsKey(plantName))
                {
                    Console.WriteLine("error");
                    continue;
                }
                if (cmdType == "Rate")
                {
                    double rating = double.Parse(cmdArgs[2]);
                    
                    plants[plantName].Rating.Add(rating);
                }
                else if (cmdType == "Update")
                {
                    int rarity = int.Parse(cmdArgs[2]);

                    plants[plantName].Rarity = rarity;
                }
                else if (cmdType == "Reset")
                {
                    plants[plantName].Rating.Clear();
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                double averageRating = item.Value.Rating.Sum() / item.Value.Rating.Count;

                if (averageRating > 0)
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {averageRating:f2}");
                }
                else
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: 0.00");
                }
                
            }
        }
    }

    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }
    }
}
