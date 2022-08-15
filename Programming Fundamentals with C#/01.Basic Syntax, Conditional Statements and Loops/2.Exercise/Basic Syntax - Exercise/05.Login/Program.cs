using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //string username = Console.ReadLine();

            //string pass = "";
            //int counter = 0;
            //string userInput = "";

            //for (int i = username.Length - 1; i >= 0; i--)
            //{
            //    pass += username[i];
            //}

            //while ((userInput = Console.ReadLine()) != pass)
            //{
            //    if (userInput != pass)
            //    {
            //        if (counter == 3)
            //        {
            //            Console.WriteLine($"User {username} blocked!");
            //            return;
            //        }

            //        Console.WriteLine("Incorrect password. Try again.");
            //        counter++;

            //    }
            //}
            //if (userInput == pass)
            //{
            //    Console.WriteLine($"User {username} logged in.");
            //}



            string username = Console.ReadLine();

            string pass = "";
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }

            string userInput = Console.ReadLine();

            while (userInput != pass)
            {
                if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                counter++;

                userInput = Console.ReadLine();
            }
            if (userInput == pass)
            {
                Console.WriteLine($"User {username} logged in.");
            }


        }
    }
}
