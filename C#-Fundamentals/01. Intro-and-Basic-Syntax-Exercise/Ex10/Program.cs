using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int countH = 0; int countM = 0; int countK = 0; int countD = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    countH++;
                    if (i%3 == 0)
                    {
                        countM++;
                        countK++;
                        if (countK % 2 == 0)
                        {
                            countD++;
                        }
                    }
                }
                else if (i % 3 == 0)
                {
                    countM++;
                }
            }
            Console.WriteLine($"Rage expenses: {countH * headsetPrice + countM * mousePrice + countK * keyboardPrice + countD * displayPrice:F2} lv.");
        }
    }
}
