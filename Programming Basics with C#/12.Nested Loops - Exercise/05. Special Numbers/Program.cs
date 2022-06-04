using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1111; i <= 9999; i++)
            //{
            //    string curNum = i.ToString();
            //    int counter = 0;
            //    for (int j = 0; j < curNum.Length; j++)
            //    {
            //        int curr = int.Parse(curNum[j].ToString());
            //        if (curr == 0)
            //        {
            //            continue;
            //        }
            //        if (n % curr == 0)
            //        {
            //            counter++;
            //        }
            //    }
            //    if (counter == 4)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (n % i == 0 && n % j == 0 && n % k == 0 && n % l == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
