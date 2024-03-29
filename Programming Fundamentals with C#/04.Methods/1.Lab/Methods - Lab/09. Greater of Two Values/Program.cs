﻿using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            switch (input)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
            }
        }

        static int GetMax(int first,int second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }

        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }

            return second;
        }
    }
}
