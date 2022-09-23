using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int biggestOrder = orders.Max();

            Console.WriteLine(biggestOrder);

            while (orders.Count > 0)
            {
                int theCurrOrder = orders.Peek();
                if (foodQuantity >= theCurrOrder)
                {
                    foodQuantity -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }

            }
                Console.WriteLine($"Orders complete");
        }
    }
}
