using System;
using System.Collections.Generic;

namespace _04.Team
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(input[0],
                    input[1],
                    int.Parse(input[2]), 
                        decimal.Parse(input[3]));

                persons.Add(person);
            }

            Team team = new Team("Softuni");

            foreach (var person in persons)
            {
                team.AddPerson(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
