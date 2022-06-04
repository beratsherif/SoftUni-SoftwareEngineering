using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheBook = Console.ReadLine();
            string book = Console.ReadLine();
            int couter = 0;
            bool check = false;
            while (book != "No More Books")
            {
                if (book == nameOfTheBook)
                {
                    check = true;
                    break;
                }
                else
                {
                    couter++;
                    book = Console.ReadLine();
                }
            }
            if (check)
            {
                Console.WriteLine($"You checked {couter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {couter} books.");
            }
        }
    }
}
