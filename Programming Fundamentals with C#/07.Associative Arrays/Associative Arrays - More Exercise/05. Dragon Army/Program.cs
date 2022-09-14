using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int[]>> data =
                new Dictionary<string, SortedDictionary<string, int[]>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                CategoryAllocation(data);
            }

            PrintingTheResult(data);
        }

        private static void PrintingTheResult(Dictionary<string, SortedDictionary<string, int[]>> data)
        {
            foreach (var type in data)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Select(x => x.Value[0]).Average():f2}/{type.Value.Select(x => x.Value[1]).Average():f2}/{type.Value.Select(x => x.Value[2]).Average():f2})");

                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: { name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }

        private static void CategoryAllocation(Dictionary<string, SortedDictionary<string, int[]>> data)
        {
            string[] input = Console.ReadLine().Split();

            string type = input[0];
            string name = input[1];
            var damage = 0;
            var health = 0;
            var armor = 0;

            damage = input[2] == "null" ? 45 : int.Parse(input[2]);
            health = input[3] == "null" ? 250 : int.Parse(input[3]);
            armor = input[4] == "null" ? 10 : int.Parse(input[4]);

            if (!data.ContainsKey(type))
            {
                
                data.Add(type,new SortedDictionary<string, int[]>());
            }

            if (!data[type].ContainsKey(name))
            {
                data[type][name] = new int[3];
            }

            data[type][name][0] = damage;
            data[type][name][1] = health;
            data[type][name][2] = armor;
        }
    }
}
