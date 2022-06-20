using System;

namespace _06.Generalization
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //int quantityDetergent = int.Parse(Console.ReadLine()) * 750;
            //string input = Console.ReadLine();
            //int counter = 0;
            //int totalDetergant = 0;
            //int dishes = 0;
            //int pots = 0;
            //bool check = false;
            //while (input != "End")
            //{
            //    int coutOfDishes = int.Parse(input);
            //    counter++;
            //    if (counter % 3 == 0)
            //    {
            //        pots += coutOfDishes;
            //        totalDetergant += coutOfDishes * 15;
            //    }
            //    else
            //    {
            //        dishes += coutOfDishes;
            //        totalDetergant += coutOfDishes * 5;
            //    }
            //    if (totalDetergant > quantityDetergent)
            //    {
            //        check = true;
            //        break;
            //    }
            //    input = Console.ReadLine();
            //}
            //if (check)
            //{
            //    Console.WriteLine($"Not enough detergent, {totalDetergant - quantityDetergent} ml. more necessary!");
            //}
            //else
            //{
            //    Console.WriteLine("Detergent was enough!");
            //    Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
            //    Console.WriteLine($"Leftover detergent {quantityDetergent - totalDetergant} ml.");
            //}

            //2

            //double neededMoney = double.Parse(Console.ReadLine());
            //string input = Console.ReadLine();
            //int transactionCounter = 0;
            //double totalSum = 0;
            //int totalCS = 0;
            //double totalCSMoney = 0;
            //int totalCC = 0;
            //double totalCCMoney = 0;
            //bool check = false;
            //while (input != "End")
            //{
            //    double currSum = double.Parse(input);
            //    transactionCounter++;
            //    if (transactionCounter % 2 == 0)
            //    {
            //        if (currSum < 10)
            //        {
            //            Console.WriteLine("Error in transaction!");
            //        }
            //        else
            //        {
            //            totalCC++;
            //            totalCCMoney += currSum;
            //            totalSum += currSum;
            //            Console.WriteLine("Product sold!");
            //        }
            //    }
            //    else
            //    {
            //        if (currSum > 100)
            //        {
            //            Console.WriteLine("Error in transaction!");
            //        }
            //        else
            //        {
            //            totalCS++;
            //            totalCSMoney += currSum;
            //            totalSum += currSum;
            //            Console.WriteLine("Product sold!");
            //        }
            //    }
            //    if (totalSum >= neededMoney)
            //    {
            //        check = true;
            //        break;
            //    }

            //    input = Console.ReadLine();

            //}
            //if (check)
            //{
            //    Console.WriteLine($"Average CS: {totalCSMoney / totalCS:f2}");
            //    Console.WriteLine($"Average CC: {totalCCMoney / totalCC:f2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Failed to collect required money for charity.");
            //}

            //3

            //int c = 0;
            //int o = 0;
            //int n = 0;
            //string secretWord = string.Empty;
            //string word = string.Empty;
            //string input = Console.ReadLine();

            //while (input != "End")
            //{
            //    char symbol = char.Parse(input);
            //    if (symbol >= 'a' && symbol <= 'z' || symbol >= 'A' && symbol <= 'Z' )
            //    {
            //        if (symbol == 'c' && c < 1)
            //        {
            //            c++;
            //        }
            //        else if (symbol == 'o' && o < 1)
            //        {
            //            o++;
            //        }
            //        else if (symbol == 'n' && n < 1)
            //        {
            //            n++;
            //        }
            //        else
            //        {
            //            word += symbol;
            //        }
            //        if (c + o + n == 3)
            //        {
            //            secretWord += word;
            //            secretWord += " ";
            //            word = string.Empty;
            //            c = 0;
            //            o = 0;
            //            n = 0;
            //        }
            //        input = Console.ReadLine();
            //    }
            //    else
            //    {
            //        input = Console.ReadLine();
            //    }
            //}
            //Console.WriteLine(secretWord);

            //4

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //5

            //int n = int.Parse(Console.ReadLine());
            //double total = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    double currentNum = double.Parse(Console.ReadLine());
            //    total += currentNum;
            //}
            //double average = total / n;
            //Console.WriteLine($"{average:f2}");
        }
    }
}
