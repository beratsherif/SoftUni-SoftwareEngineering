using System;
using System.Text;

namespace _07.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append(symbol);
                }
                else if (power == 0)
                {
                    sb.Append(symbol);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
