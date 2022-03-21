using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sum = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int number;

                if (index < 0)
                {
                    number = numbers[0];
                    sum += number;
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers.Last());
                    Pokemon(numbers, number);
                    continue;
                }
                else if (index >= numbers.Count)
                {
                    number = numbers.Last();
                    sum += number;
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(numbers.First());
                    Pokemon(numbers, number);
                    continue;
                }
                else
                {
                    number = numbers[index];
                    sum += number;
                    numbers.RemoveAt(index);
                    Pokemon(numbers, number);
                    continue;
                }
            }

            Console.WriteLine(sum);
        }

        static void Pokemon(List<int> numbers, int number)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > number)
                {
                    numbers[i] -= number;
                }
                else if (numbers[i] <= number)
                {
                    numbers[i] += number;
                }
            }
        }
    }
}
