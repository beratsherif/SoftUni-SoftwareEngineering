﻿using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double sum = Math.Floor(input * 100);
            int coins = 0;
            while (sum > 0)
            {
                if (sum >= 200)
                {
                    sum -= 200;
                }
                else if (sum >= 100)
                {
                    sum -= 100;
                }
                else if (sum >= 50)
                {
                    sum -= 50;
                }
                else if (sum >= 20)
                {
                    sum -= 20;
                }
                else if (sum >= 10)
                {
                    sum -= 10;
                }
                else if (sum >= 5)
                {
                    sum -= 5;
                }
                else if (sum >= 2)
                {
                    sum -= 2;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                }
                coins++;
            }
            Console.WriteLine(coins);
        }
    }
}
