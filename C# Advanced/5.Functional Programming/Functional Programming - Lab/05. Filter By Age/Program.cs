using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = CreatePersonFilter(condition, ageThreshold);

            List<Person> matchinPeople = people.Where(filter).ToList();

            string formatString = Console.ReadLine();
            Action<Person> printPerson = CreatePersonPrinter(formatString);

            PrintPeople(matchinPeople, printPerson);
        }

        static List<Person> ReadPeople()
        {
            int count = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                people.Add(new Person{Name = name,Age = age});
            }

            return people;
        }

        static Func<Person,bool> CreatePersonFilter(string condition, int ageThreshold)
        {
            if (condition == "older")
                return p => p.Age >= ageThreshold;
            if (condition == "younger")
                return p => p.Age < ageThreshold;

            throw new ArgumentException($"Invalid filter: {condition} {ageThreshold}");

        }
        static Action<Person> CreatePersonPrinter(string format)
        {
            if (format == "name age")
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            if (format == "name")
                return p => Console.WriteLine($"{p.Name}")
                    ; if (format == "age")
                return p => Console.WriteLine($"{p.Age}");

            throw new ArgumentException("Invalid: " + format);
        }
        static void PrintPeople(List<Person> people, Action<Person> printerPerson)
        {
            foreach (var person in people)
                printerPerson(person);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
