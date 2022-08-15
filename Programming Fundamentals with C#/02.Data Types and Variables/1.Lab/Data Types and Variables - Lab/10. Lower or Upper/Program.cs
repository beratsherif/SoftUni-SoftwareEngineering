using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (Char.IsLower(letter))
            {
                Console.WriteLine("lower-case");
            }
            else if (Char.IsUpper(letter))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
