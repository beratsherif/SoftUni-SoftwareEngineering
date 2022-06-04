using System;

namespace _06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first / 1000 % 10; i <= second / 1000 % 10; i++)
            {
                for (int j = first / 100 % 10; j <= second / 100 % 10; j++)
                {
                    for (int k = first / 10 % 10; k <= second / 10 % 10; k++)
                    {
                        for (int l = first % 10; l <= second % 10; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
