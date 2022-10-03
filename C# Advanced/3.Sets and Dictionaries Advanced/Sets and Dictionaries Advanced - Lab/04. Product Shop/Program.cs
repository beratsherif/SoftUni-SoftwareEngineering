using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Revision")
                {
                    break;
                }

                string shopName = input[0];
                string productName = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName,new Dictionary<string, double>());
                    shops[shopName].Add(productName,price);
                }
                else
                {
                    shops[shopName].Add(productName,price);
                }
            }

            shops = shops.OrderBy(n => n.Key).ToDictionary(x=>x.Key,x=> x.Value);

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var prod in shop.Value)
                {
                    Console.WriteLine($"Product: {prod.Key}, Price: {prod.Value}");
                }
            }
        }
    }
}
