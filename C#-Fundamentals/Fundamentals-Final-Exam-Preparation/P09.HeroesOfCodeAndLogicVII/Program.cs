using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] heroArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroArgs[0];
                int heroHp = int.Parse(heroArgs[1]);
                int heroMp = int.Parse(heroArgs[2]);

                if (heroHp > 100)
                {
                    heroHp = 100;
                }
                if (heroMp > 200)
                {
                    heroMp = 200;
                }

                heroes.Add(heroName, new Hero(heroName, heroHp, heroMp));
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string heroName = cmdArgs[1];

                if (cmdType == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (heroes[heroName].MP < mpNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroes[heroName].MP -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                    }
                }
                else if (cmdType == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    heroes[heroName].HP -= damage;
                    if (heroes[heroName].HP > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                    else if (heroes[heroName].HP <= 0)
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (cmdType == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    heroes[heroName].MP += amount;

                    if (heroes[heroName].MP > 200)
                    {
                        int x = heroes[heroName].MP - 200;
                        amount -= x;
                        heroes[heroName].MP = 200;
                    }

                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (cmdType == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    heroes[heroName].HP += amount;

                    if (heroes[heroName].HP > 100)
                    {
                        int x = heroes[heroName].HP - 100;
                        amount -= x;
                        heroes[heroName].HP = 100;
                    }

                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }

            foreach (var item in heroes.OrderByDescending(x => x.Value.HP).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value.HP}");
                Console.WriteLine($"  MP: {item.Value.MP}");
            }
        }
    }

    class Hero
    {
        public Hero(string heroName, int heroHp, int heroMp)
        {
            this.Name = heroName;
            this.MP = heroMp;
            this.HP = heroHp;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
