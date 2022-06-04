using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int pieces = h * w;
            int takenPieces = 0;
            bool check = false;
            string input = Console.ReadLine();
            while (input != "STOP")
            {
                int currPieces = int.Parse(input);
                takenPieces += currPieces;
                if (takenPieces >= pieces)
                {
                    check = true;
                    break;
                }
                input = Console.ReadLine();
            }
            if (check)
            {
                Console.WriteLine($"No more cake left! You need {takenPieces - pieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieces - takenPieces} pieces are left.");
            }
        }
    }
}
