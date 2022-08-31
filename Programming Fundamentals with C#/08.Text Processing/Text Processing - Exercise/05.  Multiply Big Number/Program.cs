using System;
using System.Collections.Generic;
using System.Text;

namespace _05.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            
            string bigNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int reminder = 0;

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                char digit = bigNum[i];
                int currNum = int.Parse(digit.ToString());

                int result = currNum * num + reminder;

                sb.Append(result % 10);

                reminder = result / 10;
            }

            if (reminder > 0)
            {
                sb.Append(reminder);
            }

            StringBuilder reversedSb = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversedSb.Append(sb[i]);
            }

            Console.WriteLine(reversedSb);
        }
    }
}
