using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                FindindTheAgeAndTheName(input);
            }
        }

        private static void FindindTheAgeAndTheName(string input)
        {
            int startIndexOfName = input.IndexOf('@') + 1;
            int endIndexOfName = input.IndexOf('|');

            int startIndexOfAge = input.IndexOf('#') + 1;
            int endIndexOfAge = input.IndexOf('*');

            string name = input.Substring(startIndexOfName, endIndexOfName - startIndexOfName);
            string age = input.Substring(startIndexOfAge, endIndexOfAge - startIndexOfAge);

            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}
