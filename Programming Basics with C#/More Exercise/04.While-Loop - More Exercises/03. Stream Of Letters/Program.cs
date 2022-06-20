using System;

namespace _03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //int counterC = 0;
            //int counterO = 0;
            //int counterN = 0;
            //string word = string.Empty;
            //string secredWord = string.Empty;


            //while (input != "End")
            //{
            //    char letter = char.Parse(input);

            //    if (letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z')
            //    {
            //        if (input == "c" && counterC == 0)
            //        {
            //            counterC++;
            //        }
            //        else if (input == "o" && counterO == 0)
            //        {
            //            counterO++;
            //        }
            //        else if (input == "n" && counterN == 0)
            //        {
            //            counterN++;
            //        }
            //        else
            //        {
            //            word += letter;
            //        }
            //        if (counterC + counterO + counterN == 3)
            //        {
            //            secredWord += word;
            //            secredWord += " ";
            //            word = string.Empty;
            //            counterC = 0;
            //            counterO = 0;
            //            counterN = 0;
            //        }
            //    }
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine(secredWord);




            string input = Console.ReadLine();
            int c = 0;
            int o = 0;
            int n = 0;
            string word = string.Empty;
            string secretWord = string.Empty;

            while (input != "End")
            {
                char letter = char.Parse(input);
                if (letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z')
                {
                    if (letter == 'c' && c == 0)
                    {
                        c++;
                    }
                    else if (letter == 'o' && o == 0)
                    {
                        o++;
                    }
                    else if (letter == 'n' && n == 0)
                    {
                        n++;
                    }
                    else
                    {
                        word += letter;
                    }
                    if (c + o + n == 3)
                    {
                        secretWord += word;
                        secretWord += " ";
                        word = string.Empty;
                        c = 0;
                        o = 0;
                        n = 0;
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(secretWord);
        }
    }
}
