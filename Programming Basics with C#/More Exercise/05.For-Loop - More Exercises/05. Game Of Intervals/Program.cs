using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = int.Parse(Console.ReadLine());

            int from0To9 = 0;
            int from10To19 = 0;
            int from20To29 = 0;
            int from30To39 = 0;
            int from40To50 = 0;
            int invalidNums = 0;
            double total = 0;

            for (int i = 0; i < turns; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum >= 0 && currentNum <= 9)
                {
                    from0To9++;
                    total += currentNum * 0.20;
                }
                else if (currentNum >= 10 && currentNum <= 19)
                {
                    from10To19++;
                    total += currentNum * 0.30;
                }
                else if (currentNum >= 20 && currentNum <= 29)
                {
                    from20To29++;
                    total += currentNum * 0.40;
                }
                else if (currentNum >= 30 && currentNum <= 39)
                {
                    from30To39++;
                    total += 50;
                }
                else if (currentNum >= 40 && currentNum <= 50)
                {
                    from40To50++;
                    total += 100;
                }
                else
                {
                    invalidNums++;
                    total /= 2;
                }
            }
            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"From 0 to 9: {(double)from0To9 / turns * 100.00:f2}%");
            Console.WriteLine($"From 10 to 19: {(double)from10To19 / turns * 100.00:f2}%");
            Console.WriteLine($"From 20 to 29: {(double)from20To29 / turns * 100.00:f2}%");
            Console.WriteLine($"From 30 to 39: {(double)from30To39 / turns * 100.00:f2}%");
            Console.WriteLine($"From 40 to 50: {(double)from40To50 / turns * 100.00:f2}%");
            Console.WriteLine($"Invalid numbers: {(double)invalidNums / turns * 100.00:f2}%");
        }
    }
}
