using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, string> vatFunc = x => (x * 1.2).ToString("F2");

            Console.WriteLine(string.Join(Environment.NewLine,
                Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .Select(vatFunc)));
        }
    }
}
