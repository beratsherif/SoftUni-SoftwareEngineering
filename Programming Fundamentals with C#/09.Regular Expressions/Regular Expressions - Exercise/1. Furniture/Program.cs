using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Z][a-z]+)<<(?<price>\d+.?\d*)!(?<quantity>\d+)";

            double totalPrice = 0;

            List<string> list = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }

                Match matches = Regex.Match(input, pattern,RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    var furnitureName = matches.Groups["furniture"].Value;
                    var furniturePrice = double.Parse(matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    list.Add(furnitureName);
                    totalPrice += furniturePrice * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
