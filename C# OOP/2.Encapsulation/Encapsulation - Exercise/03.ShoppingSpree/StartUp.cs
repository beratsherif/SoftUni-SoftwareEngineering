using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] persons = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Person> peopleList = new Dictionary<string, Person>();
            Dictionary<string, Product> productList = new Dictionary<string, Product>();

            try
            {
                //finding people and their money;
                for (int i = 0; i < persons.Length; i+= 2)
                {
                    string name = persons[i];
                    decimal money = decimal.Parse(persons[i + 1]);

                    Person curPerson = new Person(name, money);
                    peopleList.Add(name, curPerson);
                }
                

                //finding products and their prices;
                for (int i = 0; i < products.Length; i+= 2)
                {
                    string productName = products[i];
                    decimal productPrice = decimal.Parse(products[i + 1]);

                    Product curProduct = new Product(productName,productPrice);
                    productList.Add(productName,curProduct);
                }

                while (true)
                {
                    string cmd = Console.ReadLine();
                    if (cmd == "END")
                    {
                        break;
                    }

                    string[] command = cmd.Split();

                    string personName = command[0];
                    string productName = command[1];

                    Person person = peopleList[personName];
                    Product product = productList[productName];

                    bool isAdd = person.AddProduct(product);

                    if (!isAdd)
                    {
                        Console.WriteLine($"{personName} can't afford {productName}");
                    }
                    else
                    {
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                }

                foreach (var peoples  in peopleList)
                {
                    string info = peoples.Value.BagOfProducts.Count > 0 ? string.Join(", ",peoples.Value.BagOfProducts.Select(x => x.Name)): "Nothing bought";

                    Console.WriteLine($"{peoples.Key} - {info}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
