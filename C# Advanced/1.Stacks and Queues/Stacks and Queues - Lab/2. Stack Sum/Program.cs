using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var num in input)
            {
                stack.Push(num);
            }
            string cmd;
            while ((cmd = Console.ReadLine().ToLower()) != "end")
            {
                string[] actions = cmd.Split(" ");

                switch (actions[0])
                {
                    case "add":
                        stack.Push(int.Parse(actions[1]));
                        stack.Push(int.Parse(actions[2]));
                        break;

                    case "remove":
                        int times = int.Parse(actions[1]);

                        if (stack.Count >= times)
                        {
                            for (int i = 0; i < times; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
