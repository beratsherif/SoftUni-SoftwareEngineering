using System.Collections.Generic;
using Raiding2.Factories;
using Raiding2.Factories.Interfaces;
using Raiding2.Models;

namespace Raiding2
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<IBaseHeroFactory> heroes = new List<IBaseHeroFactory>();
                IBaseHeroFactory baseFactory = new BaseHeroFactory();

                int n = int.Parse(Console.ReadLine());

                while (heroes.Count != n)
                {
                    string name = Console.ReadLine();
                    baseFactory.CreateHero(name);
                    heroes.Add(baseFactory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
