using System;

namespace _10._Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            int stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            for (int top = 1; top <= (n - 1) / 2; top++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }

            for (int bot = 1; bot <= (n - 1) / 2; bot++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight++;
            }

            Console.Write(new string('-', leftRight));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', leftRight));


        }
    }
}
