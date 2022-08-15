using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    switch (typeOfTheGroup)
                    {
                        case "Students":
                            price = 8.45;
                            break;
                        case "Business":
                            price = 10.90;
                            break;
                        case "Regular":
                            price = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfTheGroup)
                    {
                        case "Students":
                            price = 9.80;
                            break;
                        case "Business":
                            price = 15.60;
                            break;
                        case "Regular":
                            price = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfTheGroup)
                    {
                        case "Students":
                            price = 10.46;
                            break;
                        case "Business":
                            price = 16;
                            break;
                        case "Regular":
                            price = 22.50;
                            break;
                    }
                    break;
            }

            double total = price * coutOfPeople;

            if (typeOfTheGroup == "Students" && coutOfPeople >= 30)
            {
                total *= 0.85;
            }
            else if (typeOfTheGroup == "Business" && coutOfPeople >= 100)
            {
                total = (coutOfPeople - 10) * price;
            }
            else if (typeOfTheGroup == "Regular" && coutOfPeople >= 10 && coutOfPeople <= 20)
            {
                total *= 0.95;
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
