using System;

namespace _04._Pizza_Calories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string pizzaName = pizzaInfo[1];

                string[] doughInfo = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string flourtype = doughInfo[1];
                string bakingTechnique = doughInfo[2];
                int weight = int.Parse(doughInfo[3]);
                Dough dough = new Dough(flourtype, bakingTechnique, weight);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string typeOfTopping = tokens[1];
                    int weightOfToppping = int.Parse(tokens[2]);

                    Topping topping = new Topping(typeOfTopping, weightOfToppping);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae);
            }
        }
    }
}
