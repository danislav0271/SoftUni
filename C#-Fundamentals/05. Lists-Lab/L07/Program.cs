using System;
using System.Collections.Generic;
using System.Linq;

namespace L07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool hasChanges = false;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        hasChanges = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        hasChanges = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        hasChanges = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        hasChanges = true;
                        break;
                    case "Contains":
                        bool contains = numbers.Contains(int.Parse(tokens[1]));
                        if (contains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                        Console.WriteLine(String.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                        Console.WriteLine(String.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);
                        List<int> result = FilteretNumbers(numbers, condition, number);
                        Console.WriteLine(String.Join(" ", result));
                        break;
                }
            }

            if (hasChanges)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static List<int> FilteretNumbers(List<int> numbers, string condition, int number)
        {
            if (condition == ">")
            {
                List<int> result = numbers.FindAll(x => x > number);
                return result;
            }
            else if (condition == "<")
            {
                List<int> result = numbers.FindAll(x => x < number);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = numbers.FindAll(x => x <= number);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = numbers.FindAll(x => x >= number);
                return result;
            }
            else
            {
                return numbers;
            }
        }
    }
}
