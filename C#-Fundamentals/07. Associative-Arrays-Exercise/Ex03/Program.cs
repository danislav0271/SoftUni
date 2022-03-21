using System;
using System.Collections.Generic;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minMaterialQty = 250;

            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                {"shards", "Shadowmourne" },
                {"fragments", "Valanyr" },
                {"motes", "Dragonwrath" }
            };

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"motes", 0},
                {"fragments", 0}
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();
            string itemObtained = string.Empty;

            while (string.IsNullOrEmpty(itemObtained))
            {
                string[] materials = Console.ReadLine().ToLower().Split(" ");

                for (int i = 0; i < materials.Length; i += 2)
                {
                    string currMaterial = materials[i + 1];
                    int currQuantity = int.Parse(materials[i]);

                    if (keyMaterials.ContainsKey(currMaterial))
                    {
                        keyMaterials[currMaterial] += currQuantity;

                        if (keyMaterials[currMaterial] >= minMaterialQty)
                        {
                            itemObtained = craftingTable[currMaterial];
                            keyMaterials[currMaterial] -= minMaterialQty;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currMaterial))
                        {
                            junk[currMaterial] = 0;
                        }

                        junk[currMaterial] += currQuantity;
                    }
                }
            }

            PrintOutput(keyMaterials, junk, itemObtained);
        }

        static void PrintOutput(Dictionary<string, int> keyMaterials, Dictionary<string, int> junk, string itemObtained)
        {
            Console.WriteLine($"{itemObtained} obtained!");

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
