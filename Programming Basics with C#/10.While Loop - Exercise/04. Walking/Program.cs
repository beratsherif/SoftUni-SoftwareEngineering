using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 10000;
            string input = Console.ReadLine();
            int total = 0;
            while (input != "Going home")
            {   
                int currSteps = int.Parse(input);
                total += currSteps;
                if (total >= totalSteps)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (total >= totalSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{total - totalSteps} steps over the goal!");
            }
            if (input == "Going home")
            {
                input = Console.ReadLine();
                int currSteps = int.Parse(input);
                total += currSteps;
                if (total >= totalSteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{total - totalSteps} steps over the goal!");
                }
                else
                {
                    int diff = totalSteps - total;
                    Console.WriteLine($"{diff} more steps to reach goal.");
                }
            }
        }
    }
}
