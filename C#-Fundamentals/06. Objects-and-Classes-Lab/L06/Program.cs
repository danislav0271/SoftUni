using System;
using System.Collections.Generic;
using System.Linq;

namespace L06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = cmdArgs[0];
                string name = cmdArgs[1];
                int quantity = int.Parse(cmdArgs[2]);
                decimal price = decimal.Parse(cmdArgs[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = name,
                        Price = price,
                    },
                    Quantity = quantity,
                };

                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(x => x.PriceBox).ToList();

            foreach (var item in boxes)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.PriceBox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox 
        {
            get 
            { 
                return this.Quantity * this.Item.Price; 
            }
        }
    }
}
