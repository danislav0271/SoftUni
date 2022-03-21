using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var item in students)
            {
                double avgGrade = item.Value.Sum() / item.Value.Count();
                if (avgGrade >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {avgGrade:F2}");
                }
            }
        }
    }
}
