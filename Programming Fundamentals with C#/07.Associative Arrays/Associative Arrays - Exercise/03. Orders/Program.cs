using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> newOrders = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "buy")
                {
                    break;
                }

                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, productPrice);
                    newOrders.Add(productName, quantity);
                }
                else if (orders.ContainsKey(productName))
                {
                    orders.Remove(productName);
                    orders.Add(productName, productPrice);
                    newOrders[productName] += quantity;
                }
            }

            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }


            //    List<ProductInfo> orders = new List<ProductInfo>();

            //    while (true)
            //    {
            //        string[] input = Console.ReadLine().Split();

            //        string cmd = input[0];

            //        if (cmd == "buy")
            //        {
            //            break;
            //        }

            //        var newProduct = new ProductInfo();
            //        newProduct.ProductName = input[0];
            //        newProduct.ProductPrice = double.Parse(input[1]);
            //        newProduct.Quantity = int.Parse(input[2]);

            //        orders.Add(newProduct);
            //    }

            //    foreach (var order in orders)
            //    {
            //        Console.WriteLine($"{order.ProductName} -> {order.ProductPrice * order.Quantity:f2}");
            //    }

        }
    }
    class ProductInfo
    {
        public ProductInfo()
        {
        }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
