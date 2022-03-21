using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = cmdArgs[0];
                string id = cmdArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }

                List<string> ids = companies[company];
                if (!ids.Contains(id))
                {
                    companies[company].Add(id);
                }
            }

            foreach (var item in companies)
            {
                Console.WriteLine(item.Key);
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"-- {items}");
                }
            }
        }
    }
}
