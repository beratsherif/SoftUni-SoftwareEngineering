using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            char A = (char)35;
            char B = (char)64;
            int counter = 0;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    counter++;
                    if (counter > max)
                    {
                        return;
                    }

                    Console.Write($"{A}{B}{x}{y}{B}{A}|");
                    A++;
                    B++;
                    if (A > 55)
                    {
                        A = (char)35;
                    }
                    if (B > 96)
                    {
                        B = (char)64;
                    }
                }
            }
        }
    }
}
