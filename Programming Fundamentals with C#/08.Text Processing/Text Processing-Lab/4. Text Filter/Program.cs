using System;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                string replacedWords = new string('*', bannedWord.Length);

                text = text.Replace(bannedWord, replacedWords);
            }

            Console.WriteLine(text);
        }
    }
}
