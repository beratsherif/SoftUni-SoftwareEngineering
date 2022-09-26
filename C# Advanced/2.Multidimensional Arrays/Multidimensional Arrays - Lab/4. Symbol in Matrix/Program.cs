using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[,] matrix = new int[input, input];

            for (int row = 0; row < input; row++)
            {
                string symbols = Console.ReadLine();

                for (int col = 0; col < input; col++)
                {
                    char currentSymbol = symbols[col];
                    matrix[row, col] = currentSymbol;
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            int symbolInInteger = symbol;

            for (int row = 0; row < input; row++)
            {
                for (int col = 0; col < input; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
