using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            bool check = false;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (counter > n)
                    {
                        check = true;
                        break;
                    }
                    Console.Write($"{counter} ");
                    counter++;
                }
                if (check)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
