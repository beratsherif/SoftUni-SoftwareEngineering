using System;

namespace _07.Generalization
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int hour = 0; hour <= 23; hour++)
            //{
            //    for (int min = 0; min <= 59; min++)
            //    {
            //        Console.WriteLine($"{hour}:{min}");
            //    }
            //}

            //2

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //}

            //3

            //double n = double.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int x1 = 0; x1 <= n ; x1++)
            //{
            //    for (int x2 = 0; x2 <= n; x2++)
            //    {
            //        for (int x3 = 0; x3 <= n; x3++)
            //        {
            //            if (x1 + x2 + x3 == n)
            //            {
            //                counter++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(counter);

            //4

            //int start = int.Parse(Console.ReadLine());
            //int finish = int.Parse(Console.ReadLine());
            //int magicNum = int.Parse(Console.ReadLine());
            //int combinationCounter = 0;
            //bool check = false;
            //for (int i = start; i <= finish; i++)
            //{
            //    for (int j = start; j <= finish; j++)
            //    {
            //        combinationCounter++;
            //        if (i + j == magicNum)
            //        {
            //            check = true;
            //            Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNum})");
            //            break;
            //        }
            //    }
            //    if (check)
            //    {
            //        break;
            //    }
            //}
            //if (check == false)
            //{
            //    Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");
            //}

            //5

            //string input = Console.ReadLine();
            //while (input != "End")
            //{
            //    double neededMoney = double.Parse(Console.ReadLine());
            //    double money = 0;
            //    while (money < neededMoney)
            //    {
            //        double currMoney = double.Parse(Console.ReadLine());
            //        money += currMoney;
            //    }
            //    Console.WriteLine($"Going to {input}!");
            //    input = Console.ReadLine();
            //}

            //6

            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int floor = floors; floor >= 1; floor--)
            {
                string symbol = string.Empty;
                if (floors == floor)
                {
                    symbol = "L";
                }
                else
                {
                    if (floor % 2 == 0)
                    {
                        symbol = "O";
                    }
                    else
                    {
                        symbol = "A";
                    }
                }
                for (int room = 0; room < rooms; room++)
                {
                    Console.Write($"{symbol}{floor}{room} ");
                }
                Console.WriteLine();
            }
        }
    }
}
