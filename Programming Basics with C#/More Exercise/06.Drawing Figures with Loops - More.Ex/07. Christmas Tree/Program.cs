﻿using System;

namespace _07._Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string(' ',n - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*',row));
                Console.WriteLine(new string(' ',n - row));
            }
        }
    }
}
