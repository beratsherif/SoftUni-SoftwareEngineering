﻿using System;

namespace _02._Array_Creator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);

            Console.WriteLine(string.Join(",",strings));
            Console.WriteLine(string.Join(",",integers));
        }
    }
}
