using System;
using System.Text;

namespace _04.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                char currChar = (char)(message[i] + 3);
                sb.Append(currChar);
            }

            Console.WriteLine(sb);
        }
    }
}
