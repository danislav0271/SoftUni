using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs  = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                string id = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);

                if (list.Any(i => i.Id == id))
                {
                    list.RemoveAll(i => i.Id == id);
                }

                Person person = new Person(name, id, age);
                list.Add(person);
            }

            list = list.OrderBy(i => i.Age).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
