using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < input[1]; cols++)
                {
                    matrix[row,cols] = rowData[cols];
                }
            }

            int sum = 0;
            for (int row = 0; row < input[0]; row++)
            {
                for (int col = 0; col < input[1]; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);
            Console.WriteLine(sum);
        }
    }
}
