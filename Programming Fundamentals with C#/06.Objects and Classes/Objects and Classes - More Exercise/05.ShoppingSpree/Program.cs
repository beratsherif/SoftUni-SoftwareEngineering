using System;
using System.Collections.Generic;
using System.Runtime;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in peopleInput)
            {
                string name = person.Split('=')[0];
                decimal money = decimal.Parse(person.Split('=')[1]);
                people.Add(new Person(name, money));
            }// PEOPLE

            string[] productsInput = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in productsInput)
            {
                string productName = product.Split('=')[0];
                decimal productPrice = decimal.Parse(product.Split('=')[1]);
                products.Add(new Product(productName, productPrice));
            }// PRODUCTS

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commands = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string personName = commands[0];
                string productName = commands[1];

                people.Find(p => p.PersonName == personName).BuyProduct(products.Find(p => p.ProductName == productName));

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.Bag.Count > 0)
                {
                    Console.WriteLine($"{person.PersonName} - {string.Join(", ",person.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{person.PersonName} - Nothing bought");
                }
            }
        }
    }

    class Person
    {
        public Person(string name, decimal money)
        {
            this.PersonName = name;
            this.Money = money;
        }
        public string PersonName { get; set; }
        public decimal Money { get; set; }
        public List<string> Bag { get; set; } = new List<string>();

        public void BuyProduct(Product productToBuy)
        {
            if (this.Money >= productToBuy.ProductPrice)
            {
                this.Bag.Add(productToBuy.ProductName);
                this.Money -= productToBuy.ProductPrice;
                Console.WriteLine($"{this.PersonName} bought {productToBuy.ProductName}");
            }
            else
            {
                Console.WriteLine($"{this.PersonName} can't afford {productToBuy.ProductName}");
            }
        }
    }

    class Product
    {
        public Product(string productName,decimal productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
