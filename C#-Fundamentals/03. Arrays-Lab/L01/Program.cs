using System;

namespace L01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day >= 1 && day <= daysOfWeek.Length)
            {
                Console.WriteLine(daysOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
