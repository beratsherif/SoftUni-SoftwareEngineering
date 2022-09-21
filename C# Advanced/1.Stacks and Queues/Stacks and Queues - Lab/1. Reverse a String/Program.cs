using System;
using System.Collections;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack currStack = new Stack();

            foreach (var ch in input)
            {
                currStack.Push(ch);
            }

            foreach (var st in currStack)
            {
                Console.Write(st);
            }
        }
    }
}
