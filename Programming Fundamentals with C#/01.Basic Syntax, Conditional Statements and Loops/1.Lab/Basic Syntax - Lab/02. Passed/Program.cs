using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
