using System;

namespace L11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            double result = Calculate(first, @operator, second);
            Console.WriteLine(result);
        }

        static double Calculate(int first, string @operator, int second)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = first / second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
