using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    string input = new string('*', 10);
            //    Console.WriteLine(input);
            //}


            //string input = new string('*', 10);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(input);
            //}

            for (int i = 0; i < 10; i++)
            {
                for (int l = 0; l < 10; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
