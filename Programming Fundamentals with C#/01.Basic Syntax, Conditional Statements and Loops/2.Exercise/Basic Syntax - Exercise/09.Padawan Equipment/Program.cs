using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int coutOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            int freeBelts = 0;

            if (coutOfStudents >= 6)
            {
                freeBelts = coutOfStudents / 6;
            }

            double total = (priceOfLightsabers * (Math.Ceiling(coutOfStudents * 1.1))) + (priceOfRobes * coutOfStudents) + (priceOfBelts * (coutOfStudents - freeBelts));

            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - money:f2}lv more.");
            }
        }
    }
}
