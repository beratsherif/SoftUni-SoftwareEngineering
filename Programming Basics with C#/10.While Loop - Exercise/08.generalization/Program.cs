using System;

namespace _08.generalization
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //string bookName = Console.ReadLine();
            //string input = Console.ReadLine();
            //int counter = 0;
            //bool check = false;
            //while (input != "No More Books")
            //{
            //    if (input == bookName)
            //    {
            //        check = true;
            //        break;
            //    }
            //    counter++;
            //    input = Console.ReadLine();
            //}
            //if (check)
            //{
            //    Console.WriteLine($"You checked {counter} books and found it.");
            //}
            //else
            //{
            //    Console.WriteLine($"The book you search is not here!");
            //    Console.WriteLine($"You checked {counter} books.");
            //}




            //2

            //int badGrades = int.Parse(Console.ReadLine());
            //int badGradesCounter = 0;
            //int countOfSolvedProblems = 0;
            //double total = 0;
            //bool check = false;
            //string lastEx = string.Empty;
            //string input = Console.ReadLine();
            //while (input != "Enough")
            //{
            //    double currGrade = double.Parse(Console.ReadLine());
            //    lastEx = input;
            //    countOfSolvedProblems++;
            //    total += currGrade;
            //    if (currGrade <= 4.00)
            //    {
            //        badGradesCounter++;
            //    }
            //    if (badGradesCounter >= badGrades)
            //    {
            //        check = true;
            //        break;
            //    }
            //    input = Console.ReadLine();
            //}
            //if (check)
            //{
            //    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            //}
            //else
            //{
            //    Console.WriteLine($"Average score: {total / countOfSolvedProblems:f2}");
            //    Console.WriteLine($"Number of problems: {countOfSolvedProblems}");
            //    Console.WriteLine($"Last problem: {lastEx}");
            //}


            //3

            //double neededMoney = double.Parse(Console.ReadLine());
            //double moneyHave = double.Parse(Console.ReadLine());
            //int couter = 0;
            //int totalDays = 0;
            //bool check = false;
            //while (moneyHave < neededMoney)
            //{
            //    string input = Console.ReadLine();
            //    double currSum = double.Parse(Console.ReadLine());
            //    totalDays++;
            //    switch (input)
            //    {
            //        case "spend":
            //            couter++;
            //            moneyHave -= currSum;
            //            if (moneyHave < 0)
            //            {
            //                moneyHave = 0;
            //            }
            //            break;
            //        case "save":
            //            couter = 0;
            //            moneyHave += currSum;
            //            break;
            //    }
            //    if (couter == 5)
            //    {
            //        check = true;
            //        break;
            //    }
            //}
            //if (check)
            //{
            //    Console.WriteLine("You can't save the money.");
            //    Console.WriteLine($"{totalDays}");
            //}
            //else
            //{
            //    Console.WriteLine($"You saved the money for {totalDays} days.");
            //}


            //4

            //int steps = 10000;
            //string input = Console.ReadLine();
            //int totalSteps = 0;
            //bool check = false;
            //while (input != "Going home")
            //{
            //    int currSteps = int.Parse(input);
            //    totalSteps += currSteps;
            //    if (totalSteps >= steps)
            //    {
            //        check = true;
            //        Console.WriteLine("Goal reached! Good job!");
            //        Console.WriteLine($"{totalSteps - steps} steps over the goal!");
            //        break;
            //    }
            //    input = Console.ReadLine();
            //}
            //if (check == false)
            //{
            //    int lastSteps = int.Parse(Console.ReadLine());
            //    totalSteps += lastSteps;
            //    if (totalSteps >= steps)
            //    {
            //        Console.WriteLine("Goal reached! Good job!");
            //        Console.WriteLine($"{totalSteps - steps} steps over the goal!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{steps - totalSteps} more steps to reach goal.");
            //    }
            //}


            //5

            //double input = double.Parse(Console.ReadLine());
            //double convertedInput = Math.Floor(input * 100);
            //int coinCounter = 0; 
            //while (convertedInput > 0)
            //{
            //    if (convertedInput >= 200)
            //    {
            //        convertedInput -= 200;
            //    }
            //    else if (convertedInput >= 100)
            //    {
            //        convertedInput -= 100;
            //    }
            //    else if (convertedInput >= 50)
            //    {
            //        convertedInput -= 50;
            //    }
            //    else if (convertedInput >= 20)
            //    {
            //        convertedInput -= 20;
            //    }
            //    else if (convertedInput >= 10)
            //    {
            //        convertedInput -= 10;
            //    }
            //    else if (convertedInput >= 5)
            //    {
            //        convertedInput -= 5;
            //    }
            //    else if (convertedInput >= 2)
            //    {
            //        convertedInput -= 2;
            //    }
            //    else if (convertedInput >= 1)
            //    {
            //        convertedInput -= 1;
            //    }
            //    coinCounter++;
            //}
            //Console.WriteLine(coinCounter);

            //6

            //int width = int.Parse(Console.ReadLine());
            //int lenght = int.Parse(Console.ReadLine());
            //int cakeDimension = width * lenght;
            //int piecesTaken = 0;
            //bool check = false;
            //string input = Console.ReadLine();
            //while (input != "STOP")
            //{
            //    int currTakenPieces = int.Parse(input);
            //    piecesTaken += currTakenPieces;
            //    if (piecesTaken >= cakeDimension)
            //    {
            //        check = true;
            //        break;
            //    }
            //    input = Console.ReadLine();
            //}
            //if (check)
            //{
            //    Console.WriteLine($"No more cake left! You need {piecesTaken - cakeDimension} pieces more.");
            //}
            //else
            //{
            //    Console.WriteLine($"{cakeDimension - piecesTaken} pieces are left.");
            //}

            //7

            //int width = int.Parse(Console.ReadLine());
            //int lenght = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //int totalPlace = width * lenght * height;
            //int totalBoxes = 0;
            //bool check = false;
            //string input = Console.ReadLine();
            //while (input != "Done")
            //{
            //    int boxQuantity = int.Parse(input);
            //    totalBoxes += boxQuantity;
            //    if (totalBoxes >= totalPlace)
            //    {
            //        check = true;
            //        break;
            //    }
            //    input = Console.ReadLine();
            //}
            //if (check)
            //{
            //    Console.WriteLine($"No more free space! You need {totalBoxes - totalPlace} Cubic meters more.");
            //}
            //else
            //{
            //    Console.WriteLine($"{totalPlace - totalBoxes} Cubic meters left.");
            //}
        }
    }
}
