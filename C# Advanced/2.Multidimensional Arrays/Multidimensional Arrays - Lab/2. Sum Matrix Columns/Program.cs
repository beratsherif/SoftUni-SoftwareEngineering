using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                int[] currInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currInput[j];
                }
            }

            for (int col = 0; col < matrix.GetLength(1) ; col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row,col];
                }

                Console.WriteLine(sum);
            }

        }
    }
}
