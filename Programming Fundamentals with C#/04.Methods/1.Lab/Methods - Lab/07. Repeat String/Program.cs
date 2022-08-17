using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatingString(input, times));

        }

        static string RepeatingString(string str, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
