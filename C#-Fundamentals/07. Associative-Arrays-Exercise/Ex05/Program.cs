using System;
using System.Collections.Generic;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = cmdArgs[0];
                string username = cmdArgs[1];

                if (commandType == "register")
                {
                    string licensePlate = cmdArgs[2];
                    RegisterUser(parkingRegister, username, licensePlate);
                }
                else if (commandType == "unregister")
                {
                    UnregisterUser(parkingRegister, username);
                }
            }

            foreach (var item in parkingRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        static void RegisterUser(Dictionary<string, string> parkingRegister, string username, string licensePlate)
        {
            if (parkingRegister.ContainsKey(username))
            {
                string licenseNumberRegistered = parkingRegister[username];
                Console.WriteLine($"ERROR: already registered with plate number {licenseNumberRegistered}");
            }
            else
            {
                parkingRegister.Add(username, licensePlate);
                Console.WriteLine($"{username} registered {licensePlate} successfully");
            }
        }

        static void UnregisterUser(Dictionary<string, string> parkingRegister, string username)
        {
            if (!parkingRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                parkingRegister.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
        }
    }
}
