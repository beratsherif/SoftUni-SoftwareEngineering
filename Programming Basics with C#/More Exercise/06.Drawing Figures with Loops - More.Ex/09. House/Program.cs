using System;

namespace _09._House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double roofLog = (n + 1) / 2;
            double baseLog = n - roofLog;
            int starsEven = 2;
            int starsOdd = 1;

            for (int roof = 1; roof <= roofLog; roof++)
            {
                if (n % 2 == 0)
                {
                    
                    Console.Write(new string('-', (Math.Abs(n - starsEven) / 2)));
                    Console.Write(new string('*', starsEven));
                    Console.WriteLine(new string('-', (Math.Abs(n - starsEven) / 2)));
                    starsEven += 2;
                }
                else
                {
                    Console.Write(new string('-', (Math.Abs(n - starsOdd) / 2)));
                    Console.Write(new string('*', starsOdd));
                    Console.WriteLine(new string('-', (Math.Abs(n - starsOdd) / 2)));
                    starsOdd += 2;
                }
            }
            for (int floor = 1; floor <= baseLog; floor++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }

        }
    }
}
