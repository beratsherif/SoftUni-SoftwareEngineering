using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string message = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                int index = CalculateIndex(currNum);

                char currChar = GetCharFromMessage(index, message);
                Console.Write(currChar);

                int realIndex = CalculatRealIndex(index, message);
                string newMessage = message.Remove(realIndex, 1);
                message = newMessage;
            }

        }

        private static int CalculateIndex(int currNum)
        {
            int index = 0;

            while (currNum > 0)
            {
                int currNumber = currNum % 10;
                index += currNumber;
                currNum /= 10;
            }

            return index;
        }

        private static char GetCharFromMessage(int index, string message)
        {
            int countIndex = 0;

            for (int i = 0; i < index; i++)
            {
                countIndex++;

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }

            char currChar = message[countIndex];
            return currChar;
        }

        private static int CalculatRealIndex(int index, string message)
        {
            int countIndex = 0;

            for (int i = 0; i < index; i++)
            {
                countIndex++;

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }
            return countIndex;
        }
    }
}
