using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = string.Empty;
                if (cmdArgs[0] == "car" || cmdArgs[0] == "Car")
                {
                    type = "Car";
                }
                else if (cmdArgs[0] == "truck" || cmdArgs[0] == "Truck")
                {
                    type = "Truck";
                }
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                int hp = int.Parse(cmdArgs[3]);

                Vehicle vehicle = new Vehicle(type, model, color, hp);
                vehicles.Add(vehicle);
            }

            string info;
            while ((info = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == info);

                vehicle.Print();
            }

            List<Vehicle> cars = vehicles.Where(t => t.Type == "Car").ToList();
            List<Vehicle> trucks = vehicles.Where(t => t.Type == "Truck").ToList();
            double carsHP = 0;
            double trucksHP = 0;

            foreach (Vehicle car in cars)
            {
                carsHP += car.HorsePower;
            }
            foreach (Vehicle truck in trucks)
            {
                trucksHP += truck.HorsePower;
            }

            if (cars.Count > 0)
            {
                carsHP /= cars.Count;
            }
            if (trucks.Count > 0)
            {
                trucksHP /= trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {carsHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksHP:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public void Print()
        {
            Console.WriteLine($"Type: {this.Type}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Horsepower: {this.HorsePower}");
        }
    }
}
