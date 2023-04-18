using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 4)
                {
                    citizens.Add(new Citizen(input[0],int.Parse(input[1]),input[2],input[3]));
                }
                else
                {
                    rebels.Add(new Rebel(input[0],int.Parse(input[1]),input[2]));
                }
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {

                if (cmd == "End")
                {
                    break;
                }

                if (citizens.FirstOrDefault(x=> x.Name == cmd) != null)
                {
                    Citizen citizen = citizens.FirstOrDefault(x => x.Name == cmd);
                    citizen.BuyFood();
                }

                if (rebels.FirstOrDefault(x=> x.Name == cmd) != null)
                {
                    Rebel rebel = rebels.FirstOrDefault(x => x.Name == cmd);
                    rebel.BuyFood();
                }
            }

            Console.WriteLine(citizens.Sum(x=> x.Food) + rebels.Sum(x=> x.Food));
        }
    }
}
