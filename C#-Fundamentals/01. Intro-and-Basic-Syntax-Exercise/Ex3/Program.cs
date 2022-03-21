using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;

            if (type == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price += 8.45;
                        break;
                    case "Saturday":
                        price += 9.80;
                        break;
                    case "Sunday":
                        price += 10.46;
                        break;
                }
                if (count >= 30)
                {
                    Console.WriteLine($"Total price: {price * count * 0.85:F2}");
                }
                else
                {
                    Console.WriteLine($"Total price: {price * count:F2}");
                }
            }
            else if (type == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price += 10.90;
                        break;
                    case "Saturday":
                        price += 15.60;
                        break;
                    case "Sunday":
                        price += 16;
                        break;
                }
                if (count >= 100)
                {
                    count -= 10;
                    Console.WriteLine($"Total price: {price * count:F2}");
                }
                else
                {
                    Console.WriteLine($"Total price: {price * count:F2}");
                }
            }
            else if (type == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price += 15;
                        break;
                    case "Saturday":
                        price += 20;
                        break;
                    case "Sunday":
                        price += 22.50;
                        break;
                }
                if (count >= 10 && count <= 20)
                {
                    Console.WriteLine($"Total price: {price * count * 0.95:F2}");
                }
                else
                {
                    Console.WriteLine($"Total price: {price * count:F2}");
                }
            }
        }
    }
}
