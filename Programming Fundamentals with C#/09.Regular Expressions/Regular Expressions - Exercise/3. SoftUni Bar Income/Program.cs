using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            double totalIncome = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);

                if (isValid)
                {
                    string costumer = regex.Match(input).Groups["customer"].Value;

                    string product = regex.Match(input).Groups["product"].Value;

                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);

                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double totalCurrPrice = price * quantity;
                    totalIncome += totalCurrPrice;
                    Console.WriteLine($"{costumer}: {product} - {totalCurrPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
