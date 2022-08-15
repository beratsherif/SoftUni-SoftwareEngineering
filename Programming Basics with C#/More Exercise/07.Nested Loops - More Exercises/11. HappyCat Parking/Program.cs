using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <= days; i++)
            {
                double summ = 0;
                for (int l = 1; l <= hours; l++)
                {
                    if (i % 2 == 0 && l % 2 == 1)
                    {
                        summ += 2.50;
                    }
                    else if (i % 2 == 1 && l % 2 == 0)
                    {
                        summ += 1.25;
                    }
                    else
                    {
                        summ += 1;
                    }
                }
                total += summ;
                Console.WriteLine($"Day: {i} – {summ:f2} leva");
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
