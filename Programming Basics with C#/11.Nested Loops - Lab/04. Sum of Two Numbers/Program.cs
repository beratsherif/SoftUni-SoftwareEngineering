using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool check = false;
            int combination = 0;
            for (int first = firstNum; first <= lastNum; first++)
            {
                for (int second = firstNum; second <= lastNum; second++)
                {
                    combination++;
                    if (first + second == magicNum)
                    {
                        check = true;
                        Console.WriteLine($"Combination N:{combination} ({first} + {second} = {magicNum})");
                        break;
                    }
                }
                if (check)
                {
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
            }
        }
    }
}
