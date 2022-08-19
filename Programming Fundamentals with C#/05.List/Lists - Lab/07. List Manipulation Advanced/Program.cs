using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool check = false;


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
                        check = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        check = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        check = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        check = true;
                        break;
                    case "Contains":
                        CheckContains(int.Parse(tokens[1]), numbers);
                        break;
                    case "PrintEven":
                        PrintingEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintingOdd(numbers);
                        break;
                    case "GetSum":
                        int sum = GetSumOfNums(numbers);
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        PrintFilter(tokens[1], int.Parse(tokens[2]), numbers);
                        break;
                }
            }

            if (check)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }

        }

        private static void PrintFilter(string filter, int numberTofilter, List<int> numbers)
        {
            switch (filter)
            {
                case "<":
                    foreach (int num in numbers)
                    {
                        if (num < numberTofilter)
                        {
                            Console.Write($"{num} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case ">":
                    foreach (int num in numbers)
                    {
                        if (num > numberTofilter)
                        {
                            Console.Write($"{num} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case ">=":
                    foreach (int num in numbers)
                    {
                        if (num >= numberTofilter)
                        {
                            Console.Write($"{num} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case "<=":
                    foreach (int num in numbers)
                    {
                        if (num <= numberTofilter)
                        {
                            Console.Write($"{num} ");
                        }
                    }
                    Console.WriteLine();
                    break;
            }
        }

        private static int GetSumOfNums(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        private static void PrintingOdd(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintingEven(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }

        private static void CheckContains(int number, List<int> numbers)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
