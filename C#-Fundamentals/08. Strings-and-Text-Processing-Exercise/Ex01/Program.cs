using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            List<string> result = list;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > 16 || list[i].Length < 3)
                {
                    list.Remove(list[i]);
                    i--;
                    continue;
                }
                foreach (var item in list[i])
                {
                    if (item != '-' && item != '_' && !char.IsLetterOrDigit(item))
                    {
                        list.Remove(list[i]);
                        i--;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, result));
        }
    }
}
