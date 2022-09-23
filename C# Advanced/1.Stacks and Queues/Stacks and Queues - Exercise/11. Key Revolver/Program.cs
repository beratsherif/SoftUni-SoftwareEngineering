using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locksInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int reward = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksInfo);
            Stack<int> bullets = new Stack<int>(bulletsInfo);

            int bulletShot = 0;
            while (locks.Any() && bullets.Any())
            {
                StartShootingLocks(bullets, locks, ref bulletShot, barrelSize);
            }

            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int moneyEarned = reward - (bulletShot * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }

        static void StartShootingLocks(Stack<int> bullets, Queue<int> locks, ref int bulletShot, int barrelSize)
        {
            int bulletSize = bullets.Pop();
            int lockSize = locks.Peek();
            bulletShot++;

            if (bulletSize <= lockSize)
            {
                locks.Dequeue();
                Console.WriteLine("Bang!");
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (bulletShot % barrelSize == 0 && bullets.Any())
            {
                Console.WriteLine("Reloading!");
            }
        }
    }
}
