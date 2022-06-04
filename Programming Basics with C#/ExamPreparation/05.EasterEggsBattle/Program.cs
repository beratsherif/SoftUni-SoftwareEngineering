using System;

namespace _05.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            bool check = false;
            while (input != "End of battle")
            {
                switch (input)
                {
                    case "one":
                        secondPlayerEggs--;
                        break;
                    case "two":
                        firstPlayerEggs--;
                        break;
                }
                if (firstPlayerEggs <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                    check = true;
                    break;
                }
                else if (secondPlayerEggs <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                    check = true;
                    break;
                }
                input = Console.ReadLine();
            }
            if (check == false)
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
        }
    }
}
