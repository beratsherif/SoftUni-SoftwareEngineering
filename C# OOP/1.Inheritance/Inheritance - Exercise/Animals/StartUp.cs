using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Beast!")
                {
                    break;
                }

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];

                if (age < 0 || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (command == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog.ToString());
                    Console.WriteLine(dog.ProduceSound());
                }
                else if (command == "Frog")
                {
                    Frog frog = new Frog(name,age,gender);
                    Console.WriteLine(frog.ToString());
                    Console.WriteLine(frog.ProduceSound());
                }
                else if (command == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine(cat.ToString());
                    Console.WriteLine(cat.ProduceSound());
                }
                else if (command == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    Console.WriteLine(kitten.ToString());
                    Console.WriteLine(kitten.ProduceSound());
                }
                else if (command == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    Console.WriteLine(tomcat.ToString());
                    Console.WriteLine(tomcat.ProduceSound());
                }
                else
                {
                    throw new Exception("Invalid input!");
                }
            }
        }
    }
}
