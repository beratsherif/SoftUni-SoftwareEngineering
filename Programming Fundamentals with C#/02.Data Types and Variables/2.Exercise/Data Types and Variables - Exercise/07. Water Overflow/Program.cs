using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 0;
            int countOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfInputs; i++)
            {
                int littres = int.Parse(Console.ReadLine());
                if (tankCapacity + littres > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    continue;
                }
                else
                {
                    tankCapacity += littres;
                }
            }
            Console.WriteLine(tankCapacity);
        }
    }
}
