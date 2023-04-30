using System;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Any(char.IsLetter))
                {
                    Console.WriteLine("Invalid number!");
                }
                else if (phoneNumber.Length == 10)
                {
                    Smartphone smartPhone = new Smartphone();
                    Console.WriteLine(smartPhone.Calling(phoneNumber));
                }
                else if (phoneNumber.Length == 7)
                {
                    StationaryPhone statyonaryPhone = new StationaryPhone();
                    Console.WriteLine(statyonaryPhone.Calling(phoneNumber));
                }
            }

            foreach (var website in websites)
            {
                if (website.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Smartphone smartPhone = new Smartphone();
                    Console.WriteLine(smartPhone.Browsing(website));
                }
            }
        }
    }
}
