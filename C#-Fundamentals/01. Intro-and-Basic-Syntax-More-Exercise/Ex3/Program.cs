using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            string game1 = "OutFall 4", game2 = "CS: OG", game3 = "Zplinter Zell", game4 = "Honored 2", game5 = "RoverWatch", game6 = "RoverWatch Origins Edition";
            double totalSpent = currentBalance;

            while (game != "Game Time")
            {
                if (game == game1 && currentBalance >= 39.99)
                {
                    Console.WriteLine($"Bought {game1}");
                    currentBalance -= 39.99;
                }
                else if (game == game2 && currentBalance >= 15.99)
                {
                    Console.WriteLine($"Bought {game2}");
                    currentBalance -= 15.99;
                }
                else if (game == game3 && currentBalance >= 19.99)
                {
                    Console.WriteLine($"Bought {game3}");
                    currentBalance -= 19.99;
                }
                else if (game == game4 && currentBalance >= 59.99)
                {
                    Console.WriteLine($"Bought {game4}");
                    currentBalance -= 59.99;
                }
                else if (game == game5 && currentBalance >= 29.99)
                {
                    Console.WriteLine($"Bought {game5}");
                    currentBalance -= 29.99;
                }
                else if (game == game6 && currentBalance >= 39.99)
                {
                    Console.WriteLine($"Bought {game6}");
                    currentBalance -= 39.99;
                }
                else if (game == game1 || game == game2 || game == game3 || game == game4 || game == game5 || game == game6)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
            }

            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent - currentBalance:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
