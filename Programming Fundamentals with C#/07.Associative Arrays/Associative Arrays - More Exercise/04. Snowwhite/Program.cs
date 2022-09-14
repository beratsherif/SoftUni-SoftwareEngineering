using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {

            //var dwarfs = new Dictionary<string, int>();
            //string input = Console.ReadLine();
            //while (input != "Once upon a time")
            //{
            //    string[] inputs = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
            //    string name = inputs[0];
            //    string color = inputs[1];
            //    int physics = int.Parse(inputs[2]);

            //    string ID = name + ":" + color;
            //    if (!dwarfs.ContainsKey(ID))
            //    {
            //        dwarfs.Add(ID, physics);
            //    }
            //    else
            //    {
            //        dwarfs[ID] = Math.Max(dwarfs[ID], physics);
            //    }

            //    input = Console.ReadLine();
            //}
            //foreach (var dwarf in dwarfs
            //             .OrderByDescending(x => x.Value)
            //             .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1])
            //                 .Count()))
            //{
            //    Console.WriteLine("({0}) {1} <-> {2}",
            //        dwarf.Key.Split(':')[1],
            //        dwarf.Key.Split(':')[0],
            //        dwarf.Value);
            //}


            List<Dwarf> dwarfs = new List<Dwarf>();
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                AddingDwarfs(input, dwarfs);
            }

            PrintingResult(dwarfs);
        }

        private static void PrintingResult(List<Dwarf> dwarfs)
        {
            foreach (var dwarf in dwarfs
                         .OrderByDescending(x => x.Physics)
                         .ThenByDescending(x => dwarfs.Count(y => y.Color == x.Color)))
            {
                Console.WriteLine("({0}) {1} <-> {2}", dwarf.Color, dwarf.Name, dwarf.Physics);
            }
        }

        private static void AddingDwarfs(string input, List<Dwarf> dwarfs)
        {
            string[] inputs = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
            string name = inputs[0];
            string color = inputs[1];
            int physics = int.Parse(inputs[2]);

            Dwarf repeat = dwarfs.Find(x => x.Name == name && x.Color == color);
            if (repeat == null)
            {
                Dwarf dwarf = new Dwarf(name, color, physics);
                dwarfs.Add(dwarf);
            }
            else
            {
                repeat.Physics = Math.Max(repeat.Physics, physics);
            }
        }
    }

    class Dwarf
    {
        public Dwarf(string name,string color,int physics)
        {
            this.Name = name;
            this.Color = color;
            this.Physics = physics;
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }
}
