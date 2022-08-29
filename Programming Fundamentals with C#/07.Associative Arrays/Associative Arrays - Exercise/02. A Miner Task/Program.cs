using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();

            while (true)
            {
                string resourses = Console.ReadLine();
                if (resourses == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resourses))
                {
                    items.Add(resourses, 0);
                }
                items[resourses] += quantity;
            }
            foreach (var currItem in items)
            {
                Console.WriteLine($"{currItem.Key} -> {currItem.Value}");
            }
        }
    }
}
