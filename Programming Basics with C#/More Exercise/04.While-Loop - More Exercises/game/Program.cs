using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello,what is your name? ");
            Console.WriteLine("(Type your name and click ENTER)");
            string name = Console.ReadLine();
            Console.Write($"Hello {name}, ");
            Console.WriteLine("Do you want to play a game with me? (answer with (yes) or (no))");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.Write("Lets go then. ");
                Console.WriteLine("Guess my name");
                string name1 = Console.ReadLine();
                if (name1 == "Berat")
                {
                    Console.WriteLine("You are the winner");
                }
                else
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Try again!");
                }

            }
            else
            {
                Console.WriteLine("Okey bye bye ;)");
            }
        }
    }
}
