using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 1;
            int counter = 0;
            double totalGrade = 0;
            bool check = false;

            while (clas <= 12)
            {
                double currGrade = double.Parse(Console.ReadLine());
                if (currGrade >= 4.00)
                {
                    totalGrade += currGrade;
                    clas++;
                }
                else
                {
                    counter++;
                }
                if (counter > 1)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine($"{name} has been excluded at {clas} grade");
            }
            else
            {
                double averageGrade = totalGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
