using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input[0]);
                queue.Enqueue(input[1]);
            }

            while (true)
            {
                Queue<int> copyOfQueue = new Queue<int>(queue);
                int littres = copyOfQueue.Dequeue();
                int distance = copyOfQueue.Dequeue();

                if (littres < distance)
                {
                    queue.Enqueue(queue.Dequeue());
                    queue.Enqueue(queue.Dequeue());
                }
                else if (littres >= distance)
                {
                    int leftFuel = littres - distance;

                    while (copyOfQueue.Any())
                    {
                        int litresInternal = copyOfQueue.Dequeue();
                        int distanceInternal = copyOfQueue.Dequeue();

                        if (litresInternal + leftFuel >= distanceInternal)
                        {
                            leftFuel = litresInternal + leftFuel - distanceInternal;
                        }
                        else
                        {

                            queue.Enqueue(queue.Dequeue());
                            queue.Enqueue(queue.Dequeue());
                            leftFuel = -1;
                            break;
                        }
                    }

                    if (leftFuel >= 0)
                    {
                        Console.WriteLine(index);
                        break;
                    }
                }
                index++;
            }
        }
    }
}
