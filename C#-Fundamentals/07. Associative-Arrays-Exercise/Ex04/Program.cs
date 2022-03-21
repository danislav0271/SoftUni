using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            List<Product> productsList = new List<Product>();
            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = command.Split(" ");
                string name = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                int quantity = int.Parse(cmdArgs[2]);

                if (productsList.Any(x => x.Name == name))
                {
                    Product product1 = productsList.FirstOrDefault(x => x.Name == name);

                    product1.Quantity += quantity;
                    product1.Price = price;
                }
                else
                {
                    Product product = new Product(name, price, quantity);
                    productsList.Add(product);
                }
            }

            foreach (var item in productsList)
            {
                string name = item.Name;
                double price = item.Price * item.Quantity;
                products[name] = price;
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }

    class Product
    {
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
