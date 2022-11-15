using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("Animal");
            Reptile reptile = new Reptile("Reptile");
            Mammal mammal = new Mammal("Mammal");
            Lizard lizard = new Lizard("Lizard");
            Snake snake = new Snake("Snake");
            Gorilla gorilla = new Gorilla("Gorilla");
            Bear bear = new Bear("Bear");

            Console.WriteLine(animal.Name);
            Console.WriteLine(reptile.Name);
            Console.WriteLine(mammal.Name);
            Console.WriteLine(lizard.Name);
            Console.WriteLine(snake.Name);
            Console.WriteLine(gorilla.Name);
            Console.WriteLine(bear.Name);
        }
    }
}