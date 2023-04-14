using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthdayable> list = new List<IBirthdayable>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] cmds = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmds[0] == "Citizen")
                {
                    list.Add(new Citizen(cmds[1],int.Parse(cmds[2]),cmds[3],cmds[4]));
                }

                if (cmds[0] == "Pet")
                {
                    list.Add(new Pet(cmds[1], cmds[2]));
                }
            }

            string year = Console.ReadLine();

            foreach (var item in list.Where(x => x.BirthDate.EndsWith(year)))
            {
                Console.WriteLine(item.BirthDate);
            }
        }
    }
}
