﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _4._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<name>[A-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<count>[\d]+)";
            int inputLines = int.Parse(Console.ReadLine());

            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < inputLines; i++)
            {
                string message = Console.ReadLine();
                int sum = message.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                string decryptedMessage = "";

                foreach (var symbol in message)
                {
                    decryptedMessage += (char)(symbol - sum);
                }

                Match matches = Regex.Match(decryptedMessage, pattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    int population = int.Parse(matches.Groups["population"].Value);
                    char type = char.Parse(matches.Groups["type"].Value);
                    int soldierCount = int.Parse(matches.Groups["count"].Value);

                    if (type != 'A')
                    {
                        destroyed.Add(name);
                    }
                    else
                    {
                        attacked.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
        }
    }
}
