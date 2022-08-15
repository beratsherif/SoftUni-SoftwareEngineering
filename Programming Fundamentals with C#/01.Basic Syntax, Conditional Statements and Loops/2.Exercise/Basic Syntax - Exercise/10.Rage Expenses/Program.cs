using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTimes = 0;
            int mouseTimes = 0;
            int keyboardTimes = 0;
            int keyboardTimesCheck = 0;
            int displayTimes = 0;

            for (int i = 1; i <= lostGame; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    headsetTimes++;
                    mouseTimes++;
                    keyboardTimes++;
                    keyboardTimesCheck++;
                }
                else if (i % 2 == 0)
                {
                    headsetTimes++;
                }
                else if (i % 3 == 0)
                {
                    mouseTimes++;
                }
                if (keyboardTimesCheck >= 2 && keyboardTimesCheck % 2 == 0)
                {
                    displayTimes++;
                    keyboardTimesCheck = 0;
                }
            }

            double total = (headsetPrice * headsetTimes) + (mousePrice * mouseTimes) + (keyboardPrice * keyboardTimes) + (displayPrice * displayTimes);
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
