using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();
                string cmd = command[0];
                switch (cmd)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;

                    case "Insert":
                        int number = int.Parse(command[1]);
                        int indexInsert = int.Parse(command[2]);
                        if (indexInsert > numbers.Count - 1 || indexInsert < 0)
                        {
                            Console.WriteLine($"Invalid index");
                            break;
                        }
                        numbers.Insert(indexInsert, number);
                        break;

                    case "Remove":
                        int indexRemove = int.Parse(command[1]);
                        if (indexRemove > numbers.Count - 1 || indexRemove < 0)
                        {
                            Console.WriteLine($"Invalid index");
                            break;
                        }
                        numbers.RemoveAt(indexRemove);
                        break;

                    case "Shift":
                        int count = int.Parse(command[2]);
                        string shiftType = command[1];

                        if (shiftType == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (shiftType == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
