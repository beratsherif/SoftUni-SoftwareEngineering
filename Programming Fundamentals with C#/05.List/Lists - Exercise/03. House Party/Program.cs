using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < input; i++)
            {
                string action = Console.ReadLine();
                string[] arr = action.Split();
                string currName = arr[0];

                if (arr[2] == "going!")
                {
                    if (names.Contains(currName))
                    {
                        Console.WriteLine($"{currName} is already in the list!");
                    }
                    else
                    {
                        names.Add(currName);
                    }
                }
                else
                {
                    if (names.Contains(currName))
                    {
                        names.Remove(currName);
                    }
                    else
                    {
                        Console.WriteLine($"{currName} is not in the list!");
                    }
                }
            }


            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
