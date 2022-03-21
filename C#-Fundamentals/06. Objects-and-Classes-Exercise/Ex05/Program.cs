using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] teamArgs = Console.ReadLine().Split("-");
                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(c => c.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(creator, teamName);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command.Split("->");
                string member = cmdArgs[0];
                string team = cmdArgs[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.TeamName == team);
                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                if (teams.Any(m => m.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }
                if (teams.Any(c => c.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }

                searchedTeam.AddMember(member);
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();
            List<Team> invalidTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).ToList();

            foreach (var item in validTeams)
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.Creator}");

                foreach (var member in item.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in invalidTeams)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }

    class Team
    {
        public Team(string creator, string teamName)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<string>();
        }
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }
    }
}
