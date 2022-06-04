using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine()) * 60;
            int examMinuties = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine()) * 60;
            int arrivingMinuties = int.Parse(Console.ReadLine());

            int totalExamMinuties = examHour + examMinuties;
            int totalArrivingMinuties = arrivingHour + arrivingMinuties;

            string result = "";
            int difference = 0;

            if (totalExamMinuties == totalArrivingMinuties)
            {
                result = "On time";
                Console.WriteLine(result);
            }
            else if (totalExamMinuties > totalArrivingMinuties)
            {
                difference = totalExamMinuties - totalArrivingMinuties;
                if (difference <= 30)
                {
                    result = "On time";
                    Console.WriteLine(result);
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference > 30 && difference < 60)
                {
                    result = "Early";
                    Console.WriteLine(result);
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference >= 60)
                {
                    result = "Early";
                    Console.WriteLine(result);
                    Console.WriteLine($"{difference / 60}:{difference % 60:d2} hours before the start");
                }

            }
            else if (totalExamMinuties < totalArrivingMinuties)
            {
                difference = totalArrivingMinuties - totalExamMinuties;
                result = "Late";
                if (difference <= 59)
                {
                    Console.WriteLine(result);
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    Console.WriteLine(result);
                    Console.WriteLine($"{difference / 60}:{difference % 60:d2} hours after the start");
                }
            }
        }
    }
}
