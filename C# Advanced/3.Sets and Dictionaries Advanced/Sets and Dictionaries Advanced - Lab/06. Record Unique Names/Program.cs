using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNamesList = new HashSet<string>();

            int inputForForCycle = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputForForCycle; i++)
            {
                string inputForSet = Console.ReadLine();
                uniqueNamesList.Add(inputForSet);
            }

            //Printing the set
            foreach (var name in uniqueNamesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
