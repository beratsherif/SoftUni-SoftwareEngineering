using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int positionInFibonacciSecqence = int.Parse(Console.ReadLine());
            int[] fibonacciSequence = new int[50];

            fibonacciSequence[0] = 1;
            fibonacciSequence[1] = 1;

            if (positionInFibonacciSecqence > 2)
            {
                for (int i = 2; i < positionInFibonacciSecqence; i++)
                {
                    fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
                }
            }

            Console.WriteLine(fibonacciSequence[positionInFibonacciSecqence - 1]);
        }
    }
}
