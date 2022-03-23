using System;
using System.Collections.Generic;

namespace P03___P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            string firstCommand;
            while ((firstCommand = Console.ReadLine()) != "Sail")
            {
                string[] cmdArgs = firstCommand.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                if (cities.ContainsKey(name))
                {
                    cities[name].Gold += gold;
                    cities[name].Population += population;
                }
                else
                {
                    City newCity = new City(name, population, gold);
                    cities.Add(name, newCity);
                }
            }

            string secondCommand;
            while ((secondCommand = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = secondCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Plunder")
                {
                    string townToPlunder = cmdArgs[1];
                    int populationToRemove = int.Parse(cmdArgs[2]);
                    int goldToSteal = int.Parse(cmdArgs[3]);

                    cities[townToPlunder].Population -= populationToRemove;
                    cities[townToPlunder].Gold -= goldToSteal;

                    Console.WriteLine($"{townToPlunder} plundered! {goldToSteal} gold stolen, {populationToRemove} citizens killed.");

                    if (cities[townToPlunder].Population <= 0 || cities[townToPlunder].Gold <= 0)
                    {
                        Console.WriteLine($"{townToPlunder} has been wiped off the map!");
                        cities.Remove(townToPlunder);
                    }
                }
                else if (cmdType == "Prosper")
                {
                    string townToProsper = cmdArgs[1];
                    int goldToAdd = int.Parse(cmdArgs[2]);

                    if (goldToAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        cities[townToProsper].Gold += goldToAdd;
                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. {townToProsper} now has {cities[townToProsper].Gold} gold.");
                    }
                }
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
        }
    }

    class City
    {
        public City(string name, int population, int gold)
        {
            this.Name = name;
            this.Population = population;
            this.Gold = gold;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
