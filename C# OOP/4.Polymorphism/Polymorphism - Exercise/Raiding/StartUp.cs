using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                switch (type)
                {
                    case "Druid":
                        BaseHero druid = new Druid(name);
                        heroes.Add(druid);
                        break;
                    case "Paladin":
                        BaseHero paladin = new Paladin(name);
                        heroes.Add(paladin);
                        break;
                    case "Rogue":
                        BaseHero rogue = new Rogue(name);
                        heroes.Add(rogue);
                        break;
                    case "Warrior":
                        BaseHero warrior = new Warrior(name);
                        heroes.Add(warrior);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        i--;
                        break;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalPowerFromHeroes = heroes.Select(h => h.Power).Sum();

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (totalPowerFromHeroes >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
