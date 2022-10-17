using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isItUpperCase = ch => char.IsUpper(ch[0]);
            //version 1
            //List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            //List<string> result = input.FindAll(isItUpperCase).ToList();

            //foreach (var re in result)
            //{
            //    Console.WriteLine(re);
            //}

            //version 2
            Console.WriteLine(string.Join(Environment.NewLine,Array.FindAll(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries),isItUpperCase)));
        }
    }
}
