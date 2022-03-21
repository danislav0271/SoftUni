using System;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitPerWorker = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactory = int.Parse(Console.ReadLine());

            int bisquitsPerDay = biscuitPerWorker * workers;
            double total = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    double biscuit = bisquitsPerDay * 0.75;

                    total += Math.Floor(biscuit);

                }
                else
                {
                    total += bisquitsPerDay;
                }
            }

            if (total > competingFactory)
            {
                double difference = total - competingFactory;
                double percentage = difference / competingFactory * 100;
                Console.WriteLine($"You have produced {total} biscuits for the past month.");
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                double difference = competingFactory - total;
                double percentage = difference / competingFactory * 100;
                Console.WriteLine($"You have produced {total} biscuits for the past month.");
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }

        }
    }
}
