using System;

namespace _06.Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int n = input;
            int factorielSum = 0;

            while (n > 0)
            {

                int number = n % 10;
                int factoriel = 1;

                for (int i = 1; i <= number; i++)
                {
                    factoriel *= i;
                }

                factorielSum += factoriel;
                n /= 10;

            }

            if (factorielSum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            } 
        }
    }
}
