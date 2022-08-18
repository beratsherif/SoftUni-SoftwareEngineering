using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersBetweenTwoCharacters(firstChar, secondChar);
        }

        static void CharactersBetweenTwoCharacters(char firstChar, char secondChar)
        {
            //string characters = string.Empty;

            //for (char i = (firstChar); i < secondChar; i++)
            //{
            //    characters += i + " ";
            //}

            //return characters;


            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
