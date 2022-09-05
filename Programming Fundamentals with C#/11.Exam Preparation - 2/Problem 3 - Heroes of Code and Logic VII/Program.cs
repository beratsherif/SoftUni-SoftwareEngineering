using System;
using System.Collections.Generic;

namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            int nLines = int.Parse(Console.ReadLine());

            //step1
            for (int i = 0; i < nLines; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmd[0];
                int hp = int.Parse(cmd[1]);
                int mp = int.Parse(cmd[2]);
                heroes.Add(cmd[0], new List<int>{ hp, mp });
            }

            //step2
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] actions = command.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string action = actions[0];
                switch (action)
                {
                    case "CastSpell ":
                        CastSpell(actions[1], int.Parse(actions[2]), actions[3],heroes);
                        break;

                    case "TakeDamage ":
                        TakeDamage(actions[1], int.Parse(actions[2]), actions[3], heroes);
                        break;

                    case "Recharge ":
                        Recharge(actions[1], int.Parse(actions[2]), heroes);
                        break;

                    case "Heal ":
                        Heal(actions[1], int.Parse(actions[2]), heroes);
                        break;
                }
            }
        }

        private static void CastSpell(string heroName, int mpNeeded, string spellName, Dictionary<string, List<int>> heroes)
        {
            if (heroes[heroName][1] >= mpNeeded)
            {
                heroes[heroName][1] -= mpNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                return;
            }

            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }

        private static void TakeDamage(string heroName, int damage, string atackerName, Dictionary<string, List<int>> heroes)
        {
            heroes[heroName][0] -= damage;

            if (heroes[heroName][0] > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {atackerName} and now has {heroes[heroName][0]} HP left!");

                return;
            }

            Console.WriteLine($"{heroName} has been killed by {atackerName}!");
            heroes.Remove(heroName);
        }

        private static void Recharge(string name, int amount, Dictionary<string, List<int>> heroes)
        {
            int originalMana = heroes[name][1];
            heroes[name][1] += amount;

            if (heroes[name][1] > 200)
            {
                heroes[name][1] = 200;
            }

            Console.WriteLine($"{name} recharged for {heroes[name][1] - originalMana} MP!");
        }

        private static void Heal(string name, int amount, Dictionary<string, List<int>> heroes)
        {
            int originalHP = heroes[name][0];
            heroes[name][0] += amount;

            if (heroes[name][0] > 200)
            {
                heroes[name][0] = 200;
            }

            Console.WriteLine($"{name} healed for {heroes[name][0] - originalHP} HP!");
        }
    }
}
