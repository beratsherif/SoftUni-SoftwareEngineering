using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[], string> sirString = (strings, title) =>
            {
                foreach (var name in strings)
                {
                    Console.WriteLine($"{title} {name}");
                }
            };

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            sirString(names, "Sir");
        }
    }
}
