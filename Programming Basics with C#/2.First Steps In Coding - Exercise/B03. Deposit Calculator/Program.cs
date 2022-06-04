using System;

namespace B03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double yearProcent = double.Parse(Console.ReadLine()) / 100;

            double finalResult = (sum + months * ((sum * yearProcent) / 12));
            Console.WriteLine(finalResult);
        }
    }
}
