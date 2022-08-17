using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, symbol , secondNumber));
        }

        static double Calculate(int a, char @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case '/':
                    result = a / b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
