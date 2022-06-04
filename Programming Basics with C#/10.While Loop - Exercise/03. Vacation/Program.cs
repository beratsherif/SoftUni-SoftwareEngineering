using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int daysSheSpend = 0;
            while (moneyHave < neededMoney && daysSheSpend < 5)
            {
                string type = Console.ReadLine();
                double currSum = double.Parse(Console.ReadLine());
                daysCounter++;
                switch (type)
                {
                    case "spend":
                        daysSheSpend++;
                        moneyHave -= currSum;
                        if (moneyHave < 0)
                        {
                            moneyHave = 0;
                        }
                        break;
                    case "save":
                        daysSheSpend = 0;
                        moneyHave += currSum;
                        break;
                }
            }
            if (daysSheSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (moneyHave >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
