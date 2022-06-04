using System;

namespace B04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int pagesThatHeReadFor1Hour = int.Parse(Console.ReadLine());
            int daysHeHas = int.Parse(Console.ReadLine());

            int timeHeNeedForReading = totalPages / pagesThatHeReadFor1Hour;
            int neededTimeFor1Day = timeHeNeedForReading / daysHeHas;

            Console.WriteLine(neededTimeFor1Day);
        }
    }
}
