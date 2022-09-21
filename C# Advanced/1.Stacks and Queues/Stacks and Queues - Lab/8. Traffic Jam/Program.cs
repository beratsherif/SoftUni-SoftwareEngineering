using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int numOfCars = int.Parse(Console.ReadLine());
            int countOfPassedCar = 0;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < numOfCars; i++)
                    {
                        if (queue.Count > 0)
                        {
                            string passingCar = queue.Dequeue();
                            countOfPassedCar++;
                            Console.WriteLine($"{passingCar} passed!");
                        }
                        else break;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{countOfPassedCar} cars passed the crossroads.");
        }
    }
}
