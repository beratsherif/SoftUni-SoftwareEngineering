using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());

            bool isItTrue = false;
            double price = 0;

            if (sellings >= 0 && sellings <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        price = 0.05;
                        break;
                    case "Varna":
                        price = 0.045;
                        break;
                    case "Plovdiv":
                        price = 0.055;
                        break;
                    default:
                        isItTrue = true;
                        break;
                }
            }
            else if (sellings > 500 && sellings <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        price = 0.07;
                        break;
                    case "Varna":
                        price = 0.075;
                        break;
                    case "Plovdiv":
                        price = 0.08;
                        break;
                    default:
                        isItTrue = true;
                        break;
                }
            }
            else if (sellings > 1000 && sellings <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        price = 0.08;
                        break;
                    case "Varna":
                        price = 0.10;
                        break;
                    case "Plovdiv":
                        price = 0.12;
                        break;
                    default:
                        isItTrue = true;
                        break;
                }
            }
            else if (sellings > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        price = 0.12;
                        break;
                    case "Varna":
                        price = 0.13;
                        break;
                    case "Plovdiv":
                        price = 0.145;
                        break;
                    default:
                        isItTrue = true;
                        break;
                }
            }
            else
            {
                isItTrue = true;
            }
            if (isItTrue)
            {
                Console.WriteLine("error");
            }
            else
            {
                double finalPrice = sellings * price;
                Console.WriteLine($"{finalPrice:f2}");
            }

            
        }
    }
}
