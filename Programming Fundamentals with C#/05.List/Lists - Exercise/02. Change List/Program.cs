using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmd = command.Split();
                
                if (cmd.Length == 2)
                {
                    int element = int.Parse(cmd[1]);
                    numbers.RemoveAll(el => el == element);
                }
                else if(cmd.Length == 3)
                {
                    int element = int.Parse(cmd[1]);
                    int index = int.Parse(cmd[2]);

                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
