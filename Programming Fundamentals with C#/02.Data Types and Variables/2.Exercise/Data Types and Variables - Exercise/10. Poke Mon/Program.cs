using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaust = int.Parse(Console.ReadLine());

            int startingPower = power;
            int coutOfPoked = 0;

            while (power >= distance)
            {
                power -= distance;
                coutOfPoked++;
                if (startingPower * 0.5 == power && exhaust > 0)
                {
                    power /= exhaust;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(coutOfPoked);
        }
    }
}
