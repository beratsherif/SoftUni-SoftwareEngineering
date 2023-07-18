namespace _04._Wild_Farm
{
    using System;
    using System.Collections.Generic;
    using Models.Animals;
    using Models.Foods;
    using Models.Interfaces;
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                IAnimal currAnimal = AnimalCreator(animalInfo);
                animals.Add(currAnimal);

                string[] foodInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IFood currFood = CreateFood(foodInfo);

                Console.WriteLine(currAnimal.PoduceSound());

                try
                {
                    currAnimal.Eat(currFood);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
        private static IFood CreateFood(string[] information)
        {
            IFood food = null;
            string type = information[0];
            int quantity = int.Parse(information[1]);

            switch (type)
            {
                case nameof(Vegetable):
                    food = new Vegetable(quantity);
                    break;
                case nameof(Fruit):
                    food = new Fruit(quantity);
                    break;
                case nameof(Meat):
                    food = new Meat(quantity);
                    break;
                case nameof(Seeds):
                    food = new Seeds(quantity);
                    break;
            }
            return food;
        }
        private static IAnimal AnimalCreator(string[] information)
        {
            IAnimal currAnimal = null;

            string type = information[0];
            switch (type)
            {
                case nameof(Owl):
                    currAnimal = new Owl(information[1], double.Parse(information[2]), double.Parse(information[3]));
                    break;
                case nameof(Hen):
                    currAnimal = new Hen(information[1], double.Parse(information[2]), double.Parse(information[3]));
                    break;
                case nameof(Mouse):
                    currAnimal = new Mouse(information[1], double.Parse(information[2]), (information[3]));
                    break;
                case nameof(Dog):
                    currAnimal = new Dog(information[1], double.Parse(information[2]), (information[3]));
                    break;
                case nameof(Cat):
                    currAnimal = new Cat(information[1], double.Parse(information[2]), (information[3]), information[4]);
                    break;
                case nameof(Tiger):
                    currAnimal = new Tiger(information[1], double.Parse(information[2]), (information[3]), information[4]);
                    break;
            }
            return currAnimal;
        }
    }
}
