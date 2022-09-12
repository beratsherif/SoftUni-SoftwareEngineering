using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            //VERSION 1;
            //string input = Console.ReadLine();

            //List<int> numbersList = input
            //    .Where(x => char.IsDigit(x))
            //    .Select(x => x.ToString())
            //    .Select(int.Parse)
            //    .ToList();

            //List<string> nonNumbersList = input
            //    .ToCharArray()
            //    .Where(x => x < '0' || x > '9')
            //    .Select(x => x.ToString())
            //    .ToList();

            //List<int> takeList = numbersList
            //    .Where((x, index) => index % 2 == 0)
            //    .ToList();

            //List<int> skipList = numbersList
            //    .Where((x, index) => index % 2 != 0)
            //    .ToList();


            //string result = string.Empty;

            //int index = 0;

            //for (int i = 0; i < takeList.Count; i++)
            //{
            //    List<string> temp = nonNumbersList
            //        .Skip(index)
            //        .Take(takeList[i])
            //        .ToList();

            //    result += string.Concat(temp);

            //    index += takeList[i] + skipList[i];
            //}


            //Console.WriteLine(result);




            //VERSION - 2;
            //string input = Console.ReadLine();

            //List<int> numbersList = new List<int>();

            //List<string> nonNumbersList = new List<string>();

            //List<int> takeList = new List<int>();

            //List<int> skipList = new List<int>();

            //string result = string.Empty;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (char.IsDigit(input[i]))
            //    {
            //        numbersList.Add(int.Parse(input[i].ToString()));
            //    }
            //    else
            //    {
            //        nonNumbersList.Add(input[i].ToString());
            //    }
            //}//finding digits and chars

            //for (int i = 0; i < numbersList.Count; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        takeList.Add(numbersList[i]);
            //    }
            //    else
            //    {
            //        skipList.Add(numbersList[i]);
            //    }
            //}//sorting numbers 



            //int index = 0;
            //for (int i = 0; i < takeList.Count; i++)
            //{
            //    int take = takeList[i];
            //    int skip = skipList[i];

            //    if (index + take > nonNumbersList.Count)
            //    {
            //        take = nonNumbersList.Count - index;
            //    }

            //    for (int j = 0; j < take; j++)
            //    {
            //        result += nonNumbersList[index + j];
            //    }

            //    index += take + skip;
            //}

            //Console.WriteLine(result);


            //VERSION 3;

            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<string> nonNumbers = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(input[i].ToString());
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>();

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

                result.Append(string.Join(" ", temp));

                indexForSkip += takeList[i] + skipList[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
