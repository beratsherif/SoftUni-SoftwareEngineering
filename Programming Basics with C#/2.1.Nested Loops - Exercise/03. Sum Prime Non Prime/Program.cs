using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //int primeNum = 0;
            //int nonPrime = 0;
            //while (input != "stop")
            //{
            //    int currentNum = int.Parse(input);
            //    int counter = 0;
            //    if (currentNum < 0)
            //    {
            //        Console.WriteLine("Number is negative.");
            //    }
            //    else if (currentNum == 0)
            //    {
            //        primeNum += currentNum;
            //    }
            //    else
            //    {
            //        if (currentNum % 1 == 0)
            //        {
            //            counter++;
            //        }
            //        if (currentNum % currentNum == 0)
            //        {
            //            counter++;
            //        }
            //        if (currentNum % 2 == 0 && currentNum != 2)
            //        {
            //            counter++;
            //        }
            //        if (currentNum % 3 == 0 && currentNum != 3)
            //        {
            //            counter++;
            //        }
            //        if (counter > 2)
            //        {
            //            nonPrime += currentNum;
            //        }
            //        else
            //        {
            //            primeNum += currentNum;
            //        }
            //    }
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine($"Sum of all prime numbers is: {primeNum}");
            //Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");

            string input = Console.ReadLine();
            int primeNumSum = 0;
            int nonPrimeNumSum = 0;

            while (input != "stop")
            {
                int currNum = int.Parse(input);

                if (currNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool primeCheck = true;

                for (int i = 2; i <= currNum - 1; i++)
                {
                    if (currNum % i == 0)
                    {
                        primeCheck = false;
                    }
                }

                if (primeCheck)
                {
                    primeNumSum += currNum;
                }
                else
                {
                    nonPrimeNumSum += currNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumSum}");
        }
    }
}
