using System;
using System.Collections.Generic;
using System.Linq;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                if (command[0] == "Add")
                {
                    if (!cards.Contains(command[1]))
                    {
                        cards.Add(command[1]);
                        Console.WriteLine("Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (cards.Contains(command[1]))
                    {
                        cards.Remove(command[1]);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < cards.Count)
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string card = command[2];

                    if (index >= 0 && index < cards.Count)
                    {
                        if (!cards.Contains(card))
                        {
                            cards.Insert(index, card);
                            Console.WriteLine("Card successfully added");
                        }
                        else
                        {
                            Console.WriteLine("Card is already added");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(String.Join(", ", cards));
        }
    }
}
