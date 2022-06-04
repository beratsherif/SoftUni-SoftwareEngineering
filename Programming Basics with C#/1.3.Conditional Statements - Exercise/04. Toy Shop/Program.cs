using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //const double puzzlePrice = 2.60;
            //const double talkingDollPrice = 3;
            //const double bearPrice = 4.10;
            //const double minionPrice = 8.20;
            //const double truckPrice = 2;


            //double excoursionPrice = double.Parse(Console.ReadLine());
            //int puzzle = int.Parse(Console.ReadLine());
            //int talkingDoll = int.Parse(Console.ReadLine());
            //int bear = int.Parse(Console.ReadLine());
            //int minions = int.Parse(Console.ReadLine());
            //int trucks = int.Parse(Console.ReadLine());

            //int totalToys = puzzle + talkingDoll + bear + minions + trucks;

            //double totalPuzzlePrice = puzzlePrice * puzzle;
            //double totalTalkingDollsPrice = talkingDollPrice * talkingDoll;
            //double totalBearsPrice = bearPrice * bear;
            //double totalMinionsPrice = minionPrice * minions;
            //double totalTruckPrice = truckPrice * trucks;

            //double totalToysPrice = totalPuzzlePrice + totalTalkingDollsPrice + totalBearsPrice + totalMinionsPrice + totalTruckPrice;

            //if (totalToys >= 50 )
            //{
            //    totalToysPrice *= 0.75;
            //}

            //double rentPrice = totalToysPrice * 0.1;

            //double moneyLeft = totalToysPrice - rentPrice;
            //if (moneyLeft >= excoursionPrice)
            //{
            //    Console.WriteLine($"Yes! {moneyLeft - excoursionPrice:f2} lv left.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money! {excoursionPrice - moneyLeft:f2} lv needed.");
            //}

            const double puzzlePrice = 2.60;
            const double talkDollPrice = 3;
            const double bearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2;
            double excuorsionPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());
            int toysCount = numberOfPuzzles + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;
            double totalPrice = numberOfPuzzles * puzzlePrice + numberOfDolls * talkDollPrice + numberOfBears * bearPrice + numberOfMinions * minionPrice + numberOfTrucks * truckPrice;
            if (toysCount >= 50)
            {
                totalPrice *= 0.75;
            }
            double rent = 0.10 * totalPrice;
            double difference = Math.Abs(rent + excuorsionPrice - totalPrice);
            if (totalPrice >= rent + excuorsionPrice)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");

            }
        }
    }
}
