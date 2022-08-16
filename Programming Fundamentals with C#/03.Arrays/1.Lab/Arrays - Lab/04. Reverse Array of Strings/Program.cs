using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < elements.Length / 2; i++)
            //{
            //    string frontElement = elements[i];
            //    string backElement = elements[(elements.Length - 1 - i)];
            //    string tempEleent = frontElement;
            //    elements[i] = backElement;
            //    elements[(elements.Length - 1) - i] = tempEleent;
            //}
            //Console.WriteLine(string.Join(" ",elements));


            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
