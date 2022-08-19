using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
