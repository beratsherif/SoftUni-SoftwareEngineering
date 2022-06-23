using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {

            int months = int.Parse(Console.ReadLine());

            int waterPrice = 20 * months;
            int internetPrice = 15 * months;
            double electricityPrice = 0;
            double otherPrice = 0;

            for (int i = 0; i < months; i++)
            {
                double currElectricityPrice = double.Parse(Console.ReadLine());
                electricityPrice += currElectricityPrice;
                otherPrice += (currElectricityPrice + 35) * 1.20;
            }
            double averagePrice = (electricityPrice + waterPrice + internetPrice + otherPrice) / months;
            Console.WriteLine($"Electricity: {electricityPrice:f2} lv");
            Console.WriteLine($"Water: {waterPrice:f2} lv");
            Console.WriteLine($"Internet: {internetPrice:f2} lv");
            Console.WriteLine($"Other: {otherPrice:f2} lv");
            Console.WriteLine($"Average: {averagePrice:f2} lv");
        }
    }
}
