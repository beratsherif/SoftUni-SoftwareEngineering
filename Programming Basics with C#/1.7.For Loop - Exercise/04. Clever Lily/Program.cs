using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCount = 0;
            int moneyCount = 0;
            int savedMoney = 0;
            int moneyUp = 10;
            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    moneyCount++;
                    savedMoney += moneyUp;
                    moneyUp += 10;
                }
                else
                {
                    toysCount++;
                }
                
            }
            int moneyTakenFromBrother = moneyCount * 1;
            int moneyFromToys = toysCount * toyPrice;
            int totalMoney = savedMoney + moneyFromToys - moneyTakenFromBrother;
            double diff = Math.Abs(totalMoney - laundryPrice);
            if (totalMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
