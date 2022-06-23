using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearWillLive = int.Parse(Console.ReadLine());
            int age = 18;
            int total = 0;
            for (int i = 1800; i <= yearWillLive; i++)
            {
                if (i % 2 == 0)
                {
                    total += 12000;
                    age++;
                }
                else
                {
                    total += 12000 + (50 * age);
                    age++;
                }
            }
            double diff = Math.Abs(inheritedMoney - total);
            if (inheritedMoney >= total)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {diff:f2} dollars to survive.");
            }
        }
    }
}
