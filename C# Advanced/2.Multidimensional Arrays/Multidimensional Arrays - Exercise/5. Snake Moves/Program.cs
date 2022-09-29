using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[input[0], input[1]];

            string cmd = Console.ReadLine();
            Queue<char> queue = new Queue<char>(cmd);

            for (int row = 0; row < input[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < input[1]; col++)
                    {
                        matrix[row, col] = queue.Peek();
                        queue.Enqueue(queue.Dequeue());
                    }
                }
                else
                {
                    for (int col = input[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Peek();
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }

            for (int r = 0; r < input[0]; r++)
            {
                for (int c = 0; c < input[1]; c++)
                {
                    Console.Write(matrix[r,c]);
                }

                Console.WriteLine();
            }
        }
    }
}
