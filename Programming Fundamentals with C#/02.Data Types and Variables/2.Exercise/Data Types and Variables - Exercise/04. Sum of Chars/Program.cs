﻿using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfChars = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < countOfChars; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += (int)letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
