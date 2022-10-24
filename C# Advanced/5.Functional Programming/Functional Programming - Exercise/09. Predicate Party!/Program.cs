using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Party!")
                {
                    break;
                }

                string action = input[0];
                string condition = input[1];
                string value = input[2];

                if (action == "Remove")
                {
                    people.RemoveAll(GetPredicate(condition, value));

                }
                else
                {
                    List<string> peopleToDouble = people.FindAll(GetPredicate(condition, value));
                    int index = people.FindIndex(GetPredicate(condition, value));
                    if (index >= 0)
                    {
                        people.InsertRange(index,peopleToDouble);
                    }
                }
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ",people)} are going to the party!");   
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string condition, string value)
        {
            switch (condition)
            {
                case "StartsWith":
                    return s => s.StartsWith(value);
                case "EndsWith":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                default:
                    return default(Predicate<string>);
            }
        }
    }
}
