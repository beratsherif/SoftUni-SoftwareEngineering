using System;
using System.Linq;
namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());

            int[] ladyBugsfield = new int[filedSize];

            string[] occupiedIndexes = Console.ReadLine().Split();

            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currIndex = int.Parse(occupiedIndexes[i]);
                if (currIndex >= 0 && currIndex < filedSize)
                {
                    ladyBugsfield[currIndex] = 1;
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {

                bool isFirst = true;
                int currIndex = int.Parse(commands[0]);

                while (currIndex >= 0 && currIndex < filedSize && ladyBugsfield[currIndex] != 0)
                {

                    if (isFirst)
                    {
                        ladyBugsfield[currIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flightLenght = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        currIndex -= flightLenght;
                        if (currIndex >= 0 && currIndex < filedSize)
                        {
                            if (ladyBugsfield[currIndex] == 0)
                            {
                                ladyBugsfield[currIndex] = 1;
                                break;
                            }
                        }
                    }

                    else
                    {
                        currIndex += flightLenght;
                        if (currIndex >= 0 && currIndex < filedSize)
                        {
                            if (ladyBugsfield[currIndex] == 0)
                            {
                                ladyBugsfield[currIndex] = 1;
                                break;
                            }
                        }
                    }

                }

                commands = Console.ReadLine().Split();

            }

            Console.WriteLine(string.Join(" ",ladyBugsfield));

        }
    }
}
