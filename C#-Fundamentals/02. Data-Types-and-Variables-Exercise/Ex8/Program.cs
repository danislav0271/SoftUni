using System;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestModel = string.Empty;
            double maxVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());

                double volume = Math.PI * (Math.Pow(radius, 2)) * height;
                if (volume > maxVolume)
                {
                    biggestModel = model;
                    maxVolume = volume;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
