using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int vPool = int.Parse(Console.ReadLine());
            int P1For1Hour = int.Parse(Console.ReadLine());
            int P2For1Hour = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double P1Total = P1For1Hour * H;
            double P2Total = P2For1Hour * H;
            double P1P2Total = P1Total + P2Total;

            if (P1P2Total <= vPool)
            {
                double percentFull = (P1P2Total / vPool) * 100;
                double pipe1Percent = (P1Total / P1P2Total) * 100;
                double pipe2Percent = (P2Total / P1P2Total) * 100;
                Console.WriteLine($"The pool is {percentFull:F2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
            }
            else
            {
                double diff = P1P2Total - vPool;
                Console.WriteLine($"For {H} hours the pool overflows with {diff:f2} liters.");

            }
        }
    }
}
