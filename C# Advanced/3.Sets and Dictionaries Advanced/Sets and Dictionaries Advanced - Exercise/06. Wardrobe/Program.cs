using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();

            int inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color,new Dictionary<string, int>());
                }

                for (int j = 1; j <= input.Length - 1; j++)
                {
                    if (!wardrobe[color].ContainsKey(input[j]))
                    {
                        wardrobe[color].Add(input[j],0);
                    }

                    wardrobe[color][input[j]]++;
                }
            }

            string[] cmd = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string colorInput = cmd[0];
            string currCloth = cmd[1];

            foreach (var clotheColor in wardrobe)
            {
                Console.WriteLine($"{clotheColor.Key} clothes:");
                foreach (var cloth in clotheColor.Value)
                {
                    string printItem = $"* {cloth.Key} - {cloth.Value}";
                    if (clotheColor.Key == colorInput && cloth.Key == currCloth)
                    {
                        printItem = $"* {cloth.Key} - {cloth.Value} (found!)";
                    }

                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
