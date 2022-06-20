using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededSum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int payingCash = 0;
            int payingWithWard = 0;
            int couter = 1;
            int total = 0;
            double totalPayingCash = 0;
            double totalPayingWithCard = 0;
            while (input != "End")
            {
                int currentSum = int.Parse(input);
                if (couter % 2 == 0)
                {
                    if (currentSum < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        couter++;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        couter++;
                        payingWithWard++;
                        totalPayingWithCard += currentSum;
                        total += currentSum;
                    }
                }
                else
                {
                    if (currentSum > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        couter++;
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        payingCash++;
                        totalPayingCash += currentSum;
                        total += currentSum;
                        couter++;
                    }
                }
                if (total >= neededSum)
                {
                    Console.WriteLine($"Average CS: {totalPayingCash / payingCash:f2}");
                    Console.WriteLine($"Average CC: {totalPayingWithCard / payingWithWard:f2}");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
