using System;
using System.Collections.Generic;

namespace _05.CitiesByContCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> citiesByCountyAndConti =
                new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                string conti = cmd[0];
                string country = cmd[1];
                string city = cmd[2];

                if (!citiesByCountyAndConti.ContainsKey(conti))
                {
                    citiesByCountyAndConti.Add(conti,new Dictionary<string, List<string>>());
                }

                if (!citiesByCountyAndConti[conti].ContainsKey(country))
                {
                    citiesByCountyAndConti[conti].Add(country,new List<string>());
                }

                citiesByCountyAndConti[conti][country].Add(city);
            }

            foreach (var conti in citiesByCountyAndConti)
            {
                Console.WriteLine($"{conti.Key}:");
                foreach (var country in conti.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
