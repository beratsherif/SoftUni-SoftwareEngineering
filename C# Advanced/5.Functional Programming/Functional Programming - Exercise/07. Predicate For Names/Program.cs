using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[], Predicate<string>> printNames = (names, match) =>
            {
                foreach (var name in names)
                {
                    if (match(name))
                    {
                        Console.WriteLine(name);
                    }
                }
            };

            int maxNameLenght = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            printNames(input, n => n.Length <= maxNameLenght);
        }
    }
}
