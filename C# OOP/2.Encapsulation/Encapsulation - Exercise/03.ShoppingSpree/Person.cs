using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
   public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public IReadOnlyCollection<Product> BagOfProducts => this.bagOfProducts.AsReadOnly();

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public bool AddProduct(Product product)
        {
            if (Money - product.Cost < 0)
            {
                return false;
            }

            bagOfProducts.Add(product);
            Money -= product.Cost;

            return true;
        }
    }
}
