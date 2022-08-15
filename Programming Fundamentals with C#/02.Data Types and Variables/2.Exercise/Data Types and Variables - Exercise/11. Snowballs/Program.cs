using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSnowBalls = int.Parse(Console.ReadLine());

            BigInteger snowBallValue;
            BigInteger snowBallSnow;
            BigInteger snowBallTime;
            int snowBallQuality;
            BigInteger bestSnowBall = int.MinValue;

            string bestSnowBallFormula = "";

            for (int i = 0; i < totalSnowBalls; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger currValue = snowBallSnow / snowBallTime;
                snowBallValue = BigInteger.Pow(currValue, snowBallQuality);

                if (snowBallValue > bestSnowBall)
                {
                    bestSnowBall = snowBallValue;
                    bestSnowBallFormula = $"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQuality})";
                }
            }
            Console.WriteLine(bestSnowBallFormula);
        }
    }
}
