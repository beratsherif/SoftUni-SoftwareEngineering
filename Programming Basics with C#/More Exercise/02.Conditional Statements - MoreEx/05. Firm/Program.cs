using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workersWorkingMore = int.Parse(Console.ReadLine());

            double daysOfFullWorking = days * 0.90;
            double totalHoursWorking = daysOfFullWorking * 8;
            double FinalHoursWorking = Math.Floor(totalHoursWorking + (workersWorkingMore * (days * 2)));
            double diff = Math.Abs(neededHours - FinalHoursWorking);

            if (FinalHoursWorking >= neededHours)
            {
                Console.WriteLine($"Yes!{diff} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{diff} hours needed.");
            }




        }
    }
}
