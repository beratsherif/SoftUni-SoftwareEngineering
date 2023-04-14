using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmd.Length == 2)
                {
                    identifiables.Add(new Robot(cmd[0],cmd[1]));
                }

                if (cmd.Length == 3)
                {
                    identifiables.Add(new Citizen(cmd[0],int.Parse(cmd[1]),cmd[2]));
                }
            }

            string chechForFake = Console.ReadLine();

            foreach (var item in identifiables.Where(x => x.Id.EndsWith(chechForFake)))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
