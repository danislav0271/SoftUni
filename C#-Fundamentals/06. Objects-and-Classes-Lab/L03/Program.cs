using System;
using System.Collections.Generic;

namespace L03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] songArgs = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
                string typeList = songArgs[0];
                string name = songArgs[1];
                string time = songArgs[2];

                Song song = new Song(typeList, name, time);
                list.Add(song);
            }

            string type = Console.ReadLine();
            if (type == "all")
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in list)
                {
                    if (type == item.TypeList)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
