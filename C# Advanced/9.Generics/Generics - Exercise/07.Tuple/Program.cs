using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] drinkInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] numbersInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string> nameAddress = new Tuple<string, string>();
            nameAddress.Item1 = $"{personsInfo[0]} {personsInfo[1]}";
            nameAddress.Item2 = personsInfo[2];

            Tuple<string, int> nameBeer = new Tuple<string, int>();
            nameBeer.Item1 = drinkInfo[0];
            nameBeer.Item2 = int.Parse(drinkInfo[1]);

            Tuple<int, double> numbers = new Tuple<int, double>();
            numbers.Item1 = int.Parse(numbersInfo[0]);
            numbers.Item2 = double.Parse(numbersInfo[1]);

            Console.WriteLine(nameAddress.ToString());
            Console.WriteLine(nameBeer.ToString());
            Console.WriteLine(numbers.ToString());
        }
    }
}
