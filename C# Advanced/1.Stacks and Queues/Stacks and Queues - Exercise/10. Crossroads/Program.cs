using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int greenLightDuration = int.Parse(Console.ReadLine());
            int windowDuration = int.Parse(Console.ReadLine());

            int passedCars = 0;

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green")
                {
                    int currTime = greenLightDuration;
                    if (greenLightDuration == 0)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    while (cars.Count > 0 && currTime > 0)
                    {
                        if (cars.Peek().Length <= currTime)
                        {
                            currTime -= cars.Peek().Length;
                            cars.Dequeue();
                            passedCars++;
                        }
                        else
                        {
                            if (cars.Peek().Length <= currTime + windowDuration)
                            {
                                passedCars++;
                                cars.Dequeue();
                                break;
                            }
                            Console.WriteLine($"A crash happened!");
                            int indexCrashed = currTime + windowDuration;
                            string carText = cars.Peek();
                            string subs = carText.Substring(indexCrashed, 1);
                            Console.WriteLine($"{carText} was hit at {subs}.");
                            return;
                        }
                    }
                }
                else
                    cars.Enqueue(input);
            }

            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
