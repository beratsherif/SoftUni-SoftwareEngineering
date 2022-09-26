using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];

            for (int row = 0; row < input; row++)
            {
                int[] currCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < input; col++)
                {
                    matrix[row, col] = currCol[col];
                }
            }

            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
