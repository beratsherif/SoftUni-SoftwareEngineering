using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int sum = 0;

            //for (int index = 0; index < firstArray.Length; index++)
            //{
            //    if (firstArray[index] != secondArray[index])
            //    {
            //        Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            //        break;
            //    }

            //    else
            //    {
            //        sum += firstArray[index];
            //    }

            //    if (index == firstArray.Length - 1)
            //    {
            //        Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //    }
            //}


            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool check = true;
            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sum += firstArray[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
