using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            //int maxCapacity = int.Parse(Console.ReadLine());
            //string command = Console.ReadLine();

            //while (command != "end")
            //{
            //    string[] input = command.Split();

            //    if (input.Length == 2)
            //    {
            //        int passengersInWagon = int.Parse(input[1]);
            //        wagons.Add(passengersInWagon);
            //    }
            //    else
            //    {
            //        int curPassengers = int.Parse(input[0]);
            //        FindingPlaceForPassengers(wagons, maxCapacity, curPassengers);
            //    }

            //    command = Console.ReadLine();
            //}

            //Console.WriteLine(string.Join(" ", wagons));








            //1
            //List<int> listOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            //int maximumCapacityOfTheWagon = int.Parse(Console.ReadLine());

            //while (true)
            //{
            //    string[] input = Console.ReadLine().Split();

            //    if (input[0] == "end")
            //    {
            //        Console.WriteLine(string.Join(" ", listOfWagons));
            //        return;
            //    }

            //    if (input[0] == "Add")
            //    {
            //        int addingPassengers = int.Parse(input[1]);
            //        listOfWagons.Add(addingPassengers);
            //    }
            //    else
            //    {
            //        int passengers = int.Parse(input[0]);
            //        for (int i = 0; i < listOfWagons.Count - 1; i++)
            //        {
            //            if (listOfWagons[i] + passengers <= maximumCapacityOfTheWagon)
            //            {
            //                listOfWagons[i] += passengers;
            //                break;
            //            }
            //        }
            //    }
            //}


            //2
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //while (true)
            //{
            //    string[] input = Console.ReadLine().Split();

            //    if (input[0] == "end")
            //    {
            //        Console.WriteLine(string.Join(" ", numbers));
            //        return;
            //    }

            //    int element = int.Parse(input[1]);

            //    switch (input[0])
            //    {
            //        case "Delete":
            //            numbers.RemoveAll(el => el == element);

            //            break;
            //        case "Insert":
            //            int position = int.Parse(input[2]);
            //            numbers.Insert(position, element);
            //            break;
            //    }
            //}


            //3

            //int countOfCommands = int.Parse(Console.ReadLine());

            //List<string> guestlist = new List<string>(countOfCommands);

            //for (int i = 0; i < countOfCommands; i++)
            //{
            //    string[] command = Console.ReadLine().Split();

            //    string currPerson = command[0];
            //    string action = command[2];
            //    if (action == "going!")
            //    {
            //        if (guestlist.Contains(currPerson))
            //        {
            //            Console.WriteLine($"{currPerson} is already in the list!");
            //        }
            //        else
            //        {
            //            guestlist.Add(currPerson);
            //        }
            //    }
            //    else
            //    {
            //        if (guestlist.Contains(currPerson))
            //        {
            //            guestlist.Remove(currPerson);
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{currPerson} is not in the list!");
            //        }
            //    }
            //}

            //Console.WriteLine(string.Join(" ", guestlist));




            //4
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //while (true)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    string command = input[0];

            //    if (command == "End")
            //    {
            //        Console.WriteLine(string.Join(" ", numbers));
            //        return;
            //    }

            //    switch (command)
            //    {
            //        case "Add":
            //            numbers.Add(int.Parse(input[1]));
            //            break;

            //        case "Insert":

            //            int num = int.Parse(input[1]);
            //            int index = int.Parse(input[2]);
            //            if (index < 0 || index > numbers.Count - 1)
            //            {
            //                Console.WriteLine($"Invalid index");
            //                break;
            //            }
            //            numbers.Insert(index, num);
            //            break;

            //        case "Remove":
            //            int indexForRemove = int.Parse(input[1]);
            //            if (indexForRemove < 0 || indexForRemove > numbers.Count - 1)
            //            {
            //                Console.WriteLine($"Invalid index");
            //                break;
            //            }
            //            numbers.RemoveAt(indexForRemove);
            //            break;

            //        case "Shift":

            //            string typeOfShifting = input[1];
            //            int count = int.Parse(input[2]);
            //            switch (typeOfShifting)
            //            {
            //                case "left":
            //                    for (int i = 0; i < count; i++)
            //                    {
            //                        numbers.Add(numbers[0]);
            //                        numbers.RemoveAt(0);
            //                    }
            //                    break;
            //                case "right":
            //                    for (int i = 0; i < count; i++)
            //                    {
            //                        numbers.Insert(0, numbers[numbers.Count -1]);
            //                        numbers.RemoveAt(numbers.Count - 1);
            //                    }
            //                    break;
            //            }
            //            break;
            //    }
            //}


            //5

            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int specialBombNumber = input[0];
            //int power = input[1];

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == specialBombNumber)
            //    {
            //        int start = i - power;
            //        if (start < 0)
            //        {
            //            start = 0;
            //        }

            //        int finish = i + power + 1;
            //        if (finish > numbers.Count)
            //        {
            //            finish = numbers.Count;
            //        }

            //        for (int j = start; j < finish; j++)
            //        {
            //            numbers[j] = 0;
            //        }
            //    }
            //}

            //Console.WriteLine(numbers.Sum());


            //6

            //List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            //while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            //{
            //    if (firstPlayer[0] > secondPlayer[0])
            //    {
            //        firstPlayer.Add(firstPlayer[0]);
            //        firstPlayer.Add(secondPlayer[0]);
            //    }
            //    else if (secondPlayer[0] > firstPlayer[0])
            //    {
            //        secondPlayer.Add(secondPlayer[0]);
            //        secondPlayer.Add(firstPlayer[0]);
            //    }

            //    firstPlayer.Remove(firstPlayer[0]);
            //    secondPlayer.Remove(secondPlayer[0]);

            //    if (firstPlayer.Count == 0)
            //    {
            //        Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            //        break;
            //    }
            //    if (secondPlayer.Count == 0)
            //    {
            //        Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            //        break;
            //    }

            //}


            //7

            //var numbers = Console.ReadLine().Split('|').Reverse().ToList();
            //var reversedNumbers = new List<int>();

            //foreach (var num in numbers)
            //{
            //    reversedNumbers.AddRange(num.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            //}

            //Console.WriteLine(string.Join(" ",reversedNumbers));


            //8



        }





























        //private static void FindingPlaceForPassengers(List<int> wagons, int maxCapacity, int curPassengers)
        //{
        //    for (int i = 0; i < wagons.Count; i++)
        //    {
        //        if (curPassengers + wagons[i] <= maxCapacity)
        //        {
        //            wagons[i] += curPassengers;
        //            break;
        //        }
        //    }
        //}
    }
}
