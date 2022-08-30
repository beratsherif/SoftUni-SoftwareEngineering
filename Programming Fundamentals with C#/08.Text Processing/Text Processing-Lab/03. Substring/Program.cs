using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordForRemove = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(wordForRemove))
            {
                word = word.Replace(wordForRemove, string.Empty);
            }

            Console.WriteLine(word);
        }
    }
}
