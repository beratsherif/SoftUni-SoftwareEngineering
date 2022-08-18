using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFctoriel = Factoriel(firstNumber);
            double secondFactoriel = Factoriel(secondNumber);
            Reslult(firstFctoriel, secondFactoriel);
        }

        private static void Reslult(double firstFctoriel, double secondFactoriel) => Console.WriteLine($"{firstFctoriel / secondFactoriel:f2}");

        private static double Factoriel(int firstNumber)
        {
            double result = 1;
            while (firstNumber != 1)
            {
                result *= firstNumber;
                firstNumber--;
            }
            return result;
        }
    }
}
