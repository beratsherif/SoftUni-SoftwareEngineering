﻿using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            FinalResult(result, num3);
            //Console.WriteLine(FinalResult(result, num3));
        }
        private static int Add(int num1, int num2) => num1 + num2;
        //{
        //    int sum = num1 + num2;
        //    return sum;
        //}

        private static void FinalResult(int result, int num3) => Console.WriteLine(result - num3);
        //{
        //    int finalResult = result - num3;
        //    return finalResult;
        //}

    }
}
