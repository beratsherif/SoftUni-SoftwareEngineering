using System;

namespace _04._Random_List
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");

            Console.WriteLine(randomList.RandomString());
        }
    }
}
