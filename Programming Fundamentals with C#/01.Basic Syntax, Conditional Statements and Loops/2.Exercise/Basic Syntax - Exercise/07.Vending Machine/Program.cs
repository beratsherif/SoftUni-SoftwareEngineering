using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Nuts = 2.0;
            const double Water = 0.7;
            const double Crisps = 1.5;
            const double Soda = 0.8;
            const double Coke = 1.0;

            double price = 0;

            string input = Console.ReadLine();
            double coins = 0;


            while (input != "Start")
            {
                double currMoney = double.Parse(input);
                if (currMoney == 0.1 || currMoney == 0.2 || currMoney == 0.5 || currMoney == 1 || currMoney == 2)
                {
                    coins += currMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currMoney}");
                }
                input = Console.ReadLine();
            }

            string productName = Console.ReadLine();

            while (productName != "End")
            {
                string currProduct = string.Empty;

                if (productName == "Nuts" || productName == "Water" || productName == "Crisps" || productName == "Soda" || productName == "Coke")
                {
                    switch (productName)
                    {
                        case "Nuts":
                            currProduct = "nuts";
                            price = Nuts;
                            break;
                        case "Water":
                            currProduct = "water";
                            price = Water;
                            break;
                        case "Crisps":
                            currProduct = "crisps";
                            price = Crisps;
                            break;
                        case "Soda":
                            currProduct = "soda";
                            price = Soda;
                            break;
                        case "Coke":
                            currProduct = "coke";
                            price = Coke;
                            break;
                    }
                    if (price <= coins)
                    {
                        coins -= price;
                        Console.WriteLine($"Purchased {currProduct}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                productName = Console.ReadLine();

            }

            Console.WriteLine($"Change: {coins:f2}");
        }
    }
}
