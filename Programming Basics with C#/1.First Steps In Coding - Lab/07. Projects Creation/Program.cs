using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int neededTime = projects * 3;

            Console.WriteLine($"The architect {name} will need {neededTime} hours to complete {projects} project/s.");
        }
    }
}
