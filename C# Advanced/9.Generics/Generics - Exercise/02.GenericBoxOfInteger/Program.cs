﻿using System;

namespace _02.GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Items.Add(input);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
