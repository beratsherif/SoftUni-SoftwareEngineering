using System;
using System.Collections.Generic;

namespace _05._Stack_of_Strings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            stackOfStrings.AddRange(new List<string> { "1", "2", "3", "4", "5" });

            while (!stackOfStrings.IsEmpty())
            {
                Console.WriteLine(stackOfStrings.Pop());
            }
        }
    }
}
