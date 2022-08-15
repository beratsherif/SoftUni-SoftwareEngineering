using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            for (int number = 1; number <= counter; number++)
            {
                int total = 0;
                int digits = number;

                while (digits > 0)
                {
                    total += digits % 10;
                    digits /= 10;
                }

                bool check = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{number} -> {check}");
            }

        }
    }
}
