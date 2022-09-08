using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintingTheResult(input);
        }

        private static void PrintingTheResult(string input)
        {
            switch (input)
            {
                case "int":
                    int integer = int.Parse(Console.ReadLine()) * 2;
                    Console.WriteLine(integer);
                    break;

                case "real":
                    double realNumber = double.Parse(Console.ReadLine()) * 1.5;
                    Console.WriteLine($"{realNumber:f2}");
                    break;

                case "string":
                    string message = Console.ReadLine();
                    Console.WriteLine($"${message}$");
                    break;
            }
        }
    }
}
