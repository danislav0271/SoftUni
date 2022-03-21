using System;
using System.Collections.Generic;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] courseArgs = command.Split(" : ");

                string courseName = courseArgs[0];
                string studentName = courseArgs[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }

                courseInfo[courseName].Add(studentName);
            }

            foreach (var item in courseInfo)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"-- {items}");
                }
            }
        }
    }
}
