using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfOrders = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= coutOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCout = int.Parse(Console.ReadLine());

                double coffeePrice = ((days * capsuleCout) * pricePerCapsule);
                total += coffeePrice;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
