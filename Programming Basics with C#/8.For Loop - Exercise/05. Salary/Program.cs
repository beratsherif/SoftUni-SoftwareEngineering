using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int penalty = 0;
            bool check = false;

            for (int i = 0; i < tabs; i++)
            {
                string tabName = Console.ReadLine();
                switch (tabName)
                {
                    case "Facebook":
                        penalty += 150;
                        break;
                    case "Instagram":
                        penalty += 100;
                        break;
                    case "Reddit":
                        penalty += 50;
                        break;
                    default:
                        break;
                }
                if (penalty >= salary)
                {
                    check = true;
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (check == false)
            {
            int diff = salary - penalty;
            Console.WriteLine(diff);
            }
        }
    }
}
