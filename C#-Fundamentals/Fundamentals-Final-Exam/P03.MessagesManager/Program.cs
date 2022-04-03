using System;
using System.Collections.Generic;

namespace P03.MessagesManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Username> users = new Dictionary<string, Username>();

            int capacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] cmdArgs = command.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string username = cmdArgs[1];

                if (cmdType == "Add")
                {
                    int sent = int.Parse(cmdArgs[2]);
                    int received = int.Parse(cmdArgs[3]);

                    if (users.ContainsKey(username))
                    {
                        continue;
                    }

                    users.Add(username, new Username(username, sent, received));
                }
                else if (cmdType == "Message")
                {
                    string receiver = cmdArgs[2];

                    if (!users.ContainsKey(username) || !users.ContainsKey(receiver))
                    {
                        continue;
                    }

                    users[username].SentMessages++;
                    users[receiver].ReveivedMessages++;

                    if (users[username].SentMessages + users[username].ReveivedMessages >= capacity)
                    {
                        Console.WriteLine($"{username} reached the capacity!");
                        users.Remove(username);
                    }
                    if (users[receiver].ReveivedMessages + users[receiver].SentMessages >= capacity)
                    {
                        Console.WriteLine($"{receiver} reached the capacity!");
                        users.Remove(receiver);
                    }
                }
                else if (cmdType == "Empty")
                {
                    if (username == "All")
                    {
                        users.Clear();
                    }
                    else
                    {
                        if (!users.ContainsKey(username))
                        {
                            continue;
                        }

                        users.Remove(username);
                    }
                }
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var item in users)
            {
                int messages = item.Value.ReveivedMessages + item.Value.SentMessages;
                Console.WriteLine($"{item.Key} - {messages}");
            }
        }
    }
    class Username
    {
        public Username(string name, int sent, int received)
        {
            this.Name = name;
            this.SentMessages = sent;
            this.ReveivedMessages = received;
        }
        public string Name { get; set; }
        public int SentMessages { get; set; }
        public int ReveivedMessages { get; set; }
    }
}
