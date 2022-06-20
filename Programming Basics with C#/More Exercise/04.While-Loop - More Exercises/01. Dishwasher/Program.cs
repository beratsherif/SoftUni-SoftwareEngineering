using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfPreparation = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int quantityOfPreparation = coutOfPreparation * 750;
            int counter = 0;
            int plateCount = 0;
            int sauceoanCount = 0;
            int usedPreparation = 0;
            bool check = false;
            while (input != "End")
            {
                int quantityDishes = int.Parse(input);
                counter++;
                if (counter % 3 == 0)
                {
                    usedPreparation += quantityDishes * 15;
                    sauceoanCount += quantityDishes;
                }
                else
                {
                    usedPreparation += quantityDishes * 5;
                    plateCount += quantityDishes;
                }
                if (quantityOfPreparation < usedPreparation)
                {
                    Console.WriteLine($"Not enough detergent, {usedPreparation - quantityOfPreparation} ml. more necessary!");
                    check = true;
                    break;
                }
                input = Console.ReadLine();
            }
            if (check == false)
            {
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{plateCount} dishes and {sauceoanCount} pots were washed.");
            Console.WriteLine($"Leftover detergent {quantityOfPreparation - usedPreparation} ml.");
            }
        }
    }
}
