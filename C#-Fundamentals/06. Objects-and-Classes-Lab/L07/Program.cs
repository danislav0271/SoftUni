using System;
using System.Collections.Generic;
using System.Linq;

namespace L07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split("/");
                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int thirdParam = int.Parse(cmdArgs[3]);

                if (type == "Car")
                {
                    Car car = new Car(brand, model, thirdParam);
                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, thirdParam);
                    catalog.Trucks.Add(truck);
                }
            }

            catalog.Cars = catalog.Cars.OrderBy(x => x.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();

            if (catalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (var item in catalog.Cars)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Horsepower}hp");
                }
            }
            if (catalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var item in catalog.Trucks)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }
    
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsepower)
        {
            this.Brand = brand;
            this.Model = model;
            this.Horsepower = horsepower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}
