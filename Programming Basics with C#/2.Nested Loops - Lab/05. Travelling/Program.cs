using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0;
            while (input != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                while (money < neededMoney)
                {
                    double currMoney = double.Parse(Console.ReadLine());
                    money += currMoney;
                    if (money >= neededMoney)
                    {
                        Console.WriteLine($"Going to {input}!");
                        money = 0;
                        break;
                    }
                }
                input = Console.ReadLine();


            }
        }
    }
}
