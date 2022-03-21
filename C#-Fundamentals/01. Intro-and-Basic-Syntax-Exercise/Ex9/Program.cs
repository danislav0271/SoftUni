using System;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalPrice = lightsaberPrice * (studentsCount + Math.Ceiling(0.10 * studentsCount)) + robePrice * studentsCount;
            if (studentsCount >= 6)
            {
                totalPrice += beltPrice * (studentsCount - (int)(studentsCount / 6));
            }
            else
            {
                totalPrice += beltPrice * studentsCount;
            }
            if (totalPrice <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - amountMoney:F2}lv more.");
            }
        }
    }
}
