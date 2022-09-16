using System;
using System.Collections.Generic;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articleInfo = new List<string>();
            articleInfo.Add(Console.ReadLine());
            articleInfo.Add(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end of comments")
            {
                articleInfo.Add(input);
            }

            Console.WriteLine($"<h1>\n\t{articleInfo[0]}\n</h1>");
            Console.WriteLine($"<article>\n\t{articleInfo[1]}\n</article>");

            for (int i = 2; i < articleInfo.Count; i++)
            {
                Console.WriteLine($"<div>\n\t{articleInfo[i]}\n</div>");
            }
        }
    }
}
