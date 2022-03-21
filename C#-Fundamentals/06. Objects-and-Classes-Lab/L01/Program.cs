using System;

namespace L01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int index = rnd.Next(0, array.Length);
                string item = array[i];
                array[i] = array[index];
                array[index] = item;
            }

            Console.WriteLine(string.Join(Environment.NewLine , array));
        }
    }
}
