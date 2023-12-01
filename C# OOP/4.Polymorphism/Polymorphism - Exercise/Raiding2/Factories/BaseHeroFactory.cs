using System;
using Raiding2.Factories.Interfaces;
using Raiding2.Models;
using Raiding2.Models.Interfaces;

namespace Raiding2.Factories
{
    public class BaseHeroFactory : IBaseHeroFactory
    {
        public IBaseHero CreateHero(string name)
        {
            string type = Console.ReadLine();

            IBaseHero hero;

            switch (type)
            {
                case "Druid":
                    hero = new Druid(name);
                    break;
                case "Paladin":
                    hero = new Paladin(name);
                    break;
                case "Rogue":
                    hero = new Rogue(name);
                    break;
                case "Warrior":
                    hero = new Warrior(name);
                    break;
                default:
                    throw new ArgumentException("Invalid hero!");
                    break;
            }

            return hero;
        }
    }
}
