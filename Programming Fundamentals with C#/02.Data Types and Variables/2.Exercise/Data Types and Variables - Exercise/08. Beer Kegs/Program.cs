using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string biggestKeg = string.Empty;
            double bigKeg = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                string modelOfTheKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double sum = Math.PI * Math.Pow(radius, 2) * height;

                if (sum > bigKeg)
                {
                    bigKeg = sum;
                    biggestKeg = modelOfTheKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
