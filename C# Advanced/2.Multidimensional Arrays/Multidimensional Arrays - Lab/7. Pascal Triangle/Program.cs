using System;
using System.Data;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            long[][] pascal = new long[input][];

            for (int i = 0; i < input; i++)
            {
                pascal[i] = new long[i + 1];

                for (int j = 0; j < pascal[i].Length; j++)
                {
                    if (i == 0)
                    {
                        pascal[i][j] = 1;
                        continue;
                    }

                    long curValue = 0;
                    if (j > 0 && i > 0)
                    {
                        curValue += pascal[i - 1][j - 1];
                    }

                    if (pascal[i].Length - 1 > j)
                    {
                        curValue += pascal[i - 1][j];
                    }

                    pascal[i][j] = curValue;
                }
            }

            //for (int i = 0; i < pascal.Length; i++)
            //{
            //    for (int j = 0; j < pascal[i].Length; j++)
            //    {
            //        Console.Write($"{pascal[i][j]} ");
            //    }

            //    Console.WriteLine();
            //}

            foreach (var row in pascal)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
