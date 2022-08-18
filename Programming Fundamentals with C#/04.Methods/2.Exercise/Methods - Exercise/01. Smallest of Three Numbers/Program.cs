using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestInteger(firstNum, secondNum, thirdNum));

        }

        static int SmallestInteger(int first, int second, int third)
        {
            //int smallestNum = first;

            //if (second < first)
            //{
            //    smallestNum = second;
            //}
            //if (third < second)
            //{
            //    if (third < first)
            //    {
            //        smallestNum = third;
            //    }
            //}

            //return smallestNum;

            return Math.Min(first, Math.Min(second, third));
        }
    }
}
