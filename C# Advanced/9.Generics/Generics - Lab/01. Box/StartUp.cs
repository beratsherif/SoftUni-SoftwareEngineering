using System;

namespace _01._Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Version 1

            //Box<int> box = new Box<int>();
            //box.Add(1);
            //box.Add(2);
            //Console.WriteLine(box.Remove());


            //Box<string> box2 = new Box<string>();
            //box2.Add("Hello");
            //box2.Add("World");
            //Console.WriteLine(box2.Remove());

            //Console.WriteLine(box2.Count);

            //Version 2

            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

        }
    }
}
