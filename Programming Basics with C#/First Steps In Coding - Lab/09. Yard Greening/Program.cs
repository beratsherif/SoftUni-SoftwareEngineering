using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceFor1KMeter = 7.61;

            double placeForGreening = double.Parse(Console.ReadLine());

            double totalPrice = placeForGreening * priceFor1KMeter;
            double finalPrice = totalPrice * 0.82;
            double discount = totalPrice * 0.18;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
