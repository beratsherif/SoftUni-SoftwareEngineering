using System;

namespace _08.__Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];

                double number = int.Parse(item.Substring(1, item.Length - 2));
                int upperCaseNumberPosition = 0;
                int lowerCaseNumberPosition = 0;

                double result = 0;

                if (char.IsUpper(firstLetter))
                {
                    upperCaseNumberPosition = firstLetter - 64;
                    result = number / upperCaseNumberPosition;
                }
                else
                {
                    lowerCaseNumberPosition = firstLetter - 96;
                    result = number * lowerCaseNumberPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    upperCaseNumberPosition = lastLetter - 64;
                    sum += result - upperCaseNumberPosition;
                }
                else
                {
                    lowerCaseNumberPosition = lastLetter - 96;
                    sum += result + lowerCaseNumberPosition;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
