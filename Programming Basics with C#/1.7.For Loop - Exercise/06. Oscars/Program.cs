using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointFromAcademy = double.Parse(Console.ReadLine());
            int coutOfRaters = int.Parse(Console.ReadLine());
            double total = pointFromAcademy;
            bool check = false;
            for (int i = 0; i < coutOfRaters; i++)
            {
                string nameOfRater = Console.ReadLine();
                double ratersPoints = double.Parse(Console.ReadLine());
                double totalRaiterPoints =  nameOfRater.Length * ratersPoints / 2;
                total += totalRaiterPoints;
                if (total > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {total:f1}!");
                    check = true;
                    break;
                }

            }
            if (check == false)
            {
            double diff = 1250.5 - total;
            Console.WriteLine($"Sorry, {actorName} you need {diff:f1} more!");
            }
        }
    }
}
