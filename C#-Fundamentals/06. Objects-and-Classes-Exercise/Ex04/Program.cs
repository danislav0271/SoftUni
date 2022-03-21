using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string studentFirstName = studentArgs[0];
                string studentLastName = studentArgs[1];
                double studentGrade = double.Parse(studentArgs[2]);

                Student student = new Student(studentFirstName, studentLastName, studentGrade);
                students.Add(student);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
