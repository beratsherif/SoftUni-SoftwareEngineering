using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case"coffee":
                    Coffee(quantity, 1.50);
                    break;
                case "water":
                    Water(quantity, 1);
                    break;
                case "coke":
                    Coke(quantity, 1.40);
                    break;
                case "snacks":
                    Snacks(quantity, 2);
                    break;
            }
        }
        static void Coffee(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }
        static void Water(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }
        static void Coke(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }
        static void Snacks(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }

    }
}
