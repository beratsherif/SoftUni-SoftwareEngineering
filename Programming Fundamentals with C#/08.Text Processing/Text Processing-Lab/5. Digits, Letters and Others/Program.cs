using System;
using System.Linq;
using System.Text;

namespace _5._Digits__Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {

            //WITH LINQ

            //string input = Console.ReadLine();

            //char[] digits = input.Where(ch => char.IsDigit(ch)).ToArray();

            //char[] letters = input.Where(ch => char.IsLetter(ch)).ToArray();

            //char[] others = input.Where(ch => !char.IsLetterOrDigit(ch)).ToArray();

            //Console.WriteLine(digits);
            //Console.WriteLine(letters);
            //Console.WriteLine(others);


            // 2 - Option
            //string input = Console.ReadLine();

            //StringBuilder digits = new StringBuilder();
            //StringBuilder letters = new StringBuilder();
            //StringBuilder others = new StringBuilder();

            //foreach (var ch in input)
            //{
            //    if (char.IsDigit(ch))
            //    {
            //        digits.Append(ch);
            //    }
            //    else if (char.IsLetter(ch))
            //    {
            //        digits.Append(ch);
            //    }
            //    else
            //    {
            //        others.Append(ch);
            //    }
            //}
            //Console.WriteLine(digits);
            //Console.WriteLine(letters);
            //Console.WriteLine(others);


            string input = Console.ReadLine();

            Console.WriteLine(input.Where(ch => char.IsDigit(ch)).ToArray());
            Console.WriteLine(input.Where(ch => char.IsLetter(ch)).ToArray());
            Console.WriteLine(input.Where(ch => !char.IsLetterOrDigit(ch)).ToArray());
        }
    }
}
