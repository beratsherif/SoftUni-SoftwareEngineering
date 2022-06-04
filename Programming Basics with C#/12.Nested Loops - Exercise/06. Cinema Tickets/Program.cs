using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalTickets = 0;
            int student = 0;
            int standard = 0;
            int kid = 0;


            while (input != "Finish")
            {
                int freeSpace = int.Parse(Console.ReadLine());
                int buyedTichets = 0;
                for (int i = 0; i < freeSpace; i++)
                {
                    string type = Console.ReadLine();
                    if (type == "End")
                    {
                        break;
                    }
                    else
                    {
                        switch (type)
                        {
                            case "student":
                                buyedTichets++;
                                student++;
                                break;
                            case "standard":
                                buyedTichets++;
                                standard++;
                                break;
                            case "kid":
                                buyedTichets++;
                                kid++;
                                break;
                        }
                    }
                }
                totalTickets += buyedTichets;
                double percentFull = (double)buyedTichets / freeSpace * 100.00;
                Console.WriteLine($"{input} - {percentFull:f2}% full.");
                input = Console.ReadLine();

            }

            Console.WriteLine($"Total tickets: {totalTickets}");

            double percentStudent = (double)student / totalTickets * 100.00;
            double percentStandard = (double)standard / totalTickets * 100.00;
            double percentKid = (double)kid / totalTickets * 100.00;

            Console.WriteLine($"{percentStudent:f2}% student tickets.");
            Console.WriteLine($"{percentStandard:f2}% standard tickets.");
            Console.WriteLine($"{percentKid:f2}% kids tickets.");
        }
    }
}
