using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Stack<string> stack = new Stack<string>(input.Split(' ').Reverse());

            //while (stack.Count > 1)
            //{
            //    int firstNum = int.Parse(stack.Pop());
            //    string operation = stack.Pop();
            //    int secondNum = int.Parse(stack.Pop());

            //    int result = 0;


            //    result = operation == "+" ? firstNum + secondNum : firstNum - secondNum;

            //    //if (operation == "+")
            //    //    result = firstNum + secondNum;
            //    //else
            //    //    result = firstNum - secondNum;

            //    stack.Push(result.ToString());
            //}

            //Console.WriteLine(stack.Peek());

            Stack<string> stack = new Stack<string>(Console.ReadLine().Split(" ").Reverse());

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                int result = 0;

                result = operation == "+" ? firstNum + secondNum : firstNum - secondNum;

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
