using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@#+)(?<group>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})(@#+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    char[] digits = input.Where(char.IsDigit).ToArray();

                    //string barcodeGroup;
                    //if (digits.Length == 0)
                    //{
                    //    barcodeGroup = "00";
                    //}
                    //else
                    //{
                    //    barcodeGroup = string.Join("", digits);
                    //}
                    string barcodeGroup = digits.Length == 0 ? "00" : string.Join("", digits);

                    Console.WriteLine($"Product group: {barcodeGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
