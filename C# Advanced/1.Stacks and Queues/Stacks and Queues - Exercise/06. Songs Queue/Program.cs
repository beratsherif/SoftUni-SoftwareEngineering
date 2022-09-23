using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> input = new Queue<string>(Console.ReadLine().Split(", "));

            while (input.Count > 0)
            {
                string[] cmd = Console.ReadLine().Split();
                string action = cmd[0];
                switch (action)
                {
                    case "Play":
                        input.Dequeue();
                        break;
                    case "Add":
                        string songToAdd = string.Join(' ', cmd.Skip(1));
                        if (!input.Contains(songToAdd))
                            input.Enqueue(songToAdd);
                        else
                            Console.WriteLine($"{songToAdd} is already contained!");
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", input));
                        break;
                }
            }
            Console.WriteLine($"No more songs!");
        }
    }
}
