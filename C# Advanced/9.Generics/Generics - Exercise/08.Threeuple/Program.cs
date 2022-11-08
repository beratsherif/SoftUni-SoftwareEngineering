using System;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            Threeuple<string, string, string> nameAddressTown = new Threeuple<string, string, string>();
            nameAddressTown.Item1 = $"{input1[0]} {input1[1]}";
            nameAddressTown.Item2 = input1[2];
            if (input1.Length > 4) nameAddressTown.Item3 = string.Join(" ", input1[3], input1[4]);
            else nameAddressTown.Item3 = input1[3];

            Threeuple<string, int, bool> nameLittresOfBeerDrunkOrNot = new Threeuple<string, int, bool>
            {
                Item1 = input2[0],
                Item2 = int.Parse(input2[1]),
                Item3 = input2[2] == "drunk"
            };

            Threeuple<string, double, string> nameAccountBalanceBankName = new Threeuple<string, double, string>
            {
                Item1 = input3[0],
                Item2 = double.Parse(input3[1]),
                Item3 = input3[2]
            };

            Console.WriteLine(nameAddressTown.ToString());
            Console.WriteLine(nameLittresOfBeerDrunkOrNot.ToString());
            Console.WriteLine(nameAccountBalanceBankName.ToString());
        }
    }
}
