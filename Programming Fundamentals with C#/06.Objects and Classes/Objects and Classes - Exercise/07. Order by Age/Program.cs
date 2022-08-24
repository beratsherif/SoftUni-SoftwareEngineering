using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Person> persons = new List<Person>();

            while (command[0] != "End")
            {

                Person currPersonInfo = new Person(command[0], command[1], int.Parse(command[2]));
                persons.Add(currPersonInfo);

                command = Console.ReadLine().Split();
            }

            persons.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person));
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }


        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
    }
}
