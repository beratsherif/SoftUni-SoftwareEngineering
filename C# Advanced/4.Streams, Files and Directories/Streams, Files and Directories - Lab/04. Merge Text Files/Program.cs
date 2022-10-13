using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt"; 
            var secondInputFilePath = @"..\..\..\Files\input2.txt"; 
            var outputFilePath = @"..\..\..\Files\output.txt"; 
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);

        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            Queue<string> firstInputData = new Queue<string>();
            Queue<string> secondInputData = new Queue<string>();

            using (StreamReader readFirst = new StreamReader(firstInputFilePath))
            {
                string currChar = readFirst.ReadLine();
                while (currChar != null)
                {
                    firstInputData.Enqueue(currChar);
                    currChar = readFirst.ReadLine();
                }
                using (StreamReader readSecond = new StreamReader(secondInputFilePath))
                {
                    string currChar2 = readSecond.ReadLine();
                    while (currChar2 != null)
                    {
                        secondInputData.Enqueue(currChar2);
                        currChar2 = readSecond.ReadLine();
                    }
                }
            }

            int minCount = Math.Min(firstInputData.Count, secondInputData.Count);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i <minCount ; i++)
                {
                    writer.WriteLine(firstInputData.Dequeue());
                    writer.WriteLine(secondInputData.Dequeue());
                }

                if (firstInputData.Count > 0)
                {
                    while (firstInputData.Count > 0)
                    {
                        writer.WriteLine(firstInputData.Dequeue());
                    }
                }
                else if (secondInputData.Count > 0)
                {
                    while (secondInputData.Count > 0)
                    {
                        writer.WriteLine(secondInputData.Dequeue());
                    }
                }
            }
        }
    }
}